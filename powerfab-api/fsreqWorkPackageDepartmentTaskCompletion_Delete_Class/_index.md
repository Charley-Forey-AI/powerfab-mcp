---
title: fsreqWorkPackageDepartmentTaskCompletion_Delete Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-task-completiondelete-class-80920
slug: fsreq-work-package-department-task-completiondelete-class-80920
node_id: 80920
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTaskCompletion_Delete Class
children:
- title: fsreqWorkPackageDepartmentTaskCompletion_Delete Constructor
  kind: Constructor
  slug: fsreq-work-package-department-task-completiondelete-constructor-80921
  path: fsreqWorkPackageDepartmentTaskCompletion_Delete_Constructor.md
- title: fsreqWorkPackageDepartmentTaskCompletion_Delete.WorkPackageDepartmentTaskCompletionID Property
  kind: Property
  slug: work-package-department-task-completion-id-property-80923
  path: fsreqWorkPackageDepartmentTaskCompletion_Delete.WorkPackageDepartmentTaskCompletionID_Property.md
---

# fsreqWorkPackageDepartmentTaskCompletion_Delete Class

Deletes one or more work package task completions.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTaskCompletion\_Delete

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTaskCompletion_Delete : fsreqCommand
```

The fsreqWorkPackageDepartmentTaskCompletion\_Delete type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTaskCompletion\_Delete](fsreqWorkPackageDepartmentTaskCompletion_Delete_Constructor.md) | fsreqWorkPackageDepartmentTaskCompletion\_Delete class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [WorkPackageDepartmentTaskCompletionID](fsreqWorkPackageDepartmentTaskCompletion_Delete.WorkPackageDepartmentTaskCompletionID_Property.md) | Work Package Department Task Completion ID to delete |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
