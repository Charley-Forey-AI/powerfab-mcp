---
title: Production Control
url: https://developer.tekla.com/documentation/production-control
slug: production-control
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Production Control
updated: 13 Feb 2025
---

# Production Control

This section details the API calls available for managing production control data within Tekla PowerFab.

### **API Calls**

- `GetProductionControlJobInformation`

  This API call retrieves the job information associated with a specific production control job. You'll need to provide the job ID.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <GetProductionControlJobInformation>
      <ProductionControlJobID>123</ProductionControlJobID> 
    </GetProductionControlJobInformation>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Get the job information for Production Control ID 123.
  reqPowerFabAPI.fsreqGetProductionControlJobInformation getJobInfoCommand = new reqPowerFabAPI.fsreqGetProductionControlJobInformation();
  getJobInfoCommand.ProductionControlJobID = 123;
  request.GetProductionControlJobInformation = new List<reqPowerFabAPI.fsreqGetProductionControlJobInformation>();
  request.GetProductionControlJobInformation.Add(getJobInfoCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.fsresGetProductionControlJobInformation jobInfoResponse = response.GetProductionControlJobInformation.First();
      if (!jobInfoResponse.Successful)
          MessageBox.Show(jobInfoResponse.ErrorMessage);
      else
      {
          // Get the job information from the response.
          resPowerFabAPI.fsresGetProductionControlJobInformation_JobInformation jobInfo = jobInfoResponse.JobInformation;
          MessageBox.Show(jobInfo.JobName);
      }
  }
  ```
- `GetProductionControlJobs`

  This API call retrieves a list of production control jobs based on specified filter criteria.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>8B169C11-E72F-44AB-A0E1-95E957E32685</ConnectionGUID>
    <GetProductionControlJobs>
      <IncludeCutLists>false</IncludeCutLists>
      <IncludeClosedJobs>false</IncludeClosedJobs>
    </GetProductionControlJobs>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Get the production control jobs.
  reqPowerFabAPI.fsreqGetProductionControlJobs getProdControlJobsCommand = new reqPowerFabAPI.fsreqGetProductionControlJobs();
  getProdControlJobsCommand.IncludeCutLists = false;
  getProdControlJobsCommand.IncludeClosedJobs = false;
  request.GetProductionControlJobs = new List<reqPowerFabAPI.fsreqGetProductionControlJobs>();
  request.GetProductionControlJobs.Add(getProdControlJobsCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.fsresGetProductionControlJobs prodControlJobsResponse = response.GetProductionControlJobs.First();
      if (!prodControlJobsResponse.Successful)
          MessageBox.Show(prodControlJobsResponse.ErrorMessage);
      else
      {
          // Get the production control jobs from the response.
          List<resPowerFabAPI.fsresProductionControlJob> prodControlJobs = prodControlJobsResponse.ProductionControlJob;
          string prodControlJobsString = "";
          foreach (resPowerFabAPI.fsresProductionControlJob prodControlJob in prodControlJobs)
          {
              prodControlJobsString += "Production Control ID:" + prodControlJob.ProductionControlJobID.ToString() + ", Job Number: " + prodControlJob.JobNumber + Environment.NewLine;
          }
          MessageBox.Show(prodControlJobsString);
      }
  }
  ```
