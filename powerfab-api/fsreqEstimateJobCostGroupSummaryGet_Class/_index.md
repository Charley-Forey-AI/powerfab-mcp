---
title: fsreqEstimateJobCostGroupSummaryGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-estimate-job-cost-group-summary-get-class-77942
slug: fsreq-estimate-job-cost-group-summary-get-class-77942
node_id: 77942
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqEstimateJobCostGroupSummaryGet Class
children:
- title: fsreqEstimateJobCostGroupSummaryGet Constructor
  kind: Constructor
  slug: fsreq-estimate-job-cost-group-summary-get-constructor-77943
  path: fsreqEstimateJobCostGroupSummaryGet_Constructor.md
- title: fsreqEstimateJobCostGroupSummaryGet.EstimateID Property
  kind: Property
  slug: estimate-id-property-77945
  path: fsreqEstimateJobCostGroupSummaryGet.EstimateID_Property.md
- title: fsreqEstimateJobCostGroupSummaryGet.SummaryBy Property
  kind: Property
  slug: summary-property-77946
  path: fsreqEstimateJobCostGroupSummaryGet.SummaryBy_Property.md
---

# fsreqEstimateJobCostGroupSummaryGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqEstimateJobCostGroupSummaryGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqEstimateJobCostGroupSummaryGet : fsreqCommand
```

The fsreqEstimateJobCostGroupSummaryGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqEstimateJobCostGroupSummaryGet](fsreqEstimateJobCostGroupSummaryGet_Constructor.md) | fsreqEstimateJobCostGroupSummaryGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [EstimateID](fsreqEstimateJobCostGroupSummaryGet.EstimateID_Property.md) |  |
| Public property | [SummaryBy](fsreqEstimateJobCostGroupSummaryGet.SummaryBy_Property.md) | Indicates whether the primary level of the summary is by cost code or cost type. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
