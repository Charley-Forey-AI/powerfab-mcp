---
title: Inventory Location Sweeps
url: https://developer.tekla.com/documentation/inventory-location-sweeps
slug: inventory-location-sweeps
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Inventory Location Sweeps
updated: 13 Feb 2025
---

# Inventory Location Sweeps

This section details the API calls available for managing inventory location sweeps within Tekla PowerFab.

### **API Calls**

- `CreateInventoryLocationSweep`

  This API call initiates the creation of a new inventory location sweep in Tekla PowerFab. You'll typically provide details like the location being swept and the date of the sweep.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <CreateInventoryLocationSweep>
      <InventoryLocationSweep>
        <InventoryLocationID>2</InventoryLocationID> 
        <SweepDate>2024-09-06</SweepDate> 
      </InventoryLocationSweep>
    </CreateInventoryLocationSweep>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the InventoryLocationSweep object
  reqPowerFabAPI.fsreqInventoryLocationSweep sweep = new reqPowerFabAPI.fsreqInventoryLocationSweep();
  sweep.InventoryLocationID = 2; 
  sweep.SweepDate = new DateTime(2024, 9, 6);

  // Create the CreateInventoryLocationSweep command
  reqPowerFabAPI.fsreqCreateInventoryLocationSweep createCommand = new reqPowerFabAPI.fsreqCreateInventoryLocationSweep();
  createCommand.InventoryLocationSweep = sweep;

  // Add the command to the request
  request.CreateInventoryLocationSweep = createCommand; 

  // Execute the command and get the response
  resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```

**End of Section: Inventory Location Sweeps**
