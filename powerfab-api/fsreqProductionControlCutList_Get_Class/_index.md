---
title: fsreqProductionControlCutList_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-cut-listget-class-79676
slug: fsreq-production-control-cut-listget-class-79676
node_id: 79676
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlCutList_Get Class
children:
- title: fsreqProductionControlCutList_Get Constructor
  kind: Constructor
  slug: fsreq-production-control-cut-listget-constructor-79677
  path: fsreqProductionControlCutList_Get_Constructor.md
- title: fsreqProductionControlCutList_Get.GetOptions Property
  kind: Property
  slug: get-options-property-79679
  path: fsreqProductionControlCutList_Get.GetOptions_Property.md
- title: fsreqProductionControlCutList_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-79680
  path: fsreqProductionControlCutList_Get.LastLogID_Property.md
- title: fsreqProductionControlCutList_Get.ProductionControlCutListID Property
  kind: Property
  slug: production-control-cut-list-id-property-79681
  path: fsreqProductionControlCutList_Get.ProductionControlCutListID_Property.md
- title: fsreqProductionControlCutList_Get.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79682
  path: fsreqProductionControlCutList_Get.ProductionControlID_Property.md
---

# fsreqProductionControlCutList_Get Class

Retrieves one or more Production Control Cut List.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlCutList\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlCutList_Get : fsreqCommand
```

The fsreqProductionControlCutList\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlCutList\_Get](fsreqProductionControlCutList_Get_Constructor.md) | fsreqProductionControlCutList\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqProductionControlCutList_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqProductionControlCutList_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [ProductionControlCutListID](fsreqProductionControlCutList_Get.ProductionControlCutListID_Property.md) | CutListID |
| Public property | [ProductionControlID](fsreqProductionControlCutList_Get.ProductionControlID_Property.md) | ProductionControlID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
