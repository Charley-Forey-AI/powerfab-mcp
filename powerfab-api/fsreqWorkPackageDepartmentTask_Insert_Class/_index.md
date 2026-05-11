---
title: fsreqWorkPackageDepartmentTask_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-taskinsert-class-80885
slug: fsreq-work-package-department-taskinsert-class-80885
node_id: 80885
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTask_Insert Class
children:
- title: fsreqWorkPackageDepartmentTask_Insert Constructor
  kind: Constructor
  slug: fsreq-work-package-department-taskinsert-constructor-80886
  path: fsreqWorkPackageDepartmentTask_Insert_Constructor.md
- title: fsreqWorkPackageDepartmentTask_Insert.Hours Property
  kind: Property
  slug: hours-property-80888
  path: fsreqWorkPackageDepartmentTask_Insert.Hours_Property.md
- title: fsreqWorkPackageDepartmentTask_Insert.Weight Property
  kind: Property
  slug: weight-property-80889
  path: fsreqWorkPackageDepartmentTask_Insert.Weight_Property.md
- title: fsreqWorkPackageDepartmentTask_Insert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80890
  path: fsreqWorkPackageDepartmentTask_Insert.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkPackageDepartmentTask_Insert.WorkPackageDepartmentID Property
  kind: Property
  slug: work-package-department-id-property-80891
  path: fsreqWorkPackageDepartmentTask_Insert.WorkPackageDepartmentID_Property.md
---

# fsreqWorkPackageDepartmentTask_Insert Class

Inserts one work package department task for a future work package.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTask\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTask_Insert : fsreqCommand
```

The fsreqWorkPackageDepartmentTask\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTask\_Insert](fsreqWorkPackageDepartmentTask_Insert_Constructor.md) | Initializes a new instance of the fsreqWorkPackageDepartmentTask\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Hours](fsreqWorkPackageDepartmentTask_Insert.Hours_Property.md) |  |
| Public property | [Weight](fsreqWorkPackageDepartmentTask_Insert.Weight_Property.md) |  |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkPackageDepartmentTask_Insert.WorkAreaDepartmentScheduleID_Property.md) |  |
| Public property | [WorkPackageDepartmentID](fsreqWorkPackageDepartmentTask_Insert.WorkPackageDepartmentID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
