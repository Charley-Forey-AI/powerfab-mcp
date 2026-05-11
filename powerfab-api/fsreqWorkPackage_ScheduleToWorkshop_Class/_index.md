---
title: fsreqWorkPackage_ScheduleToWorkshop Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-packageschedule-workshop-class-80813
slug: fsreq-work-packageschedule-workshop-class-80813
node_id: 80813
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackage_ScheduleToWorkshop Class
children:
- title: fsreqWorkPackage_ScheduleToWorkshop Constructor
  kind: Constructor
  slug: fsreq-work-packageschedule-workshop-constructor-80814
  path: fsreqWorkPackage_ScheduleToWorkshop_Constructor.md
- title: fsreqWorkPackage_ScheduleToWorkshop.ScheduledDate Property
  kind: Property
  slug: scheduled-date-property-80816
  path: fsreqWorkPackage_ScheduleToWorkshop.ScheduledDate_Property.md
- title: fsreqWorkPackage_ScheduleToWorkshop.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80817
  path: fsreqWorkPackage_ScheduleToWorkshop.WorkPackageID_Property.md
- title: fsreqWorkPackage_ScheduleToWorkshop.WorkshopID Property
  kind: Property
  slug: workshop-id-property-80818
  path: fsreqWorkPackage_ScheduleToWorkshop.WorkshopID_Property.md
---

# fsreqWorkPackage_ScheduleToWorkshop Class

Schedules one or more work packages.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackage\_ScheduleToWorkshop

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackage_ScheduleToWorkshop : fsreqCommand
```

The fsreqWorkPackage\_ScheduleToWorkshop type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackage\_ScheduleToWorkshop](fsreqWorkPackage_ScheduleToWorkshop_Constructor.md) | Initializes a new instance of the fsreqWorkPackage\_ScheduleToWorkshop class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ScheduledDate](fsreqWorkPackage_ScheduleToWorkshop.ScheduledDate_Property.md) | ScheduledDate to update |
| Public property | [WorkPackageID](fsreqWorkPackage_ScheduleToWorkshop.WorkPackageID_Property.md) | WorkPackageID to update |
| Public property | [WorkshopID](fsreqWorkPackage_ScheduleToWorkshop.WorkshopID_Property.md) | WorkshopID to update |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
