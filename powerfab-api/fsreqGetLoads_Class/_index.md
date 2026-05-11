---
title: fsreqGetLoads Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-loads-class-79130
slug: fsreq-get-loads-class-79130
node_id: 79130
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetLoads Class
children:
- title: fsreqGetLoads Constructor
  kind: Constructor
  slug: fsreq-get-loads-constructor-79131
  path: fsreqGetLoads_Constructor.md
- title: fsreqGetLoads.DestinationName Property
  kind: Property
  slug: destination-name-property-79133
  path: fsreqGetLoads.DestinationName_Property.md
- title: fsreqGetLoads.Filters Property
  kind: Property
  slug: filters-property-79134
  path: fsreqGetLoads.Filters_Property.md
- title: fsreqGetLoads.IncludeCompletedMaterial Property
  kind: Property
  slug: include-completed-material-property-79135
  path: fsreqGetLoads.IncludeCompletedMaterial_Property.md
- title: fsreqGetLoads.IncludeLoads Property
  kind: Property
  slug: include-loads-property-79136
  path: fsreqGetLoads.IncludeLoads_Property.md
- title: fsreqGetLoads.IncludeRemainingMaterial Property
  kind: Property
  slug: include-remaining-material-property-79137
  path: fsreqGetLoads.IncludeRemainingMaterial_Property.md
- title: fsreqGetLoads.IncludeUnshippedLoads Property
  kind: Property
  slug: include-unshipped-loads-property-79138
  path: fsreqGetLoads.IncludeUnshippedLoads_Property.md
- title: fsreqGetLoads.JobNumber Property
  kind: Property
  slug: job-number-property-79139
  path: fsreqGetLoads.JobNumber_Property.md
- title: fsreqGetLoads.LoadNumber Property
  kind: Property
  slug: load-number-property-79140
  path: fsreqGetLoads.LoadNumber_Property.md
- title: fsreqGetLoads.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79141
  path: fsreqGetLoads.ProductionControlID_Property.md
---

# fsreqGetLoads Class

Retrieves the completed/remaining status and details by destination and load #.
Either ProductionControlID or JobNumber must be specified.
This command can be used a few different ways:
1. Retrieve the list of destinations.
IncludeLoads = false, IncludeUnshippedLoads = false, IncludeCompletedMaterial = false, IncludeRemainingMaterial = false
2. Retrieve the list of loads.
Include[Unshipped]Loads = true, IncludeCompletedMaterial = false, IncludeRemainingMaterial = false
3. Retrieve the details of the material on each load.
Include[Unshipped]Loads = true, IncludeCompletedMaterial = true, IncludeRemainingMaterial = false
4. Retrieve the details of the material remaining to be loaded.
IncludeLoads = false, IncludeUnshippedLoads = false, IncludeCompletedMaterial = false, IncludeRemainingMaterial = true

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetLoads

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetLoads : fsreqCommand
```

The fsreqGetLoads type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetLoads](fsreqGetLoads_Constructor.md) | fsreqGetLoads class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DestinationName](fsreqGetLoads.DestinationName_Property.md) | The shipping destination to restrict the result to. Specify the value 'Jobsite' for the jobsite destination. If this element is not specified then information from all shipping destinations will be retrieved. |
| Public property | [Filters](fsreqGetLoads.Filters_Property.md) |  |
| Public property | [IncludeCompletedMaterial](fsreqGetLoads.IncludeCompletedMaterial_Property.md) | Indicates if the details of the material on each load should be retrieved. |
| Public property | [IncludeLoads](fsreqGetLoads.IncludeLoads_Property.md) | Indicates if the individual loads should be retrieved. |
| Public property | [IncludeRemainingMaterial](fsreqGetLoads.IncludeRemainingMaterial_Property.md) | Indicates if the details of the material remaining to be loaded should be retrieved. |
| Public property | [IncludeUnshippedLoads](fsreqGetLoads.IncludeUnshippedLoads_Property.md) | Indicates if the loads that have not yet been shipped should be retrieved. |
| Public property | [JobNumber](fsreqGetLoads.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [LoadNumber](fsreqGetLoads.LoadNumber_Property.md) | The load # to restrict the result to. If this element is not specified then information from all loads will be retrieved. |
| Public property | [ProductionControlID](fsreqGetLoads.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
