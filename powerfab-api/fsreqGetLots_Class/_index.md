---
title: fsreqGetLots Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-lots-class-79142
slug: fsreq-get-lots-class-79142
node_id: 79142
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetLots Class
children:
- title: fsreqGetLots Constructor
  kind: Constructor
  slug: fsreq-get-lots-constructor-79143
  path: fsreqGetLots_Constructor.md
- title: fsreqGetLots.Filters Property
  kind: Property
  slug: filters-property-79145
  path: fsreqGetLots.Filters_Property.md
- title: fsreqGetLots.InspectionTests Property
  kind: Property
  slug: inspection-tests-property-79146
  path: fsreqGetLots.InspectionTests_Property.md
- title: fsreqGetLots.JobNumber Property
  kind: Property
  slug: job-number-property-79147
  path: fsreqGetLots.JobNumber_Property.md
- title: fsreqGetLots.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79148
  path: fsreqGetLots.ProductionControlID_Property.md
---

# fsreqGetLots Class

Retrieves the list of lots in a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetLots

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetLots : fsreqCommand
```

The fsreqGetLots type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetLots](fsreqGetLots_Constructor.md) | fsreqGetLots class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetLots.Filters_Property.md) |  |
| Public property | [InspectionTests](fsreqGetLots.InspectionTests_Property.md) | If true then the inspection test summary is retrieved along with the category details. |
| Public property | [JobNumber](fsreqGetLots.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetLots.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
