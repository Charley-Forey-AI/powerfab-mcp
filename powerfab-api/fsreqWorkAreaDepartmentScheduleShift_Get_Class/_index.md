---
title: fsreqWorkAreaDepartmentScheduleShift_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-department-schedule-shiftget-class-80740
slug: fsreq-work-area-department-schedule-shiftget-class-80740
node_id: 80740
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartmentScheduleShift_Get Class
children:
- title: fsreqWorkAreaDepartmentScheduleShift_Get Constructor
  kind: Constructor
  slug: fsreq-work-area-department-schedule-shiftget-constructor-80741
  path: fsreqWorkAreaDepartmentScheduleShift_Get_Constructor.md
- title: fsreqWorkAreaDepartmentScheduleShift_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80743
  path: fsreqWorkAreaDepartmentScheduleShift_Get.LastLogID_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80744
  path: fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleShiftID Property
  kind: Property
  slug: work-area-department-schedule-shift-id-property-80745
  path: fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleShiftID_Property.md
---

# fsreqWorkAreaDepartmentScheduleShift_Get Class

Retrieves one or more WorkArea schedule shifts.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartmentScheduleShift\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartmentScheduleShift_Get : fsreqCommand
```

The fsreqWorkAreaDepartmentScheduleShift\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartmentScheduleShift\_Get](fsreqWorkAreaDepartmentScheduleShift_Get_Constructor.md) | fsreqWorkAreaDepartmentScheduleShift\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqWorkAreaDepartmentScheduleShift_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentScheduleID to retrieve |
| Public property | [WorkAreaDepartmentScheduleShiftID](fsreqWorkAreaDepartmentScheduleShift_Get.WorkAreaDepartmentScheduleShiftID_Property.md) | WorkAreaDepartmentScheduleShiftID to retrieve |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
