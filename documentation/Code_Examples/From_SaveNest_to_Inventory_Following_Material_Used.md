---
title: 'From SaveNest to Inventory: Following Material Used'
url: https://developer.tekla.com/documentation/material-used-savenest-inventory
slug: material-used-savenest-inventory
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'From SaveNest to Inventory: Following Material Used'
updated: 5 Dec 2025
---

# From SaveNest to Inventory: Following Material Used

When an external software sends a nest to PowerFab using SaveNest, PowerFab may send material to a requisition rather than reserving inventory.  This article shows how to find the stock used once it has been ordered and/or received from that requisition.

Suppose we send a SaveNest like this one into PowerFab:

```
<FabSuiteXMLRequest xmlns="http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <SaveNest>
    <APILog>all</APILog>
    <SourceApplication>Demo</SourceApplication>
    <SourceApplicationVersion>2025</SourceApplicationVersion>
    <CreationDateTime>12/2/2025 8:25:42 AM</CreationDateTime>

    <NestResult>
      <NestID>0791e8fd-ebee-42cc-a3e3-b3ba66f48acd</NestID>
      <Quantity>1</Quantity>
      <MaterialUsed>

        <Shape>PL</Shape>
        <Dimensions Metric="false">3/8x48</Dimensions>
        <Grade>A36</Grade>
        <Width UOM="IN">48</Width>
        <Length UOM="IN">96</Length>
      </MaterialUsed>
      <NestedParts>
        <NestPart>
          <JobNumber>EPM-001</JobNumber>
          <PieceMark>p55</PieceMark>
          <Sequence>1</Sequence>

          <Quantity>1</Quantity>
          <Length UOM="IN">15</Length>
          <Width UOM="IN">13.375</Width>
        </NestPart>
 
      </NestedParts>
    </NestResult>
  </SaveNest>

</FabSuiteXMLRequest>
```

We may get a response like this, that tells us the material we used was not available in PowerFab and has been added to a requisition.

```
<?xml version="1.0" encoding="UTF-8" standalone="no" ?>
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
 <Lang>en</Lang>
 <SaveNest>
   <Successful>1</Successful>
   <SourceApplication>Demo</SourceApplication>
   <SourceApplicationVersion>2025</SourceApplicationVersion>
   <CreationDateTime>12/2/2025 8:25:42 AM</CreationDateTime>
   <TotalSuccessful>1</TotalSuccessful>
   <TotalUnSuccessful>0</TotalUnSuccessful>
   <SavedNest>
     <NestID>0791e8fd-ebee-42cc-a3e3-b3ba66f48acd</NestID>
     <ExternalNestID>2</ExternalNestID>
     <SavedTo>Requisition</SavedTo>
     <RequisitionItem>
       <RequisitionItemID>707</RequisitionItemID>
       <RequisitionID>6</RequisitionID>
       <RequisitionNumber>2025-12-05 06:56:00</RequisitionNumber>
       <ItemID>10</ItemID>
       <Cost CurrencyID="1">122.504</Cost>
       <Weight>222.2675188</Weight>
       <SurfaceArea>6.015495902</SurfaceArea>
       <SquareMetersEach>2.972909172</SquareMetersEach>
       <Quantity>1</Quantity>
       <ShapeID>57</ShapeID>
       <GradeID>27</GradeID>
       <SizeID DimWidth="1219.202438">1986</SizeID>
       <Length>2438.404877</Length>
       <BasePrice CurrencyID="1" Format="100">0.5511556555</BasePrice>
       <JobNumber>EPM-001</JobNumber>
       <KerfRipCut>0</KerfRipCut>
       <KerfCrossCut>0</KerfCrossCut>
       <PercentCombined>1</PercentCombined>
       <ExternalNestID>2</ExternalNestID>
       <ExternalNestBroken>0</ExternalNestBroken>
       <ExpectedDrop>0</ExpectedDrop>
       <CombinationDetailID>462</CombinationDetailID>
     </RequisitionItem>
   </SavedNest>
 </SaveNest>
</FabSuiteXMLResponse>
```

Specifically, it was added to a requisition named "2025-12-05 06:56:00" (The RequisitionNumber field), and is Item 10 on that requisition.   We also know that it has a NestID that matches the one we sent in: "0791e8fd-ebee-42cc-a3e3-b3ba66f48acd".

Eventually this plate will be ordered and received.  We need to find the plate that actually ends up in inventory for this nest.   To do so, we run a GetInventory command looking for items of a matching size and grade to what we ordered:

```
<FabSuiteXMLRequest xmlns="http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
 <GetInventory>
    <IncludeInventory>true</IncludeInventory>
    <LinkSoftware>Demo</LinkSoftware>
    <Filters>
        <Filter>
            <FilterType>ShapeDimensions</FilterType>
            <FilterValue>PL 3/8x48</FilterValue>
        </Filter>    
        <Filter>
            <FilterType>Grade</FilterType>
            <FilterValue>A36</FilterValue>
        </Filter>
    </Filters>
 </GetInventory>
</FabSuiteXMLRequest>
```

Then we iterate through the results, looking for one with a "NestID" field that matches our nest.

