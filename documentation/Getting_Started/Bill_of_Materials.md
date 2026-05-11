---
title: Bill of Materials
url: https://developer.tekla.com/documentation/bill-materials
slug: bill-materials
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Bill of Materials
updated: 19 Feb 2025
---

# Bill of Materials

## **Bill of Materials**

### **GetBillOfMaterials**

Description: Retrieves bill of materials from Tekla PowerFab.

**Request (XML)**

```
<FabSuiteXMLRequest>
<ConnectionGUID>your_connection_guid</ConnectionGUID>
<GetBillOfMaterials>
<JobNumber>your_job_number</JobNumber>
</GetBillOfMaterials>
</FabSuiteXMLRequest>
```

**Response (XML)**

```
<FabSuiteXMLResponse>
<GetBillOfMaterials>
  <Successful>true</Successful>
  <BillOfMaterial>
    <BillOfMaterialID>123</BillOfMaterialID>
    <BillOfMaterialName>Bill of Material 1</BillOfMaterialName>
  </BillOfMaterial>
  <BillOfMaterial>
    <BillOfMaterialID>456</BillOfMaterialID>
    <BillOfMaterialName>Bill of Material 2</BillOfMaterialName>
  </BillOfMaterial>
</GetBillOfMaterials>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

You can use filters to limit the bill of materials returned.
