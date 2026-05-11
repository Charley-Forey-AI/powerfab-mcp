---
title: Work Package Department Tasks
url: https://developer.tekla.com/documentation/work-package-department-tasks
slug: work-package-department-tasks
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Package Department Tasks
updated: 13 Feb 2025
---

# Work Package Department Tasks

This section details the API calls available for managing work package department tasks in Tekla PowerFab.

### **API Calls**

- `WorkPackageDepartmentTask_Get`

  This API call retrieves work package department tasks from Tekla PowerFab. You can filter the results by various criteria, such as `WorkPackageDepartmentTaskID` or `WorkPackageDepartmentID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTask_Get>
      <WorkPackageDepartmentID>123</WorkPackageDepartmentID>
    </WorkPackageDepartmentTask_Get>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Get the work package department tasks for WorkPackageDepartmentID 123.
  reqPowerFabAPI.fsreqWorkPackageDepartmentTask_Get getWorkPackageDepartmentTasksCommand = new reqPowerFabAPI.fsreqWorkPackageDepartmentTask_Get();
  getWorkPackageDepartmentTasksCommand.WorkPackageDepartmentID = 123;
  request.WorkPackageDepartmentTask_Get = new List<reqPowerFabAPI.fsreqWorkPackageDepartmentTask_Get>();
  request.WorkPackageDepartmentTask_Get.Add(getWorkPackageDepartmentTasksCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.WorkPackageDepartmentTask_Get workPackageDepartmentTasksResponse = response.WorkPackageDepartmentTask_Get.First();
      if (!workPackageDepartmentTasksResponse.Successful)
          MessageBox.Show(workPackageDepartmentTasksResponse.ErrorMessage);
      else
      {
          // Get the work package department tasks from the response.
          List<resPowerFabAPI.WorkPackageDepartmentTask> workPackageDepartmentTasks = workPackageDepartmentTasksResponse.WorkPackageDepartmentTask;
          string workPackageDepartmentTasksString = "";
          foreach (resPowerFabAPI.WorkPackageDepartmentTask workPackageDepartmentTask in workPackageDepartmentTasks)
          {
              workPackageDepartmentTasksString += "Work Package Department Task ID:" + workPackageDepartmentTask.WorkPackageDepartmentTaskID.ToString() + ", Work Package Department ID: " + workPackageDepartmentTask.WorkPackageDepartmentID + Environment.NewLine;
          }
          MessageBox.Show(workPackageDepartmentTasksString);
      }
  }
  ```
- `WorkPackageDepartmentTask_Split`

  This API call allows you to split a work package department task into two separate tasks. You'll need to provide the `WorkPackageDepartmentTaskID` to split and the split information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTask_Split>
      <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
      <SplitQuantity>50</SplitQuantity> </WorkPackageDepartmentTask_Split>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTask_Delete`

  This API call allows you to delete a work package department task. You'll need to provide the `WorkPackageDepartmentTaskID` to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTask_Delete>
      <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
    </WorkPackageDepartmentTask_Delete>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTask_Unschedule`

  This API call unschedules a work package department task. You'll need to provide the `WorkPackageDepartmentTaskID` to unschedule.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTask_Unschedule>
      <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
    </WorkPackageDepartmentTask_Unschedule>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageDepartmentTask_Schedule`

  This API call schedules a work package department task. You'll need to provide the `WorkPackageDepartmentTaskID` to schedule and the scheduling information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartmentTask_Schedule>
      <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
      <WorkAreaDepartmentID>456</WorkAreaDepartmentID>
    </WorkPackageDepartmentTask_Schedule>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Package Department Tasks**
