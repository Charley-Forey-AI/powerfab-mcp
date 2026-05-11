---
title: Workshop
url: https://developer.tekla.com/documentation/workshop
slug: workshop
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Workshop
updated: 13 Feb 2025
---

# Workshop

This section details the API call available for retrieving workshop data within Tekla PowerFab.

### **API Calls**

- `Workshop_Get`

  This API call retrieves information about workshops in Tekla PowerFab. You can filter the results by various criteria, such as workshop name or location.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <Workshop_Get>
      <WorkshopName>Workshop A</WorkshopName>
    </Workshop_Get>
  </FabSuiteXMLRequest>
  ```

**End of Section: Workshop**
