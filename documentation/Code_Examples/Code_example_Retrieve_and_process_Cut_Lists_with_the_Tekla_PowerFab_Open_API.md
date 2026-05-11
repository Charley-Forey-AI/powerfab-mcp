---
title: 'Code example: Retrieve and process Cut Lists with the Tekla PowerFab Open API'
url: https://developer.tekla.com/documentation/code-example-retrieve-and-process-cut-lists-tekla-powerfab-open-api
slug: code-example-retrieve-and-process-cut-lists-tekla-powerfab-open-api
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Retrieve and process Cut Lists with the Tekla PowerFab Open API'
updated: 8 Sep 2023
---

# Code example: Retrieve and process Cut Lists with the Tekla PowerFab Open API

This code example shows how to use Tekla PowerFab Open API to

- Connect and disconnect the Tekla PowerFab database
- Read the production control jobs
- Show each job in a list box
- Get the cut lists of the selected job
- Get the DSTV file for each part to be cut
- Verify that the nest is still valid in Tekla PowerFab
- Keep the inventory up to date by "cutting" the bar in Tekla PowerFab

## Get the list of production control jobs from Tekla PowerFab

1. First, request the list of production control jobs:

   ```
   <FabSuiteXMLRequest>
     <GetProductionControlJobs/>
   </FabSuiteXMLRequest>
   ```
2. Tekla PowerFab responds with a list of production control jobs. Below is a sample response to the **GetProductionControlJobs** request:

   ```
   <?xml version="1.0" encoding="UTF-8" standalone="yes" ?>

   <FabSuiteXMLResponse xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

     <GetProductionControlJobs>

       <Successful>1</Successful>

       <ProductionControlJob>

         <ProductionControlID>1397</ProductionControlID>

         <JobNumber>Demo Job</JobNumber>

         <JobDescription>Demo Job</JobDescription>

         <JobLocation/>

         <GroupName/>

         <GroupName2/>

       </ProductionControlJob>

       <ProductionControlJob>

         <ProductionControlID>1394</ProductionControlID>

         <JobNumber>Demo Job 2</JobNumber>

         <JobDescription>Demo Job 2</JobDescription>

         <JobLocation/>

         <GroupName/>

         <GroupName2/>

       </ProductionControlJob>

       <ProductionControlJob>

         <ProductionControlID>781</ProductionControlID>

         <JobNumber>Demo Job 3</JobNumber>

         <JobDescription>Demo Job 3</JobDescription>

         <JobLocation/>

         <GroupName>Old Orders</GroupName>

         <GroupName2/>

       </ProductionControlJob>

     </GetProductionControlJobs>

     <JobGroups>

         <GroupName> </GroupName>

         <GroupName>Old Orders </GroupName>

      </JobGroups>

   </FabSuiteXMLResponse>
   ```

