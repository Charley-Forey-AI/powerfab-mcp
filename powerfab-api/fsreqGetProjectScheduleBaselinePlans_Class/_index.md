---
title: fsreqGetProjectScheduleBaselinePlans Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-project-schedule-baseline-plans-class-79216
slug: fsreq-get-project-schedule-baseline-plans-class-79216
node_id: 79216
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProjectScheduleBaselinePlans Class
children:
- title: fsreqGetProjectScheduleBaselinePlans Constructor
  kind: Constructor
  slug: fsreq-get-project-schedule-baseline-plans-constructor-79217
  path: fsreqGetProjectScheduleBaselinePlans_Constructor.md
- title: fsreqGetProjectScheduleBaselinePlans.JobNumber Property
  kind: Property
  slug: job-number-property-79219
  path: fsreqGetProjectScheduleBaselinePlans.JobNumber_Property.md
- title: fsreqGetProjectScheduleBaselinePlans.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79220
  path: fsreqGetProjectScheduleBaselinePlans.ProductionControlID_Property.md
- title: fsreqGetProjectScheduleBaselinePlans.ProjectID Property
  kind: Property
  slug: project-id-property-79221
  path: fsreqGetProjectScheduleBaselinePlans.ProjectID_Property.md
---

# fsreqGetProjectScheduleBaselinePlans Class

Retrieves the baseline plans for a project.
One of ProjectID, ProductionControlID, or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProjectScheduleBaselinePlans

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProjectScheduleBaselinePlans : fsreqCommand
```

The fsreqGetProjectScheduleBaselinePlans type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProjectScheduleBaselinePlans](fsreqGetProjectScheduleBaselinePlans_Constructor.md) | Initializes a new instance of the fsreqGetProjectScheduleBaselinePlans class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [JobNumber](fsreqGetProjectScheduleBaselinePlans.JobNumber_Property.md) | The job number of the project to retrieve. |
| Public property | [ProductionControlID](fsreqGetProjectScheduleBaselinePlans.ProductionControlID_Property.md) | The unique identifier of the production control job to retrieve. |
| Public property | [ProjectID](fsreqGetProjectScheduleBaselinePlans.ProjectID_Property.md) | The unique identifier of the project to retrieve. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
