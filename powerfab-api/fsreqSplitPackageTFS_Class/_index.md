---
title: fsreqSplitPackageTFS Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-split-package-tfs-class-80489
slug: fsreq-split-package-tfs-class-80489
node_id: 80489
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSplitPackageTFS Class
children:
- title: fsreqSplitPackageTFS Constructor
  kind: Constructor
  slug: fsreq-split-package-tfs-constructor-80490
  path: fsreqSplitPackageTFS_Constructor.md
- title: fsreqSplitPackageTFS.IncludeAllRequired Property
  kind: Property
  slug: include-all-required-property-80492
  path: fsreqSplitPackageTFS.IncludeAllRequired_Property.md
- title: fsreqSplitPackageTFS.NestSolutionID Property
  kind: Property
  slug: nest-solution-id-property-80493
  path: fsreqSplitPackageTFS.NestSolutionID_Property.md
- title: fsreqSplitPackageTFS.NestSolutionRequiredID Property
  kind: Property
  slug: nest-solution-required-id-property-80494
  path: fsreqSplitPackageTFS.NestSolutionRequiredID_Property.md
- title: fsreqSplitPackageTFS.NestSolutionRequiredQuantity Property
  kind: Property
  slug: nest-solution-required-quantity-property-80495
  path: fsreqSplitPackageTFS.NestSolutionRequiredQuantity_Property.md
- title: fsreqSplitPackageTFS.OverrideAutomaticScrapSetting Property
  kind: Property
  slug: override-automatic-scrap-setting-property-80496
  path: fsreqSplitPackageTFS.OverrideAutomaticScrapSetting_Property.md
- title: fsreqSplitPackageTFS.OverrideAutomaticToInventory Property
  kind: Property
  slug: override-automatic-inventory-property-80497
  path: fsreqSplitPackageTFS.OverrideAutomaticToInventory_Property.md
- title: fsreqSplitPackageTFS.OverrideAutomaticToScrap Property
  kind: Property
  slug: override-automatic-scrap-property-80498
  path: fsreqSplitPackageTFS.OverrideAutomaticToScrap_Property.md
- title: fsreqSplitPackageTFS.PieceTrackingBatchID Property
  kind: Property
  slug: piece-tracking-batch-id-property-80499
  path: fsreqSplitPackageTFS.PieceTrackingBatchID_Property.md
- title: fsreqSplitPackageTFS.PieceTrackingHours Property
  kind: Property
  slug: piece-tracking-hours-property-80500
  path: fsreqSplitPackageTFS.PieceTrackingHours_Property.md
- title: fsreqSplitPackageTFS.PieceTrackingUserID Property
  kind: Property
  slug: piece-tracking-user-id-property-80501
  path: fsreqSplitPackageTFS.PieceTrackingUserID_Property.md
- title: fsreqSplitPackageTFS.TFSResult Property
  kind: Property
  slug: tfs-result-property-80502
  path: fsreqSplitPackageTFS.TFSResult_Property.md
---

# fsreqSplitPackageTFS Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSplitPackageTFS

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSplitPackageTFS : fsreqCommand
```

The fsreqSplitPackageTFS type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSplitPackageTFS](fsreqSplitPackageTFS_Constructor.md) | fsreqSplitPackageTFS class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [IncludeAllRequired](fsreqSplitPackageTFS.IncludeAllRequired_Property.md) | If true, then all of the required stock records are to be joined and cut. If false, then NestSolutionRequiredID and NestSolutionRequiredQuantity must be populated with the specific stock records and quantities to join and cut. |
| Public property | [NestSolutionID](fsreqSplitPackageTFS.NestSolutionID_Property.md) | Unique ID of the splice package being cut. |
| Public property | [NestSolutionRequiredID](fsreqSplitPackageTFS.NestSolutionRequiredID_Property.md) | If IncludeAllRequired is false, the required stock records that are to be joined and cut. |
| Public property | [NestSolutionRequiredQuantity](fsreqSplitPackageTFS.NestSolutionRequiredQuantity_Property.md) | If IncludeAllRequired is false, the quantities of the required stock records that are to be joined and cut. Must have the same number of elements as NestSolutionRequiredID. |
| Public property | [OverrideAutomaticScrapSetting](fsreqSplitPackageTFS.OverrideAutomaticScrapSetting_Property.md) | If true, then override the scrap setting set for this shape and size in S/G/S |
| Public property | [OverrideAutomaticToInventory](fsreqSplitPackageTFS.OverrideAutomaticToInventory_Property.md) | If true, and OverrideAutomaticScrapSettings is true, then force any drop to go to Inventory. |
| Public property | [OverrideAutomaticToScrap](fsreqSplitPackageTFS.OverrideAutomaticToScrap_Property.md) | If true, and OverrideAutomaticScrapSettings is true, then force any drop to go to Scrap. |
| Public property | [PieceTrackingBatchID](fsreqSplitPackageTFS.PieceTrackingBatchID_Property.md) | The BatchID value to record for piece tracking purposes. |
| Public property | [PieceTrackingHours](fsreqSplitPackageTFS.PieceTrackingHours_Property.md) | The number of hours to record for piece tracking purposes. |
| Public property | [PieceTrackingUserID](fsreqSplitPackageTFS.PieceTrackingUserID_Property.md) | Identifies the user to record the records for piece tracking purposes. |
| Public property | [TFSResult](fsreqSplitPackageTFS.TFSResult_Property.md) | If IncludeAllRequired is false, the quantities of the required stock records that are to be joined and cut. Must have the same number of elements as NestSolutionRequiredID. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
