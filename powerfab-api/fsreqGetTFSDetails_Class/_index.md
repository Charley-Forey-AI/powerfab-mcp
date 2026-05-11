---
title: fsreqGetTFSDetails Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-tfs-details-class-79301
slug: fsreq-get-tfs-details-class-79301
node_id: 79301
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetTFSDetails Class
children:
- title: fsreqGetTFSDetails Constructor
  kind: Constructor
  slug: fsreq-get-tfs-details-constructor-79302
  path: fsreqGetTFSDetails_Constructor.md
- title: fsreqGetTFSDetails.Filters Property
  kind: Property
  slug: filters-property-79304
  path: fsreqGetTFSDetails.Filters_Property.md
- title: fsreqGetTFSDetails.JobNumber Property
  kind: Property
  slug: job-number-property-79305
  path: fsreqGetTFSDetails.JobNumber_Property.md
- title: fsreqGetTFSDetails.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79306
  path: fsreqGetTFSDetails.ProductionControlID_Property.md
---

# fsreqGetTFSDetails Class

Retrieves the details of the PDC material that has been taken from stock including tracibility information.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetTFSDetails

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetTFSDetails : fsreqCommand
```

The fsreqGetTFSDetails type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetTFSDetails](fsreqGetTFSDetails_Constructor.md) | fsreqGetTFSDetails class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetTFSDetails.Filters_Property.md) |  |
| Public property | [JobNumber](fsreqGetTFSDetails.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetTFSDetails.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
