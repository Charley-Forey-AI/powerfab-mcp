---
title: 'Code Example: Nesting Request'
url: https://developer.tekla.com/documentation/nesting-request-xml
slug: nesting-request-xml
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code Example: Nesting Request'
updated: 2 Dec 2025
---

# Code Example: Nesting Request

A Combining Run can be exported from Tekla PowerFab as a Nesting Request.  This request is intended to contain everything necessary for an external software (not Tekla PowerFab) to perform the nest and send it back to PowerFab.

A Nesting Request has four main parts:

### Header

The header contains the version of PowerFab that sent it, what software it's intended for, what combining run this nest request is from and such.

#### WorkOrderParts

This contains the job and piecemark  and additional info for every part requested to be nested.  A job+piecemark pair will be unique.

#### WorkOrderCNCData

This contains the definition for each part requested to be nested.  There will be a maximum of one definition for each job/piecemark pair.

#### AvailableInventory

This contains information about what stock is available for nesting.  An ID of 0 means that the stock is available to order.

The Schema can be found here:  
[https://developer.tekla.com/documentation/workorder-schema](../Schemas/Tekla_PowerFab_WorkOrder_Schema_(for_Nesting_Requests_to_external_software).md)

And an article on using this schema:  
[https://developer.tekla.com/documentation/workorder-schema-usage](../Schemas/The_PowerFab_WorkOrder_Schema_and_using_it.md)

## Here's a sample file:

```
<?xml version="1.0" encoding="UTF-8" standalone="no" ?>
<FabSuiteWorkOrder xmlns="https://schema.teklapowerfab.net/xml-schema/PowerFabWorkOrder.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

 <SourceApplication>Tekla PowerFab</SourceApplication> <SourceApplicationVersion>2025iSP1</SourceApplicationVersion> <FabSuiteWorkOrderVersion>1.3</FabSuiteWorkOrderVersion>
 <CreationDateTime>2025-12-02 07:07:59</CreationDateTime>
 <Destination>Other</Destination>
 <WorkOrderID>84</WorkOrderID>
 <WorkOrderDescription>2025-12-02 07:07:21</WorkOrderDescription>

 <WorkOrderParts>
   <WorkOrderPart>
     <PartID>15797</PartID>
     <Quantity>1</Quantity>
     <JobNumber>J2100</JobNumber>
     <DrawingNumber>C7</DrawingNumber>
     <MainMark>C7</MainMark>
     <PieceMark>F72</PieceMark>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Sequence>1</Sequence>
     <LotNumber>1</LotNumber>
     <Shape>PLT</Shape>
     <Grade>S355JR</Grade>
     <Dimensions Metric="true">10X139.4</Dimensions>
     <Length UOM="MM">143</Length>
     <Width UOM="MM">139.4</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Area UOM="SQM">0.01993134</Area>
     <SquaringAmount UOM="MM">0</SquaringAmount>
     <Finish>SP1</Finish>
     <Route>Fab / Paint</Route>
   </WorkOrderPart>
   <WorkOrderPart>
     <PartID>15791</PartID>
     <Quantity>1</Quantity>
     <JobNumber>J2100</JobNumber>
     <DrawingNumber>C7</DrawingNumber>
     <MainMark>C7</MainMark>
     <PieceMark>F73</PieceMark>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Sequence>1</Sequence>
     <LotNumber>1</LotNumber>
     <Shape>PLT</Shape>
     <Grade>S355JR</Grade>
     <Dimensions Metric="true">10X143</Dimensions>
     <Length UOM="MM">157</Length>
     <Width UOM="MM">143</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Area UOM="SQM">0.022451</Area>
     <SquaringAmount UOM="MM">0</SquaringAmount>
     <Finish>SP1</Finish>
     <Route>Fab / Paint</Route>
   </WorkOrderPart>
   <WorkOrderPart>
     <PartID>15785</PartID>
     <Quantity>1</Quantity>
     <JobNumber>J2100</JobNumber>
     <DrawingNumber>C7</DrawingNumber>
     <MainMark>C7</MainMark>
     <PieceMark>F74</PieceMark>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Sequence>1</Sequence>
     <LotNumber>1</LotNumber>
     <Shape>PLT</Shape>
     <Grade>S355JR</Grade>
     <Dimensions Metric="true">10X143</Dimensions>
     <Length UOM="MM">578.8</Length>
     <Width UOM="MM">143</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Area UOM="SQM">0.08276268</Area>
     <SquaringAmount UOM="MM">0</SquaringAmount>
     <Finish>SP1</Finish>
     <Route>Fab / Paint</Route>
   </WorkOrderPart>
 </WorkOrderParts>

 <WorkOrderCNCData>
   <PartCNCData>
     <JobNumber>J2100</JobNumber>
     <PieceMark>F74</PieceMark>
     <CNCFormat>.NC1</CNCFormat>
     <CNCData>ST
** F74.nc1
 21513
 F74
 2
 F74
 S355
 7
 PLT10
 B
    578.76
    143.00
     10.00
     10.00
     10.00
      0.00
    78.500
     2.174
     0.000
     0.000
     0.000
     0.000

AK
 v       0.00u      0.00       0.00       0.00       0.00       0.00       0.00
       578.76       0.00       0.00       0.00       0.00       0.00       0.00
       578.76     143.00       0.00       0.00       0.00       0.00       0.00
         0.00     143.00       0.00       0.00       0.00       0.00       0.00
         0.00       0.00       0.00       0.00       0.00       0.00       0.00
BO
 v      45.52s     93.50      18.00
 v      89.38s     69.49      18.00
 v     239.38s     93.30      22.00
 v     339.38s     93.30      22.00
 v     489.38s     69.49      18.00
 v     533.24s     93.50      18.00
EN
</CNCData>
   </PartCNCData>
   <PartCNCData>
     <JobNumber>J2100</JobNumber>
     <PieceMark>F73</PieceMark>
     <CNCFormat>.NC1</CNCFormat>
     <CNCData>ST
** F73.nc1
 21513
 F73
 2
 F73
 S355
 7
 PLT10
 B
    157.00
    143.00
     10.00
     10.00
     10.00
      0.00
    78.500
     2.267
     0.000
     0.000
     0.000
     0.000

AK
 v       0.00u      0.00       0.00       0.00       0.00       0.00       0.00
       157.00       0.00       0.00       0.00       0.00       0.00       0.00
       157.00     143.00       0.00       0.00       0.00       0.00       0.00
         0.00     143.00       0.00       0.00       0.00       0.00       0.00
         0.00       0.00       0.00       0.00       0.00       0.00       0.00
BO
 v      45.52s     93.50      18.00
 v      89.38s     69.49      18.00
EN
</CNCData>
   </PartCNCData>
   <PartCNCData>
     <JobNumber>J2100</JobNumber>
     <PieceMark>F72</PieceMark>
     <CNCFormat>.NC1</CNCFormat>
     <CNCData>ST
** F72.nc1
 21513
 F72
 2
 F72
 S355
 7
 PLT10
 B
    143.00
    139.38
     10.00
     10.00
     10.00
      0.00
    78.500
     2.283
     0.000
     0.000
     0.000
     0.000

AK
 v       0.00u      0.00       0.00       0.00       0.00       0.00       0.00
       143.00       0.00       0.00       0.00       0.00       0.00       0.00
       143.00     139.38       0.00       0.00       0.00       0.00       0.00
         0.00     139.38       0.00       0.00       0.00       0.00       0.00
         0.00       0.00       0.00       0.00       0.00       0.00       0.00
BO
 v      49.48s     45.52      18.00
 v      73.50s     89.38      18.00
EN
</CNCData>
   </PartCNCData>
 </WorkOrderCNCData>

 <AvailableInventory>
   <InventoryItem>
     <ID>0</ID>
     <ExternalInventoryLinkID>0</ExternalInventoryLinkID>
     <Shape>PLT</Shape>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Dimensions Metric="true">10X1000</Dimensions>
     <Width UOM="MM">1000</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Grade>S355JR</Grade>
     <Length UOM="MM">2000</Length>
     <Weight UOM="KG">157</Weight>
     <Quantity>any</Quantity>
     <Location></Location>
     <SecondaryLocation></SecondaryLocation>
     <Supplier>Stockholder</Supplier>
     <HeatNumber></HeatNumber>
     <HeatSerialNumber></HeatSerialNumber>
     <PONumber></PONumber>
     <BillOfLadingNumber></BillOfLadingNumber>
     <CountryOfOrigin></CountryOfOrigin>
     <MillOfOrigin></MillOfOrigin>
     <PartNumber></PartNumber>
     <CostCode></CostCode>
     <CostType></CostType>
     <Remarks></Remarks>
   </InventoryItem>
   <InventoryItem>
     <ID>0</ID>
     <ExternalInventoryLinkID>0</ExternalInventoryLinkID>
     <Shape>PLT</Shape>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Dimensions Metric="true">10X1250</Dimensions>
     <Width UOM="MM">1250</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Grade>S355JR</Grade>
     <Length UOM="MM">2500</Length>
     <Weight UOM="KG">245.3125</Weight>
     <Quantity>any</Quantity>
     <Location></Location>
     <SecondaryLocation></SecondaryLocation>
     <Supplier>Stockholder</Supplier>
     <HeatNumber></HeatNumber>
     <HeatSerialNumber></HeatSerialNumber>
     <PONumber></PONumber>
     <BillOfLadingNumber></BillOfLadingNumber>
     <CountryOfOrigin></CountryOfOrigin>
     <MillOfOrigin></MillOfOrigin>
     <PartNumber></PartNumber>
     <CostCode></CostCode>
     <CostType></CostType>
     <Remarks></Remarks>
   </InventoryItem>
   <InventoryItem>
     <ID>0</ID>
     <ExternalInventoryLinkID>0</ExternalInventoryLinkID>
     <Shape>PLT</Shape>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Dimensions Metric="true">10X1500</Dimensions>
     <Width UOM="MM">1500</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Grade>S355JR</Grade>
     <Length UOM="MM">3000</Length>
     <Weight UOM="KG">353.25</Weight>
     <Quantity>any</Quantity>
     <Location></Location>
     <SecondaryLocation></SecondaryLocation>
     <Supplier>Stockholder</Supplier>
     <HeatNumber></HeatNumber>
     <HeatSerialNumber></HeatSerialNumber>
     <PONumber></PONumber>
     <BillOfLadingNumber></BillOfLadingNumber>
     <CountryOfOrigin></CountryOfOrigin>
     <MillOfOrigin></MillOfOrigin>
     <PartNumber></PartNumber>
     <CostCode></CostCode>
     <CostType></CostType>
     <Remarks></Remarks>
   </InventoryItem>
   <InventoryItem>
     <ID>0</ID>
     <ExternalInventoryLinkID>0</ExternalInventoryLinkID>
     <Shape>PLT</Shape>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Dimensions Metric="true">10X2000</Dimensions>
     <Width UOM="MM">2000</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Grade>S355JR</Grade>
     <Length UOM="MM">4000</Length>
     <Weight UOM="KG">628</Weight>
     <Quantity>any</Quantity>
     <Location></Location>
     <SecondaryLocation></SecondaryLocation>
     <Supplier>Stockholder</Supplier>
     <HeatNumber></HeatNumber>
     <HeatSerialNumber></HeatSerialNumber>
     <PONumber></PONumber>
     <BillOfLadingNumber></BillOfLadingNumber>
     <CountryOfOrigin></CountryOfOrigin>
     <MillOfOrigin></MillOfOrigin>
     <PartNumber></PartNumber>
     <CostCode></CostCode>
     <CostType></CostType>
     <Remarks></Remarks>
   </InventoryItem>
   <InventoryItem>
     <ID>0</ID>
     <ExternalInventoryLinkID>0</ExternalInventoryLinkID>
     <Shape>PLT</Shape>
     <DSTVProfileCode>B</DSTVProfileCode>
     <Dimensions Metric="true">10X2500</Dimensions>
     <Width UOM="MM">2500</Width>
     <PlateThickness UOM="MM">10</PlateThickness>
     <Grade>S355JR</Grade>
     <Length UOM="MM">5000</Length>
     <Weight UOM="KG">981.25</Weight>
     <Quantity>any</Quantity>
     <Location></Location>
     <SecondaryLocation></SecondaryLocation>
     <Supplier>Stockholder</Supplier>
     <HeatNumber></HeatNumber>
     <HeatSerialNumber></HeatSerialNumber>
     <PONumber></PONumber>
     <BillOfLadingNumber></BillOfLadingNumber>
     <CountryOfOrigin></CountryOfOrigin>
     <MillOfOrigin></MillOfOrigin>
     <PartNumber></PartNumber>
     <CostCode></CostCode>
     <CostType></CostType>
     <Remarks></Remarks>
   </InventoryItem>
 </AvailableInventory>

</FabSuiteWorkOrder>
```
