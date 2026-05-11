---
title: Work Package Department Task Completions
url: https://developer.tekla.com/documentation/work-package-department-task-completions
slug: work-package-department-task-completions
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Package Department Task Completions
updated: 13 Feb 2025
---

# Work Package Department Task Completions

This section details the API calls available for managing work package department task completions in Tekla PowerFab.

### **API Calls**

- `WorkPackageDepartmentTaskCompletion_Get`

  This API call retrieves work package department task completions from Tekla PowerFab. You can filter the results by various criteria, such as `WorkPackageDepartmentTaskCompletionID` or `WorkPackageDepartmentTaskID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTaskCompletion_Get>
      <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
    </WorkPackageDepartmentTaskCompletion_Get>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTaskCompletion_Update`

  This API call allows you to update a work package department task completion. You'll need to provide the `WorkPackageDepartmentTaskCompletionID` and the updated completion information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTaskCompletion_Update>
      <WorkPackageDepartmentTaskCompletion>
        <WorkPackageDepartmentTaskCompletionID>456</WorkPackageDepartmentTaskCompletionID>
        <//... updated completion details>
      </WorkPackageDepartmentTaskCompletion>
    </WorkPackageDepartmentTaskCompletion_Update>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTaskCompletion_Insert`

  This API call allows you to insert a new work package department task completion. You'll need to provide the necessary details for the completion, such as the `WorkPackageDepartmentTaskID` and other relevant information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTaskCompletion_Insert>
      <WorkPackageDepartmentTaskCompletion>
        <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
        <//... other completion details>
      </WorkPackageDepartmentTaskCompletion>
    </WorkPackageDepartmentTaskCompletion_Insert>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTaskCompletion_Delete`

  This API call allows you to delete a work package department task completion. You'll need to provide the `WorkPackageDepartmentTaskCompletionID` to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTaskCompletion_Delete>
      <WorkPackageDepartmentTaskCompletionID>456</WorkPackageDepartmentTaskCompletionID>
    </WorkPackageDepartmentTaskCompletion_Delete>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Package Department Task Completions**
