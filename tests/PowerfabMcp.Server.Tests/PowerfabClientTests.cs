using System.Xml.Linq;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using PowerfabMcp.Server.Configuration;
using PowerfabMcp.Server.Powerfab;
using PowerfabMcp.Server.Tests.Fakes;

namespace PowerfabMcp.Server.Tests;

public sealed class PowerfabClientTests
{
    private static readonly XNamespace Ns = PowerfabClient.RequestNs;

    private static PowerfabClient CreateClient(
        FakeTeklaPowerFabAPI fakeApi,
        PowerfabOptions? options = null)
    {
        options ??= new PowerfabOptions
        {
            Username = "user",
            Password = "pw",
            RemoteHost = "127.0.0.1",
            RemotePort = 8080,
        };
        return new PowerfabClient(fakeApi, Options.Create(options), NullLogger<PowerfabClient>.Instance);
    }

    private static string Envelope(string innerXml)
        => $"""<?xml version="1.0" encoding="utf-8"?><FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd">{innerXml}</FabSuiteXMLResponse>""";

    [Fact]
    public async Task ExecuteAsync_ConnectsOnFirstCall_AndReusesConnectionGuid()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>GUID-1</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>true</Successful><WorkPackageID>10</WorkPackageID></WorkPackage_Insert>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>true</Successful><WorkPackageID>11</WorkPackageID></WorkPackage_Insert>"));

        var client = CreateClient(api);

        await client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert"));
        await client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert"));