```
<?xml version="1.0" encoding="UTF-8" standalone="no" ?>
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
 <Lang>en</Lang>
 <GetInventory>
   <Successful>1</Successful>
   <LastTransactionID>1</LastTransactionID>
   <Filters>
     <Filter>
       <FilterType>ShapeDimensions</FilterType>
       <FilterValue>PL 3/8x48</FilterValue>
     </Filter>
     <Filter>
       <FilterType>Grade</FilterType>
       <FilterValue>A36</FilterValue>
     </Filter>
   </Filters>
   <InventoryRecord>
     <Type>INV</Type>
     <ID>704</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">48</Length>
     <Weight UOM="kg">111.1338</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">61.25</Valuation>
     <OriginalDate>2012-12-20</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>Sample2</Job>
     <PONumber>0000000001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <DeliveryDate>2012-12-20</DeliveryDate>
     <OnOrder/>
     <POItemNumber>1970</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>0.5513</PercentCombined>
     <ExternalInventoryLinkID>136</ExternalInventoryLinkID>
   </InventoryRecord>
   <InventoryRecord>
     <Type>INV</Type>
     <ID>702</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">48</Length>
     <Weight UOM="kg">111.1338</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">61.25</Valuation>
     <OriginalDate>2012-12-20</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>Sample2</Job>
     <PONumber>0000000001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <DeliveryDate>2012-12-20</DeliveryDate>
     <OnOrder/>
     <POItemNumber>1950</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>0.8249</PercentCombined>
     <ExternalInventoryLinkID>136</ExternalInventoryLinkID>
   </InventoryRecord>
   <InventoryRecord>
     <Type>INV</Type>
     <ID>701</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">48</Length>
     <Weight UOM="kg">111.1338</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">61.25</Valuation>
     <OriginalDate>2012-12-20</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>Sample2</Job>
     <PONumber>0000000001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <DeliveryDate>2012-12-20</DeliveryDate>
     <OnOrder/>
     <POItemNumber>1940</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>0.8466</PercentCombined>
     <ExternalInventoryLinkID>136</ExternalInventoryLinkID>
   </InventoryRecord>
   <InventoryRecord>
     <Type>INV</Type>
     <ID>703</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">48</Length>
     <Weight UOM="kg">111.1338</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">61.25</Valuation>
     <OriginalDate>2012-12-20</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>Sample2</Job>
     <PONumber>0000000001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <DeliveryDate>2012-12-20</DeliveryDate>
     <OnOrder/>
     <POItemNumber>1960</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>0.9243</PercentCombined>
     <ExternalInventoryLinkID>136</ExternalInventoryLinkID>
   </InventoryRecord>
   <InventoryRecord>
     <Type>INV</Type>
     <ID>879</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">96</Length>
     <Weight UOM="kg">222.2675</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">122.5</Valuation>
     <OriginalDate>2025-12-05</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>EPM-001</Job>
     <PONumber>EPM-0001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <OnOrder>1</OnOrder>
     <POItemNumber>6960</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>1</PercentCombined>
     <ExternalInventoryLinkID>215</ExternalInventoryLinkID>
     <NestID>0791e8fd-ebee-42cc-a3e3-b3ba66f48acd</NestID>
   </InventoryRecord>
 </GetInventory>
</FabSuiteXMLResponse>
```

In this set of results, we can see that our desired record was returned at the end.  It has an ExternalInventoryLinkID=215, and a matching NestID.  We can also see that the "OnOrder" field of this item is set to 1 - or true.  This means that the item has not yet been received.  It cannot be processed through the shop yet because it hasn't yet arrived at the shop.

After it has been received, running the same "GetInventory" command gives the following as the final result:

```
 <InventoryRecord>
     <Type>INV</Type>
     <ID>880</ID>
     <Quantity>1</Quantity>
     <Shape>PL</Shape>
     <Dimensions Metric="0">3/8 x 48</Dimensions>
     <Grade>A36</Grade>
     <Thickness UOM="in">0.375</Thickness>
     <Width UOM="in">48</Width>
     <Length UOM="in">96</Length>
     <Weight UOM="kg">222.2675</Weight>
     <CurrentPrice Currency="USD" Units="/CWT">25</CurrentPrice>
     <Valuation Currency="USD">122.5</Valuation>
     <OriginalDate>2025-12-05</OriginalDate>
     <OriginalPrice Currency="USD" Units="/CWT">25</OriginalPrice>
     <Job>EPM-001</Job>
     <Location>Main Bay</Location>
     <HeatNo>33333</HeatNo>
     <PONumber>EPM-0001</PONumber>
     <Supplier>Tekla EPM - Supplier</Supplier>
     <DeliveryDate>2025-12-05</DeliveryDate>
     <OnOrder/>
     <POItemNumber>6960</POItemNumber>
     <KerfRipCut UOM="mm">0</KerfRipCut>
     <KerfCrossCut UOM="mm">0</KerfCrossCut>
     <PercentCombined>1</PercentCombined>
     <ExternalInventoryLinkID>216</ExternalInventoryLinkID>
     <NestID>0791e8fd-ebee-42cc-a3e3-b3ba66f48acd</NestID>
   </InventoryRecord>
```

The NestID matches, the ExternalInventoryLinkID has been updated to 216 because some properties about it have changed (the location and heat number in this case), and the OnOrder is now empty.  This piece can now be substituted for the original "to be ordered" stock that was sent to PowerFab.  It has been ordered, is received and is in stock.  The Inventory item can be kept in sync between PowerFab and the external software.

The most reliable way to sent a TFS cut to PowerFab in this situation is to use the NestID in the TFSCut command.
