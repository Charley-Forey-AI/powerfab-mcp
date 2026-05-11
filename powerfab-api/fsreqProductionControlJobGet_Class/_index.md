---
title: fsreqProductionControlJobGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-job-get-class-79768
slug: fsreq-production-control-job-get-class-79768
node_id: 79768
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlJobGet Class
children:
- title: fsreqProductionControlJobGet Constructor
  kind: Constructor
  slug: fsreq-production-control-job-get-constructor-79769
  path: fsreqProductionControlJobGet_Constructor.md
- title: fsreqProductionControlJobGet.GetOptions Property
  kind: Property
  slug: get-options-property-79771
  path: fsreqProductionControlJobGet.GetOptions_Property.md
- title: fsreqProductionControlJobGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-79772
  path: fsreqProductionControlJobGet.LastLogID_Property.md
- title: fsreqProductionControlJobGet.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79773
  path: fsreqProductionControlJobGet.ProductionControlID_Property.md
---

# fsreqProductionControlJobGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlJobGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlJobGet : fsreqCommand
```

The fsreqProductionControlJobGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlJobGet](fsreqProductionControlJobGet_Constructor.md) | fsreqProductionControlJobGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqProductionControlJobGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqProductionControlJobGet.LastLogID_Property.md) | If specified, will retrieve changes since this logID |
| Public property | [ProductionControlID](fsreqProductionControlJobGet.ProductionControlID_Property.md) | List of IDs to retrieve. If blank, will retrieve all jobs |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
