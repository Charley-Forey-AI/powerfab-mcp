---
title: fsreqWorkPackageDepartmentTaskCompletion_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-task-completionupdate-class-80937
slug: fsreq-work-package-department-task-completionupdate-class-80937
node_id: 80937
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTaskCompletion_Update Class
children:
- title: fsreqWorkPackageDepartmentTaskCompletion_Update Constructor
  kind: Constructor
  slug: fsreq-work-package-department-task-completionupdate-constructor-80938
  path: fsreqWorkPackageDepartmentTaskCompletion_Update_Constructor.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedHours Property
  kind: Property
  slug: completed-hours-property-80940
  path: fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedHours_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedWeight Property
  kind: Property
  slug: completed-weight-property-80941
  path: fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedWeight_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80942
  path: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskCompletionID Property
  kind: Property
  slug: work-package-department-task-completion-id-property-80943
  path: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskCompletionID_Property.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskID Property
  kind: Property
  slug: work-package-department-task-id-property-80944
  path: fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskID_Property.md
---

# fsreqWorkPackageDepartmentTaskCompletion_Update Class

Updates a work package department task completion.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTaskCompletion\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTaskCompletion_Update : fsreqCommand
```

The fsreqWorkPackageDepartmentTaskCompletion\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTaskCompletion\_Update](fsreqWorkPackageDepartmentTaskCompletion_Update_Constructor.md) | Initializes a new instance of the fsreqWorkPackageDepartmentTaskCompletion\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CompletedHours](fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedHours_Property.md) | new Completed Hours of work package department completion |
| Public property | [CompletedWeight](fsreqWorkPackageDepartmentTaskCompletion_Update.CompletedWeight_Property.md) | new Hours of work package department task completion |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkPackageDepartmentTaskCompletion_Update.WorkAreaDepartmentScheduleID_Property.md) | new Work Area Department Schedule ID to update |
| Public property | [WorkPackageDepartmentTaskCompletionID](fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskCompletionID_Property.md) | work package department task completion ID to update |
| Public property | [WorkPackageDepartmentTaskID](fsreqWorkPackageDepartmentTaskCompletion_Update.WorkPackageDepartmentTaskID_Property.md) | new Work Package Department Task ID of work package department task completion |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
