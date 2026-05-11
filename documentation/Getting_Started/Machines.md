---
title: Machines
url: https://developer.tekla.com/documentation/machines
slug: machines
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Machines
updated: 13 Feb 2025
---

# Machines

This section details the API calls available for retrieving information about machines and machine groups within Tekla PowerFab.

### **API Calls**

- `Machine_Get`

  This API call retrieves information about machines defined in Tekla PowerFab. You can filter the results by various criteria, such as machine type, department, or status.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <Machine_Get>
      <Filter>
        <DepartmentID>1</DepartmentID> 
        <MachineTypeID>2</MachineTypeID> 
      </Filter>
    </Machine_Get>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <Machine_Get>
      <Successful>true</Successful>
      <Machine>
        <MachineID>1</MachineID>
        <MachineName>CNC Plasma Cutter - 1</MachineName>
        <DepartmentID>1</DepartmentID>
        <MachineTypeID>2</MachineTypeID>
      </Machine>
      <Machine>
        <MachineID>2</MachineID>
        <MachineName>Drill Line - A</MachineName>
        <DepartmentID>1</DepartmentID>
        <MachineTypeID>3</MachineTypeID> 
      </Machine>
    </Machine_Get>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the Machine_Get command with filter
  reqPowerFabAPI.fsreqMachine_Get getCommand = new reqPowerFabAPI.fsreqMachine_Get();
  getCommand.Filter = new reqPowerFabAPI.fsreqMachine_Get_Filter();
  getCommand.Filter.DepartmentID = 1;
  getCommand.Filter.MachineTypeID = 2; 

  // Add the command to the request
  request.Machine_Get = new List<reqPowerFabAPI.fsreqMachine_Get>();
  request.Machine_Get.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  if (response.Machine_Get.First().Successful)
  {
      List<resPowerFabAPI.Machine> machines = response.Machine_Get.First().Machine;
      //... process the retrieved machines
  }
  else
  {
      //... handle errors
  }
  ```
- `MachineGroup_Get`

  This API call retrieves information about machine groups defined in Tekla PowerFab. You can filter the results by specific criteria, if needed.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <MachineGroup_Get/> 
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <MachineGroup_Get>
      <Successful>true</Successful>
      <MachineGroup>
        <MachineGroupID>1</MachineGroupID>
        <MachineGroupName>Cutting Machines</MachineGroupName>
      </MachineGroup>
      <MachineGroup>
        <MachineGroupID>2</MachineGroupID>
        <MachineGroupName>Drilling Machines</MachineGroupName>
      </MachineGroup>
    </MachineGroup_Get>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the MachineGroup_Get command
  reqPowerFabAPI.fsreqMachineGroup_Get getCommand = new reqPowerFabAPI.fsreqMachineGroup_Get();

  // Add the command to the request
  request.MachineGroup_Get = new List<reqPowerFabAPI.fsreqMachineGroup_Get>();
  request.MachineGroup_Get.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  if (response.MachineGroup_Get.First().Successful)
  {
      List<resPowerFabAPI.MachineGroup> machineGroups = response.MachineGroup_Get.First().MachineGroup;
      //... process the retrieved machine groups
  }
  else
  {
      //... handle errors
  }
  ```

**End of Section: Machines**
