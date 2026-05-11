---
title: fsreqWorkPackageDepartmentTaskCompletion_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-task-completioninsert-class-80930
slug: fsreq-work-package-department-task-completioninsert-class-80930
node_id: 80930
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTaskCompletion_Insert Class
children:
- title: fsreqWorkPackageDepartmentTaskCompletion_Insert Constructor
  kind: Constructor
  slug: fsreq-work-package-department-task-completioninsert-constructor-80931
  path: fsreqWorkPackageDepartmentTaskCompletion_Insert_Constructor.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedHours Property
  kind: Property
  slug: completed-hours-property-80933
  path: fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedHours_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedWeight Property
  kind: Property
  slug: completed-weight-property-80934
  path: fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedWeight_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80935
  path: fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkPackageDepartmentTaskID Property
  kind: Property
  slug: work-package-department-task-id-property-80936
  path: fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkPackageDepartmentTaskID_Property.md
---

# fsreqWorkPackageDepartmentTaskCompletion_Insert Class

Adds a new work package department task completion.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTaskCompletion\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTaskCompletion_Insert : fsreqCommand
```

The fsreqWorkPackageDepartmentTaskCompletion\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTaskCompletion\_Insert](fsreqWorkPackageDepartmentTaskCompletion_Insert_Constructor.md) | Initializes a new instance of the fsreqWorkPackageDepartmentTaskCompletion\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CompletedHours](fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedHours_Property.md) | Completed Hours of new work package department task completion |
| Public property | [CompletedWeight](fsreqWorkPackageDepartmentTaskCompletion_Insert.CompletedWeight_Property.md) | Completed Weight of new work package department task completion |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkAreaDepartmentScheduleID_Property.md) | Work Area Department Schedule ID of new work package department task completion |
| Public property | [WorkPackageDepartmentTaskID](fsreqWorkPackageDepartmentTaskCompletion_Insert.WorkPackageDepartmentTaskID_Property.md) | Work Package Department Task ID of new work package department task completion |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
