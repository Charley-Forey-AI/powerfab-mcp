using System.Xml.Linq;
using Microsoft.Extensions.Logging.Abstractions;
using ModelContextProtocol;
using PowerfabMcp.Server.Models;
using PowerfabMcp.Server.Powerfab;
using PowerfabMcp.Server.Tests.Fakes;
using PowerfabMcp.Server.Tools;

namespace PowerfabMcp.Server.Tests;

public sealed class WorkPackageToolsTests
{
    private static readonly XNamespace Ns = PowerfabClient.RequestNs;

    [Fact]
    public async Task CreateWorkPackage_MapsAllFields_AndReturnsServerId()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (name, _) => new XElement(Ns + name,
                new XElement(Ns + "Successful", "true"),
                new XElement(Ns + "WorkPackageID", "4242")),
        };

        var tool = new WorkPackageTools(fake, NullLogger<WorkPackageTools>.Instance);

        var input = new CreateWorkPackageInput
        {
            ProductionControlId = 17,
            WorkPackageNumber = "WP-001",
            Description = "First package",
            Notes = "Hello",
            WorkshopId = 5,
            Status = 2,
            Priority = WorkPackagePriority.High,
            IsFuture = true,
            StartDate = new DateOnly(2026, 5, 20),
            DueDate = new DateOnly(2026, 5, 30),
            Group1 = "Phase 1",
            Group2 = "Floor 3",
            IdempotencyKey = "stable-key-123",
        };

        var result = await tool.CreateAsync(input);

        Assert.Equal(4242, result.WorkPackageId);
        Assert.Contains("WP-001", result.Message);
        Assert.Equal("WorkPackage_Insert", fake.LastResponseElementName);

        var cmd = fake.LastCommand!;
        Assert.Equal("WorkPackage_Insert", cmd.Name.LocalName);
        Assert.Equal("stable-key-123", LocalValue(cmd, "CommandGUID"));
        Assert.Equal("17", LocalValue(cmd, "ProductionControlID"));
        Assert.Equal("WP-001", LocalValue(cmd, "WorkPackageNumber"));
        Assert.Equal("First package", LocalValue(cmd, "Description"));
        Assert.Equal("Hello", LocalValue(cmd, "Notes"));
        Assert.Equal("5", LocalValue(cmd, "WorkshopID"));
        Assert.Equal("2", LocalValue(cmd, "Status"));
        Assert.Equal("High", LocalValue(cmd, "Priority"));
        Assert.Equal("true", LocalValue(cmd, "IsFuture"));
        Assert.Equal("2026-05-20", LocalValue(cmd, "StartDate"));
        Assert.Equal("2026-05-30", LocalValue(cmd, "DueDate"));
        Assert.Equal("Phase 1", LocalValue(cmd, "Group1"));
        Assert.Equal("Floor 3", LocalValue(cmd, "Group2"));
    }

    [Fact]
    public async Task CreateWorkPackage_OmitsAbsentOptionalFields_AndAutoGeneratesIdempotencyKey()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (name, _) => new XElement(Ns + name,
                new XElement(Ns + "Successful", "true"),
                new XElement(Ns + "WorkPackageID", "1")),
        };

        var tool = new WorkPackageTools(fake, NullLogger<WorkPackageTools>.Instance);

        var result = await tool.CreateAsync(new CreateWorkPackageInput
        {
            ProductionControlId = 1,
            WorkPackageNumber = "WP-Min",
        });

        Assert.Equal(1, result.WorkPackageId);
        var cmd = fake.LastCommand!;

        Assert.Null(FindLocal(cmd, "Description"));
        Assert.Null(FindLocal(cmd, "Notes"));
        Assert.Null(FindLocal(cmd, "WorkshopID"));
        Assert.Null(FindLocal(cmd, "Status"));
        Assert.Null(FindLocal(cmd, "StartDate"));
        Assert.Null(FindLocal(cmd, "DueDate"));
        Assert.Null(FindLocal(cmd, "Group1"));
        Assert.Null(FindLocal(cmd, "Group2"));

        Assert.Equal("Medium", LocalValue(cmd, "Priority"));
        Assert.Equal("false", LocalValue(cmd, "IsFuture"));

        var generatedKey = LocalValue(cmd, "CommandGUID");
        Assert.True(Guid.TryParse(generatedKey, out _), $"CommandGUID was not a GUID: {generatedKey}");
    }

    [Theory]
    [InlineData(0, "WP-X")]
    [InlineData(-1, "WP-X")]
    [InlineData(1, "")]
    [InlineData(1, "   ")]
    public async Task CreateWorkPackage_RejectsInvalidInput(int prodControlId, string number)
    {
        var fake = new FakePowerfabClient();
        var tool = new WorkPackageTools(fake, NullLogger<WorkPackageTools>.Instance);

        await Assert.ThrowsAsync<ArgumentException>(() => tool.CreateAsync(new CreateWorkPackageInput
        {
            ProductionControlId = prodControlId,
            WorkPackageNumber = number,
        }));

        Assert.Null(fake.LastCommand);
    }

    [Fact]
    public async Task CreateWorkPackage_ThrowsWhenServerOmitsWorkPackageId()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (name, _) => new XElement(Ns + name,
                new XElement(Ns + "Successful", "true")),
        };

        var tool = new WorkPackageTools(fake, NullLogger<WorkPackageTools>.Instance);

        await Assert.ThrowsAsync<McpException>(() => tool.CreateAsync(new CreateWorkPackageInput
        {
            ProductionControlId = 1,
            WorkPackageNumber = "WP",
        }));
    }

    [Fact]
    public async Task CreateWorkPackage_SurfacesPowerfabError_AsMcpException()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (_, __) => throw new PowerfabException("Job 99 not found"),
        };
        var tool = new WorkPackageTools(fake, NullLogger<WorkPackageTools>.Instance);

        var ex = await Assert.ThrowsAsync<McpException>(() => tool.CreateAsync(new CreateWorkPackageInput
        {
            ProductionControlId = 99,
            WorkPackageNumber = "WP",
        }));
        Assert.Contains("Job 99 not found", ex.Message);
    }

    private static string? LocalValue(XElement parent, string localName)
        => FindLocal(parent, localName)?.Value;

    private static XElement? FindLocal(XElement parent, string localName)
        => parent.Elements().FirstOrDefault(e => string.Equals(e.Name.LocalName, localName, StringComparison.OrdinalIgnoreCase));
}
