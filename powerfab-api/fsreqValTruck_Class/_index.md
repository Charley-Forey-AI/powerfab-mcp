---
title: fsreqValTruck Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-val-truck-class-80642
slug: fsreq-val-truck-class-80642
node_id: 80642
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqValTruck Class
children:
- title: fsreqValTruck Constructor
  kind: Constructor
  slug: fsreq-val-truck-constructor-80643
  path: fsreqValTruck_Constructor.md
- title: fsreqValTruck.ActionIfNotExist Property
  kind: Property
  slug: action-if-not-exist-property-80645
  path: fsreqValTruck.ActionIfNotExist_Property.md
- title: fsreqValTruck.Capacity Property
  kind: Property
  slug: capacity-property-80646
  path: fsreqValTruck.Capacity_Property.md
- title: fsreqValTruck.Carrier Property
  kind: Property
  slug: carrier-property-80647
  path: fsreqValTruck.Carrier_Property.md
- title: fsreqValTruck.Destination Property
  kind: Property
  slug: destination-property-80648
  path: fsreqValTruck.Destination_Property.md
- title: fsreqValTruck.DestinationGroup Property
  kind: Property
  slug: destination-group-property-80649
  path: fsreqValTruck.DestinationGroup_Property.md
- title: fsreqValTruck.JobNumber Property
  kind: Property
  slug: job-number-property-80650
  path: fsreqValTruck.JobNumber_Property.md
- title: fsreqValTruck.MaximumLength Property
  kind: Property
  slug: maximum-length-property-80651
  path: fsreqValTruck.MaximumLength_Property.md
- title: fsreqValTruck.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80652
  path: fsreqValTruck.ProductionControlID_Property.md
- title: fsreqValTruck.ShippedFromFirm Property
  kind: Property
  slug: shipped-firm-property-80653
  path: fsreqValTruck.ShippedFromFirm_Property.md
- title: fsreqValTruck.ToBeReturned Property
  kind: Property
  slug: be-returned-property-80654
  path: fsreqValTruck.ToBeReturned_Property.md
- title: fsreqValTruck.TrailerNumber Property
  kind: Property
  slug: trailer-number-property-80655
  path: fsreqValTruck.TrailerNumber_Property.md
- title: fsreqValTruck.TruckNumber Property
  kind: Property
  slug: truck-number-property-80656
  path: fsreqValTruck.TruckNumber_Property.md
---

# fsreqValTruck Class

Validates that a truck/load exists, optionally adds it if it does not exist.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqValTruck

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqValTruck : fsreqCommand
```

The fsreqValTruck type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqValTruck](fsreqValTruck_Constructor.md) | fsreqValTruck class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [ActionIfNotExist](fsreqValTruck.ActionIfNotExist_Property.md) | Action if the truck does not exist and is created. |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Capacity](fsreqValTruck.Capacity_Property.md) | If the truck does not exist and is created: The capacity of the truck. |
| Public property | [Carrier](fsreqValTruck.Carrier_Property.md) | If the truck does not exist and is created: The carrier. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Destination](fsreqValTruck.Destination_Property.md) | If the truck does not exist and is created: The destination of the load. Intermediate Destination: Company code of the intermediate shipping destination. Jobsite: Blank or 'Jobsite' |
| Public property | [DestinationGroup](fsreqValTruck.DestinationGroup_Property.md) |  |
| Public property | [JobNumber](fsreqValTruck.JobNumber_Property.md) |  |
| Public property | [MaximumLength](fsreqValTruck.MaximumLength_Property.md) | If the truck does not exist and is created: The maximum length of the truck. |
| Public property | [ProductionControlID](fsreqValTruck.ProductionControlID_Property.md) |  |
| Public property | [ShippedFromFirm](fsreqValTruck.ShippedFromFirm_Property.md) | If the truck does not exist and is created: The name of the firm that the load is being shipped from. |
| Public property | [ToBeReturned](fsreqValTruck.ToBeReturned_Property.md) | If the truck does not exist and is created, and the destination is an intermediate location: Indicates if the material on the load is going to be returned to the shop before being shipped to the jobsite. |
| Public property | [TrailerNumber](fsreqValTruck.TrailerNumber_Property.md) | If the truck does not exist and is created: The trailer number of the load. |
| Public property | [TruckNumber](fsreqValTruck.TruckNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
