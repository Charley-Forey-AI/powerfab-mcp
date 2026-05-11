---
title: Labor Rates
url: https://developer.tekla.com/documentation/labor-rates
slug: labor-rates
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Labor Rates
updated: 18 Feb 2025
---

# Labor Rates

This section details the API calls available for managing labor rates within Tekla PowerFab.

### **API Calls**

- `LaborRate_Get`

  This API call retrieves information about labor rates defined in Tekla PowerFab. You can filter the results by criteria such as department or effective date.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <LaborRate_Get>
      <Filter>
        <DepartmentID>1</DepartmentID>
      </Filter>
    </LaborRate_Get>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <LaborRate_Get>
      <Successful>true</Successful>
      <LaborRate>
        <LaborRateID>1</LaborRateID>
        <LaborRateName>Welding - Shop</LaborRateName>
        <DepartmentID>1</DepartmentID>
        <RatePerHour>45.50</RatePerHour>
        <EffectiveDate>2024-01-15</EffectiveDate>
      </LaborRate>
      <LaborRate>
        <LaborRateID>2</LaborRateID>
        <LaborRateName>Fitting - Shop</LaborRateName>
        <DepartmentID>1</DepartmentID>
        <RatePerHour>42.00</RatePerHour>
        <EffectiveDate>2024-02-01</EffectiveDate>
      </LaborRate>
    </LaborRate_Get>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the LaborRate_Get command with filter
  reqPowerFabAPI.fsreqLaborRate_Get getCommand = new reqPowerFabAPI.fsreqLaborRate_Get();
  getCommand.Filter = new reqPowerFabAPI.fsreqLaborRate_Get_Filter();
  getCommand.Filter.DepartmentID = 1;

  // Add the command to the request
  request.LaborRate_Get = new List<reqPowerFabAPI.fsreqLaborRate_Get>();
  request.LaborRate_Get.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request); // Note the updated response type

  // Handle the response (check for errors, etc.)
  if (response.LaborRate_Get.First().Successful) 
  {
      List<resPowerFabAPI.LaborRate> rates = response.LaborRate_Get.First().LaborRate;
      //... process the retrieved labor rates
  }
  else 
  {
      //... handle errors
  }
  ```
- `LaborRate_Upsert`

  This API call allows you to create new labor rates or update existing ones. You'll need to provide details like the labor rate name, department, rate per hour, and effective date.

  **Request (XML) - Create New**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <LaborRate_Upsert>
      <LaborRate>
        <LaborRateID>0</LaborRateID>
        <LaborRateName>Painting - Shop</LaborRateName>
        <DepartmentID>2</DepartmentID>
        <RatePerHour>38.75</RatePerHour>
        <EffectiveDate>2024-09-15</EffectiveDate>
      </LaborRate>
    </LaborRate_Upsert>
  </FabSuiteXMLRequest>
  ```

  **Request (XML) - Update Existing**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <LaborRate_Upsert>
      <LaborRate>
        <LaborRateID>3</LaborRateID> 
        <LaborRateName>Updated Rate Name</LaborRateName>
        <DepartmentID>2</DepartmentID>
        <RatePerHour>40.25</RatePerHour>
        <EffectiveDate>2024-10-01</EffectiveDate>
      </LaborRate>
    </LaborRate_Upsert>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the LaborRate object
  reqPowerFabAPI.fsreqLaborRate rate = new reqPowerFabAPI.fsreqLaborRate();
  rate.LaborRateID = 0; // 0 for new, otherwise existing ID
  rate.LaborRateName = "My New Rate";
  rate.DepartmentID = 3;
  rate.RatePerHour = 42.50m;
  rate.EffectiveDate = new DateTime(2024, 10, 1);

  // Create the LaborRate_Upsert command
  reqPowerFabAPI.fsreqLaborRate_Upsert upsertCommand = new reqPowerFabAPI.fsreqLaborRate_Upsert();
  upsertCommand.LaborRate = rate;

  // Add the command to the request
  request.LaborRate_Upsert = upsertCommand;

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request); // Note the updated response type

  // Handle the response (check for errors, etc.)
  //...
  ```

### **LaborRate\_Delete**

**Description:** Deletes one or more labor rates from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <LaborRate_Delete>
    <LaborRateID>123</LaborRateID>
    <LaborRateID>456</LaborRateID>
  </LaborRate_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <LaborRate_Delete>
    <Successful>true</Successful>
  </LaborRate_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `LaborRateID` element is required for each labor rate to be deleted.

**End of Section: Labor Rates**
