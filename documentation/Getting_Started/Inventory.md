---
title: Inventory
url: https://developer.tekla.com/documentation/inventory
slug: inventory
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Inventory
updated: 31 Mar 2026
---

# Inventory

This section details the API calls available for managing inventory data within Tekla PowerFab.

### **API Calls**

- `GetInventory`

  This API call retrieves information about inventory items. You can filter the results using various criteria, such as material type, shape, or location.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <GetInventory>
      <Filter>
        <MaterialTypeID>1</MaterialTypeID> 
        <Shape>W</Shape>
      </Filter>
    </GetInventory>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <GetInventory>
      <Successful>true</Successful>
      <InventoryItem>
        <InventoryItemID>101</InventoryItemID>
        <MaterialTypeID>1</MaterialTypeID>
        <Shape>W</Shape>
        <Dimensions Metric="0">16 x 36</Dimensions> 
        <Quantity>500</Quantity>
        <QuantityUOM>ft</QuantityUOM> 
      </InventoryItem>
      <InventoryItem>
        <InventoryItemID>102</InventoryItemID>
        <MaterialTypeID>1</MaterialTypeID>
        <Shape>W</Shape>
        <Dimensions Metric="0">12 x 26</Dimensions> 
        <Quantity>1200</Quantity>
        <QuantityUOM>ft</QuantityUOM> 
      </InventoryItem>
    </GetInventory>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the GetInventory command with filter
  reqPowerFabAPI.fsreqGetInventory getCommand = new reqPowerFabAPI.fsreqGetInventory();
  getCommand.Filter = new reqPowerFabAPI.fsreqGetInventory_Filter();
  getCommand.Filter.MaterialTypeID = 1;
  getCommand.Filter.Shape = "W";

  // Add the command to the request
  request.GetInventory = new List<reqPowerFabAPI.fsreqGetInventory>();
  request.GetInventory.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request); // Note the updated response type

  // Handle the response (check for errors, etc.)
  if (response.GetInventory.First().Successful) 
  {
      List<resPowerFabAPI.InventoryItem> items = response.GetInventory.First().InventoryItem;
      //... process the retrieved inventory items
  }
  else 
  {
      //... handle errors
  }
  ```

**End of Section: Inventory**
