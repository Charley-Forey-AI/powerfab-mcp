---
title: Work Package Departments
url: https://developer.tekla.com/documentation/work-package-departments
slug: work-package-departments
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Package Departments
updated: 13 Feb 2025
---

# Work Package Departments

This section details the API call available for retrieving work package department data within Tekla PowerFab.

### **API Calls**

- `WorkPackageDepartment_Get`

  This API call retrieves information about the departments associated with a work package. You can filter the results by various criteria, such as the `WorkPackageID` or `DepartmentID`.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkPackageDepartment_Get>
      <WorkPackageID>123</WorkPackageID>
    </WorkPackageDepartment_Get>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Package Departments**
