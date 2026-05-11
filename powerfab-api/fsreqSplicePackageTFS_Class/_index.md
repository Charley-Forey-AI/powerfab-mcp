---
title: fsreqSplicePackageTFS Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-splice-package-tfs-class-80473
slug: fsreq-splice-package-tfs-class-80473
node_id: 80473
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSplicePackageTFS Class
children:
- title: fsreqSplicePackageTFS Constructor
  kind: Constructor
  slug: fsreq-splice-package-tfs-constructor-80474
  path: fsreqSplicePackageTFS_Constructor.md
- title: fsreqSplicePackageTFS.IncludeAllRequired Property
  kind: Property
  slug: include-all-required-property-80476
  path: fsreqSplicePackageTFS.IncludeAllRequired_Property.md
- title: fsreqSplicePackageTFS.JoinToLocation Property
  kind: Property
  slug: join-location-property-80477
  path: fsreqSplicePackageTFS.JoinToLocation_Property.md
- title: fsreqSplicePackageTFS.JoinToSecondaryLocation Property
  kind: Property
  slug: join-secondary-location-property-80478
  path: fsreqSplicePackageTFS.JoinToSecondaryLocation_Property.md
- title: fsreqSplicePackageTFS.NestSolutionID Property
  kind: Property
  slug: nest-solution-id-property-80479
  path: fsreqSplicePackageTFS.NestSolutionID_Property.md
- title: fsreqSplicePackageTFS.NestSolutionRequiredID Property
  kind: Property
  slug: nest-solution-required-id-property-80480
  path: fsreqSplicePackageTFS.NestSolutionRequiredID_Property.md
- title: fsreqSplicePackageTFS.NestSolutionRequiredQuantity Property
  kind: Property
  slug: nest-solution-required-quantity-property-80481
  path: fsreqSplicePackageTFS.NestSolutionRequiredQuantity_Property.md
- title: fsreqSplicePackageTFS.OverrideAutomaticScrapSetting Property
  kind: Property
  slug: override-automatic-scrap-setting-property-80482
  path: fsreqSplicePackageTFS.OverrideAutomaticScrapSetting_Property.md
- title: fsreqSplicePackageTFS.OverrideAutomaticToInventory Property
  kind: Property
  slug: override-automatic-inventory-property-80483
  path: fsreqSplicePackageTFS.OverrideAutomaticToInventory_Property.md
- title: fsreqSplicePackageTFS.OverrideAutomaticToScrap Property
  kind: Property
  slug: override-automatic-scrap-property-80484
  path: fsreqSplicePackageTFS.OverrideAutomaticToScrap_Property.md
- title: fsreqSplicePackageTFS.PieceTrackingBatchID Property
  kind: Property
  slug: piece-tracking-batch-id-property-80485
  path: fsreqSplicePackageTFS.PieceTrackingBatchID_Property.md
- title: fsreqSplicePackageTFS.PieceTrackingHours Property
  kind: Property
  slug: piece-tracking-hours-property-80486
  path: fsreqSplicePackageTFS.PieceTrackingHours_Property.md
- title: fsreqSplicePackageTFS.PieceTrackingUserID Property
  kind: Property
  slug: piece-tracking-user-id-property-80487
  path: fsreqSplicePackageTFS.PieceTrackingUserID_Property.md
- title: fsreqSplicePackageTFS.TFSResult Property
  kind: Property
  slug: tfs-result-property-80488
  path: fsreqSplicePackageTFS.TFSResult_Property.md
---

# fsreqSplicePackageTFS Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSplicePackageTFS

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSplicePackageTFS : fsreqCommand
```

The fsreqSplicePackageTFS type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSplicePackageTFS](fsreqSplicePackageTFS_Constructor.md) | fsreqSplicePackageTFS class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [IncludeAllRequired](fsreqSplicePackageTFS.IncludeAllRequired_Property.md) | If true, then all of the required stock records are to be joined and cut. If false, then NestSolutionRequiredID and NestSolutionRequiredQuantity must be populated with the specific stock records and quantities to join and cut. |
| Public property | [JoinToLocation](fsreqSplicePackageTFS.JoinToLocation_Property.md) | The intermediate location where the stock will be joined into the long length. |
| Public property | [JoinToSecondaryLocation](fsreqSplicePackageTFS.JoinToSecondaryLocation_Property.md) | The intermediate secondary location where the stock will be joined into the long length. |
| Public property | [NestSolutionID](fsreqSplicePackageTFS.NestSolutionID_Property.md) | Unique ID of the splice package being cut. |
| Public property | [NestSolutionRequiredID](fsreqSplicePackageTFS.NestSolutionRequiredID_Property.md) | If IncludeAllRequired is false, the required stock records that are to be joined and cut. |
| Public property | [NestSolutionRequiredQuantity](fsreqSplicePackageTFS.NestSolutionRequiredQuantity_Property.md) | If IncludeAllRequired is false, the quantities of the required stock records that are to be joined and cut. Must have the same number of elements as NestSolutionRequiredID. |
| Public property | [OverrideAutomaticScrapSetting](fsreqSplicePackageTFS.OverrideAutomaticScrapSetting_Property.md) | If true, then override the scrap setting set for this shape and size in S/G/S |
| Public property | [OverrideAutomaticToInventory](fsreqSplicePackageTFS.OverrideAutomaticToInventory_Property.md) | If true, and OverrideAutomaticScrapSettings is true, then force any drop to go to Inventory. |
| Public property | [OverrideAutomaticToScrap](fsreqSplicePackageTFS.OverrideAutomaticToScrap_Property.md) | If true, and OverrideAutomaticScrapSettings is true, then force any drop to go to Scrap. |
| Public property | [PieceTrackingBatchID](fsreqSplicePackageTFS.PieceTrackingBatchID_Property.md) | The BatchID value to record for piece tracking purposes. |
| Public property | [PieceTrackingHours](fsreqSplicePackageTFS.PieceTrackingHours_Property.md) | The number of hours to record for piece tracking purposes. |
| Public property | [PieceTrackingUserID](fsreqSplicePackageTFS.PieceTrackingUserID_Property.md) | Identifies the user to record the records for piece tracking purposes. |
| Public property | [TFSResult](fsreqSplicePackageTFS.TFSResult_Property.md) | If IncludeAllRequired is false, the quantities of the required stock records that are to be joined and cut. Must have the same number of elements as NestSolutionRequiredID. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