- `ProductionControlCutList_Get`

  This API call retrieves the cut list associated with a specific production control job. You'll need to provide the job ID.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlCutList_Get>
      <ProductionControlJobID>123</ProductionControlJobID> 
    </ProductionControlCutList_Get>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <ProductionControlCutList_Get>
      <Successful>true</Successful>
      <CutList>
        <CutListID>456</CutListID> 
        <ProductionControlJobID>123</ProductionControlJobID>
        <CutListItem>
          <PartID>789</PartID>
          <//... other cut list item details>
        </CutListItem>
        <CutListItem>
          <PartID>101112</PartID>
          <//... other cut list item details>
        </CutListItem>
      </CutList>
    </ProductionControlCutList_Get>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the ProductionControlCutList_Get command
  reqPowerFabAPI.fsreqProductionControlCutList_Get getCommand = new reqPowerFabAPI.fsreqProductionControlCutList_Get();
  getCommand.ProductionControlJobID = 123; // Replace with the actual job ID

  // Add the command to the request
  request.ProductionControlCutList_Get = new List<reqPowerFabAPI.fsreqProductionControlCutList_Get>();
  request.ProductionControlCutList_Get.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  if (response.ProductionControlCutList_Get.First().Successful)
  {
      resPowerFabAPI.CutList cutList = response.ProductionControlCutList_Get.First().CutList;
      //... process the retrieved cut list
  }
  else
  {
      //... handle errors
  }
  ```
- `ProductionControlFinish_Get`

  Retrieves finish details for a given Production Control ID.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlFinish_Get>
      <ProductionControlID>123</ProductionControlID>
    </ProductionControlFinish_Get>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlFinish_Insert`

  Inserts a new finish record.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlFinish_Insert>
      <ProductionControlFinish>
        <ProductionControlID>123</ProductionControlID>
        <FinishID>456</FinishID>
        <//... other finish details>
      </ProductionControlFinish>
    </ProductionControlFinish_Insert>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlFinish_Update`

  Updates an existing finish record.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlFinish_Update>
      <ProductionControlFinish>
        <ProductionControlID>123</ProductionControlID>
        <FinishID>456</FinishID>
        <//... other finish details>
      </ProductionControlFinish>
    </ProductionControlFinish_Update>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlFinish_Delete`

  Deletes a finish record.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlFinish_Delete>
      <ProductionControlID>123</ProductionControlID>
    </ProductionControlFinish_Delete>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlLoad_Get`

  Retrieves loads based on specified filter criteria.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlLoad_Get>
      <GetOptions>
        <IncludeCutList>true</IncludeCutList>
        <IncludeJobInformation>true</IncludeJobInformation>
        <IncludeLoadInformation>true</IncludeLoadInformation>
        <IncludeLoadItems>true</IncludeLoadItems>
        <IncludeMaterials>true</IncludeMaterials>
        <IncludeShipToLocation>true</IncludeShipToLocation>
        <IncludeShippingMethod>true</IncludeShippingMethod>
      </GetOptions>
      <Filters>
        <FilterType>Load</FilterType>
        <LoadNumber>Load-001</LoadNumber>
      </Filters>
    </ProductionControlLoad_Get>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlLoad_Delete`
- `ProductionControlLoad_Insert`
- `ProductionControlLoad_Update`
- `ProductionControlLoad_Ship`

  Marks a load as shipped.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlLoad_Ship>
      <ProductionControlLoadID>123</ProductionControlLoadID>
      <ShippedToFirmID>456</ShippedToFirmID>
      <ShipDate>2025-03-15</ShipDate>
    </ProductionControlLoad_Ship>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlLoad_Unship`
- `ProductionControlLoad_IsDuplicateLoadNumber`
- `ProductionControlLoad_InputOptions_Get`
- `ProductionControlLoadAdditional_Insert`
- `ProductionControlLoadAdditional_Update`
- `ProductionControlLoadAdditional_Delete`
- `ProductionControlLoadRemaining_Get`
- `ProductionControlLoadMaterial_Add`
- `ProductionControlLoadMaterial_Remove`
- `ProductionControlLoadMaterial_Load`
- `ProductionControlLoadMaterial_Unload`

  Unloads material from a load.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <ProductionControlLoadMaterial_Unload>
      <UnloadItem>
        <ProductionControlLoadMaterialID>123</ProductionControlLoadMaterialID>
        <Quantity>5</Quantity>
      </UnloadItem>
    </ProductionControlLoadMaterial_Unload>
  </FabSuiteXMLRequest>
  ```
- `ProductionControlLoadMaterial_Return`
- `ProductionControlLoadMaterial_Unreturn`
- `ProductionScheduleSettings_Get`

### **ProductionControlLoad\_Unship**

**Description:** Marks a load as not shipped, reverting the `ProductionControlLoad_Ship` action.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoad_Unship>
    <ProductionControlLoadID>123</ProductionControlLoadID>
  </ProductionControlLoad_Unship>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to reverse the shipping status of a load.
- [To be added]

### **ProductionControlLoad\_IsDuplicateLoadNumber**

