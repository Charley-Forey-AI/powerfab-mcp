---
title: fsreqLoad Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-load-class-79515
slug: fsreq-load-class-79515
node_id: 79515
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqLoad Class
children:
- title: fsreqLoad Constructor
  kind: Constructor
  slug: fsreq-load-constructor-79516
  path: fsreqLoad_Constructor.md
- title: fsreqLoad.BarcodeSerialNumber Property
  kind: Property
  slug: barcode-serial-number-property-79518
  path: fsreqLoad.BarcodeSerialNumber_Property.md
- title: fsreqLoad.CommitType Property
  kind: Property
  slug: commit-type-property-79519
  path: fsreqLoad.CommitType_Property.md
- title: fsreqLoad.Date Property
  kind: Property
  slug: date-property-79520
  path: fsreqLoad.Date_Property.md
- title: fsreqLoad.Description Property
  kind: Property
  slug: description-property-79521
  path: fsreqLoad.Description_Property.md
- title: fsreqLoad.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-79522
  path: fsreqLoad.InstanceNumbers_Property.md
- title: fsreqLoad.JobNumber Property
  kind: Property
  slug: job-number-property-79523
  path: fsreqLoad.JobNumber_Property.md
- title: fsreqLoad.LotNumber Property
  kind: Property
  slug: lot-number-property-79524
  path: fsreqLoad.LotNumber_Property.md
- title: fsreqLoad.MainMark Property
  kind: Property
  slug: main-mark-property-79525
  path: fsreqLoad.MainMark_Property.md
- title: fsreqLoad.Notes Property
  kind: Property
  slug: notes-property-79526
  path: fsreqLoad.Notes_Property.md
- title: fsreqLoad.PerformReverseTFS Property
  kind: Property
  slug: perform-reverse-tfs-property-79527
  path: fsreqLoad.PerformReverseTFS_Property.md
- title: fsreqLoad.PieceMark Property
  kind: Property
  slug: piece-mark-property-79528
  path: fsreqLoad.PieceMark_Property.md
- title: fsreqLoad.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79529
  path: fsreqLoad.ProductionControlID_Property.md
- title: fsreqLoad.ProductionControlTrucksAdditionalID Property
  kind: Property
  slug: production-control-trucks-additional-id-property-79530
  path: fsreqLoad.ProductionControlTrucksAdditionalID_Property.md
- title: fsreqLoad.Quantity Property
  kind: Property
  slug: quantity-property-79531
  path: fsreqLoad.Quantity_Property.md
- title: fsreqLoad.Sequence Property
  kind: Property
  slug: sequence-property-79532
  path: fsreqLoad.Sequence_Property.md
- title: fsreqLoad.TruckNumber Property
  kind: Property
  slug: truck-number-property-79533
  path: fsreqLoad.TruckNumber_Property.md
- title: fsreqLoad.WeightEach Property
  kind: Property
  slug: weight-each-property-79534
  path: fsreqLoad.WeightEach_Property.md
- title: fsreqLoad.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-79535
  path: fsreqLoad.WorkPackageNumber_Property.md
---

# fsreqLoad Class

Loads or Un-Loads a production assembly/part from a truck.
Either ProductionControlID or JobNumber must be specified.
When loading either MainMark or Description must be specified.
When un-loading either MainMark or ProductionControlTrucksAdditionalID must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqLoad

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqLoad : fsreqCommand
```

The fsreqLoad type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqLoad](fsreqLoad_Constructor.md) | fsreqLoad class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BarcodeSerialNumber](fsreqLoad.BarcodeSerialNumber_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommitType](fsreqLoad.CommitType_Property.md) | Type of action: Save -> Load Delete -> Un-Load |
| Public property | [Date](fsreqLoad.Date_Property.md) |  |
| Public property | [Description](fsreqLoad.Description_Property.md) | Description of the additional item to add. |
| Public property | [InstanceNumbers](fsreqLoad.InstanceNumbers_Property.md) |  |
| Public property | [JobNumber](fsreqLoad.JobNumber_Property.md) |  |
| Public property | [LotNumber](fsreqLoad.LotNumber_Property.md) |  |
| Public property | [MainMark](fsreqLoad.MainMark_Property.md) |  |
| Public property | [Notes](fsreqLoad.Notes_Property.md) | Notes for the additional item to add. |
| Public property | [PerformReverseTFS](fsreqLoad.PerformReverseTFS_Property.md) | If true and this action is for deleting an Additional item, and that item represents an inventory record, then perform a reverse TFS and add that material back into inventory. |
| Public property | [PieceMark](fsreqLoad.PieceMark_Property.md) | Exclude this element when shipping an assembly. Only specify this element for shipping an accessory part. |
| Public property | [ProductionControlID](fsreqLoad.ProductionControlID_Property.md) |  |
| Public property | [ProductionControlTrucksAdditionalID](fsreqLoad.ProductionControlTrucksAdditionalID_Property.md) | The additional item to delete. |
| Public property | [Quantity](fsreqLoad.Quantity_Property.md) |  |
| Public property | [Sequence](fsreqLoad.Sequence_Property.md) |  |
| Public property | [TruckNumber](fsreqLoad.TruckNumber_Property.md) |  |
| Public property | [WeightEach](fsreqLoad.WeightEach_Property.md) | Weight each of the additional item to add.. |
| Public property | [WorkPackageNumber](fsreqLoad.WorkPackageNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
