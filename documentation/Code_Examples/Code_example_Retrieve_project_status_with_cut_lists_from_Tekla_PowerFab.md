---
title: 'Code example: Retrieve project status with cut lists from Tekla PowerFab'
url: https://developer.tekla.com/documentation/code-example-retrieve-project-status-cut-lists-tekla-powerfab
slug: code-example-retrieve-project-status-cut-lists-tekla-powerfab
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Retrieve project status with cut lists from Tekla PowerFab'
updated: 13 Apr 2023
---

# Code example: Retrieve project status with cut lists from Tekla PowerFab

This guide explains the Tekla PowerFab Open API command **GetProjectStatus** and how you can use it to get, for example, **CutList** information.

### Tekla PowerFab Open API command GetProjectStatus

**GetProjectStatus** retrieves summary information about the job including:

- Assemblies
- Drawings
- Sequences
- Lots
- RFIs
- Change Orders
- Transmittals
- Cut Lists
- Material Status
- Production Status
- Shipping Status

The **GetProjectStatus** command contains several fields that are not included in this guide.  For detailed documentation of all fields, see [API Reference](https://developer.tekla.com/tekla-epm/api/8/16984). XML is handy in that it lets you easily ignore unrecognized fields. So feel free to not define anything you don’t want.

The following example shows how to get CutList information. After retrieving the information, you can present the list of Cut Lists available for cutting in this job (cut list with something uncut).

## Retrieving CutList information for one job

| Command | Required Parameter | Optional Parameter |
| --- | --- | --- |
| GetProjectStatus | ProductionControlID:integer OR JobNumber:string | IncludeCutLists:boolean |

**IncludeCutLists** should be included, so it it is set to 1.

Here command **GetProjectStatus** uses **ProductionControlID** parameter:

```
<FabSuiteXMLRequest>
<GetProjectStatus>
  <ProductionControlID>1394</ProductionControlID>
  <IncludeCutLists>1</IncludeCutLists>
</GetProjectStatus>
</FabSuiteXMLRequest>
```

Or, you can call **GetProjectStatus** with **JobNumber** parameter:

```
<FabSuiteXMLRequest>
<GetProjectStatus>
  <JobNumber>Demo Job 2</JobNumber>
  <IncludeCutLists>1</IncludeCutLists>
</GetProjectStatus>
</FabSuiteXMLRequest>
```

Here is the example response:

```
<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0105.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <GetProjectStatus>
    <Successful>1</Successful>
    <ProductionControlID>1394</ProductionControlID>
    <JobNumber>Demo Job 2</JobNumber>
    <JobDescription>Demo Job 2</JobDescription>
    <JobLocation/>
    <GroupName/>
    <GroupName2/>
    <HasProjectSchedule>0</HasProjectSchedule>
    <InputDisplayUnits>
      <SizeUOM>Imperial</SizeUOM>
      <LengthUOM>Imperial</LengthUOM>
      <LengthTypeIDMetric>101</LengthTypeIDMetric>
      <LengthTypeIDImperial>1</LengthTypeIDImperial>
      <WeightUOM>Imperial</WeightUOM>
      <PriceUOM>Imperial</PriceUOM>
    </InputDisplayUnits>
    <Assemblies>
      <Quantity>106</Quantity>
    </Assemblies>
    <Drawings>
      <Total>118</Total>
      <TotalApproved>0</TotalApproved>
    </Drawings>
    <Sequences>
      <Total>4</Total>
    </Sequences>
    <Lots>
      <Total>2</Total>
    </Lots>
    <CutLists>
      <CutLists>3</CutLists>
      <CuttingDetails>4</CuttingDetails>
      <TotalCut>0</TotalCut>
      <TotalInvalidated>0</TotalInvalidated>
      <TotalValidationRequired>0</TotalValidationRequired>
      <TotalOnOrder>0</TotalOnOrder>
      <CutList>
        <CutListID>398</CutListID>
        <CutListName>W10x12</CutListName>
        <DateCreated>2022-02-29</DateCreated>
        <DateRequired>202-02-30</DateRequired>
        <CuttingDetails>2</CuttingDetails>
        <TotalCut>0</TotalCut>
        <TotalInvalidated>0</TotalInvalidated>
        <TotalValidationRequired>0</TotalValidationRequired>
        <TotalOnOrder>0</TotalOnOrder>
      </CutList>
      <CutList>
        <CutListID>399</CutListID>
        <CutListName>W12x22</CutListName>
        <DateCreated>2022-02-29</DateCreated>
        <DateRequired>2022-02-30</DateRequired>
        <CuttingDetails>1</CuttingDetails>
        <TotalCut>0</TotalCut>
        <TotalInvalidated>0</TotalInvalidated>
        <TotalValidationRequired>0</TotalValidationRequired>
        <TotalOnOrder>0</TotalOnOrder>
      </CutList>
      <CutList>
        <CutListID>400</CutListID>
        <CutListName>W14x30</CutListName>
        <DateCreated>2022-02-29</DateCreated>
        <DateRequired>2022-02-30</DateRequired>
        <CuttingDetails>1</CuttingDetails>
        <TotalCut>0</TotalCut>
        <TotalInvalidated>0</TotalInvalidated>
        <TotalValidationRequired>0</TotalValidationRequired>
        <TotalOnOrder>0</TotalOnOrder>
      </CutList>
    </CutLists>
  </GetProjectStatus>

</FabSuiteXMLResponse>
```
