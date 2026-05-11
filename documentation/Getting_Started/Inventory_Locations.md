---
title: Inventory Locations
url: https://developer.tekla.com/documentation/inventory-locations
slug: inventory-locations
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Inventory Locations
updated: 13 Feb 2025
---

# Inventory Locations

This section details the API calls available for managing inventory locations within Tekla PowerFab.

### **API Calls**

- `GetInventoryLocations`

  This API call retrieves information about inventory locations defined in Tekla PowerFab. You can optionally filter the results by specific criteria.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <GetInventoryLocations/> 
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <GetInventoryLocations>
      <Successful>true</Successful>
      <InventoryLocation>
        <InventoryLocationID>1</InventoryLocationID>
        <InventoryLocationName>Main Warehouse</InventoryLocationName>
      </InventoryLocation>
      <InventoryLocation>
        <InventoryLocationID>2</InventoryLocationID>
        <InventoryLocationName>Yard</InventoryLocationName>
      </InventoryLocation>
    </GetInventoryLocations>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the GetInventoryLocations command 
  reqPowerFabAPI.fsreqGetInventoryLocations getCommand = new reqPowerFabAPI.fsreqGetInventoryLocations();

  // Add the command to the request
  request.GetInventoryLocations = new List<reqPowerFabAPI.fsreqGetInventoryLocations>();
  request.GetInventoryLocations.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  if (response.GetInventoryLocations.First().Successful) 
  {
      List<resPowerFabAPI.InventoryLocation> locations = response.GetInventoryLocations.First().InventoryLocation;
      //... process the retrieved inventory locations
  }
  else 
  {
      //... handle errors
  }
  ```
- `InventoryLocation_Upsert`

  This API call allows you to create new inventory locations or update existing ones. Provide the necessary details like location name and any relevant attributes.

  **Request (XML) - Create New**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <InventoryLocation_Upsert>
      <InventoryLocation>
        <InventoryLocationID>0</InventoryLocationID> <InventoryLocationName>New Location</InventoryLocationName>
      </InventoryLocation>
    </InventoryLocation_Upsert>
  </FabSuiteXMLRequest>
  ```

  **Request (XML) - Update Existing**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <InventoryLocation_Upsert>
      <InventoryLocation>
        <InventoryLocationID>3</InventoryLocationID> <InventoryLocationName>Updated Location Name</InventoryLocationName>
      </InventoryLocation>
    </InventoryLocation_Upsert>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the InventoryLocation object
  reqPowerFabAPI.fsreqInventoryLocation location = new reqPowerFabAPI.fsreqInventoryLocation();
  location.InventoryLocationID = 0; // 0 for new location, otherwise existing ID
  location.InventoryLocationName = "My New Location"; 

  // Create the InventoryLocation_Upsert command
  reqPowerFabAPI.fsreqInventoryLocation_Upsert upsertCommand = new reqPowerFabAPI.fsreqInventoryLocation_Upsert();
  upsertCommand.InventoryLocation = location;

  // Add the command to the request
  request.InventoryLocation_Upsert = upsertCommand;

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```
- `InventoryLocation_Delete`

  This API call allows you to delete an inventory location from Tekla PowerFab. You'll need to provide the ID of the location to be deleted.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <InventoryLocation_Delete>
      <InventoryLocationID>4</InventoryLocationID> 
    </InventoryLocation_Delete>
  </FabSuiteXMLRequest>
  ```

**End of Section: Inventory Locations**
