---
title: Work Packages
url: https://developer.tekla.com/documentation/work-packages
slug: work-packages
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Packages
updated: 13 Feb 2025
---

# Work Packages

This section details the API calls available for managing work packages in Tekla PowerFab.

### **API Calls**

- `WorkPackage_Get`

  This API call retrieves work packages from Tekla PowerFab. You can filter the results by various criteria, such as the `WorkPackageID`, `JobNumber`, or `WorkshopID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_Get>
      <JobNumber>JOB-001</JobNumber>
    </WorkPackage_Get>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Get the work packages for JobNumber "JOB-001".
  reqPowerFabAPI.fsreqWorkPackage_Get getWorkPackagesCommand = new reqPowerFabAPI.fsreqWorkPackage_Get();
  getWorkPackagesCommand.JobNumber = "JOB-001";
  request.WorkPackage_Get = new List<reqPowerFabAPI.fsreqWorkPackage_Get>();
  request.WorkPackage_Get.Add(getWorkPackagesCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.WorkPackage_Get workPackagesResponse = response.WorkPackage_Get.First();
      if (!workPackagesResponse.Successful)
          MessageBox.Show(workPackagesResponse.ErrorMessage);
      else
      {
          // Get the work packages from the response.
          List<resPowerFabAPI.WorkPackage> workPackages = workPackagesResponse.WorkPackage;
          string workPackagesString = "";
          foreach (resPowerFabAPI.WorkPackage workPackage in workPackages)
          {
              workPackagesString += "Work Package ID:" + workPackage.WorkPackageID.ToString() + ", Job Number: " + workPackage.JobNumber + Environment.NewLine;
          }
          MessageBox.Show(workPackagesString);
      }
  }
  ```
- `WorkPackage_Insert`

  This API call allows you to insert a new work package into Tekla PowerFab. You'll need to provide the necessary details for the work package, such as the `JobNumber`, `WorkshopID`, and other relevant information.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_Insert>
      <WorkPackage>
        <JobNumber>JOB-001</JobNumber>
        <WorkshopID>123</WorkshopID>
        <//... other work package details>
      </WorkPackage>
    </WorkPackage_Insert>
  </FabSuiteXMLRequest>
  ```
- `WorkPackage_Update`

  This API call allows you to update an existing work package in Tekla PowerFab. You'll need to provide the `WorkPackageID` and the updated information for the work package.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_Update>
      <WorkPackage>
        <WorkPackageID>456</WorkPackageID>
        <//... updated work package details>
      </WorkPackage>
    </WorkPackage_Update>
  </FabSuiteXMLRequest>
  ```
- `WorkPackage_Delete`

  This API call allows you to delete a work package from Tekla PowerFab. You'll need to provide the `WorkPackageID` to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_Delete>
      <WorkPackageID>456</WorkPackageID>
    </WorkPackage_Delete>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageGroup1List_Get`

  This API call retrieves a list of work package group 1 values.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageGroup1List_Get/>
  </FabSuiteXMLRequest>
  ```
- `WorkPackageGroup2List_Get`

  This API call retrieves a list of work package group 2 values.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageGroup2List_Get/>
  </FabSuiteXMLRequest>
  ```
- `WorkPackage_ScheduleToWorkshop`

  This API call schedules a work package to a specific workshop. You'll need to provide the `WorkPackageID` and the `WorkshopID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_ScheduleToWorkshop>
      <WorkPackageID>456</WorkPackageID>
      <WorkshopID>123</WorkshopID>
    </WorkPackage_ScheduleToWorkshop>
  </FabSuiteXMLRequest>
  ```
- `WorkPackage_Unschedule`

  This API call unschedules a work package from its current workshop. You'll need to provide the `WorkPackageID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackage_Unschedule>
      <WorkPackageID>456</WorkPackageID>
    </WorkPackage_Unschedule>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Packages**
