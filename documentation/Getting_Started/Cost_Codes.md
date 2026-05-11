---
title: Cost Codes
url: https://developer.tekla.com/documentation/cost-codes
slug: cost-codes
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Cost Codes
updated: 13 Feb 2025
---

# Cost Codes

### **CostCode\_Get**

**Description:** Retrieves cost codes from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostCode_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostCode_Get>
    <Successful>true</Successful>
    <CostCode>
      <CostCodeID>123</CostCodeID>
      <CostCodeName>Cost Code 1</CostCodeName>
    </CostCode>
    <CostCode>
      <CostCodeID>456</CostCodeID>
      <CostCodeName>Cost Code 2</CostCodeName>
    </CostCode>
  </CostCode_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the cost codes returned.

### **CostCode\_Upsert**

**Description:** Inserts or updates one or more cost codes in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostCode_Upsert>
    <CostCode>
      <CostCodeID>123</CostCodeID>
      <CostCodeName>Cost Code 1</CostCodeName>
    </CostCode>
    <CostCode>
      <CostCodeID>456</CostCodeID>
      <CostCodeName>Cost Code 2</CostCodeName>
    </CostCode>
  </CostCode_Upsert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostCode_Upsert>
    <Successful>true</Successful>
  </CostCode_Upsert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `CostCodeID` and `CostCodeName` elements are required for each cost code.

### **CostCode\_Delete**

**Description:** Deletes one or more cost codes from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostCode_Delete>
    <CostCodeID>123</CostCodeID>
    <CostCodeID>456</CostCodeID>
  </CostCode_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostCode_Delete>
    <Successful>true</Successful>
  </CostCode_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `CostCodeID` element is required.

**End of Section: Cost Codes**