        Assert.Equal(3, api.Requests.Count);
        Assert.Contains("ConnectRemote", api.Requests[0]);
        Assert.Contains("GUID-1", api.Requests[1]);
        Assert.Contains("GUID-1", api.Requests[2]);
        Assert.DoesNotContain("ConnectRemote", api.Requests[2]);
    }

    [Fact]
    public async Task ExecuteAsync_ReconnectsOnceWhenSessionExpired()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>GUID-OLD</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>false</Successful><ErrorMessage>Connection expired, please log in again.</ErrorMessage></WorkPackage_Insert>"));
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>GUID-NEW</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>true</Successful><WorkPackageID>99</WorkPackageID></WorkPackage_Insert>"));

        var client = CreateClient(api);

        var response = await client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert"));

        Assert.Equal("99", response.Elements().First(e => e.Name.LocalName == "WorkPackageID").Value);
        Assert.Equal(4, api.Requests.Count);
        Assert.Contains("GUID-OLD", api.Requests[1]);
        Assert.Contains("GUID-NEW", api.Requests[3]);
    }

    [Fact]
    public async Task ExecuteAsync_ThrowsPowerfabException_OnXmlError()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>G</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope("<XMLError>Bad request</XMLError>"));

        var client = CreateClient(api);

        var ex = await Assert.ThrowsAsync<PowerfabException>(() =>
            client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert")));

        Assert.Contains("Bad request", ex.Message);
    }

    [Fact]
    public async Task ExecuteAsync_PropagatesPerCommandErrorMessage()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>G</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>false</Successful><ErrorMessage>Workshop 999 not found</ErrorMessage></WorkPackage_Insert>"));

        var client = CreateClient(api);

        var ex = await Assert.ThrowsAsync<PowerfabException>(() =>
            client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert")));

        Assert.Contains("Workshop 999 not found", ex.Message);
        Assert.False(ex.IsAuthExpired);
    }

    [Fact]
    public async Task ExecuteAsync_AddsApiLogElement_WhenConfigured()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>G</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            "<WorkPackage_Insert><Successful>true</Successful><WorkPackageID>1</WorkPackageID></WorkPackage_Insert>"));

        var client = CreateClient(api, new PowerfabOptions
        {
            Username = "u",
            Password = "p",
            RemoteHost = "h",
            RemotePort = 1,
            ApiLog = "all",
        });

        await client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert"));

        Assert.Contains("APILog", api.Requests[1]);
        Assert.Contains(">all<", api.Requests[1]);
    }

    [Fact]
    public async Task ExecuteAsync_TreatsSuccessfulOne_AsSuccess()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<ConnectRemote><Successful>true</Successful><ConnectionGUID>G</ConnectionGUID></ConnectRemote>"));
        api.Responses.Enqueue(_ => Envelope(
            """
            <GetProductionControlJobs>
              <Successful>1</Successful>
              <ProductionControlJob>
                <ProductionControlID>1397</ProductionControlID>
                <JobNumber>J1</JobNumber>
                <JobDescription>Demo</JobDescription>
              </ProductionControlJob>
            </GetProductionControlJobs>
            """));

        var client = CreateClient(api);
        var response = await client.ExecuteAsync(
            "GetProductionControlJobs",
            new XElement(Ns + "GetProductionControlJobs"));

        Assert.Equal("1397", response.Elements().First(e => e.Name.LocalName == "ProductionControlJob")
            .Elements().First(e => e.Name.LocalName == "ProductionControlID").Value);
    }

    [Fact]
    public async Task Connect_AppendsHint_WhenXmLErrorLooksLikeTls_AndPortIsDatabase()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<XMLError>Cannot determine the frame size or a corrupted frame was received.</XMLError>"));

        var client = CreateClient(api, new PowerfabOptions
        {
            Username = "u",
            Password = "p",
            RemoteHost = "127.0.0.1",
            RemotePort = 3306,
        });

        var ex = await Assert.ThrowsAsync<PowerfabException>(() =>
            client.ExecuteAsync("GetProductionControlJobs", new XElement(Ns + "GetProductionControlJobs")));

        Assert.Contains("3306", ex.Message);
        Assert.Contains("database port", ex.Message);
    }

    [Fact]
    public async Task Connect_DoesNotAppendDatabaseHint_WhenPortIsTypicalRemoteService()
    {
        var api = new FakeTeklaPowerFabAPI();
        api.Responses.Enqueue(_ => Envelope(
            "<XMLError>Cannot determine the frame size or a corrupted frame was received.</XMLError>"));

        var client = CreateClient(api, new PowerfabOptions
        {
            Username = "u",
            Password = "p",
            RemoteHost = "127.0.0.1",
            RemotePort = 8080,
        });

        var ex = await Assert.ThrowsAsync<PowerfabException>(() =>
            client.ExecuteAsync("GetProductionControlJobs", new XElement(Ns + "GetProductionControlJobs")));

        Assert.DoesNotContain("database port", ex.Message);
    }

    [Fact]
    public async Task ExecuteAsync_ConnectsExactlyOnce_UnderConcurrentRequests()
    {
        var api = new FakeTeklaPowerFabAPI();
        using var connectGate = new ManualResetEventSlim(initialState: false);
        api.Responses.Enqueue(_ =>
        {
            connectGate.Wait(TimeSpan.FromSeconds(5));
            return Envelope(
                "<ConnectRemote><Successful>true</Successful><ConnectionGUID>SHARED</ConnectionGUID></ConnectRemote>");
        });
        for (var i = 0; i < 10; i++)
        {
            api.Responses.Enqueue(_ => Envelope(
                "<WorkPackage_Insert><Successful>true</Successful><WorkPackageID>1</WorkPackageID></WorkPackage_Insert>"));
        }

        var client = CreateClient(api);

        var tasks = Enumerable.Range(0, 10)
            .Select(_ => client.ExecuteAsync("WorkPackage_Insert", new XElement(Ns + "WorkPackage_Insert")))
            .ToArray();

        await Task.Delay(50);
        connectGate.Set();

        await Task.WhenAll(tasks);

        var connectCount = api.Requests.Count(r => r.Contains("ConnectRemote"));
        Assert.Equal(1, connectCount);
        Assert.Equal(11, api.Requests.Count);
    }
}
