---
title: Departments
url: https://developer.tekla.com/documentation/departments
slug: departments
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Departments
updated: 13 Feb 2025
---

# Departments

### **Department\_Get**

**Description:** Retrieves departments from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Department_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Department_Get>
    <Successful>true</Successful>
    <Department>
      <DepartmentID>123</DepartmentID>
      <DepartmentName>Department 1</DepartmentName>
    </Department>
    <Department>
      <DepartmentID>456</DepartmentID>
      <DepartmentName>Department 2</DepartmentName>
    </Department>
  </Department_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the departments returned.

### **Department\_Upsert**

**Description:** Inserts or updates one or more departments in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Department_Upsert>
    <Department>
      <DepartmentID>123</DepartmentID>
      <DepartmentName>Department 1</DepartmentName>
    </Department>
    <Department>
      <DepartmentID>456</DepartmentID>
      <DepartmentName>Department 2</DepartmentName>
    </Department>
  </Department_Upsert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Department_Upsert>
    <Successful>true</Successful>
  </Department_Upsert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DepartmentID` and `DepartmentName` elements are required for each department.

### **Department\_Delete**

**Description:** Deletes one or more departments from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Department_Delete>
    <DepartmentID>123</DepartmentID>
    <DepartmentID>456</DepartmentID>
  </Department_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Department_Delete>
    <Successful>true</Successful>
  </Department_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DepartmentID` element is required.

**End of Section: Departments**
