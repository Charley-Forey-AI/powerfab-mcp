---
title: fsreqProductionControlFinishGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-finish-get-class-79750
slug: fsreq-production-control-finish-get-class-79750
node_id: 79750
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlFinishGet Class
children:
- title: fsreqProductionControlFinishGet Constructor
  kind: Constructor
  slug: fsreq-production-control-finish-get-constructor-79751
  path: fsreqProductionControlFinishGet_Constructor.md
- title: fsreqProductionControlFinishGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-79753
  path: fsreqProductionControlFinishGet.LastLogID_Property.md
- title: fsreqProductionControlFinishGet.ProductionControlFinishID Property
  kind: Property
  slug: production-control-finish-id-property-79754
  path: fsreqProductionControlFinishGet.ProductionControlFinishID_Property.md
---

# fsreqProductionControlFinishGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlFinishGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlFinishGet : fsreqCommand
```

The fsreqProductionControlFinishGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlFinishGet](fsreqProductionControlFinishGet_Constructor.md) | fsreqProductionControlFinishGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqProductionControlFinishGet.LastLogID_Property.md) | If specified, gets changes to finishes since this logID |
| Public property | [ProductionControlFinishID](fsreqProductionControlFinishGet.ProductionControlFinishID_Property.md) | If specified, gets these Finishes |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
