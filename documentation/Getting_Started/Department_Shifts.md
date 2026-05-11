---
title: Department Shifts
url: https://developer.tekla.com/documentation/department-shifts
slug: department-shifts
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Department Shifts
updated: 13 Feb 2025
---

# Department Shifts

### **DepartmentShift\_Get**

**Description:** Retrieves department shifts from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DepartmentShift_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DepartmentShift_Get>
    <Successful>true</Successful>
    <DepartmentShift>
      <DepartmentShiftID>123</DepartmentShiftID>
      <DepartmentShiftName>Department Shift 1</DepartmentShiftName>
    </DepartmentShift>
    <DepartmentShift>
      <DepartmentShiftID>456</DepartmentShiftID>
      <DepartmentShiftName>Department Shift 2</DepartmentShiftName>
    </DepartmentShift>
  </DepartmentShift_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the department shifts returned.

### **DepartmentShift\_Upsert**

**Description:** Inserts or updates one or more department shifts in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DepartmentShift_Upsert>
    <DepartmentShift>
      <DepartmentShiftID>123</DepartmentShiftID>
      <DepartmentShiftName>Department Shift 1</DepartmentShiftName>
    </DepartmentShift>
    <DepartmentShift>
      <DepartmentShiftID>456</DepartmentShiftID>
      <DepartmentShiftName>Department Shift 2</DepartmentShiftName>
    </DepartmentShift>
  </DepartmentShift_Upsert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DepartmentShift_Upsert>
    <Successful>true</Successful>
  </DepartmentShift_Upsert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DepartmentShiftID` and `DepartmentShiftName` elements are required for each department shift.

### **DepartmentShift\_Delete**

**Description:** Deletes one or more department shifts from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DepartmentShift_Delete>
    <DepartmentShiftID>123</DepartmentShiftID>
    <DepartmentShiftID>456</DepartmentShiftID>
  </DepartmentShift_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DepartmentShift_Delete>
    <Successful>true</Successful>
  </DepartmentShift_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DepartmentShiftID` element is required.

**End of Section: Department Shifts**
