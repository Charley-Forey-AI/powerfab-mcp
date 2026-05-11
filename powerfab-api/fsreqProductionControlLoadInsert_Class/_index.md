---
title: fsreqProductionControlLoadInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-insert-class-79838
slug: fsreq-production-control-load-insert-class-79838
node_id: 79838
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadInsert Class
children:
- title: fsreqProductionControlLoadInsert Constructor
  kind: Constructor
  slug: fsreq-production-control-load-insert-constructor-79839
  path: fsreqProductionControlLoadInsert_Constructor.md
- title: fsreqProductionControlLoadInsert.Capacity Property
  kind: Property
  slug: capacity-property-79841
  path: fsreqProductionControlLoadInsert.Capacity_Property.md
- title: fsreqProductionControlLoadInsert.Carrier Property
  kind: Property
  slug: carrier-property-79842
  path: fsreqProductionControlLoadInsert.Carrier_Property.md
- title: fsreqProductionControlLoadInsert.LoadCategory1 Property
  kind: Property
  slug: load-category1-property-79843
  path: fsreqProductionControlLoadInsert.LoadCategory1_Property.md
- title: fsreqProductionControlLoadInsert.LoadCategory2 Property
  kind: Property
  slug: load-category2-property-79844
  path: fsreqProductionControlLoadInsert.LoadCategory2_Property.md
- title: fsreqProductionControlLoadInsert.LoadCategory3 Property
  kind: Property
  slug: load-category3-property-79845
  path: fsreqProductionControlLoadInsert.LoadCategory3_Property.md
- title: fsreqProductionControlLoadInsert.LoadNumber Property
  kind: Property
  slug: load-number-property-79846
  path: fsreqProductionControlLoadInsert.LoadNumber_Property.md
- title: fsreqProductionControlLoadInsert.MaximumLength Property
  kind: Property
  slug: maximum-length-property-79847
  path: fsreqProductionControlLoadInsert.MaximumLength_Property.md
- title: fsreqProductionControlLoadInsert.PlannedShipDate Property
  kind: Property
  slug: planned-ship-date-property-79848
  path: fsreqProductionControlLoadInsert.PlannedShipDate_Property.md
- title: fsreqProductionControlLoadInsert.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79849
  path: fsreqProductionControlLoadInsert.ProductionControlID_Property.md
- title: fsreqProductionControlLoadInsert.ShippedFrom Property
  kind: Property
  slug: shipped-property-79850
  path: fsreqProductionControlLoadInsert.ShippedFrom_Property.md
- title: fsreqProductionControlLoadInsert.ShippedFromFirmAddressID Property
  kind: Property
  slug: shipped-firm-address-id-property-79851
  path: fsreqProductionControlLoadInsert.ShippedFromFirmAddressID_Property.md
- title: fsreqProductionControlLoadInsert.ShippedFromFirmID Property
  kind: Property
  slug: shipped-firm-id-property-79852
  path: fsreqProductionControlLoadInsert.ShippedFromFirmID_Property.md
- title: fsreqProductionControlLoadInsert.ShippedToFirmAddressID Property
  kind: Property
  slug: shipped-firm-address-id-property-79853
  path: fsreqProductionControlLoadInsert.ShippedToFirmAddressID_Property.md
- title: fsreqProductionControlLoadInsert.ShippedToFirmID Property
  kind: Property
  slug: shipped-firm-id-property-79854
  path: fsreqProductionControlLoadInsert.ShippedToFirmID_Property.md
- title: fsreqProductionControlLoadInsert.ShippingDestinationGroupID Property
  kind: Property
  slug: shipping-destination-group-id-property-79855
  path: fsreqProductionControlLoadInsert.ShippingDestinationGroupID_Property.md
- title: fsreqProductionControlLoadInsert.ToBeReturned Property
  kind: Property
  slug: be-returned-property-79856
  path: fsreqProductionControlLoadInsert.ToBeReturned_Property.md
- title: fsreqProductionControlLoadInsert.TopText Property
  kind: Property
  slug: top-text-property-79857
  path: fsreqProductionControlLoadInsert.TopText_Property.md
- title: fsreqProductionControlLoadInsert.TrailerNumber Property
  kind: Property
  slug: trailer-number-property-79858
  path: fsreqProductionControlLoadInsert.TrailerNumber_Property.md
---

# fsreqProductionControlLoadInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadInsert : fsreqCommand
```

The fsreqProductionControlLoadInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadInsert](fsreqProductionControlLoadInsert_Constructor.md) | Initializes a new instance of the fsreqProductionControlLoadInsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Capacity](fsreqProductionControlLoadInsert.Capacity_Property.md) |  |
| Public property | [Carrier](fsreqProductionControlLoadInsert.Carrier_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LoadCategory1](fsreqProductionControlLoadInsert.LoadCategory1_Property.md) |  |
| Public property | [LoadCategory2](fsreqProductionControlLoadInsert.LoadCategory2_Property.md) |  |
| Public property | [LoadCategory3](fsreqProductionControlLoadInsert.LoadCategory3_Property.md) |  |
| Public property | [LoadNumber](fsreqProductionControlLoadInsert.LoadNumber_Property.md) |  |
| Public property | [MaximumLength](fsreqProductionControlLoadInsert.MaximumLength_Property.md) |  |
| Public property | [PlannedShipDate](fsreqProductionControlLoadInsert.PlannedShipDate_Property.md) |  |
| Public property | [ProductionControlID](fsreqProductionControlLoadInsert.ProductionControlID_Property.md) |  |
| Public property | [ShippedFrom](fsreqProductionControlLoadInsert.ShippedFrom_Property.md) |  |
| Public property | [ShippedFromFirmAddressID](fsreqProductionControlLoadInsert.ShippedFromFirmAddressID_Property.md) |  |
| Public property | [ShippedFromFirmID](fsreqProductionControlLoadInsert.ShippedFromFirmID_Property.md) |  |
| Public property | [ShippedToFirmAddressID](fsreqProductionControlLoadInsert.ShippedToFirmAddressID_Property.md) |  |
| Public property | [ShippedToFirmID](fsreqProductionControlLoadInsert.ShippedToFirmID_Property.md) |  |
| Public property | [ShippingDestinationGroupID](fsreqProductionControlLoadInsert.ShippingDestinationGroupID_Property.md) |  |
| Public property | [ToBeReturned](fsreqProductionControlLoadInsert.ToBeReturned_Property.md) |  |
| Public property | [TopText](fsreqProductionControlLoadInsert.TopText_Property.md) |  |
| Public property | [TrailerNumber](fsreqProductionControlLoadInsert.TrailerNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
