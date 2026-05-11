---
title: Shop Floor
url: https://developer.tekla.com/documentation/shop-floor
slug: shop-floor
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Shop Floor
updated: 13 Feb 2025
---

# Shop Floor

This section details the API call available for saving shop floor data within Tekla PowerFab.

### **API Calls**

- `ShopFloorSave`

  This API call allows you to save shop floor data to Tekla PowerFab. You'll typically provide details about the work done on the shop floor, such as the task, employee, and hours worked.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ShopFloorSave>
      <WorkCompleted>
        <WorkPackageDepartmentTaskID>123</WorkPackageDepartmentTaskID>
        <EmployeeID>456</EmployeeID>
        <HoursWorked>8</HoursWorked>
      </WorkCompleted>
    </ShopFloorSave>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create a ShopFloorSave command.
  reqPowerFabAPI.fsreqShopFloorSave shopFloorSaveCommand = new reqPowerFabAPI.fsreqShopFloorSave();

  // Create a WorkCompleted object.
  reqPowerFabAPI.fsreqShopFloorSave_WorkCompleted workCompleted = new reqPowerFabAPI.fsreqShopFloorSave_WorkCompleted();
  workCompleted.WorkPackageDepartmentTaskID = 123;
  workCompleted.EmployeeID = 456;
  workCompleted.HoursWorked = 8;

  // Add the WorkCompleted object to the ShopFloorSave command.
  shopFloorSaveCommand.WorkCompleted = new List<reqPowerFabAPI.fsreqShopFloorSave_WorkCompleted>();
  shopFloorSaveCommand.WorkCompleted.Add(workCompleted);

  // Add the ShopFloorSave command to the request.
  request.ShopFloorSave = shopFloorSaveCommand;

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.ShopFloorSave shopFloorSaveResponse = response.ShopFloorSave.First();
      if (!shopFloorSaveResponse.Successful)
          MessageBox.Show(shopFloorSaveResponse.ErrorMessage);
      else
      {
          // The command was successful.
          MessageBox.Show("Shop floor data saved successfully.");
      }
  }
  ```

**End of Section: Shop Floor**
