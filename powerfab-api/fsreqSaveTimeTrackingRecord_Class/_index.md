---
title: fsreqSaveTimeTrackingRecord Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-save-time-tracking-record-class-80386
slug: fsreq-save-time-tracking-record-class-80386
node_id: 80386
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSaveTimeTrackingRecord Class
children:
- title: fsreqSaveTimeTrackingRecord Constructor
  kind: Constructor
  slug: fsreq-save-time-tracking-record-constructor-80387
  path: fsreqSaveTimeTrackingRecord_Constructor.md
- title: fsreqSaveTimeTrackingRecord.DeductionHours Property
  kind: Property
  slug: deduction-hours-property-80389
  path: fsreqSaveTimeTrackingRecord.DeductionHours_Property.md
- title: fsreqSaveTimeTrackingRecord.EmployeeUserID Property
  kind: Property
  slug: employee-user-id-property-80390
  path: fsreqSaveTimeTrackingRecord.EmployeeUserID_Property.md
- title: fsreqSaveTimeTrackingRecord.EndDateTime Property
  kind: Property
  slug: end-date-time-property-80391
  path: fsreqSaveTimeTrackingRecord.EndDateTime_Property.md
- title: fsreqSaveTimeTrackingRecord.JobNumber Property
  kind: Property
  slug: job-number-property-80392
  path: fsreqSaveTimeTrackingRecord.JobNumber_Property.md
- title: fsreqSaveTimeTrackingRecord.Overtime2Hours Property
  kind: Property
  slug: overtime2-hours-property-80393
  path: fsreqSaveTimeTrackingRecord.Overtime2Hours_Property.md
- title: fsreqSaveTimeTrackingRecord.OvertimeHours Property
  kind: Property
  slug: overtime-hours-property-80394
  path: fsreqSaveTimeTrackingRecord.OvertimeHours_Property.md
- title: fsreqSaveTimeTrackingRecord.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80395
  path: fsreqSaveTimeTrackingRecord.ProductionControlID_Property.md
- title: fsreqSaveTimeTrackingRecord.RegularHours Property
  kind: Property
  slug: regular-hours-property-80396
  path: fsreqSaveTimeTrackingRecord.RegularHours_Property.md
- title: fsreqSaveTimeTrackingRecord.StartDate Property
  kind: Property
  slug: start-date-property-80397
  path: fsreqSaveTimeTrackingRecord.StartDate_Property.md
- title: fsreqSaveTimeTrackingRecord.StartDateTime Property
  kind: Property
  slug: start-date-time-property-80398
  path: fsreqSaveTimeTrackingRecord.StartDateTime_Property.md
- title: fsreqSaveTimeTrackingRecord.StationID Property
  kind: Property
  slug: station-id-property-80399
  path: fsreqSaveTimeTrackingRecord.StationID_Property.md
- title: fsreqSaveTimeTrackingRecord.SubjectFields Property
  kind: Property
  slug: subject-fields-property-80400
  path: fsreqSaveTimeTrackingRecord.SubjectFields_Property.md
- title: fsreqSaveTimeTrackingRecord.TaskID Property
  kind: Property
  slug: task-id-property-80401
  path: fsreqSaveTimeTrackingRecord.TaskID_Property.md
---

# fsreqSaveTimeTrackingRecord Class

Adds a time tracking record.
Either ProductionControlID or JobNumber must be specified.
Either StartDate or StartDateTime must be specified.
If StartDateTime is specified then EndDateTime must also be included.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSaveTimeTrackingRecord

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSaveTimeTrackingRecord : fsreqCommand
```

The fsreqSaveTimeTrackingRecord type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSaveTimeTrackingRecord](fsreqSaveTimeTrackingRecord_Constructor.md) | fsreqSaveTimeTrackingRecord class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DeductionHours](fsreqSaveTimeTrackingRecord.DeductionHours_Property.md) |  |
| Public property | [EmployeeUserID](fsreqSaveTimeTrackingRecord.EmployeeUserID_Property.md) |  |
| Public property | [EndDateTime](fsreqSaveTimeTrackingRecord.EndDateTime_Property.md) |  |
| Public property | [JobNumber](fsreqSaveTimeTrackingRecord.JobNumber_Property.md) |  |
| Public property | [Overtime2Hours](fsreqSaveTimeTrackingRecord.Overtime2Hours_Property.md) |  |
| Public property | [OvertimeHours](fsreqSaveTimeTrackingRecord.OvertimeHours_Property.md) |  |
| Public property | [ProductionControlID](fsreqSaveTimeTrackingRecord.ProductionControlID_Property.md) |  |
| Public property | [RegularHours](fsreqSaveTimeTrackingRecord.RegularHours_Property.md) |  |
| Public property | [StartDate](fsreqSaveTimeTrackingRecord.StartDate_Property.md) |  |
| Public property | [StartDateTime](fsreqSaveTimeTrackingRecord.StartDateTime_Property.md) |  |
| Public property | [StationID](fsreqSaveTimeTrackingRecord.StationID_Property.md) |  |
| Public property | [SubjectFields](fsreqSaveTimeTrackingRecord.SubjectFields_Property.md) |  |
| Public property | [TaskID](fsreqSaveTimeTrackingRecord.TaskID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
