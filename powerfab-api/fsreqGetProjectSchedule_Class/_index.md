---
title: fsreqGetProjectSchedule Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-project-schedule-class-79211
slug: fsreq-get-project-schedule-class-79211
node_id: 79211
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProjectSchedule Class
children:
- title: fsreqGetProjectSchedule Constructor
  kind: Constructor
  slug: fsreq-get-project-schedule-constructor-79212
  path: fsreqGetProjectSchedule_Constructor.md
- title: fsreqGetProjectSchedule.ScheduleBaselineID Property
  kind: Property
  slug: schedule-baseline-id-property-79214
  path: fsreqGetProjectSchedule.ScheduleBaselineID_Property.md
- title: fsreqGetProjectSchedule.ScheduleSnapshotID Property
  kind: Property
  slug: schedule-snapshot-id-property-79215
  path: fsreqGetProjectSchedule.ScheduleSnapshotID_Property.md
---

# fsreqGetProjectSchedule Class

Retrieves the breakdown elements, tasks, and task links for a baseline plan - optionally at a snapshot.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProjectSchedule

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProjectSchedule : fsreqCommand
```

The fsreqGetProjectSchedule type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProjectSchedule](fsreqGetProjectSchedule_Constructor.md) | Initializes a new instance of the fsreqGetProjectSchedule class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ScheduleBaselineID](fsreqGetProjectSchedule.ScheduleBaselineID_Property.md) | The unique identifier of the baseline plan to retrieve. |
| Public property | [ScheduleSnapshotID](fsreqGetProjectSchedule.ScheduleSnapshotID_Property.md) | The unique identifier of the snapshot of the baseline plan to retrieve. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
