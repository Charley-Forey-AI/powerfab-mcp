---
title: 'Code example: Retrieve a list of jobs from Tekla PowerFab'
url: https://developer.tekla.com/documentation/code-example-retrieve-list-jobs-tekla-powerfab
slug: code-example-retrieve-list-jobs-tekla-powerfab
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Retrieve a list of jobs from Tekla PowerFab'
updated: 7 May 2024
---

# Code example: Retrieve a list of jobs from Tekla PowerFab

Get code

[Tekla PowerFab API code example - Read Production Control jobs](https://developer.tekla.com/sites/default/files/files/download-codefile/file/TeklaPowerFabOpenAPIExample-Direct_2.zip "Open archive in new window")9.36 MB

This guide explains the Tekla PowerFab Open API command **GetProductionControlJobs.**

Tekla PowerFab Go job overview

Production control job information in Tekla PowerFab Go.

## GetProductionControlJobs command

| Command | Required parameter | Optional parameters |
| --- | --- | --- |
| GetProductionControlJobs | None | GroupName :string |
|  |  | GroupName2:string |
|  |  | JobNumber :string |

## Request format

The request can be formed like this:

```
<FabSuiteXMLRequest>
  <GetProductionControlJobs/>
</FabSuiteXMLRequest>
```

Or like this:

```
<FabSuiteXMLRequest>
  <GetProductionControlJobs>
  </GetProductionControlJobs>
</FabSuiteXMLRequest>
```

## Using optional parameters

Below is an example with one optional parameter. You can add multiple optional parameters if needed. The example will retrieve all jobs in the “Structural” job group:

```
<FabSuiteXMLRequest>
  <GetProductionControlJobs>
    <GroupName>Structural</GroupName>
  </GetProductionControlJobs>
</FabSuiteXMLRequest>
```

Using the **JobNumber** tag will retrieve one job – with the matching JobNumber. Here in an example response:

```
<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
<FabSuiteXMLResponse xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <GetProductionControlJobs>
    <Successful>1</Successful>
    <ProductionControlJob>
      <ProductionControlID>1397</ProductionControlID>
      <JobNumber>Project 0001</JobNumber>
      <JobDescription>Demo Job</JobDescription>
      <JobLocation/>
      <GroupName/>
      <GroupName2/>
    </ProductionControlJob>
    <ProductionControlJob>
      <ProductionControlID>1394</ProductionControlID>
      <JobNumber>Project 0002</JobNumber>
      <JobDescription>Demo Job 2</JobDescription>
      <JobLocation/>
      <GroupName/>
      <GroupName2/>
    </ProductionControlJob>
    <ProductionControlJob>
      <ProductionControlID>781</ProductionControlID>
      <JobNumber>Project 0003</JobNumber>
      <JobDescription>Demo Job 3</JobDescription>
      <JobLocation/>
      <GroupName>Old Orders</GroupName>
      <GroupName2/>
    </ProductionControlJob>
  </GetProductionControlJobs>
  <JobGroups>
      <GroupName> </GroupName>
      <GroupName>Old Orders </GroupName>
   </JobGroups>
</FabSuiteXMLResponse>
```

## Descriptions for all fields

| Field | Parent | Description |
| --- | --- | --- |
| GetProductionControlJobs | FabSuiteXMLResponse | Command that this is responding to |
|  |  |  |
| Successful | GetProductionControlJobs | Boolean: 1 if command was successful |
| ProductionControlJob | GetProductionControlJobs | A single production control job. There may be several of these. |
|  |  |  |
| ProductionControlID | ProductionControlJob | Integer: Unique numeric ID of job |
| JobNumber | ProductionControlJob | String: Unique Name of job |
| JobDescription | ProductionControlJob | String: Job Description |
| JobLocation | ProductionControlJob | String: Job Location |
| GroupName | ProductionControlJob | String: Job Group |
| GroupName2 | ProductionControlJob | String: Job Group 2 |
|  |  |  |
| JobGroups | FabSuiteXMLResponse | XML tag that contains all job groups represented in this response |
|  |  |  |
| GroupName | JobGroups | String: A single Job Group represented. Multiple is allowed. |
| GroupName2 | JobGroups | String: A single Job Group2 represented. Multiple is allowed. |
