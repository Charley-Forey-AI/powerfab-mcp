---
title: fsreqGetInspectionTestRecordSummary Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inspection-test-record-summary-class-79067
slug: fsreq-get-inspection-test-record-summary-class-79067
node_id: 79067
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInspectionTestRecordSummary Class
children:
- title: fsreqGetInspectionTestRecordSummary Constructor
  kind: Constructor
  slug: fsreq-get-inspection-test-record-summary-constructor-79068
  path: fsreqGetInspectionTestRecordSummary_Constructor.md
- title: fsreqGetInspectionTestRecordSummary.Filters Property
  kind: Property
  slug: filters-property-79070
  path: fsreqGetInspectionTestRecordSummary.Filters_Property.md
- title: fsreqGetInspectionTestRecordSummary.JobNumber Property
  kind: Property
  slug: job-number-property-79071
  path: fsreqGetInspectionTestRecordSummary.JobNumber_Property.md
- title: fsreqGetInspectionTestRecordSummary.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79072
  path: fsreqGetInspectionTestRecordSummary.ProductionControlID_Property.md
---

# fsreqGetInspectionTestRecordSummary Class

Retrieves the summary of a set of inspection test records.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInspectionTestRecordSummary

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInspectionTestRecordSummary : fsreqCommand
```

The fsreqGetInspectionTestRecordSummary type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInspectionTestRecordSummary](fsreqGetInspectionTestRecordSummary_Constructor.md) | fsreqGetInspectionTestRecordSummary class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetInspectionTestRecordSummary.Filters_Property.md) |  |
| Public property | [JobNumber](fsreqGetInspectionTestRecordSummary.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetInspectionTestRecordSummary.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