**Description:** Checks if the given load number is a duplicate.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoad_IsDuplicateLoadNumber>
    <LoadNumber>load-number-123</LoadNumber>
  </ProductionControlLoad_IsDuplicateLoadNumber>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to validate load numbers for uniqueness.

### **ProductionControlLoad\_InputOptions\_Get**

**Description:** Retrieves the input options for production control loads.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoad_InputOptions_Get/>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the available options for creating or updating production control loads.

### **ProductionControlLoadAdditional\_Insert**

**Description:** Inserts additional information for a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadAdditional_Insert>
    <ProductionControlLoadAdditional>
      <ProductionControlLoadID>123</ProductionControlLoadID>
      <AdditionalInformation>additional-info-456</AdditionalInformation>
    </ProductionControlLoadAdditional>
  </ProductionControlLoadAdditional_Insert>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add extra details to a production control load.

### **ProductionControlLoadAdditional\_Update**

**Description:** Updates the additional information for a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadAdditional_Update>
    <ProductionControlLoadAdditional>
      <ProductionControlLoadAdditionalID>456</ProductionControlLoadAdditionalID>
      <AdditionalInformation>updated-additional-info-789</AdditionalInformation>
    </ProductionControlLoadAdditional>
  </ProductionControlLoadAdditional_Update>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to modify the additional details associated with a production control load.

### **ProductionControlLoadAdditional\_Delete**

**Description:** Deletes the additional information for a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadAdditional_Delete>
    <ProductionControlLoadAdditionalID>456</ProductionControlLoadAdditionalID>
  </ProductionControlLoadAdditional_Delete>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove the extra details from a production control load.

### **ProductionControlLoadRemaining\_Get**

**Description:** Retrieves the remaining items for a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadRemaining_Get>
    <ProductionControlLoadID>123</ProductionControlLoadID>
  </ProductionControlLoadRemaining_Get>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the list of items that have not yet been loaded for a specific production control load.

### **ProductionControlLoadMaterial\_Add**

**Description:** Adds material to a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_Add>
    <AddItem>
      <ProductionControlLoadID>123</ProductionControlLoadID>
      <MaterialID>456</MaterialID>
      <Quantity>10</Quantity>
    </AddItem>
  </ProductionControlLoadMaterial_Add>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add materials to a production control load, indicating which materials are planned to be included in the load.

### **ProductionControlLoadMaterial\_Remove**

**Description:** Removes material from a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_Remove>
    <RemoveItem>
      <ProductionControlLoadMaterialID>789</ProductionControlLoadMaterialID>
    </RemoveItem>
  </ProductionControlLoadMaterial_Remove>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove materials from a production control load, indicating that the material is no longer planned to be included in the load.

### **ProductionControlLoadMaterial\_Load**

**Description:** Marks material as loaded onto a load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_Load>
    <LoadItem>
      <ProductionControlLoadMaterialID>789</ProductionControlLoadMaterialID>
      <Quantity>5</Quantity>
    </LoadItem>
  </ProductionControlLoadMaterial_Load>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to update the status of materials on a production control load, indicating that the material has been physically loaded onto the transport.

### **ProductionControlLoadMaterial\_ChangeLoadNumber**

**Description:** Changes the load number of a material.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_ChangeLoadNumber>
    <ProductionControlLoadMaterialID>789</ProductionControlLoadMaterialID>
    <NewLoadNumber>new-load-number-456</NewLoadNumber>
  </ProductionControlLoadMaterial_ChangeLoadNumber>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to update the load number associated with a specific material on a production control load.

### **ProductionControlLoadMaterial\_ChangeMaterial**

**Description:** Changes the material associated with a load item.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_ChangeMaterial>
    <ProductionControlLoadMaterialID>789</ProductionControlLoadMaterialID>
    <NewMaterialID>new-material-id-123</NewMaterialID>
  </ProductionControlLoadMaterial_ChangeMaterial>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to update the material associated with a specific item on a production control load.

### **ProductionControlLoadMaterial\_Get**

**Description:** Retrieves the materials associated with a production control load.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ProductionControlLoadMaterial_Get>
    <ProductionControlLoadID>123</ProductionControlLoadID>
  </ProductionControlLoadMaterial_Get>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the details of the materials that are part of a specific production control load.

**End of Section: Production Control**
