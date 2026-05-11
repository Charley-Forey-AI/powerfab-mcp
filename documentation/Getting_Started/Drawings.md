---
title: Drawings
url: https://developer.tekla.com/documentation/drawings
slug: drawings
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Drawings
updated: 13 Feb 2025
---

# Drawings

### **Drawing\_Get**

**Description:** Retrieves drawings from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Drawing_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Drawing_Get>
    <Successful>true</Successful>
    <Drawing>
      <DrawingID>123</DrawingID>
      <DrawingName>Drawing 1</DrawingName>
    </Drawing>
    <Drawing>
      <DrawingID>456</DrawingID>
      <DrawingName>Drawing 2</DrawingName>
    </Drawing>
  </Drawing_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

reqPowerFabAPI.fsreqDrawing_Get getDrawingsCommand = new reqPowerFabAPI.fsreqDrawing_Get();

request.Drawing_Get = new List<reqPowerFabAPI.fsreqDrawing_Get>();
request.Drawing_Get.Add(getDrawingsCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the Drawing_Get response object and check if it was successful
    resPowerFabAPI.fsresDrawing_Get getDrawingsResponse = response.Drawing_Get.First();
    if (!getDrawingsResponse.Successful)
        MessageBox.Show(getDrawingsResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the drawings
        List<resPowerFabAPI.fsresDrawing> drawings = getDrawingsResponse.Drawing;
        string drawingsString = "";
        foreach (resPowerFabAPI.fsresDrawing drawing in drawings)
        {
            drawingsString += "Drawing ID:" + drawing.DrawingID.ToString() + ", Drawing Name: " + drawing.DrawingName + Environment.NewLine;
        }
        MessageBox.Show(drawingsString);
    }
}
```

**Notes:**

- You can use filters to limit the drawings returned.

### **Drawing\_Insert**

**Description:** Inserts a new drawing into Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Drawing_Insert>
    <Drawing>
      <DrawingName>Drawing 1</DrawingName>
      <DrawingTypeID>1</DrawingTypeID>
      <DrawingCategoryID>1</DrawingCategoryID>
      <DrawingNumber>1</DrawingNumber>
      <DrawingRevision>A</DrawingRevision>
      <DrawingTitle>Drawing Title 1</DrawingTitle>
      <DrawingDescription>Drawing Description 1</DrawingDescription>
      <DrawingFileName>drawing1.pdf</DrawingFileName>
      <DrawingFileContents>base64-encoded file contents</DrawingFileContents>
    </Drawing>
  </Drawing_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Drawing_Insert>
    <Successful>true</Successful>
    <Drawing>
      <DrawingID>123</DrawingID>
      <DrawingName>Drawing 1</DrawingName>
    </Drawing>
  </Drawing_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingName`, `DrawingTypeID`, `DrawingCategoryID`, `DrawingNumber`, `DrawingRevision`, `DrawingTitle`, `DrawingDescription`, `DrawingFileName`, and `DrawingFileContents` elements are required.

### **Drawing\_Update**

**Description:** Updates an existing drawing in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Drawing_Update>
    <Drawing>
      <DrawingID>123</DrawingID>
      <DrawingName>Drawing 1</DrawingName>
      <DrawingTypeID>1</DrawingTypeID>
      <DrawingCategoryID>1</DrawingCategoryID>
      <DrawingNumber>1</DrawingNumber>
      <DrawingRevision>A</DrawingRevision>
      <DrawingTitle>Drawing Title 1</DrawingTitle>
      <DrawingDescription>Drawing Description 1</DrawingDescription>
      <DrawingFileName>drawing1.pdf</DrawingFileName>
      <DrawingFileContents>base64-encoded file contents</DrawingFileContents>
    </Drawing>
  </Drawing_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Drawing_Update>
    <Successful>true</Successful>
    <Drawing>
      <DrawingID>123</DrawingID>
      <DrawingName>Drawing 1</DrawingName>
    </Drawing>
  </Drawing_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingID`, `DrawingName`, `DrawingTypeID`, `DrawingCategoryID`, `DrawingNumber`, `DrawingRevision`, `DrawingTitle`, `DrawingDescription`, `DrawingFileName`, and `DrawingFileContents` elements are required.

### **Drawing\_Delete**

**Description:** Deletes one or more drawings from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Drawing_Delete>
    <DrawingID>123</DrawingID>
    <DrawingID>456</DrawingID>
  </Drawing_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Drawing_Delete>
    <Successful>true</Successful>
  </Drawing_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DrawingID` element is required.

### **DrawingCategory\_Get**

**Description:** Retrieves drawing categories from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingCategory_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingCategory_Get>
    <Successful>true</Successful>
    <DrawingCategory>
      <DrawingCategoryID>123</DrawingCategoryID>
      <DrawingCategoryName>Drawing Category 1</DrawingCategoryName>
    </DrawingCategory>
    <DrawingCategory>
      <DrawingCategoryID>456</DrawingCategoryID>
      <DrawingCategoryName>Drawing Category 2</DrawingCategoryName>
    </DrawingCategory>
  </DrawingCategory_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

