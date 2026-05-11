---
title: fsreqWorkPackage_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-packageinsert-class-80793
slug: fsreq-work-packageinsert-class-80793
node_id: 80793
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackage_Insert Class
children:
- title: fsreqWorkPackage_Insert Constructor
  kind: Constructor
  slug: fsreq-work-packageinsert-constructor-80794
  path: fsreqWorkPackage_Insert_Constructor.md
- title: fsreqWorkPackage_Insert.Description Property
  kind: Property
  slug: description-property-80796
  path: fsreqWorkPackage_Insert.Description_Property.md
- title: fsreqWorkPackage_Insert.DueDate Property
  kind: Property
  slug: due-date-property-80797
  path: fsreqWorkPackage_Insert.DueDate_Property.md
- title: fsreqWorkPackage_Insert.Group1 Property
  kind: Property
  slug: group1-property-80798
  path: fsreqWorkPackage_Insert.Group1_Property.md
- title: fsreqWorkPackage_Insert.Group2 Property
  kind: Property
  slug: group2-property-80799
  path: fsreqWorkPackage_Insert.Group2_Property.md
- title: fsreqWorkPackage_Insert.IsFuture Property
  kind: Property
  slug: future-property-80800
  path: fsreqWorkPackage_Insert.IsFuture_Property.md
- title: fsreqWorkPackage_Insert.Notes Property
  kind: Property
  slug: notes-property-80801
  path: fsreqWorkPackage_Insert.Notes_Property.md
- title: fsreqWorkPackage_Insert.Priority Property
  kind: Property
  slug: priority-property-80802
  path: fsreqWorkPackage_Insert.Priority_Property.md
- title: fsreqWorkPackage_Insert.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80803
  path: fsreqWorkPackage_Insert.ProductionControlID_Property.md
- title: fsreqWorkPackage_Insert.StartDate Property
  kind: Property
  slug: start-date-property-80804
  path: fsreqWorkPackage_Insert.StartDate_Property.md
- title: fsreqWorkPackage_Insert.Status Property
  kind: Property
  slug: status-property-80805
  path: fsreqWorkPackage_Insert.Status_Property.md
- title: fsreqWorkPackage_Insert.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-80806
  path: fsreqWorkPackage_Insert.WorkPackageNumber_Property.md
- title: fsreqWorkPackage_Insert.WorkshopID Property
  kind: Property
  slug: workshop-id-property-80807
  path: fsreqWorkPackage_Insert.WorkshopID_Property.md
---

# fsreqWorkPackage_Insert Class

Adds a new work package.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackage\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackage_Insert : fsreqCommand
```

The fsreqWorkPackage\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackage\_Insert](fsreqWorkPackage_Insert_Constructor.md) | Initializes a new instance of the fsreqWorkPackage\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Description](fsreqWorkPackage_Insert.Description_Property.md) | Description of new work package |
| Public property | [DueDate](fsreqWorkPackage_Insert.DueDate_Property.md) | Due date of new work package |
| Public property | [Group1](fsreqWorkPackage_Insert.Group1_Property.md) | Group1 of new work package |
| Public property | [Group2](fsreqWorkPackage_Insert.Group2_Property.md) | Group2 of new work package |
| Public property | [IsFuture](fsreqWorkPackage_Insert.IsFuture_Property.md) | True if this is a future work package |
| Public property | [Notes](fsreqWorkPackage_Insert.Notes_Property.md) | Notes for work package |
| Public property | [Priority](fsreqWorkPackage_Insert.Priority_Property.md) | Priority of new work package |
| Public property | [ProductionControlID](fsreqWorkPackage_Insert.ProductionControlID_Property.md) | Production Control ID of job that contains the new work package |
| Public property | [StartDate](fsreqWorkPackage_Insert.StartDate_Property.md) | Start date of new work package |
| Public property | [Status](fsreqWorkPackage_Insert.Status_Property.md) | Status of new work package |
| Public property | [WorkPackageNumber](fsreqWorkPackage_Insert.WorkPackageNumber_Property.md) | Name of new work package |
| Public property | [WorkshopID](fsreqWorkPackage_Insert.WorkshopID_Property.md) | Workshop ID of new work package |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
