---
title: fsreqGetProductionControlJobs Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-production-control-jobs-class-79189
slug: fsreq-get-production-control-jobs-class-79189
node_id: 79189
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProductionControlJobs Class
children:
- title: fsreqGetProductionControlJobs Constructor
  kind: Constructor
  slug: fsreq-get-production-control-jobs-constructor-79190
  path: fsreqGetProductionControlJobs_Constructor.md
- title: fsreqGetProductionControlJobs.GroupName Property
  kind: Property
  slug: group-name-property-79192
  path: fsreqGetProductionControlJobs.GroupName_Property.md
- title: fsreqGetProductionControlJobs.GroupName2 Property
  kind: Property
  slug: group-name2-property-79193
  path: fsreqGetProductionControlJobs.GroupName2_Property.md
- title: fsreqGetProductionControlJobs.IncludeClosedJobs Property
  kind: Property
  slug: include-closed-jobs-property-79194
  path: fsreqGetProductionControlJobs.IncludeClosedJobs_Property.md
- title: fsreqGetProductionControlJobs.JobNumber Property
  kind: Property
  slug: job-number-property-79195
  path: fsreqGetProductionControlJobs.JobNumber_Property.md
- title: fsreqGetProductionControlJobs.OnlyContainingCutLists Property
  kind: Property
  slug: only-containing-cut-lists-property-79196
  path: fsreqGetProductionControlJobs.OnlyContainingCutLists_Property.md
- title: fsreqGetProductionControlJobs.OnlyLinkedToProject Property
  kind: Property
  slug: only-linked-project-property-79197
  path: fsreqGetProductionControlJobs.OnlyLinkedToProject_Property.md
- title: fsreqGetProductionControlJobs.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79198
  path: fsreqGetProductionControlJobs.ProductionControlID_Property.md
- title: fsreqGetProductionControlJobs.UseLastGroups Property
  kind: Property
  slug: use-last-groups-property-79199
  path: fsreqGetProductionControlJobs.UseLastGroups_Property.md
---

# fsreqGetProductionControlJobs Class

Retrieves a concise list of Production Control jobs.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProductionControlJobs

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProductionControlJobs : fsreqCommand
```

The fsreqGetProductionControlJobs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProductionControlJobs](fsreqGetProductionControlJobs_Constructor.md) | fsreqGetProductionControlJobs class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GroupName](fsreqGetProductionControlJobs.GroupName_Property.md) | GroupName to restrict the result to. |
| Public property | [GroupName2](fsreqGetProductionControlJobs.GroupName2_Property.md) | GroupName2 to restrict the result to. |
| Public property | [IncludeClosedJobs](fsreqGetProductionControlJobs.IncludeClosedJobs_Property.md) | If false or not specified, then only open production control jobs will be returned. |
| Public property | [JobNumber](fsreqGetProductionControlJobs.JobNumber_Property.md) | Job # to restrict the result to. |
| Public property | [OnlyContainingCutLists](fsreqGetProductionControlJobs.OnlyContainingCutLists_Property.md) | If true, then only production control jobs that contain at least one uncut and not-invalidated cut list will be returned. Also, number of cut lists job contains will be added to response. |
| Public property | [OnlyLinkedToProject](fsreqGetProductionControlJobs.OnlyLinkedToProject_Property.md) | If true, then only production control jobs that are linked to a project management job will be retrieved. |
| Public property | [ProductionControlID](fsreqGetProductionControlJobs.ProductionControlID_Property.md) | ProductionControlID to restrict the result to. |
| Public property | [UseLastGroups](fsreqGetProductionControlJobs.UseLastGroups_Property.md) | Use the last GroupName and GroupName2 selections that the current user set in FabSuite to restrict the result. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