reqPowerFabAPI.fsreqDrawingCategory_Get getDrawingCategoriesCommand = new reqPowerFabAPI.fsreqDrawingCategory_Get();

request.DrawingCategory_Get = new List<reqPowerFabAPI.fsreqDrawingCategory_Get>();
request.DrawingCategory_Get.Add(getDrawingCategoriesCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the DrawingCategory_Get response object and check if it was successful
    resPowerFabAPI.fsresDrawingCategory_Get getDrawingCategoriesResponse = response.DrawingCategory_Get.First();
    if (!getDrawingCategoriesResponse.Successful)
        MessageBox.Show(getDrawingCategoriesResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the drawing categories
        List<resPowerFabAPI.fsresDrawingCategory> drawingCategories = getDrawingCategoriesResponse.DrawingCategory;
        string drawingCategoriesString = "";
        foreach (resPowerFabAPI.fsresDrawingCategory drawingCategory in drawingCategories)
        {
            drawingCategoriesString += "Drawing Category ID:" + drawingCategory.DrawingCategoryID.ToString() + ", Drawing Category Name: " + drawingCategory.DrawingCategoryName + Environment.NewLine;
        }
        MessageBox.Show(drawingCategoriesString);
    }
}
```

**Notes:**

- You can use filters to limit the drawing categories returned.

### **DrawingCategory\_Insert**

**Description:** Inserts a new drawing category into Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingCategory_Insert>
    <DrawingCategory>
      <DrawingCategoryName>Drawing Category 1</DrawingCategoryName>
    </DrawingCategory>
  </DrawingCategory_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingCategory_Insert>
    <Successful>true</Successful>
    <DrawingCategory>
      <DrawingCategoryID>123</DrawingCategoryID>
      <DrawingCategoryName>Drawing Category 1</DrawingCategoryName>
    </DrawingCategory>
  </DrawingCategory_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingCategoryName` element is required.

### **DrawingCategory\_Update**

**Description:** Updates an existing drawing category in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingCategory_Update>
    <DrawingCategory>
      <DrawingCategoryID>123</DrawingCategoryID>
      <DrawingCategoryName>Drawing Category 1</DrawingCategoryName>
    </DrawingCategory>
  </DrawingCategory_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingCategory_Update>
    <Successful>true</Successful>
    <DrawingCategory>
      <DrawingCategoryID>123</DrawingCategoryID>
      <DrawingCategoryName>Drawing Category 1</DrawingCategoryName>
    </DrawingCategory>
  </DrawingCategory_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingCategoryID` and `DrawingCategoryName` elements are required.

### **DrawingCategory\_Delete**

**Description:** Deletes one or more drawing categories from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingCategory_Delete>
    <DrawingCategoryID>123</DrawingCategoryID>
    <DrawingCategoryID>456</DrawingCategoryID>
  </DrawingCategory_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingCategory_Delete>
    <Successful>true</Successful>
  </DrawingCategory_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DrawingCategoryID` element is required.

### **DrawingType\_Get**

**Description:** Retrieves drawing types from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingType_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingType_Get>
    <Successful>true</Successful>
    <DrawingType>
      <DrawingTypeID>123</DrawingTypeID>
      <DrawingTypeName>Drawing Type 1</DrawingTypeName>
    </DrawingType>
    <DrawingType>
      <DrawingTypeID>456</DrawingTypeID>
      <DrawingTypeName>Drawing Type 2</DrawingTypeName>
    </DrawingType>
  </DrawingType_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

reqPowerFabAPI.fsreqDrawingType_Get getDrawingTypesCommand = new reqPowerFabAPI.fsreqDrawingType_Get();

request.DrawingType_Get = new List<reqPowerFabAPI.fsreqDrawingType_Get>();
request.DrawingType_Get.Add(getDrawingTypesCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the DrawingType_Get response object and check if it was successful
    resPowerFabAPI.fsresDrawingType_Get getDrawingTypesResponse = response.DrawingType_Get.First();
    if (!getDrawingTypesResponse.Successful)
        MessageBox.Show(getDrawingTypesResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the drawing types
        List<resPowerFabAPI.fsresDrawingType> drawingTypes = getDrawingTypesResponse.DrawingType;
        string drawingTypesString = "";
        foreach (resPowerFabAPI.fsresDrawingType drawingType in drawingTypes)
        {
            drawingTypesString += "Drawing Type ID:" + drawingType.DrawingTypeID.ToString() + ", Drawing Type Name: " + drawingType.DrawingTypeName + Environment.NewLine;
        }
        MessageBox.Show(drawingTypesString);
    }
}
```

**Notes:**

- You can use filters to limit the drawing types returned.

### **DrawingType\_Insert**

**Description:** Inserts a new drawing type into Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingType_Insert>
    <DrawingType>
      <DrawingTypeName>Drawing Type 1</DrawingTypeName>
    </DrawingType>
  </DrawingType_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingType_Insert>
    <Successful>true</Successful>
    <DrawingType>
      <DrawingTypeID>123</DrawingTypeID>
      <DrawingTypeName>Drawing Type 1</DrawingTypeName>
    </DrawingType>
  </DrawingType_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingTypeName` element is required.

