---
title: fsreqWorkAreaDepartmentFutureTask_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-department-future-taskupsert-class-80688
slug: fsreq-work-area-department-future-taskupsert-class-80688
node_id: 80688
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartmentFutureTask_Upsert Class
children:
- title: fsreqWorkAreaDepartmentFutureTask_Upsert Constructor
  kind: Constructor
  slug: fsreq-work-area-department-future-taskupsert-constructor-80689
  path: fsreqWorkAreaDepartmentFutureTask_Upsert_Constructor.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.Description Property
  kind: Property
  slug: description-property-80691
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.Description_Property.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.Hours Property
  kind: Property
  slug: hours-property-80692
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.Hours_Property.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.Weight Property
  kind: Property
  slug: weight-property-80693
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.Weight_Property.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentFutureTaskID Property
  kind: Property
  slug: work-area-department-future-task-id-property-80694
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentFutureTaskID_Property.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentID Property
  kind: Property
  slug: work-area-department-id-property-80695
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentID_Property.md
- title: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80696
  path: fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentScheduleID_Property.md
---

# fsreqWorkAreaDepartmentFutureTask_Upsert Class

Inserts or updates into Tekla PowerFab WorkArea Department future task

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartmentFutureTask\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartmentFutureTask_Upsert : fsreqCommand
```

The fsreqWorkAreaDepartmentFutureTask\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartmentFutureTask\_Upsert](fsreqWorkAreaDepartmentFutureTask_Upsert_Constructor.md) | fsreqWorkAreaDepartmentFutureTask\_Upsert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Description](fsreqWorkAreaDepartmentFutureTask_Upsert.Description_Property.md) | Description |
| Public property | [Hours](fsreqWorkAreaDepartmentFutureTask_Upsert.Hours_Property.md) | Hours |
| Public property | [Weight](fsreqWorkAreaDepartmentFutureTask_Upsert.Weight_Property.md) | Weight |
| Public property | [WorkAreaDepartmentFutureTaskID](fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentFutureTaskID_Property.md) | WorkAreaDepartmentFutureTaskID |
| Public property | [WorkAreaDepartmentID](fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentID_Property.md) | WorkAreaDepartmentID |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkAreaDepartmentFutureTask_Upsert.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentScheduleID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
