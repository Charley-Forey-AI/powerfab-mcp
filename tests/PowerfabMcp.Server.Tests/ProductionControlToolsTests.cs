using System.Xml.Linq;
using Microsoft.Extensions.Logging.Abstractions;
using ModelContextProtocol;
using PowerfabMcp.Server.Models;
using PowerfabMcp.Server.Powerfab;
using PowerfabMcp.Server.Tests.Fakes;
using PowerfabMcp.Server.Tools;

namespace PowerfabMcp.Server.Tests;

public sealed class ProductionControlToolsTests
{
    private static readonly XNamespace Ns = PowerfabClient.RequestNs;

    [Fact]
    public async Task ListJobs_ParsesProductionControlJobs_AndReturnsSummaries()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (_, _) => new XElement(Ns + "GetProductionControlJobs",
                new XElement(Ns + "Successful", "1"),
                new XElement(Ns + "ProductionControlJob",
                    new XElement(Ns + "ProductionControlID", "1397"),
                    new XElement(Ns + "JobNumber", "Project 0001"),
                    new XElement(Ns + "JobDescription", "Demo Job"),
                    new XElement(Ns + "JobLocation", "Site A"),
                    new XElement(Ns + "GroupName", "Structural"),
                    new XElement(Ns + "GroupName2", ""),
                    new XElement(Ns + "CutListCount", "3"))),
        };

        var tool = new ProductionControlTools(fake, NullLogger<ProductionControlTools>.Instance);
        var result = await tool.ListAsync(new ListProductionControlJobsInput(), default);

        Assert.Equal("GetProductionControlJobs", fake.LastResponseElementName);
        var cmd = fake.LastCommand!;
        Assert.Equal("GetProductionControlJobs", cmd.Name.LocalName);
        Assert.DoesNotContain(cmd.Elements(), e => e.Name.LocalName == "IncludeClosedJobs");

        Assert.Single(result.Jobs);
        var j = result.Jobs[0];
        Assert.Equal(1397, j.ProductionControlId);
        Assert.Equal("Project 0001", j.JobNumber);
        Assert.Equal("Demo Job", j.JobDescription);
        Assert.Equal("Site A", j.JobLocation);
        Assert.Equal("Structural", j.GroupName);
        Assert.Null(j.GroupName2);
        Assert.Equal(3, j.CutListCount);
        Assert.Contains("1 production control job", result.Message);
    }

    [Fact]
    public async Task ListJobs_AddsOptionalFilters_WhenProvided()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (_, _) => new XElement(Ns + "GetProductionControlJobs",
                new XElement(Ns + "Successful", "true")),
        };

        var tool = new ProductionControlTools(fake, NullLogger<ProductionControlTools>.Instance);
        await tool.ListAsync(new ListProductionControlJobsInput
        {
            GroupName = " G1 ",
            IncludeClosedJobs = true,
            OnlyLinkedToProject = true,
            OnlyContainingCutLists = true,
            ProductionControlId = 42,
        }, default);

        var cmd = fake.LastCommand!;
        Assert.Equal("G1", cmd.Elements().First(e => e.Name.LocalName == "GroupName").Value);
        Assert.Equal("true", cmd.Elements().First(e => e.Name.LocalName == "IncludeClosedJobs").Value);
        Assert.Equal("true", cmd.Elements().First(e => e.Name.LocalName == "OnlyLinkedToProject").Value);
        Assert.Equal("true", cmd.Elements().First(e => e.Name.LocalName == "OnlyContainingCutLists").Value);
        Assert.Equal("42", cmd.Elements().First(e => e.Name.LocalName == "ProductionControlID").Value);
    }

    [Fact]
    public async Task ListJobs_SurfacesPowerfabError_AsMcpException()
    {
        var fake = new FakePowerfabClient
        {
            ResponseFactory = (_, _) => throw new PowerfabException("Remote offline"),
        };

        var tool = new ProductionControlTools(fake, NullLogger<ProductionControlTools>.Instance);
        var ex = await Assert.ThrowsAsync<McpException>(() =>
            tool.ListAsync(new ListProductionControlJobsInput(), default));

        Assert.Contains("Remote offline", ex.Message);
    }
}