### **DrawingType\_Update**

**Description:** Updates an existing drawing type in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingType_Update>
    <DrawingType>
      <DrawingTypeID>123</DrawingTypeID>
      <DrawingTypeName>Drawing Type 1</DrawingTypeName>
    </DrawingType>
  </DrawingType_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingType_Update>
    <Successful>true</Successful>
    <DrawingType>
      <DrawingTypeID>123</DrawingTypeID>
      <DrawingTypeName>Drawing Type 1</DrawingTypeName>
    </DrawingType>
  </DrawingType_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingTypeID` and `DrawingTypeName` elements are required.

### **DrawingType\_Delete**

**Description:** Deletes one or more drawing types from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingType_Delete>
    <DrawingTypeID>123</DrawingTypeID>
    <DrawingTypeID>456</DrawingTypeID>
  </DrawingType_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingType_Delete>
    <Successful>true</Successful>
  </DrawingType_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DrawingTypeID` element is required.

### **DrawingInputOptions\_Get**

**Description:** Retrieves drawing input options from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingInputOptions_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingInputOptions_Get>
    <Successful>true</Successful>
    <DrawingInputOptions>
      <DrawingInputOption>
        <DrawingInputOptionID>123</DrawingInputOptionID>
        <DrawingInputOptionName>Drawing Input Option 1</DrawingInputOptionName>
      </DrawingInputOption>
      <DrawingInputOption>
        <DrawingInputOptionID>456</DrawingInputOptionID>
        <DrawingInputOptionName>Drawing Input Option 2</DrawingInputOptionName>
      </DrawingInputOption>
    </DrawingInputOptions>
  </DrawingInputOptions_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the drawing input options returned.

### **DrawingFile\_Get**

**Description:** Retrieves drawing files from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingFile_Get>
    <DrawingID>123</DrawingID>
  </DrawingFile_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingFile_Get>
    <Successful>true</Successful>
    <DrawingFile>
      <DrawingFileID>123</DrawingFileID>
      <DrawingFileName>Drawing File 1</DrawingFileName>
    </DrawingFile>
    <DrawingFile>
      <DrawingFileID>456</DrawingFileID>
      <DrawingFileName>Drawing File 2</DrawingFileName>
    </DrawingFile>
  </DrawingFile_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingID` element is required.

### **DrawingRevision\_Get**

**Description:** Retrieves drawing revisions from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingRevision_Get>
    <DrawingID>123</DrawingID>
  </DrawingRevision_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingRevision_Get>
    <Successful>true</Successful>
    <DrawingRevision>
      <DrawingRevisionID>123</DrawingRevisionID>
      <DrawingRevisionName>Drawing Revision 1</DrawingRevisionName>
    </DrawingRevision>
    <DrawingRevision>
      <DrawingRevisionID>456</DrawingRevisionID>
      <DrawingRevisionName>Drawing Revision 2</DrawingRevisionName>
    </DrawingRevision>
  </DrawingRevision_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingID` element is required.

### **DrawingRevision\_Insert**

**Description:** Inserts a new drawing revision into Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingRevision_Insert>
    <DrawingRevision>
      <DrawingID>123</DrawingID>
      <DrawingRevisionName>Drawing Revision 1</DrawingRevisionName>
    </DrawingRevision>
  </DrawingRevision_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingRevision_Insert>
    <Successful>true</Successful>
    <DrawingRevision>
      <DrawingRevisionID>123</DrawingRevisionID>
      <DrawingRevisionName>Drawing Revision 1</DrawingRevisionName>
    </DrawingRevision>
  </DrawingRevision_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingID` and `DrawingRevisionName` elements are required.

### **DrawingRevision\_Update**

**Description:** Updates an existing drawing revision in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingRevision_Update>
    <DrawingRevision>
      <DrawingRevisionID>123</DrawingRevisionID>
      <DrawingID>123</DrawingID>
      <DrawingRevisionName>Drawing Revision 1</DrawingRevisionName>
    </DrawingRevision>
  </DrawingRevision_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingRevision_Update>
    <Successful>true</Successful>
    <DrawingRevision>
      <DrawingRevisionID>123</DrawingRevisionID>
      <DrawingRevisionName>Drawing Revision 1</DrawingRevisionName>
    </DrawingRevision>
  </DrawingRevision_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `DrawingRevisionID`, `DrawingID`, and `DrawingRevisionName` elements are required.

### **DrawingRevision\_Delete**

**Description:** Deletes one or more drawing revisions from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <DrawingRevision_Delete>
    <DrawingRevisionID>123</DrawingRevisionID>
    <DrawingRevisionID>456</DrawingRevisionID>
  </DrawingRevision_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <DrawingRevision_Delete>
    <Successful>true</Successful>
  </DrawingRevision_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `DrawingRevisionID` element is required.

**End of Section: Drawings**
