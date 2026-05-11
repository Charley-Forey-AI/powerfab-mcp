---
title: fsreqGetProductionControlJobInformationTransactions Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-production-control-job-information-transactions-class-79184
slug: fsreq-get-production-control-job-information-transactions-class-79184
node_id: 79184
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProductionControlJobInformationTransactions Class
children:
- title: fsreqGetProductionControlJobInformationTransactions Constructor
  kind: Constructor
  slug: fsreq-get-production-control-job-information-transactions-constructor-79185
  path: fsreqGetProductionControlJobInformationTransactions_Constructor.md
- title: fsreqGetProductionControlJobInformationTransactions.JobNumber Property
  kind: Property
  slug: job-number-property-79187
  path: fsreqGetProductionControlJobInformationTransactions.JobNumber_Property.md
- title: fsreqGetProductionControlJobInformationTransactions.LastLogID Property
  kind: Property
  slug: last-log-id-property-79188
  path: fsreqGetProductionControlJobInformationTransactions.LastLogID_Property.md
---

# fsreqGetProductionControlJobInformationTransactions Class

Retrieves the changes that have been made to Production Control job information.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProductionControlJobInformationTransactions

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProductionControlJobInformationTransactions : fsreqCommand
```

The fsreqGetProductionControlJobInformationTransactions type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProductionControlJobInformationTransactions](fsreqGetProductionControlJobInformationTransactions_Constructor.md) | fsreqGetProductionControlJobInformationTransactions class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [JobNumber](fsreqGetProductionControlJobInformationTransactions.JobNumber_Property.md) | The jobs to retrieve the information from. If no JobNumber elements are specified then all jobs will be returned. |
| Public property | [LastLogID](fsreqGetProductionControlJobInformationTransactions.LastLogID_Property.md) | The log ID that the production control job transactions have already been read up to. Only retrieve transactions after this log ID. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
