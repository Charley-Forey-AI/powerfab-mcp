---
title: Work Area Department Schedules
url: https://developer.tekla.com/documentation/work-area-department-schedules
slug: work-area-department-schedules
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Area Department Schedules
updated: 18 Feb 2025
---

# Work Area Department Schedules

This section details the API calls available for managing work area department schedules in Tekla PowerFab.

### **API Calls**

- `WorkAreaDepartmentSchedule_Upsert`

  This API call allows you to create or update work area department schedules. You'll need to provide the necessary details for the schedule, such as the `WorkAreaDepartmentID`, `StartDate`, and `EndDate`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartmentSchedule_Upsert>
      <WorkAreaDepartmentSchedule>
        <WorkAreaDepartmentID>123</WorkAreaDepartmentID>
        <StartDate>2025-03-10</StartDate>
        <EndDate>2025-03-25</EndDate>
      </WorkAreaDepartmentSchedule>
    </WorkAreaDepartmentSchedule_Upsert>
  </FabSuiteXMLRequest>
  ```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new work area department schedule or update an existing one.
- `WorkAreaDepartmentSchedule_Delete`

  This API call allows you to delete a work area department schedule. You'll need to provide the `WorkAreaDepartmentScheduleID` to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartmentSchedule_Delete>
      <WorkAreaDepartmentScheduleID>456</WorkAreaDepartmentScheduleID>
    </WorkAreaDepartmentSchedule_Delete>
  </FabSuiteXMLRequest>
  ```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove a work area department schedule from the system.
- `WorkAreaDepartmentSchedule_Get`

  This API call retrieves work area department schedules. You can filter the results by various criteria, such as the `WorkAreaDepartmentID` or a date range.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <WorkAreaDepartmentSchedule_Get>
    <WorkAreaDepartmentID>123</WorkAreaDepartmentID>
  </WorkAreaDepartmentSchedule_Get>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to retrieve the details of one or more work area department schedules.
- `WorkAreaDepartmentSchedule_Move_Start_And_End_Dates`

  This API call allows you to move the start and end dates of a work area department schedule. You'll need to provide the `WorkAreaDepartmentScheduleID` and the new start and end dates.

**Description:** Moves the start and end dates of a work area department schedule.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <WorkAreaDepartmentSchedule_Move_Start_And_End_Dates>
    <WorkAreaDepartmentScheduleID>456</WorkAreaDepartmentScheduleID>
    <NewStartDate>2025-04-01</NewStartDate>
    <NewEndDate>2025-04-15</NewEndDate>
  </WorkAreaDepartmentSchedule_Move_Start_And_End_Dates>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to change the start and end dates of an existing work area department schedule.

**End of Section: Work Area Department Schedules**
