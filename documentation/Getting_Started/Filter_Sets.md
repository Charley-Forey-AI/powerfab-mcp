---
title: Filter Sets
url: https://developer.tekla.com/documentation/filter-sets
slug: filter-sets
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Filter Sets
updated: 13 Feb 2025
---

# Filter Sets

### **FilterSetDetails\_Get**

**Description:** Retrieves filter set details from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FilterSetDetails_Get>
    <FilterSetName>Filter Set 1</FilterSetName>
  </FilterSetDetails_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FilterSetDetails_Get>
    <Successful>true</Successful>
    <FilterSetDetails>
      <FilterSetName>Filter Set 1</FilterSetName>
      <FilterSetDescription>Filter Set Description 1</FilterSetDescription>
      <FilterSet>
        <FilterName>Filter 1</FilterName>
        <FilterValue>Value 1</FilterValue>
      </FilterSet>
      <FilterSet>
        <FilterName>Filter 2</FilterName>
        <FilterValue>Value 2</FilterValue>
      </FilterSet>
    </FilterSetDetails>
  </FilterSetDetails_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FilterSetName` element is required.

**End of Section: Filter Sets**