Tip:  
Check the guide [Retrieve list of jobs from Tekla PowerFab](https://developer.tekla.com/tekla-epm/documentation/retrieve-list-jobs-tekla-epm) for more detailed explanation of GetProductionControlJobs command.

## Present the cut lists of the selected job

1. Show **JobNumber** and**JobDescription** fields. The **JobNumber** is unique.
2. Let the user select the job and retrieve cut lists for the selected job. Use the **productionControlID** for the job selected job. For example, if the user selected **ProductionControlID** 1394, the call would look like this:

   ```
   <FabSuiteXMLRequest>

   <GetProjectStatus>

   <ProductionControlID>1394</ProductionControlID>

   <IncludeCutLists>1</IncludeCutLists>

   </GetProjectStatus>

   </FabSuiteXMLRequest>
   ```
3. As a response, you'll receive a list of cut lists available for cutting in this job. Present this to the user as a list of available cut lists for cutting. Use the **CutListName** field to show the user. For instance, if the job has three cut lists and they are called "W10x12", "W12x22", and "W14x30", the response would be like this:

   ```
   <?xml version="1.0" encoding="UTF-8" standalone="yes" ?>

   <FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0105.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

     <GetProjectStatus>

       <Successful>1</Successful>

       <ProductionControlID>1394</ProductionControlID>

       <JobNumber>Demo Job 2</JobNumber>

       <JobDescription>Demo Job 2</JobDescription>

       <JobLocation/>

       <GroupName/>

       <GroupName2/>

       <HasProjectSchedule>0</HasProjectSchedule>

       <InputDisplayUnits>

         <SizeUOM>Imperial</SizeUOM>

         <LengthUOM>Imperial</LengthUOM>

         <LengthTypeIDMetric>101</LengthTypeIDMetric>

         <LengthTypeIDImperial>1</LengthTypeIDImperial>

         <WeightUOM>Imperial</WeightUOM>

         <PriceUOM>Imperial</PriceUOM>

       </InputDisplayUnits>

       <Assemblies>

         <Quantity>106</Quantity>

       </Assemblies>

       <Drawings>

         <Total>118</Total>

         <TotalApproved>0</TotalApproved>

       </Drawings>

       <Sequences>

         <Total>4</Total>

       </Sequences>

       <Lots>

         <Total>2</Total>

       </Lots>

       <CutLists>

         <CutLists>3</CutLists>

         <CuttingDetails>4</CuttingDetails>

         <TotalCut>0</TotalCut>

         <TotalInvalidated>0</TotalInvalidated>

         <TotalValidationRequired>0</TotalValidationRequired>

         <TotalOnOrder>0</TotalOnOrder>

         <CutList>

           <CutListID>398</CutListID>

           <CutListName>W10x12</CutListName>

           <DateCreated>2023-02-29</DateCreated>

           <DateRequired>2023-02-30</DateRequired>

           <CuttingDetails>2</CuttingDetails>

           <TotalCut>0</TotalCut>

           <TotalInvalidated>0</TotalInvalidated>

           <TotalValidationRequired>0</TotalValidationRequired>

           <TotalOnOrder>0</TotalOnOrder>

         </CutList>

         <CutList>

           <CutListID>399</CutListID>

           <CutListName>W12x22</CutListName>

           <DateCreated>2023-02-29</DateCreated>

           <DateRequired>2023-02-30</DateRequired>

           <CuttingDetails>1</CuttingDetails>

           <TotalCut>0</TotalCut>

           <TotalInvalidated>0</TotalInvalidated>

           <TotalValidationRequired>0</TotalValidationRequired>

           <TotalOnOrder>0</TotalOnOrder>

         </CutList>

         <CutList>

           <CutListID>400</CutListID>

           <CutListName>W14x30</CutListName>

           <DateCreated>2023-02-29</DateCreated>

           <DateRequired>2023-02-30</DateRequired>

           <CuttingDetails>1</CuttingDetails>

           <TotalCut>0</TotalCut>

           <TotalInvalidated>0</TotalInvalidated>

           <TotalValidationRequired>0</TotalValidationRequired>

           <TotalOnOrder>0</TotalOnOrder>

         </CutList>

       </CutLists>

     </GetProjectStatus>

   </FabSuiteXMLResponse>
   ```

Tip:  
For more detailed explanation of the GetProjectStatus command and using it to get CutLists, see [Retrieve project status with cut lists](https://developer.tekla.com/tekla-epm/documentation/code-example-retrieve-project-status-cut-lists-tekla-epm) guide.

## Get information of a cut list from Tekla PowerFab

Note that as these are bars, they are listed in the order that Tekla PowerFab has placed them; they are optimized. On the response example below, the 18B3 is placed before 18B4:

1. After the user has selected a cut list to import, retrieve the actual cut list information from the Tekla PowerFab. Use the **CutListID** of the **CutList** that the user selected. Below is a **GetCutList** request for **CutListID** 400:

   ```
   <FabSuiteXMLRequest>

   <GetCutList>

    <CutListID>400</CutListID>

   </GetCutList>

   </FabSuiteXMLRequest> 
   ```
2. The response to the **GetCutList** is nested set of bars. It's equivalent in content to a group of dstv+ files.
   - Each **CutListItem** in the cut list is what one dstv+ file would represent
   - Each **CutListItem** is a bar
   - Each **CutListItemPart** within a **CutListItem** is one part to be cut
   - Note that as this is a bar, they are listed in the order that FabSuite has placed them; they are optimized.  On the bar example below, the 18B3 is placed before 18B4:

     ```
     <?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
     <FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0105.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
      
       <GetCutList>
         <Successful>1</Successful>
         <ProductionControlID>1394</ProductionControlID>
         <JobNumber>Demo Job 2</JobNumber>
         <CutListID>400</CutListID>
         <CutListName>W14x30</CutListName>
         <DateCreated>2023-02-29</DateCreated>
         <DateRequired>2023-02-30</DateRequired>
         <CuttingDetails>1</CuttingDetails>
         <TotalCut>0</TotalCut>
         <TotalInvalidated>0</TotalInvalidated>
         <TotalValidationRequired>0</TotalValidationRequired>
         <InputDisplayUnits>
           <SizeUOM>Imperial</SizeUOM>
           <LengthUOM>Imperial</LengthUOM>
           <LengthTypeIDMetric>101</LengthTypeIDMetric>
           <LengthTypeIDImperial>1</LengthTypeIDImperial>
           <WeightUOM>Imperial</WeightUOM>
           <PriceUOM>Imperial</PriceUOM>
         </InputDisplayUnits>
         <CutListItem>
           <CutListItemID>9213</CutListItemID>
           <CutListSerialNumber>38404</CutListSerialNumber>
           <OnOrder>0</OnOrder>
           <Shape>W</Shape>
           <Grade>A992</Grade>
           <Dimensions>14 x 30</Dimensions>
           <Length UOM="in">540</Length>
           <Weight UOM="kg">612.349699500000980169758734421791</Weight>
           <Kerf UOM="in">0.1875</Kerf>
           <ExpectedDrop UOM="in">8.625</ExpectedDrop>
           <ExpectedPercentDrop>1.5972222222224</ExpectedPercentDrop>
           <CutListItemPart>
             <ProductionControlID>1394</ProductionControlID>
             <JobNumber>Demo Job 2</JobNumber>
             <DrawingNumber>18</DrawingNumber>
             <DrawingFile>
               <FileName>18.pdf</FileName>
               <FileExtension>.pdf</FileExtension>
               <ContentType>application/pdf</ContentType>
             </DrawingFile>
             <MainMark>18B3</MainMark>
             <PieceMark>w84</PieceMark>
             <Sequence>2</Sequence>
             <LotNumber>1</LotNumber>
             <Quantity>1</Quantity>
             <Length UOM="in">265.5</Length>
             <Category>BEAM</Category>
             <Remark></Remark>
             <CNCFileID>10882</CNCFileID>
             <CNCFormat>DSTV</CNCFormat>
           </CutListItemPart>
           <CutListItemPart>
             <ProductionControlID>1394</ProductionControlID>
             <JobNumber>Demo Job 2</JobNumber>
             <DrawingNumber>18</DrawingNumber>
             <DrawingFile>
               <FileName>18.pdf</FileName>
               <FileExtension>.pdf</FileExtension>
               <ContentType>application/pdf</ContentType>
             </DrawingFile>
             <MainMark>18B4</MainMark>
             <PieceMark>w83</PieceMark>
             <Sequence>2</Sequence>
             <LotNumber>1</LotNumber>
             <Quantity>1</Quantity>
             <Length UOM="in">265.5</Length>
             <Category>BEAM</Category>
             <Remark></Remark>
             <CNCFileID>10883</CNCFileID>
             <CNCFormat>DSTV</CNCFormat>
           </CutListItemPart>
         </CutListItem>
       </GetCutList>
      
     </FabSuiteXMLResponse>
     ```

## Get the DSTV file for each CutListItemPart

1. Retrieve the DSTV file for each CutListItemPart.  In this example, we use the following: part with **MainMark** 18B4, **PieceMark** w83, which is **CNCFileID** 10883.

   ```
   <FabSuiteXMLRequest>
   <CNCData>
   <CNCFileID>10883</CNCFileID>
   </CNCData>
   </FabSuiteXMLRequest>
   ```
2. The returned response contains the actual DSTV text in the <**CNCData**> tag.

   ```
   <CNCData>
       <Successful>1</Successful>
       <PieceMarkCNCData>
         <CNCFileID>10883</CNCFileID>
         <PieceMark>18B4</PieceMark>
         <Format>DSTV</Format>
         <CNCData>ST
     Demo Job 2
     18
     1
     18B4
     A992
     1
     W14X30
     I
     6743.70
     350.52
     170.94
     9.78
     6.86
     18.80
     44.645
     0.000
     0.000
     0.000
     0.000
     0.000
    
    
   BO
     v       44.45o     274.32    20.64    0.00
     v       44.45o     198.12    20.64    0.00
     v       44.45o     121.92    20.64    0.00
   BO
     v     4083.05o     172.72    20.64    0.00
     v     4083.05o      96.52    20.64    0.00
     v     4222.75o     172.72    20.64    0.00
     v     4222.75o      96.52    20.64    0.00
   BO
     v     5911.85o     210.82    20.64    0.00
     v     5911.85o     134.62    20.64    0.00
     v     6051.55o     210.82    20.64    0.00
     v     6051.55o     134.62    20.64    0.00
   BO
     u     5854.70s      41.02    20.64    0.00
     u     5854.70s     129.92    20.64    0.00
     u     6108.70s      41.02    20.64    0.00
     u     6108.70s     129.92    20.64    0.00
   BO
     o     5892.80s      41.02    20.64    0.00
     o     5892.80s     129.92    20.64    0.00
     o     6070.60s      41.02    20.64    0.00
     o     6070.60s     129.92    20.64    0.00
   AK
     o        0.00s       0.00     0.00
     o        0.00s     170.94     0.00
     o     6743.70s     170.94     0.00
     o     6743.70s       0.00     0.00
     o        0.00s       0.00     0.00
   AK
     v        0.00o       0.00     0.00
     v     6743.70o       0.00     0.00
     v     6743.70o     350.52     0.00
     v        0.00o     350.52     0.00
     v        0.00o       0.00     0.00
   AK
     u        0.00s       0.00     0.00
     u     6743.70s       0.00     0.00
     u     6743.70s     170.94     0.00
     u        0.00s     170.94     0.00
     u        0.00s       0.00     0.00
   EN
   </CNCData>
         <CNCFile>
           <FileName>18B4.nc1</FileName>
           <FileExtension>.nc1</FileExtension>
         </CNCFile>
       </PieceMarkCNCData>
     </CNCData>
    
   </FabSuiteXMLResponse>
   ```

## Verify that the nest is still valid in Tekla PowerFab

At this point, you have everything needed to present the Tekla PowerFab generated nest to the user.

When a user selects a nest to be cut, verify that the nest is still valid in Tekla PowerFab.

1. Call **ValCutListItem** for each **CutListItem** (which represents a single bar). For example:

   ```
   <FabSuiteXMLRequest>
   <ValCutListItem>
   <CutListItemID>9213</CutListItemID>
   </ValCutListItem>
   </FabSuiteXMLRequest>
   ```
2. The response would look like this:

   ```
   <?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
   <FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0105.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    
     <ValCutListItem>
       <Successful>1</Successful>
       <CutListItemID>9213</CutListItemID>
       <CutListSerialNumber>38404</CutListSerialNumber>
       <QuantityRemaining>1</QuantityRemaining>
       <Shape>W</Shape>
       <Grade>A992</Grade>
       <Dimensions Metric="0">14 x 30</Dimensions>
       <Length UOM="in">540</Length>
       <Weight UOM="kg">612.3496995</Weight>
       <Kerf UOM="in">0.1875</Kerf>
       <ExpectedDrop UOM="in">8.625</ExpectedDrop>
       <HasNotMatchFilter>0</HasNotMatchFilter>
       <ScrapAmount UOM="in">60</ScrapAmount>
       <DropJobReservePrompt CurrentJobReserve="Demo Job 2" Option="4000">Always unreserve</DropJobReservePrompt>
       <MaterialInStock>1</MaterialInStock>
       <PONumber>amytests</PONumber>
       <BillOfLadingNumber/>
       <CountryOfOrigin/>
       <HeatNumber/>
       <HeatSerialNumber/>
       <Location/>
       <SecondaryLocation/>
       <CutPart>
         <JobNumber>Demo Job 2</JobNumber>
         <MainMark>18B3</MainMark>
         <PieceMark>w84</PieceMark>
         <Sequence>2</Sequence>
         <LotNumber>1</LotNumber>
         <Quantity>1</Quantity>
         <Length UOM="in">265.5</Length>
         <Route>310</Route>
         <TrueShapeID/>
         <CNCFileID>10882</CNCFileID>
         <MatchFilter>1</MatchFilter>
       </CutPart>
       <CutPart>
         <JobNumber>Demo Job 2</JobNumber>
         <MainMark>18B4</MainMark>
         <PieceMark>w83</PieceMark>
         <Sequence>2</Sequence>
         <LotNumber>1</LotNumber>
         <Quantity>1</Quantity>
         <Length UOM="in">265.5</Length>
         <Route>310</Route>
         <TrueShapeID/>
         <CNCFileID>10883</CNCFileID>
         <MatchFilter>1</MatchFilter>
       </CutPart>
       <CutListItemAvailable>
         <Quantity>1</Quantity>
         <HeatNumber/>
         <HeatSerialNumber/>
         <PONumber>tests</PONumber>
         <BillOfLadingNumber/>
         <CountryOfOrigin/>
         <Location/>
         <SecondaryLocation/>
       </CutListItemAvailable>
       <Users>
         <User>
           <Username>Aai</Username>
           <LastName>Siharath</LastName>
           <FirstName>Aai</FirstName>
         </User>
         <User>
           <Username>admin</Username>
           <LastName>Administrator</LastName>
           <FirstName/>
         </User>
         <User>
           <Username>dev</Username>
           <LastName>Development</LastName>
           <FirstName>TPF</FirstName>
         </User>
       </Users>
     </ValCutListItem>
    
   </FabSuiteXMLResponse>
   ```

## Cut the bar in Tekla PowerFab

Finally, "cut" the bar in Tekla PowerFab using **TFSCut**. That will take the bar from the stock and keep inventory up to date.

1. Call **TFSCut**:

   ```
   <FabSuiteXMLRequest>
   <TFSCut>
   <CutListItemID>9213</CutListItemID>
   <Quantity>1</Quantity>
   <HeatNumber></HeatNumber>
   <PONumber>tests</PONumber>
   <Location></Location>
   <PieceTrackingUsername>admin</PieceTrackingUsername>
   <PieceTrackingHours>0.25</PieceTrackingHours>
   <DropLength UOM="in">72</DropLength>
   <DropLocation>A4</DropLocation>
   </TFSCut>
   </FabSuiteXMLRequest>
   ```

   ### Some tags do not have matching information in the CutListItem

   Note that the **HeatNumber**, **HeatSerialNumber**, **PONumber**, **BillOfLadingNumber**, **CountryOfOrigin**, **Location,** and **SecondaryLocation** do not have to match the information in the **CutListItem**.

   However, they must match the information of some piece in Tekla PowerFab inventory. This allows material that is actually cut to be swapped for identical material in the shop.  The information populated here should be for the actual piece of steel used, not the one that Tekla PowerFab thought would be used.  Tekla PowerFab will make the substitution.

   ### Some tags are required, even if they are blank

   **HeatNumber**, **PONumber** and **Location** are required, even if they're blank. **BillOfLadingNumber**, **CountryOfOrigin** and **SecondaryLocation** only need to be included if they're not blank. In the code example, **HeatNumber** and **Location** were blank.  They are sent blank in the format: **<HeatNumber/>**, but the system expects a blank **HeatNumber** back in the format: **<HeatNumber></HeatNumber>**.
2. A successful response to the **TFSCut** command looks like this:

   ```
   <?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
   <FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0105.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
     <TFSCut>
       <Successful>1</Successful>
       <RTSType>Restock</RTSType>
       <CutListItemID>9213</CutListItemID>
       <CutListItemDateTimeCompleted>2023-02-29 18:50:46</CutListItemDateTimeCompleted>
       <ActualHeatNumber/>
       <ActualHeatSerialNumber/>
       <ActualPONumber>tests</ActualPONumber>
       <ActualBillOfLadingNumber/>
       <ActualCountryOfOrigin/>
       <ActualDropLength UOM="in">72</ActualDropLength>
       <ActualDropLocation>A4</ActualDropLocation>
       <ActualDropSecondaryLocation/>
     </TFSCut>
   </FabSuiteXMLResponse>
   ```
