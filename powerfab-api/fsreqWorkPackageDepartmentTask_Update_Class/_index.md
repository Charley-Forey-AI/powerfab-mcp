---
title: fsreqWorkPackageDepartmentTask_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-taskupdate-class-80913
slug: fsreq-work-package-department-taskupdate-class-80913
node_id: 80913
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTask_Update Class
children:
- title: fsreqWorkPackageDepartmentTask_Update Constructor
  kind: Constructor
  slug: fsreq-work-package-department-taskupdate-constructor-80914
  path: fsreqWorkPackageDepartmentTask_Update_Constructor.md
- title: fsreqWorkPackageDepartmentTask_Update.Hours Property
  kind: Property
  slug: hours-property-80916
  path: fsreqWorkPackageDepartmentTask_Update.Hours_Property.md
- title: fsreqWorkPackageDepartmentTask_Update.Weight Property
  kind: Property
  slug: weight-property-80917
  path: fsreqWorkPackageDepartmentTask_Update.Weight_Property.md
- title: fsreqWorkPackageDepartmentTask_Update.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80918
  path: fsreqWorkPackageDepartmentTask_Update.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkPackageDepartmentTask_Update.WorkPackageDepartmentTaskID Property
  kind: Property
  slug: work-package-department-task-id-property-80919
  path: fsreqWorkPackageDepartmentTask_Update.WorkPackageDepartmentTaskID_Property.md
---

# fsreqWorkPackageDepartmentTask_Update Class

Updates one work package department task for a future work package.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTask\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTask_Update : fsreqCommand
```

The fsreqWorkPackageDepartmentTask\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTask\_Update](fsreqWorkPackageDepartmentTask_Update_Constructor.md) | Initializes a new instance of the fsreqWorkPackageDepartmentTask\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Hours](fsreqWorkPackageDepartmentTask_Update.Hours_Property.md) |  |
| Public property | [Weight](fsreqWorkPackageDepartmentTask_Update.Weight_Property.md) |  |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkPackageDepartmentTask_Update.WorkAreaDepartmentScheduleID_Property.md) |  |
| Public property | [WorkPackageDepartmentTaskID](fsreqWorkPackageDepartmentTask_Update.WorkPackageDepartmentTaskID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
