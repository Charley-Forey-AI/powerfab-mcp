---
title: Estimates
url: https://developer.tekla.com/documentation/estimates
slug: estimates
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Estimates
updated: 13 Feb 2025
---

# Estimates

### **EstimateJobCostSummary\_Get**

**Description:** Retrieves a summary of job costs for an estimate from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <EstimateJobCostSummary_Get>
    <EstimateID>123</EstimateID>
  </EstimateJobCostSummary_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <EstimateJobCostSummary_Get>
    <Successful>true</Successful>
    <EstimateJobCostSummary>
      <EstimateID>123</EstimateID>
      <JobNumber>JOB-123</JobNumber>
      <JobDescription>Job Description</JobDescription>
      <TotalCost>1000</TotalCost>
    </EstimateJobCostSummary>
  </EstimateJobCostSummary_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `EstimateID` element is required.

### **EstimateJobCostGroupSummary\_Get**

**Description:** Retrieves a summary of job cost groups for an estimate from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <EstimateJobCostGroupSummary_Get>
    <EstimateID>123</EstimateID>
  </EstimateJobCostGroupSummary_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <EstimateJobCostGroupSummary_Get>
    <Successful>true</Successful>
    <EstimateJobCostGroupSummary>
      <EstimateID>123</EstimateID>
      <CostGroupID>1</CostGroupID>
      <CostGroupName>Cost Group 1</CostGroupName>
      <TotalCost>500</TotalCost>
    </EstimateJobCostGroupSummary>
  </EstimateJobCostGroupSummary_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `EstimateID` element is required.

### **EstimateSummary\_Get**

**Description:** Retrieves a summary of an estimate from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <EstimateSummary_Get>
    <EstimateID>123</EstimateID>
  </EstimateSummary_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <EstimateSummary_Get>
    <Successful>true</Successful>
    <EstimateSummary>
      <EstimateID>123</EstimateID>
      <EstimateName>Estimate 1</EstimateName>
      <TotalCost>1000</TotalCost>
    </EstimateSummary>
  </EstimateSummary_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `EstimateID` element is required.

### **EstimateSummary\_Update**

**Description:** Updates an estimate summary in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <EstimateSummary_Update>
    <EstimateID>123</EstimateID>
    <EstimateName>Estimate 1</EstimateName>
    <TotalCost>1000</TotalCost>
  </EstimateSummary_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <EstimateSummary_Update>
    <Successful>true</Successful>
  </EstimateSummary_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `EstimateID`, `EstimateName`, and `TotalCost` elements are required.

**End of Section: Estimates**
