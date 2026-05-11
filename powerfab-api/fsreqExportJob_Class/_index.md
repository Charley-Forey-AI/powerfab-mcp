---
title: fsreqExportJob Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-export-job-class-78408
slug: fsreq-export-job-class-78408
node_id: 78408
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqExportJob Class
children:
- title: fsreqExportJob Constructor
  kind: Constructor
  slug: fsreq-export-job-constructor-78409
  path: fsreqExportJob_Constructor.md
- title: fsreqExportJob.Filename Property
  kind: Property
  slug: filename-property-78411
  path: fsreqExportJob.Filename_Property.md
- title: fsreqExportJob.IncludeLotNumbers Property
  kind: Property
  slug: include-lot-numbers-property-78412
  path: fsreqExportJob.IncludeLotNumbers_Property.md
- title: fsreqExportJob.IncludeWorkPackageNumbers Property
  kind: Property
  slug: include-work-package-numbers-property-78413
  path: fsreqExportJob.IncludeWorkPackageNumbers_Property.md
- title: fsreqExportJob.JobNumber Property
  kind: Property
  slug: job-number-property-78414
  path: fsreqExportJob.JobNumber_Property.md
- title: fsreqExportJob.Sequence Property
  kind: Property
  slug: sequence-property-78415
  path: fsreqExportJob.Sequence_Property.md
---

# fsreqExportJob Class

Exports a Production Control job to a KISS file.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqExportJob

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqExportJob : fsreqCommand
```

The fsreqExportJob type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqExportJob](fsreqExportJob_Constructor.md) | Initializes a new instance of the fsreqExportJob class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filename](fsreqExportJob.Filename_Property.md) | Filename to save the exported KISS file to. |
| Public property | [IncludeLotNumbers](fsreqExportJob.IncludeLotNumbers_Property.md) | Indicates if lot numbers should be included in the export file. |
| Public property | [IncludeWorkPackageNumbers](fsreqExportJob.IncludeWorkPackageNumbers_Property.md) | Indicates if work package numbers should be included in the export file. |
| Public property | [JobNumber](fsreqExportJob.JobNumber_Property.md) | Job # to export. |
| Public property | [Sequence](fsreqExportJob.Sequence_Property.md) | Sequence to export, if not specified then the whole job will be exported. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
