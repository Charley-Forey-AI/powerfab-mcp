---
title: fsreqWorkAreaDepartmentScheduleShift_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-department-schedule-shiftupsert-class-80746
slug: fsreq-work-area-department-schedule-shiftupsert-class-80746
node_id: 80746
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartmentScheduleShift_Upsert Class
children:
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert Constructor
  kind: Constructor
  slug: fsreq-work-area-department-schedule-shiftupsert-constructor-80747
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert_Constructor.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityHours Property
  kind: Property
  slug: capacity-hours-property-80749
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityHours_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityWeight Property
  kind: Property
  slug: capacity-weight-property-80750
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityWeight_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.DepartmentShiftID Property
  kind: Property
  slug: department-shift-id-property-80751
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.DepartmentShiftID_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.IsActive Property
  kind: Property
  slug: active-property-80752
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.IsActive_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80753
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleShiftID Property
  kind: Property
  slug: work-area-department-schedule-shift-id-property-80754
  path: fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleShiftID_Property.md
---

# fsreqWorkAreaDepartmentScheduleShift_Upsert Class

Inserts or updates into Tekla PowerFab WorkArea schedules shift

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartmentScheduleShift\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartmentScheduleShift_Upsert : fsreqCommand
```

The fsreqWorkAreaDepartmentScheduleShift\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartmentScheduleShift\_Upsert](fsreqWorkAreaDepartmentScheduleShift_Upsert_Constructor.md) | Initializes a new instance of the fsreqWorkAreaDepartmentScheduleShift\_Upsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CapacityHours](fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityHours_Property.md) | Capacity hours of the shift |
| Public property | [CapacityWeight](fsreqWorkAreaDepartmentScheduleShift_Upsert.CapacityWeight_Property.md) | Capacity weight of the shift |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentShiftID](fsreqWorkAreaDepartmentScheduleShift_Upsert.DepartmentShiftID_Property.md) | DepartmentShiftID |
| Public property | [IsActive](fsreqWorkAreaDepartmentScheduleShift_Upsert.IsActive_Property.md) | IsActive |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentScheduleID |
| Public property | [WorkAreaDepartmentScheduleShiftID](fsreqWorkAreaDepartmentScheduleShift_Upsert.WorkAreaDepartmentScheduleShiftID_Property.md) | WorkAreaDepartmentScheduleShiftID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
