---
title: Cost Types
url: https://developer.tekla.com/documentation/cost-types
slug: cost-types
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Cost Types
updated: 13 Feb 2025
---

# Cost Types

### **CostType\_Get**

**Description:** Retrieves cost types from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostType_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostType_Get>
    <Successful>true</Successful>
    <CostType>
      <CostTypeID>123</CostTypeID>
      <CostTypeName>Cost Type 1</CostTypeName>
    </CostType>
    <CostType>
      <CostTypeID>456</CostTypeID>
      <CostTypeName>Cost Type 2</CostTypeName>
    </CostType>
  </CostType_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the cost types returned.

### **CostType\_Upsert**

**Description:** Inserts or updates one or more cost types in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostType_Upsert>
    <CostType>
      <CostTypeID>123</CostTypeID>
      <CostTypeName>Cost Type 1</CostTypeName>
    </CostType>
    <CostType>
      <CostTypeID>456</CostTypeID>
      <CostTypeName>Cost Type 2</CostTypeName>
    </CostType>
  </CostType_Upsert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostType_Upsert>
    <Successful>true</Successful>
  </CostType_Upsert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `CostTypeID` and `CostTypeName` elements are required for each cost type.

### **CostType\_Delete**

**Description:** Deletes one or more cost types from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CostType_Delete>
    <CostTypeID>123</CostTypeID>
    <CostTypeID>456</CostTypeID>
  </CostType_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CostType_Delete>
    <Successful>true</Successful>
  </CostType_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `CostTypeID` element is required.

**End of Section: Cost Types**
