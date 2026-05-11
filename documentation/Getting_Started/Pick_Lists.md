---
title: Pick Lists
url: https://developer.tekla.com/documentation/pick-lists
slug: pick-lists
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Pick Lists
updated: 13 Feb 2025
---

# Pick Lists

This section details the API call available for retrieving pick list data within Tekla PowerFab.

### **API Calls**

- `PickList_Get`

  This API call retrieves pick lists from Tekla PowerFab. You can filter the results by various criteria, such as job number, work order, or material status.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <PickList_Get>
      <Filter>
        <JobNumber>JOB-001</JobNumber>
      </Filter>
    </PickList_Get>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <PickList_Get>
      <Successful>true</Successful>
      <PickList>
        <PickListID>1</PickListID>
        <JobNumber>JOB-001</JobNumber>
        <WorkOrder>WO-001</WorkOrder>
        <MaterialStatus>Released</MaterialStatus>
        <PickListItem>
          <PartID>123</PartID>
          <MaterialID>456</MaterialID>
          <Quantity>2</Quantity>
          <Length>10</Length>
          <LengthUOM>ft</LengthUOM>
        </PickListItem>
        <PickListItem>
          <PartID>789</PartID>
          <MaterialID>101112</MaterialID>
          <Quantity>1</Quantity>
          <Length>5</Length>
          <LengthUOM>ft</LengthUOM>
        </PickListItem>
      </PickList>
    </PickList_Get>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the PickList_Get command with filter
  reqPowerFabAPI.fsreqPickList_Get getCommand = new reqPowerFabAPI.fsreqPickList_Get();
  getCommand.Filter = new reqPowerFabAPI.fsreqPickList_Get_Filter();
  getCommand.Filter.JobNumber = "JOB-001";

  // Add the command to the request
  request.PickList_Get = new List<reqPowerFabAPI.fsreqPickList_Get>();
  request.PickList_Get.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  if (response.PickList_Get.First().Successful)
  {
      List<resPowerFabAPI.PickList> pickLists = response.PickList_Get.First().PickList;
      //... process the retrieved pick lists
  }
  else
  {
      //... handle errors
  }
  ```

**End of Section: Pick Lists**
