using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using PowerfabMcp.Server.Powerfab;
using PowerfabMcp.Server.Tests.Fakes;

namespace PowerfabMcp.Server.Tests;

public sealed class HttpTransportTests : IClassFixture<HttpTransportTests.PowerfabAppFactory>
{
    private readonly PowerfabAppFactory _factory;

    public HttpTransportTests(PowerfabAppFactory factory) => _factory = factory;

    [Fact]
    public async Task Healthz_Returns200()
    {
        using var client = _factory.CreateClient();
        var response = await client.GetAsync("/healthz");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task ToolsCall_CreateWorkPackage_RoundTripsThroughMcp()
    {
        _factory.FakeClient.ResponseFactory = (name, _) => new XElement(
            PowerfabClient.RequestNs + name,
            new XElement(PowerfabClient.RequestNs + "Successful", "true"),
            new XElement(PowerfabClient.RequestNs + "WorkPackageID", "777"));

        using var client = _factory.CreateClient();

        var initResponse = await PostJsonRpcAsync(client, """
            {
              "jsonrpc": "2.0",
              "id": 1,
              "method": "initialize",
              "params": {
                "protocolVersion": "2025-06-18",
                "capabilities": {},
                "clientInfo": { "name": "powerfab-mcp-test", "version": "0.0.0" }
              }
            }
            """);

        var sessionId = initResponse.Headers.GetValues("Mcp-Session-Id").Single();

        await PostJsonRpcAsync(client, """
            {"jsonrpc":"2.0","method":"notifications/initialized"}
            """, sessionId);

        var callResponse = await PostJsonRpcAsync(client, """
            {
              "jsonrpc": "2.0",
              "id": 2,
              "method": "tools/call",
              "params": {
                "name": "create_work_package",
                "arguments": {
                  "productionControlId": 7,
                  "workPackageNumber": "WP-Round-Trip",
                  "priority": "Low"
                }
              }
            }
            """, sessionId);

        var (json, raw) = await ReadJsonRpcAsync(callResponse);
        var root = json.RootElement;
        Assert.False(root.TryGetProperty("error", out _),
            $"Expected success, got error: {root.GetRawText()}");

        var result = root.GetProperty("result");
        var isError = result.TryGetProperty("isError", out var isErrorEl) && isErrorEl.GetBoolean();
        Assert.False(isError, $"Tool returned isError=true. Raw response: {raw}");

        var structured = result.GetProperty("structuredContent");
        Assert.Equal(777, structured.GetProperty("workPackageId").GetInt32());
    }

    [Fact]
    public async Task McpEndpoint_Rejects_When_BearerToken_Missing()
    {
        using var factory = new ProtectedPowerfabAppFactory();
        using var client = factory.CreateClient();

        var content = JsonContent.Create(new
        {
            jsonrpc = "2.0",
            id = 1,
            method = "initialize",
            @params = new { protocolVersion = "2025-06-18", capabilities = new { }, clientInfo = new { name = "t", version = "0" } },
        });
        var req = new HttpRequestMessage(HttpMethod.Post, "/mcp") { Content = content };
        req.Headers.TryAddWithoutValidation("Accept", "application/json, text/event-stream");
        var response = await client.SendAsync(req);
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        Assert.True(response.Headers.WwwAuthenticate.Count > 0);
    }

    private static async Task<HttpResponseMessage> PostJsonRpcAsync(HttpClient client, string body, string? sessionId = null)
    {
        var req = new HttpRequestMessage(HttpMethod.Post, "/mcp")
        {
            Content = new StringContent(body, System.Text.Encoding.UTF8, "application/json"),
        };
        req.Headers.TryAddWithoutValidation("Accept", "application/json, text/event-stream");
        if (sessionId is not null)
        {
            req.Headers.TryAddWithoutValidation("Mcp-Session-Id", sessionId);
        }

        var response = await client.SendAsync(req);
        response.EnsureSuccessStatusCode();
        return response;
    }

    private static async Task<(JsonDocument json, string raw)> ReadJsonRpcAsync(HttpResponseMessage response)
    {
        var raw = await response.Content.ReadAsStringAsync();
        var contentType = response.Content.Headers.ContentType?.MediaType;
        if (string.Equals(contentType, "text/event-stream", StringComparison.OrdinalIgnoreCase))
        {
            var dataLine = raw
                .Split('\n')
                .Select(l => l.TrimEnd('\r'))
                .FirstOrDefault(l => l.StartsWith("data:", StringComparison.Ordinal));
            if (dataLine is null)
            {
                throw new InvalidOperationException($"No SSE data line found in response: {raw}");
            }

            var json = dataLine[5..].TrimStart();
            return (JsonDocument.Parse(json), raw);
        }

        return (JsonDocument.Parse(raw), raw);
    }

    public class PowerfabAppFactory : WebApplicationFactory<Program>
    {
        public FakePowerfabClient FakeClient { get; } = new();

        protected virtual string? BearerToken => null;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            Environment.SetEnvironmentVariable("Powerfab__Username", "test-user");
            Environment.SetEnvironmentVariable("Powerfab__Password", "test-pw");
            Environment.SetEnvironmentVariable("Hosting__BearerToken", BearerToken ?? string.Empty);

            builder.UseEnvironment("Test");
            builder.ConfigureServices(services =>
            {
                var existing = services.Single(s => s.ServiceType == typeof(IPowerfabClient));
                services.Remove(existing);
                services.AddSingleton<IPowerfabClient>(FakeClient);
            });
        }
    }

    private sealed class ProtectedPowerfabAppFactory : PowerfabAppFactory
    {
        protected override string? BearerToken => "secret-token";
    }
}
