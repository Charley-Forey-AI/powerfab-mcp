---
title: Work Area Departments
url: https://developer.tekla.com/documentation/work-area-departments
slug: work-area-departments
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Area Departments
updated: 13 Feb 2025
---

# Work Area Departments

This section details the API call available for retrieving work area department data within Tekla PowerFab.

### **API Calls**

- `WorkAreaDepartment_Get`

  This API call retrieves information about the departments within a work area. You can filter the results by various criteria, such as the `WorkAreaDepartmentID` or `WorkAreaID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkAreaDepartment_Get>
      <WorkAreaID>123</WorkAreaID>
    </WorkAreaDepartment_Get>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Area Departments**
