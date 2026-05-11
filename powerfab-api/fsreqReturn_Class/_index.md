---
title: fsreqReturn Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-return-class-80315
slug: fsreq-return-class-80315
node_id: 80315
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqReturn Class
children:
- title: fsreqReturn Constructor
  kind: Constructor
  slug: fsreq-return-constructor-80316
  path: fsreqReturn_Constructor.md
- title: fsreqReturn.BarcodeSerialNumber Property
  kind: Property
  slug: barcode-serial-number-property-80318
  path: fsreqReturn.BarcodeSerialNumber_Property.md
- title: fsreqReturn.CommitType Property
  kind: Property
  slug: commit-type-property-80319
  path: fsreqReturn.CommitType_Property.md
- title: fsreqReturn.Date Property
  kind: Property
  slug: date-property-80320
  path: fsreqReturn.Date_Property.md
- title: fsreqReturn.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-80321
  path: fsreqReturn.InstanceNumbers_Property.md
- title: fsreqReturn.JobNumber Property
  kind: Property
  slug: job-number-property-80322
  path: fsreqReturn.JobNumber_Property.md
- title: fsreqReturn.LotNumber Property
  kind: Property
  slug: lot-number-property-80323
  path: fsreqReturn.LotNumber_Property.md
- title: fsreqReturn.MainMark Property
  kind: Property
  slug: main-mark-property-80324
  path: fsreqReturn.MainMark_Property.md
- title: fsreqReturn.PieceMark Property
  kind: Property
  slug: piece-mark-property-80325
  path: fsreqReturn.PieceMark_Property.md
- title: fsreqReturn.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80326
  path: fsreqReturn.ProductionControlID_Property.md
- title: fsreqReturn.Quantity Property
  kind: Property
  slug: quantity-property-80327
  path: fsreqReturn.Quantity_Property.md
- title: fsreqReturn.Sequence Property
  kind: Property
  slug: sequence-property-80328
  path: fsreqReturn.Sequence_Property.md
- title: fsreqReturn.TruckNumber Property
  kind: Property
  slug: truck-number-property-80329
  path: fsreqReturn.TruckNumber_Property.md
- title: fsreqReturn.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-80330
  path: fsreqReturn.WorkPackageNumber_Property.md
---

# fsreqReturn Class

Returns or Un-Returns material from an intermediate shipping location (galvanizer, subcontractor, etc).
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqReturn

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqReturn : fsreqCommand
```

The fsreqReturn type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqReturn](fsreqReturn_Constructor.md) | Initializes a new instance of the fsreqReturn class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BarcodeSerialNumber](fsreqReturn.BarcodeSerialNumber_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommitType](fsreqReturn.CommitType_Property.md) | Type of action: Save -> Return Delete -> Un-Return |
| Public property | [Date](fsreqReturn.Date_Property.md) |  |
| Public property | [InstanceNumbers](fsreqReturn.InstanceNumbers_Property.md) |  |
| Public property | [JobNumber](fsreqReturn.JobNumber_Property.md) |  |
| Public property | [LotNumber](fsreqReturn.LotNumber_Property.md) |  |
| Public property | [MainMark](fsreqReturn.MainMark_Property.md) |  |
| Public property | [PieceMark](fsreqReturn.PieceMark_Property.md) | Exclude this element when returning an assembly. Only specify this element for returning an accessory part. |
| Public property | [ProductionControlID](fsreqReturn.ProductionControlID_Property.md) |  |
| Public property | [Quantity](fsreqReturn.Quantity_Property.md) |  |
| Public property | [Sequence](fsreqReturn.Sequence_Property.md) |  |
| Public property | [TruckNumber](fsreqReturn.TruckNumber_Property.md) | Truck/Load # that the material was shipped to the intermediate location on. |
| Public property | [WorkPackageNumber](fsreqReturn.WorkPackageNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
