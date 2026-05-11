---
title: Inspections
url: https://developer.tekla.com/documentation/inspections
slug: inspections
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Inspections
updated: 13 Feb 2025
---

# Inspections

This section details the API calls available for managing inspection and test records within Tekla PowerFab.

### **API Calls**

- `DeleteInspectionTestRecord`

  This API call allows you to delete an existing inspection test record from Tekla PowerFab. You'll need to provide the unique identifier of the inspection test record you wish to delete.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <DeleteInspectionTestRecord>
      <InspectionTestRecordID>123</InspectionTestRecordID>
    </DeleteInspectionTestRecord>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the DeleteInspectionTestRecord command
  reqPowerFabAPI.fsreqDeleteInspectionTestRecord deleteCommand = new reqPowerFabAPI.fsreqDeleteInspectionTestRecord();
  deleteCommand.InspectionTestRecordID = 123; // Replace with the actual ID

  // Add the command to the request
  request.DeleteInspectionTestRecord = new List<reqPowerFabAPI.fsreqDeleteInspectionTestRecord>();
  request.DeleteInspectionTestRecord.Add(deleteCommand);

  // Execute the command and get the response
  resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```
- `GetInspectionTestRecords`

  Use this API call to retrieve a list of inspection test records. You can filter the results by specifying criteria such as date range, test type, or subject.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <GetInspectionTestRecords>
      <Filter>
        <StartDate>2024-01-01</StartDate>
        <EndDate>2024-12-31</EndDate>
        <TestTypeID>4</TestTypeID>
      </Filter>
    </GetInspectionTestRecords>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <GetInspectionTestRecords>
      <Successful>true</Successful>
      <InspectionTestRecord>
        <InspectionTestRecordID>1</InspectionTestRecordID>
        <TestDate>2024-06-15</TestDate>
        <TestTypeID>4</TestTypeID>
        <SubjectID>10</SubjectID>
        <Result>Pass</Result>
      </InspectionTestRecord>
      <InspectionTestRecord>
        <InspectionTestRecordID>2</InspectionTestRecordID>
        <TestDate>2024-08-22</TestDate>
        <TestTypeID>4</TestTypeID>
        <SubjectID>12</SubjectID>
        <Result>Fail</Result>
      </InspectionTestRecord>
    </GetInspectionTestRecords>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the GetInspectionTestRecords command with filter
  reqPowerFabAPI.fsreqGetInspectionTestRecords getCommand = new reqPowerFabAPI.fsreqGetInspectionTestRecords();
  getCommand.Filter = new reqPowerFabAPI.fsreqGetInspectionTestRecords_Filter();
  getCommand.Filter.StartDate = new DateTime(2024, 1, 1);
  getCommand.Filter.EndDate = new DateTime(2024, 12, 31);
  getCommand.Filter.TestTypeID = 4;

  // Add the command to the request
  request.GetInspectionTestRecords = new List<reqPowerFabAPI.fsreqGetInspectionTestRecords>();
  request.GetInspectionTestRecords.Add(getCommand);

  // Execute the command and get the response
  resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```
- `GetInspectionTestRecordSummary`

  This call retrieves a summary of an inspection test record, including key information like the test date, type, subject, and result.
- `GetInspectionTestRecordsCondensed`

  This API call fetches a condensed list of inspection test records, providing a compact overview of the inspection data.
- `GetInspectionTests`

  Retrieve a list of available inspection tests defined in Tekla PowerFab. This can be useful for populating dropdown lists or other UI elements in your application.
- `GetInspectionTestSubjects`

  Use this call to get a list of valid subjects for inspection tests. This can help ensure data consistency and prevent errors when creating or updating inspection records.
- `GetInspectionTestTypes`

  Retrieve a list of inspection test types available in Tekla PowerFab. This information can be used to categorize and filter inspection records.
- `SaveInspectionTestRecord`

  This API call allows you to create a new inspection test record or update an existing one. You'll need to provide the necessary details for the record, such as the test type, subject, result, and any relevant notes.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <SaveInspectionTestRecord>
      <InspectionTestRecord>
        <InspectionTestRecordID>0</InspectionTestRecordID> <TestDate>2024-09-05</TestDate>
        <TestTypeID>2</TestTypeID>
        <SubjectID>5</SubjectID>
        <Result>Pass</Result>
        <Notes>Inspection passed with no issues.</Notes>
      </InspectionTestRecord>
    </SaveInspectionTestRecord>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create the InspectionTestRecord object
  reqPowerFabAPI.fsreqInspectionTestRecord record = new reqPowerFabAPI.fsreqInspectionTestRecord();
  record.InspectionTestRecordID = 0; // 0 for new record
  record.TestDate = new DateTime(2024, 9, 5);
  record.TestTypeID = 2;
  record.SubjectID = 5;
  record.Result = "Pass";
  record.Notes = "Inspection passed with no issues.";

  // Create the SaveInspectionTestRecord command
  reqPowerFabAPI.fsreqSaveInspectionTestRecord saveCommand = new reqPowerFabAPI.fsreqSaveInspectionTestRecord();
  saveCommand.InspectionTestRecord = record;

  // Add the command to the request
  request.SaveInspectionTestRecord = saveCommand;

  // Execute the command and get the response
  resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```

Remember to replace placeholders like `your_connection_guid`, `123`, etc. with actual values from your Tekla PowerFab environment.
