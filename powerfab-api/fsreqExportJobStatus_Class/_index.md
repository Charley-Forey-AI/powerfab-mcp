---
title: fsreqExportJobStatus Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-export-job-status-class-78416
slug: fsreq-export-job-status-class-78416
node_id: 78416
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqExportJobStatus Class
children:
- title: fsreqExportJobStatus Constructor
  kind: Constructor
  slug: fsreq-export-job-status-constructor-78417
  path: fsreqExportJobStatus_Constructor.md
- title: fsreqExportJobStatus.ExportFilename Property
  kind: Property
  slug: export-filename-property-78419
  path: fsreqExportJobStatus.ExportFilename_Property.md
- title: fsreqExportJobStatus.JobNumber Property
  kind: Property
  slug: job-number-property-78420
  path: fsreqExportJobStatus.JobNumber_Property.md
- title: fsreqExportJobStatus.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78421
  path: fsreqExportJobStatus.ProductionControlID_Property.md
- title: fsreqExportJobStatus.XMLFormat Property
  kind: Property
  slug: xml-format-property-78422
  path: fsreqExportJobStatus.XMLFormat_Property.md
---

# fsreqExportJobStatus Class

Exports a Production Control job including status information.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqExportJobStatus

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqExportJobStatus : fsreqCommand
```

The fsreqExportJobStatus type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqExportJobStatus](fsreqExportJobStatus_Constructor.md) | Initializes a new instance of the fsreqExportJobStatus class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExportFilename](fsreqExportJobStatus.ExportFilename_Property.md) | Filename to save the exported file to. |
| Public property | [JobNumber](fsreqExportJobStatus.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqExportJobStatus.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |
| Public property | [XMLFormat](fsreqExportJobStatus.XMLFormat_Property.md) | Format to export to. If the value is 'SDS/2' then the export is to the SDS/2 XML format. Otherwise the export is for the FabSuite XML format. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
