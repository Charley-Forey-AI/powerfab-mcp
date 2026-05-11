---
title: fsreqMakeReport Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-make-report-class-79548
slug: fsreq-make-report-class-79548
node_id: 79548
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqMakeReport Class
children:
- title: fsreqMakeReport Constructor
  kind: Constructor
  slug: fsreq-make-report-constructor-79549
  path: fsreqMakeReport_Constructor.md
- title: fsreqMakeReport.ExportFormat Property
  kind: Property
  slug: export-format-property-79551
  path: fsreqMakeReport.ExportFormat_Property.md
- title: fsreqMakeReport.ReportGroup Property
  kind: Property
  slug: report-group-property-79552
  path: fsreqMakeReport.ReportGroup_Property.md
- title: fsreqMakeReport.ReportGUID Property
  kind: Property
  slug: report-guid-property-79553
  path: fsreqMakeReport.ReportGUID_Property.md
- title: fsreqMakeReport.ReportID Property
  kind: Property
  slug: report-id-property-79554
  path: fsreqMakeReport.ReportID_Property.md
- title: fsreqMakeReport.ReportInstanceGUID Property
  kind: Property
  slug: report-instance-guid-property-79555
  path: fsreqMakeReport.ReportInstanceGUID_Property.md
- title: fsreqMakeReport.ReportOptions Property
  kind: Property
  slug: report-options-property-79556
  path: fsreqMakeReport.ReportOptions_Property.md
- title: fsreqMakeReport.ReportTypeID Property
  kind: Property
  slug: report-type-id-property-79557
  path: fsreqMakeReport.ReportTypeID_Property.md
---

# fsreqMakeReport Class

Renders, exports, and retrieves the given report.
Either ReportID or ReportGUID is required.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqMakeReport

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqMakeReport : fsreqCommand
```

The fsreqMakeReport type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqMakeReport](fsreqMakeReport_Constructor.md) | fsreqMakeReport class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExportFormat](fsreqMakeReport.ExportFormat_Property.md) | The format to export the report to. |
| Public property | [ReportGroup](fsreqMakeReport.ReportGroup_Property.md) | Report group of the report to render. |
| Public property | [ReportGUID](fsreqMakeReport.ReportGUID_Property.md) | The report to run. |
| Public property | [ReportID](fsreqMakeReport.ReportID_Property.md) | The report to run. This parameter is deprecated, ReportGUID should be used instead. |
| Public property | [ReportInstanceGUID](fsreqMakeReport.ReportInstanceGUID_Property.md) | Report instance to use, if one had been prepared by a previous PrepareReportData command. |
| Public property | [ReportOptions](fsreqMakeReport.ReportOptions_Property.md) | The report processing options. |
| Public property | [ReportTypeID](fsreqMakeReport.ReportTypeID_Property.md) | The report type to use. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
