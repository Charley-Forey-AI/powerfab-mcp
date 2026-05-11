---
title: fsreqShopFloorSave Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-shop-floor-save-class-80451
slug: fsreq-shop-floor-save-class-80451
node_id: 80451
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqShopFloorSave Class
children:
- title: fsreqShopFloorSave Constructor
  kind: Constructor
  slug: fsreq-shop-floor-save-constructor-80452
  path: fsreqShopFloorSave_Constructor.md
- title: fsreqShopFloorSave.BarcodeSerialNumber Property
  kind: Property
  slug: barcode-serial-number-property-80454
  path: fsreqShopFloorSave.BarcodeSerialNumber_Property.md
- title: fsreqShopFloorSave.BatchID Property
  kind: Property
  slug: batch-id-property-80455
  path: fsreqShopFloorSave.BatchID_Property.md
- title: fsreqShopFloorSave.CommitType Property
  kind: Property
  slug: commit-type-property-80456
  path: fsreqShopFloorSave.CommitType_Property.md
- title: fsreqShopFloorSave.Date Property
  kind: Property
  slug: date-property-80457
  path: fsreqShopFloorSave.Date_Property.md
- title: fsreqShopFloorSave.Employee Property
  kind: Property
  slug: employee-property-80458
  path: fsreqShopFloorSave.Employee_Property.md
- title: fsreqShopFloorSave.Hours Property
  kind: Property
  slug: hours-property-80459
  path: fsreqShopFloorSave.Hours_Property.md
- title: fsreqShopFloorSave.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-80460
  path: fsreqShopFloorSave.InstanceNumbers_Property.md
- title: fsreqShopFloorSave.JobNumber Property
  kind: Property
  slug: job-number-property-80461
  path: fsreqShopFloorSave.JobNumber_Property.md
- title: fsreqShopFloorSave.LotNumber Property
  kind: Property
  slug: lot-number-property-80462
  path: fsreqShopFloorSave.LotNumber_Property.md
- title: fsreqShopFloorSave.MainMark Property
  kind: Property
  slug: main-mark-property-80463
  path: fsreqShopFloorSave.MainMark_Property.md
- title: fsreqShopFloorSave.PieceMark Property
  kind: Property
  slug: piece-mark-property-80464
  path: fsreqShopFloorSave.PieceMark_Property.md
- title: fsreqShopFloorSave.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80465
  path: fsreqShopFloorSave.ProductionControlID_Property.md
- title: fsreqShopFloorSave.Quantity Property
  kind: Property
  slug: quantity-property-80466
  path: fsreqShopFloorSave.Quantity_Property.md
- title: fsreqShopFloorSave.Sequence Property
  kind: Property
  slug: sequence-property-80467
  path: fsreqShopFloorSave.Sequence_Property.md
- title: fsreqShopFloorSave.Station Property
  kind: Property
  slug: station-property-80468
  path: fsreqShopFloorSave.Station_Property.md
- title: fsreqShopFloorSave.TimeCompleted Property
  kind: Property
  slug: time-completed-property-80469
  path: fsreqShopFloorSave.TimeCompleted_Property.md
- title: fsreqShopFloorSave.WorkAreaID Property
  kind: Property
  slug: work-area-id-property-80470
  path: fsreqShopFloorSave.WorkAreaID_Property.md
- title: fsreqShopFloorSave.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-80471
  path: fsreqShopFloorSave.WorkPackageNumber_Property.md
---

# fsreqShopFloorSave Class

Adds or Deletes the record of an assembly/part having completed a tracking station.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqShopFloorSave

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqShopFloorSave : fsreqCommand
```

The fsreqShopFloorSave type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqShopFloorSave](fsreqShopFloorSave_Constructor.md) | Initializes a new instance of the fsreqShopFloorSave class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BarcodeSerialNumber](fsreqShopFloorSave.BarcodeSerialNumber_Property.md) | Barcode Serial Number |
| Public property | [BatchID](fsreqShopFloorSave.BatchID_Property.md) | Batch of work. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommitType](fsreqShopFloorSave.CommitType_Property.md) | Type of action. |
| Public property | [Date](fsreqShopFloorSave.Date_Property.md) | Date work completed |
| Public property | [Employee](fsreqShopFloorSave.Employee_Property.md) | Employee that completed the work. |
| Public property | [Hours](fsreqShopFloorSave.Hours_Property.md) | Number of hours to complete the work. |
| Public property | [InstanceNumbers](fsreqShopFloorSave.InstanceNumbers_Property.md) | Instance Numbers |
| Public property | [JobNumber](fsreqShopFloorSave.JobNumber_Property.md) | Job Number |
| Public property | [LotNumber](fsreqShopFloorSave.LotNumber_Property.md) | Lot Number |
| Public property | [MainMark](fsreqShopFloorSave.MainMark_Property.md) | Main Mark |
| Public property | [PieceMark](fsreqShopFloorSave.PieceMark_Property.md) | Exclude this element when returning an assembly. Only specify this element for an accessory part. |
| Public property | [ProductionControlID](fsreqShopFloorSave.ProductionControlID_Property.md) | Production Control ID |
| Public property | [Quantity](fsreqShopFloorSave.Quantity_Property.md) | Quantity |
| Public property | [Sequence](fsreqShopFloorSave.Sequence_Property.md) | Sequence |
| Public property | [Station](fsreqShopFloorSave.Station_Property.md) | Tracking station that has been completed or should be deleted. |
| Public property | [TimeCompleted](fsreqShopFloorSave.TimeCompleted_Property.md) | Time work completed |
| Public property | [WorkAreaID](fsreqShopFloorSave.WorkAreaID_Property.md) | Work Area ID. |
| Public property | [WorkPackageNumber](fsreqShopFloorSave.WorkPackageNumber_Property.md) | Work Package Number |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
