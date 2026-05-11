---
title: fsreqWorkPackage_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-packageupdate-class-80823
slug: fsreq-work-packageupdate-class-80823
node_id: 80823
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackage_Update Class
children:
- title: fsreqWorkPackage_Update Constructor
  kind: Constructor
  slug: fsreq-work-packageupdate-constructor-80824
  path: fsreqWorkPackage_Update_Constructor.md
- title: fsreqWorkPackage_Update.CompletedManual Property
  kind: Property
  slug: completed-manual-property-80826
  path: fsreqWorkPackage_Update.CompletedManual_Property.md
- title: fsreqWorkPackage_Update.Description Property
  kind: Property
  slug: description-property-80827
  path: fsreqWorkPackage_Update.Description_Property.md
- title: fsreqWorkPackage_Update.DueDate Property
  kind: Property
  slug: due-date-property-80828
  path: fsreqWorkPackage_Update.DueDate_Property.md
- title: fsreqWorkPackage_Update.Group1 Property
  kind: Property
  slug: group1-property-80829
  path: fsreqWorkPackage_Update.Group1_Property.md
- title: fsreqWorkPackage_Update.Group2 Property
  kind: Property
  slug: group2-property-80830
  path: fsreqWorkPackage_Update.Group2_Property.md
- title: fsreqWorkPackage_Update.Notes Property
  kind: Property
  slug: notes-property-80831
  path: fsreqWorkPackage_Update.Notes_Property.md
- title: fsreqWorkPackage_Update.OnHold Property
  kind: Property
  slug: hold-property-80832
  path: fsreqWorkPackage_Update.OnHold_Property.md
- title: fsreqWorkPackage_Update.OnHoldNotes Property
  kind: Property
  slug: hold-notes-property-80833
  path: fsreqWorkPackage_Update.OnHoldNotes_Property.md
- title: fsreqWorkPackage_Update.Priority Property
  kind: Property
  slug: priority-property-80834
  path: fsreqWorkPackage_Update.Priority_Property.md
- title: fsreqWorkPackage_Update.ReleasedToFab Property
  kind: Property
  slug: released-fab-property-80835
  path: fsreqWorkPackage_Update.ReleasedToFab_Property.md
- title: fsreqWorkPackage_Update.StartDate Property
  kind: Property
  slug: start-date-property-80836
  path: fsreqWorkPackage_Update.StartDate_Property.md
- title: fsreqWorkPackage_Update.Status Property
  kind: Property
  slug: status-property-80837
  path: fsreqWorkPackage_Update.Status_Property.md
- title: fsreqWorkPackage_Update.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80838
  path: fsreqWorkPackage_Update.WorkPackageID_Property.md
- title: fsreqWorkPackage_Update.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-80839
  path: fsreqWorkPackage_Update.WorkPackageNumber_Property.md
- title: fsreqWorkPackage_Update.WorkshopID Property
  kind: Property
  slug: workshop-id-property-80840
  path: fsreqWorkPackage_Update.WorkshopID_Property.md
---

# fsreqWorkPackage_Update Class

Updates a work package.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackage\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackage_Update : fsreqCommand
```

The fsreqWorkPackage\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackage\_Update](fsreqWorkPackage_Update_Constructor.md) | Initializes a new instance of the fsreqWorkPackage\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CompletedManual](fsreqWorkPackage_Update.CompletedManual_Property.md) | True if work package has been manually completed |
| Public property | [Description](fsreqWorkPackage_Update.Description_Property.md) | new Description of work package |
| Public property | [DueDate](fsreqWorkPackage_Update.DueDate_Property.md) | new Due date of work package |
| Public property | [Group1](fsreqWorkPackage_Update.Group1_Property.md) | new Group1 of work package |
| Public property | [Group2](fsreqWorkPackage_Update.Group2_Property.md) | new Group2 of work package |
| Public property | [Notes](fsreqWorkPackage_Update.Notes_Property.md) | new Notes for work package |
| Public property | [OnHold](fsreqWorkPackage_Update.OnHold_Property.md) | True if work package is on hold |
| Public property | [OnHoldNotes](fsreqWorkPackage_Update.OnHoldNotes_Property.md) | new Notes about the hold for the work package |
| Public property | [Priority](fsreqWorkPackage_Update.Priority_Property.md) | new Priority of work package |
| Public property | [ReleasedToFab](fsreqWorkPackage_Update.ReleasedToFab_Property.md) | True if work package has been release for fabrication |
| Public property | [StartDate](fsreqWorkPackage_Update.StartDate_Property.md) | new Start date of work package |
| Public property | [Status](fsreqWorkPackage_Update.Status_Property.md) | new Status of work package |
| Public property | [WorkPackageID](fsreqWorkPackage_Update.WorkPackageID_Property.md) | Work Package ID to update |
| Public property | [WorkPackageNumber](fsreqWorkPackage_Update.WorkPackageNumber_Property.md) | new Name of work package |
| Public property | [WorkshopID](fsreqWorkPackage_Update.WorkshopID_Property.md) | new Workshop ID of ork package |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
