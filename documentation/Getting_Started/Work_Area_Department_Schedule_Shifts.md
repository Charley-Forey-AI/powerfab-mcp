---
title: Work Area Department Schedule Shifts
url: https://developer.tekla.com/documentation/work-area-department-schedule-shifts
slug: work-area-department-schedule-shifts
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Area Department Schedule Shifts
updated: 18 Feb 2025
---

# Work Area Department Schedule Shifts

This section details the API calls available for managing work area department schedule shifts in Tekla PowerFab.

### **API Calls**

- `WorkAreaDepartmentScheduleShift_Upsert`

  This API call allows you to create or update work area department schedule shifts. You'll need to provide the necessary details for the shift, such as the `WorkAreaDepartmentScheduleID`, `DepartmentShiftID`, and other shift-related information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartmentScheduleShift_Upsert>
      <WorkAreaDepartmentScheduleShift>
        <WorkAreaDepartmentScheduleID>123</WorkAreaDepartmentScheduleID>
        <DepartmentShiftID>456</DepartmentShiftID>
        <//... other shift details>
      </WorkAreaDepartmentScheduleShift>
    </WorkAreaDepartmentScheduleShift_Upsert>
  </FabSuiteXMLRequest>
  ```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new work area department schedule shift or update an existing one.
- `WorkAreaDepartmentScheduleShift_Delete`

  This API call allows you to delete a work area department schedule shift. You'll need to provide the `WorkAreaDepartmentScheduleShiftID` to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartmentScheduleShift_Delete>
      <WorkAreaDepartmentScheduleShiftID>789</WorkAreaDepartmentScheduleShiftID>
    </WorkAreaDepartmentScheduleShift_Delete>
  </FabSuiteXMLRequest>
  ```

  **Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove a work area department schedule shift from the system.
- `WorkAreaDepartmentScheduleShift_Get`

  This API call retrieves work area department schedule shifts. You can filter the results by various criteria, such as the `WorkAreaDepartmentScheduleID` or `DepartmentShiftID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartmentScheduleShift_Get>
      <WorkAreaDepartmentScheduleID>123</WorkAreaDepartmentScheduleID>
    </WorkAreaDepartmentScheduleShift_Get>
  </FabSuiteXMLRequest>
  ```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to retrieve the details of one or more work area department schedule shifts.

**End of Section: Work Area Department Schedule Shifts**
