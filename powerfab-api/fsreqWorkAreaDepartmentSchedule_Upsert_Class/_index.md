---
title: fsreqWorkAreaDepartmentSchedule_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-department-scheduleupsert-class-80721
slug: fsreq-work-area-department-scheduleupsert-class-80721
node_id: 80721
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartmentSchedule_Upsert Class
children:
- title: fsreqWorkAreaDepartmentSchedule_Upsert Constructor
  kind: Constructor
  slug: fsreq-work-area-department-scheduleupsert-constructor-80722
  path: fsreqWorkAreaDepartmentSchedule_Upsert_Constructor.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityHours Property
  kind: Property
  slug: available-capacity-hours-property-80724
  path: fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityHours_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityWeight Property
  kind: Property
  slug: available-capacity-weight-property-80725
  path: fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityWeight_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.CompletedHours Property
  kind: Property
  slug: completed-hours-property-80726
  path: fsreqWorkAreaDepartmentSchedule_Upsert.CompletedHours_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.CompletedWeight Property
  kind: Property
  slug: completed-weight-property-80727
  path: fsreqWorkAreaDepartmentSchedule_Upsert.CompletedWeight_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.EndDate Property
  kind: Property
  slug: end-date-property-80728
  path: fsreqWorkAreaDepartmentSchedule_Upsert.EndDate_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledHours Property
  kind: Property
  slug: scheduled-hours-property-80729
  path: fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledHours_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledWeight Property
  kind: Property
  slug: scheduled-weight-property-80730
  path: fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledWeight_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.StartDate Property
  kind: Property
  slug: start-date-property-80731
  path: fsreqWorkAreaDepartmentSchedule_Upsert.StartDate_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityHours Property
  kind: Property
  slug: total-capacity-hours-property-80732
  path: fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityHours_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityWeight Property
  kind: Property
  slug: total-capacity-weight-property-80733
  path: fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityWeight_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentID Property
  kind: Property
  slug: work-area-department-id-property-80734
  path: fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentID_Property.md
- title: fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80735
  path: fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentScheduleID_Property.md
---

# fsreqWorkAreaDepartmentSchedule_Upsert Class

Inserts or updates into Tekla PowerFab WorkArea resource future task

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartmentSchedule\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartmentSchedule_Upsert : fsreqCommand
```

The fsreqWorkAreaDepartmentSchedule\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartmentSchedule\_Upsert](fsreqWorkAreaDepartmentSchedule_Upsert_Constructor.md) | Initializes a new instance of the fsreqWorkAreaDepartmentSchedule\_Upsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [AvailableCapacityHours](fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityHours_Property.md) | Available Capacity Hours |
| Public property | [AvailableCapacityWeight](fsreqWorkAreaDepartmentSchedule_Upsert.AvailableCapacityWeight_Property.md) | Available Capacity Weight |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CompletedHours](fsreqWorkAreaDepartmentSchedule_Upsert.CompletedHours_Property.md) | CompletedHours |
| Public property | [CompletedWeight](fsreqWorkAreaDepartmentSchedule_Upsert.CompletedWeight_Property.md) | Completed Weight |
| Public property | [EndDate](fsreqWorkAreaDepartmentSchedule_Upsert.EndDate_Property.md) | End Date - required for insert |
| Public property | [ScheduledHours](fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledHours_Property.md) | Scheduled Hours |
| Public property | [ScheduledWeight](fsreqWorkAreaDepartmentSchedule_Upsert.ScheduledWeight_Property.md) | Scheduled Weight |
| Public property | [StartDate](fsreqWorkAreaDepartmentSchedule_Upsert.StartDate_Property.md) | Start Date - required for insert |
| Public property | [TotalCapacityHours](fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityHours_Property.md) | Total Capacity Hours |
| Public property | [TotalCapacityWeight](fsreqWorkAreaDepartmentSchedule_Upsert.TotalCapacityWeight_Property.md) | Total Capacity Weight |
| Public property | [WorkAreaDepartmentID](fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentID_Property.md) | WorkAreaDepartmentID - required for insert |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkAreaDepartmentSchedule_Upsert.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentScheduleID - required for update |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
