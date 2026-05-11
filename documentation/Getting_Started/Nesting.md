---
title: Nesting
url: https://developer.tekla.com/documentation/nesting
slug: nesting
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Nesting
updated: 13 Feb 2025
---

# Nesting

This section details the API call available for saving nesting data within Tekla PowerFab.

### **API Calls**

- `SaveNest`

  This API call allows you to save nesting results to Tekla PowerFab. You'll typically provide details about the nest, such as the associated parts, material, and any relevant settings.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <SaveNest>
      <APILog>all</APILog>
      <SourceApplication>Your Nesting Software</SourceApplication> 
      <SourceApplicationVersion>1.0.0</SourceApplicationVersion> 
      <CombinationRunID>1</CombinationRunID> 
      <NestResult>
        <NestID>nest-id-123</NestID> 
        <NestImageFilename>nest-image.png</NestImageFilename> 
        <NestImageBase64>base64-encoded-image-data</NestImageBase64> 
        <OutputFilename>C:\Nesting\Output\nest-output.nc</OutputFilename> 
        <Quantity>1</Quantity>
        <MaterialUsed>
          <ExternalInventoryLinkID>999</ExternalInventoryLinkID> 
          <Shape>PL</Shape> 
          <Dimensions Metric="false">1X48</Dimensions> 
          <Grade>A36</Grade> 
          <Width UOM="IN">48</Width>
          <Length UOM="IN">120</Length>
        </MaterialUsed>
        <Remnant>
          <Type>Remnant</Type>
          <RemnantID>remnant-id-456</RemnantID> 
          <Shape>PL</Shape>
          <Dimensions Metric="false">1 x 48</Dimensions>
          <Grade>A36</Grade>
          <Length UOM="IN">60</Length> 
          <Width UOM="IN">48</Width>
          <Area UOM="SQIN">2880</Area> 
          <Weight UOM="LB">1224</Weight> 
          <Quantity>1</Quantity>
          <RemnantImageFilename>remnant-image.png</RemnantImageFilename> 
          <RemnantImageBase64>base64-encoded-remnant-image-data</RemnantImageBase64> 
        </Remnant>
        <NestedParts>
          <NestPart>
            <JobNumber>JOB-001</JobNumber> 
            <MainMark>M1</MainMark> 
            <PieceMark>P1</PieceMark> 
            <Sequence>1</Sequence>
            <Quantity>1</Quantity>
            <Length UOM="IN">24</Length>
            <Width UOM="IN">24</Width>
          </NestPart>
          <NestPart>
            <JobNumber>JOB-001</JobNumber> 
            <MainMark>M2</MainMark> 
            <PieceMark>P2</PieceMark> 
            <Sequence>2</Sequence> 
            <Quantity>1</Quantity>
            <Length UOM="IN">24</Length>
            <Width UOM="IN">24</Width>
          </NestPart>
        </NestedParts>
      </NestResult>
    </SaveNest>
  </FabSuiteXMLRequest>
  ```

  **Response (XML)**

  ```
  <FabSuiteXMLResponse>
    <SaveNest>
      <Successful>1</Successful> 
      <SourceApplication>Your Nesting Software</SourceApplication> 
      <SourceApplicationVersion>1.0.0</SourceApplicationVersion> 
      <CreationDateTime>2025-02-06T14:50:00</CreationDateTime> 
      <CombinationRunID>1</CombinationRunID> 
      <TotalSuccessful>1</TotalSuccessful> 
      <TotalUnSuccessful>0</TotalUnSuccessful> 
      <SavedNest>
        <NestID>nest-id-123</NestID> 
        <SavedTo>Inventory</SavedTo> 
        <InventoryItem>
          <Type>INV</Type> 
          <ID>1001</ID> 
          <Quantity>1</Quantity>
          <Shape>PL</Shape>
          <Dimensions Metric="0">1 x 48</Dimensions>
          <Grade>A36</Grade>
          <Thickness UOM="in">1</Thickness> 
          <Width UOM="in">48</Width>
          <Length UOM="in">120</Length>
          <Weight UOM="kg">555.65</Weight> 
          <CurrentPrice Currency="USD" Units="/CWT">0</CurrentPrice> 
          <Valuation Currency="USD">0</Valuation>
          <OriginalDate>2025-02-06</OriginalDate> 
          <OriginalPrice Currency="USD" Units="/CWT">0</OriginalPrice> 
          <Job>JOB-001</Job> 
          <OnOrder/>
          <Kerf UOM="mm">0</Kerf>
          <KerfRipCut UOM="mm">0</KerfRipCut>
          <KerfCrossCut UOM="mm">0</KerfCrossCut>
          <PercentCombined>0.5</PercentCombined> 
          <ExternalInventoryLinkID>1011</ExternalInventoryLinkID> 
          <NestID>nest-id-123</NestID> 
        </InventoryItem>
      </SavedNest>
      <SavedRemnant>
        <NestID>nest-id-123</NestID> 
        <ExternalRemnantID>remnant-id-456</ExternalRemnantID> 
        <FabSuiteRemnantID>500</FabSuiteRemnantID> 
        <Quantity>1</Quantity>
        <Type>Remnant</Type>
        <Shape>PL</Shape>
        <Dimensions Metric="0">1 x 48</Dimensions>
        <Grade>A36</Grade>
        <Length UOM="IN">60</Length>
        <Width UOM="IN">48</Width>
        <Area UOM="SQIN">2880</Area>
        <Weight UOM="LB">1224</Weight>
      </SavedRemnant>
    </SaveNest>
  </FabSuiteXMLResponse>
  ```

  **Code Example (C#)**

  ```
  // Create the request object
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Create NestedParts
  //... code to create NestedParts objects

  // Create MaterialUsed
  //... code to create MaterialUsed object

  // Create Remnant
  //... code to create Remnant object

  // Create NestResult
  reqPowerFabAPI.fsreqSaveNest_NestResult nestResult = new reqPowerFabAPI.fsreqSaveNest_NestResult();
  nestResult.NestID = "nest-id-123";
  nestResult.NestImageFilename = "nest-image.png";
  nestResult.NestImageBase64 = "base64-encoded-image-data";
  //... set other properties of nestResult

  // Create SaveNest
  reqPowerFabAPI.fsreqSaveNest saveNest = new reqPowerFabAPI.fsreqSaveNest();
  saveNest.APILog = "all";
  saveNest.SourceApplication = "Your Nesting Software";
  saveNest.SourceApplicationVersion = "1.0.0";
  //... set other properties of saveNest

  // Add the command to the request
  request.SaveNest = saveNest;

  // Execute the command and get the response
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Handle the response (check for errors, etc.)
  //...
  ```

**End of Section: Nesting**
