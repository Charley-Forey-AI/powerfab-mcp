---
title: fsreqGetSequences Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-sequences-class-79275
slug: fsreq-get-sequences-class-79275
node_id: 79275
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetSequences Class
children:
- title: fsreqGetSequences Constructor
  kind: Constructor
  slug: fsreq-get-sequences-constructor-79276
  path: fsreqGetSequences_Constructor.md
- title: fsreqGetSequences.Filters Property
  kind: Property
  slug: filters-property-79278
  path: fsreqGetSequences.Filters_Property.md
- title: fsreqGetSequences.InspectionTests Property
  kind: Property
  slug: inspection-tests-property-79279
  path: fsreqGetSequences.InspectionTests_Property.md
- title: fsreqGetSequences.JobNumber Property
  kind: Property
  slug: job-number-property-79280
  path: fsreqGetSequences.JobNumber_Property.md
- title: fsreqGetSequences.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79281
  path: fsreqGetSequences.ProductionControlID_Property.md
---

# fsreqGetSequences Class

Retrieves the list of sequences in a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetSequences

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetSequences : fsreqCommand
```

The fsreqGetSequences type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetSequences](fsreqGetSequences_Constructor.md) | fsreqGetSequences class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetSequences.Filters_Property.md) |  |
| Public property | [InspectionTests](fsreqGetSequences.InspectionTests_Property.md) | If true then the inspection test summary is retrieved along with the category details. |
| Public property | [JobNumber](fsreqGetSequences.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetSequences.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
