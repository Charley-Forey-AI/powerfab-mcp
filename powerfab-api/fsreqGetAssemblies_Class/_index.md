---
title: fsreqGetAssemblies Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-assemblies-class-78942
slug: fsreq-get-assemblies-class-78942
node_id: 78942
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetAssemblies Class
children:
- title: fsreqGetAssemblies Constructor
  kind: Constructor
  slug: fsreq-get-assemblies-constructor-78943
  path: fsreqGetAssemblies_Constructor.md
- title: fsreqGetAssemblies.Filters Property
  kind: Property
  slug: filters-property-78945
  path: fsreqGetAssemblies.Filters_Property.md
- title: fsreqGetAssemblies.FilterSet Property
  kind: Property
  slug: filter-set-property-78946
  path: fsreqGetAssemblies.FilterSet_Property.md
- title: fsreqGetAssemblies.InspectionTests Property
  kind: Property
  slug: inspection-tests-property-78947
  path: fsreqGetAssemblies.InspectionTests_Property.md
- title: fsreqGetAssemblies.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-78948
  path: fsreqGetAssemblies.InstanceNumbers_Property.md
- title: fsreqGetAssemblies.JobNumber Property
  kind: Property
  slug: job-number-property-78949
  path: fsreqGetAssemblies.JobNumber_Property.md
- title: fsreqGetAssemblies.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78950
  path: fsreqGetAssemblies.ProductionControlID_Property.md
---

# fsreqGetAssemblies Class

Retrieves the list of assemblies in a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetAssemblies

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetAssemblies : fsreqCommand
```

The fsreqGetAssemblies type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetAssemblies](fsreqGetAssemblies_Constructor.md) | fsreqGetAssemblies class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetAssemblies.Filters_Property.md) |  |
| Public property | [FilterSet](fsreqGetAssemblies.FilterSet_Property.md) |  |
| Public property | [InspectionTests](fsreqGetAssemblies.InspectionTests_Property.md) | If true then the inspection test summary is retrieved along with the assembly details. |
| Public property | [InstanceNumbers](fsreqGetAssemblies.InstanceNumbers_Property.md) | If true then the instance numbers retrieved along with the assembly details. |
| Public property | [JobNumber](fsreqGetAssemblies.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetAssemblies.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
