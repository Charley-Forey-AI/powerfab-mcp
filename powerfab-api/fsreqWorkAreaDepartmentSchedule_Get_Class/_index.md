---
title: fsreqWorkAreaDepartmentSchedule_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-department-scheduleget-class-80701
slug: fsreq-work-area-department-scheduleget-class-80701
node_id: 80701
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartmentSchedule_Get Class
children:
- title: fsreqWorkAreaDepartmentSchedule_Get Constructor
  kind: Constructor
  slug: fsreq-work-area-department-scheduleget-constructor-80702
  path: fsreqWorkAreaDepartmentSchedule_Get_Constructor.md
- title: fsreqWorkAreaDepartmentSchedule_Get.GetOptions Property
  kind: Property
  slug: get-options-property-80704
  path: fsreqWorkAreaDepartmentSchedule_Get.GetOptions_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80705
  path: fsreqWorkAreaDepartmentSchedule_Get.LastLogID_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Get.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80706
  path: fsreqWorkAreaDepartmentSchedule_Get.WorkAreaDepartmentScheduleID_Property.md
---

# fsreqWorkAreaDepartmentSchedule_Get Class

Retrieves one or more WorkArea schedules.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartmentSchedule\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartmentSchedule_Get : fsreqCommand
```

The fsreqWorkAreaDepartmentSchedule\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartmentSchedule\_Get](fsreqWorkAreaDepartmentSchedule_Get_Constructor.md) | fsreqWorkAreaDepartmentSchedule\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqWorkAreaDepartmentSchedule_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqWorkAreaDepartmentSchedule_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkAreaDepartmentSchedule_Get.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentSchedule ID to retrieve |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
