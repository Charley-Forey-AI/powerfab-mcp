---
title: fsreqProductionControlLoadUpdate Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-update-class-79964
slug: fsreq-production-control-load-update-class-79964
node_id: 79964
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadUpdate Class
children:
- title: fsreqProductionControlLoadUpdate Constructor
  kind: Constructor
  slug: fsreq-production-control-load-update-constructor-79965
  path: fsreqProductionControlLoadUpdate_Constructor.md
- title: fsreqProductionControlLoadUpdate.Capacity Property
  kind: Property
  slug: capacity-property-79967
  path: fsreqProductionControlLoadUpdate.Capacity_Property.md
- title: fsreqProductionControlLoadUpdate.Carrier Property
  kind: Property
  slug: carrier-property-79968
  path: fsreqProductionControlLoadUpdate.Carrier_Property.md
- title: fsreqProductionControlLoadUpdate.DateReady Property
  kind: Property
  slug: date-ready-property-79969
  path: fsreqProductionControlLoadUpdate.DateReady_Property.md
- title: fsreqProductionControlLoadUpdate.DateReceived Property
  kind: Property
  slug: date-received-property-79970
  path: fsreqProductionControlLoadUpdate.DateReceived_Property.md
- title: fsreqProductionControlLoadUpdate.LoadCategory1 Property
  kind: Property
  slug: load-category1-property-79971
  path: fsreqProductionControlLoadUpdate.LoadCategory1_Property.md
- title: fsreqProductionControlLoadUpdate.LoadCategory2 Property
  kind: Property
  slug: load-category2-property-79972
  path: fsreqProductionControlLoadUpdate.LoadCategory2_Property.md
- title: fsreqProductionControlLoadUpdate.LoadCategory3 Property
  kind: Property
  slug: load-category3-property-79973
  path: fsreqProductionControlLoadUpdate.LoadCategory3_Property.md
- title: fsreqProductionControlLoadUpdate.LoadNumber Property
  kind: Property
  slug: load-number-property-79974
  path: fsreqProductionControlLoadUpdate.LoadNumber_Property.md
- title: fsreqProductionControlLoadUpdate.MaximumLength Property
  kind: Property
  slug: maximum-length-property-79975
  path: fsreqProductionControlLoadUpdate.MaximumLength_Property.md
- title: fsreqProductionControlLoadUpdate.PlannedShipDate Property
  kind: Property
  slug: planned-ship-date-property-79976
  path: fsreqProductionControlLoadUpdate.PlannedShipDate_Property.md
- title: fsreqProductionControlLoadUpdate.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79977
  path: fsreqProductionControlLoadUpdate.ProductionControlLoadID_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedDate Property
  kind: Property
  slug: shipped-date-property-79978
  path: fsreqProductionControlLoadUpdate.ShippedDate_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedFrom Property
  kind: Property
  slug: shipped-property-79979
  path: fsreqProductionControlLoadUpdate.ShippedFrom_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedFromFirmAddressID Property
  kind: Property
  slug: shipped-firm-address-id-property-79980
  path: fsreqProductionControlLoadUpdate.ShippedFromFirmAddressID_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedFromFirmID Property
  kind: Property
  slug: shipped-firm-id-property-79981
  path: fsreqProductionControlLoadUpdate.ShippedFromFirmID_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedToFirmAddressID Property
  kind: Property
  slug: shipped-firm-address-id-property-79982
  path: fsreqProductionControlLoadUpdate.ShippedToFirmAddressID_Property.md
- title: fsreqProductionControlLoadUpdate.ShippedToFirmID Property
  kind: Property
  slug: shipped-firm-id-property-79983
  path: fsreqProductionControlLoadUpdate.ShippedToFirmID_Property.md
- title: fsreqProductionControlLoadUpdate.ShippingDestinationGroupID Property
  kind: Property
  slug: shipping-destination-group-id-property-79984
  path: fsreqProductionControlLoadUpdate.ShippingDestinationGroupID_Property.md
- title: fsreqProductionControlLoadUpdate.ToBeReturned Property
  kind: Property
  slug: be-returned-property-79985
  path: fsreqProductionControlLoadUpdate.ToBeReturned_Property.md
- title: fsreqProductionControlLoadUpdate.TopText Property
  kind: Property
  slug: top-text-property-79986
  path: fsreqProductionControlLoadUpdate.TopText_Property.md
- title: fsreqProductionControlLoadUpdate.TrailerNumber Property
  kind: Property
  slug: trailer-number-property-79987
  path: fsreqProductionControlLoadUpdate.TrailerNumber_Property.md
---

# fsreqProductionControlLoadUpdate Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadUpdate

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadUpdate : fsreqCommand
```

The fsreqProductionControlLoadUpdate type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadUpdate](fsreqProductionControlLoadUpdate_Constructor.md) | fsreqProductionControlLoadUpdate class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Capacity](fsreqProductionControlLoadUpdate.Capacity_Property.md) |  |
| Public property | [Carrier](fsreqProductionControlLoadUpdate.Carrier_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateReady](fsreqProductionControlLoadUpdate.DateReady_Property.md) |  |
| Public property | [DateReceived](fsreqProductionControlLoadUpdate.DateReceived_Property.md) |  |
| Public property | [LoadCategory1](fsreqProductionControlLoadUpdate.LoadCategory1_Property.md) |  |
| Public property | [LoadCategory2](fsreqProductionControlLoadUpdate.LoadCategory2_Property.md) |  |
| Public property | [LoadCategory3](fsreqProductionControlLoadUpdate.LoadCategory3_Property.md) |  |
| Public property | [LoadNumber](fsreqProductionControlLoadUpdate.LoadNumber_Property.md) |  |
| Public property | [MaximumLength](fsreqProductionControlLoadUpdate.MaximumLength_Property.md) |  |
| Public property | [PlannedShipDate](fsreqProductionControlLoadUpdate.PlannedShipDate_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadUpdate.ProductionControlLoadID_Property.md) |  |
| Public property | [ShippedDate](fsreqProductionControlLoadUpdate.ShippedDate_Property.md) |  |
| Public property | [ShippedFrom](fsreqProductionControlLoadUpdate.ShippedFrom_Property.md) |  |
| Public property | [ShippedFromFirmAddressID](fsreqProductionControlLoadUpdate.ShippedFromFirmAddressID_Property.md) |  |
| Public property | [ShippedFromFirmID](fsreqProductionControlLoadUpdate.ShippedFromFirmID_Property.md) |  |
| Public property | [ShippedToFirmAddressID](fsreqProductionControlLoadUpdate.ShippedToFirmAddressID_Property.md) |  |
| Public property | [ShippedToFirmID](fsreqProductionControlLoadUpdate.ShippedToFirmID_Property.md) |  |
| Public property | [ShippingDestinationGroupID](fsreqProductionControlLoadUpdate.ShippingDestinationGroupID_Property.md) |  |
| Public property | [ToBeReturned](fsreqProductionControlLoadUpdate.ToBeReturned_Property.md) |  |
| Public property | [TopText](fsreqProductionControlLoadUpdate.TopText_Property.md) |  |
| Public property | [TrailerNumber](fsreqProductionControlLoadUpdate.TrailerNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
