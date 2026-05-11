---
title: fsreqWorkPackageDepartmentTask_Unschedule Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-taskunschedule-class-80909
slug: fsreq-work-package-department-taskunschedule-class-80909
node_id: 80909
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTask_Unschedule Class
children:
- title: fsreqWorkPackageDepartmentTask_Unschedule Constructor
  kind: Constructor
  slug: fsreq-work-package-department-taskunschedule-constructor-80910
  path: fsreqWorkPackageDepartmentTask_Unschedule_Constructor.md
- title: fsreqWorkPackageDepartmentTask_Unschedule.WorkPackageDepartmentTaskID Property
  kind: Property
  slug: work-package-department-task-id-property-80912
  path: fsreqWorkPackageDepartmentTask_Unschedule.WorkPackageDepartmentTaskID_Property.md
---

# fsreqWorkPackageDepartmentTask_Unschedule Class

Unschedules one or more work package department tasks.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTask\_Unschedule

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTask_Unschedule : fsreqCommand
```

The fsreqWorkPackageDepartmentTask\_Unschedule type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTask\_Unschedule](fsreqWorkPackageDepartmentTask_Unschedule_Constructor.md) | fsreqWorkPackageDepartmentTask\_Unschedule class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [WorkPackageDepartmentTaskID](fsreqWorkPackageDepartmentTask_Unschedule.WorkPackageDepartmentTaskID_Property.md) | Work Package Department Task Completion ID to delete |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
