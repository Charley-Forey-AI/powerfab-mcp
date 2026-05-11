---
title: fsreqGetModelObjectIDs Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-model-object-i-ds-class-79149
slug: fsreq-get-model-object-i-ds-class-79149
node_id: 79149
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetModelObjectIDs Class
children:
- title: fsreqGetModelObjectIDs Constructor
  kind: Constructor
  slug: fsreq-get-model-object-i-ds-constructor-79150
  path: fsreqGetModelObjectIDs_Constructor.md
- title: fsreqGetModelObjectIDs.AssemblyObjectOnly Property
  kind: Property
  slug: assembly-object-only-property-79152
  path: fsreqGetModelObjectIDs.AssemblyObjectOnly_Property.md
- title: fsreqGetModelObjectIDs.Filters Property
  kind: Property
  slug: filters-property-79153
  path: fsreqGetModelObjectIDs.Filters_Property.md
- title: fsreqGetModelObjectIDs.JobNumber Property
  kind: Property
  slug: job-number-property-79154
  path: fsreqGetModelObjectIDs.JobNumber_Property.md
- title: fsreqGetModelObjectIDs.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79155
  path: fsreqGetModelObjectIDs.ProductionControlID_Property.md
---

# fsreqGetModelObjectIDs Class

Retrieves the list of model object IDs / IFC Guids in a job
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetModelObjectIDs

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetModelObjectIDs : fsreqCommand
```

The fsreqGetModelObjectIDs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetModelObjectIDs](fsreqGetModelObjectIDs_Constructor.md) | fsreqGetModelObjectIDs class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [AssemblyObjectOnly](fsreqGetModelObjectIDs.AssemblyObjectOnly_Property.md) | If true then the model object IDs are retrieved only for the assemblies |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetModelObjectIDs.Filters_Property.md) |  |
| Public property | [JobNumber](fsreqGetModelObjectIDs.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetModelObjectIDs.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
