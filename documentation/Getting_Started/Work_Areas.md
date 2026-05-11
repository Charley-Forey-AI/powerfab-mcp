---
title: Work Areas
url: https://developer.tekla.com/documentation/work-areas
slug: work-areas
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Work Areas
updated: 13 Feb 2025
---

# Work Areas

This section details the API calls available for managing work areas in Tekla PowerFab.

### **API Calls**

- `WorkArea_Get`

  This API call retrieves information about work areas in Tekla PowerFab. You can filter the results by various criteria, such as the work area name or related workshop.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <WorkArea_Get>
      <WorkAreaName>Area A</WorkAreaName>
    </WorkArea_Get>
  </FabSuiteXMLRequest>
  ```

**End of Section: Work Areas**
