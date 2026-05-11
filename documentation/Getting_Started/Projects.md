---
title: Projects
url: https://developer.tekla.com/documentation/projects
slug: projects
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Projects
updated: 13 Feb 2025
---

# Projects

This section details the API calls available for managing project data within Tekla PowerFab.

### **API Calls**

- `Project_Get`

  This API call retrieves details about projects in Tekla PowerFab. You can filter the results by various criteria, such as project name, status, or date range.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <Project_Get>
      <Filter>
        <ProjectName>Project A</ProjectName>
      </Filter>
    </Project_Get>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create a Project_Get command.
  reqPowerFabAPI.fsreqProject_Get getProjectsCommand = new reqPowerFabAPI.fsreqProject_Get();

  // Set the filter to retrieve only projects with the name "Project A".
  getProjectsCommand.Filter = new reqPowerFabAPI.fsreqProject_Get_Filter();
  getProjectsCommand.Filter.ProjectName = "Project A";

  // Add the command to the request.
  request.Project_Get = new List<reqPowerFabAPI.fsreqProject_Get>();
  request.Project_Get.Add(getProjectsCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
  {
      MessageBox.Show(response.XMLError.ToString());
  }
  else
  {
      // Get the Project_Get response object and check if it was successful.
      resPowerFabAPI.Project_Get getProjectsResponse = response.Project_Get.First();
      if (!getProjectsResponse.Successful)
      {
          MessageBox.Show(getProjectsResponse.ErrorMessage);
      }
      else
      {
          // The command was successful. Get the projects from the response.
          List<resPowerFabAPI.Project> projects = getProjectsResponse.Project;
          string projectsString = "";
          foreach (resPowerFabAPI.Project project in projects)
          {
              projectsString += "Project ID: " + project.ProjectID.ToString() + ", Project Name: " + project.ProjectName + Environment.NewLine;
          }
          MessageBox.Show(projectsString);
      }
  }
  ```
- `ExportProjectSchedule`

  This API call exports the project schedule for a given project ID.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ExportProjectSchedule>
      <ProjectID>123</ProjectID>
    </ExportProjectSchedule>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Export the project schedule for Project ID 123.
  reqPowerFabAPI.fsreqExportProjectSchedule exportProjectScheduleCommand = new reqPowerFabAPI.fsreqExportProjectSchedule();
  exportProjectScheduleCommand.ProjectID = 123;
  request.ExportProjectSchedule = new List<reqPowerFabAPI.fsreqExportProjectSchedule>();
  request.ExportProjectSchedule.Add(exportProjectScheduleCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.ExportProjectSchedule exportProjectScheduleResponse = response.ExportProjectSchedule.First();
      if (!exportProjectScheduleResponse.Successful)
          MessageBox.Show(exportProjectScheduleResponse.ErrorMessage);
      else
      {
          // Get the project schedule from the response.
          string projectSchedule = exportProjectScheduleResponse.ProjectSchedule;
          MessageBox.Show(projectSchedule);
      }
  }
  ```

**End of Section: Projects**
