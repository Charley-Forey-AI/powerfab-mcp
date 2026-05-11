---
title: fsreqProductionControlCutListItemSwap Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-cut-list-item-swap-class-79713
slug: fsreq-production-control-cut-list-item-swap-class-79713
node_id: 79713
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlCutListItemSwap Class
children:
- title: fsreqProductionControlCutListItemSwap Constructor
  kind: Constructor
  slug: fsreq-production-control-cut-list-item-swap-constructor-79714
  path: fsreqProductionControlCutListItemSwap_Constructor.md
- title: fsreqProductionControlCutListItemSwap.AllowGradeSubstitutions Property
  kind: Property
  slug: allow-grade-substitutions-property-79716
  path: fsreqProductionControlCutListItemSwap.AllowGradeSubstitutions_Property.md
- title: fsreqProductionControlCutListItemSwap.ProductionControlCutListItemID Property
  kind: Property
  slug: production-control-cut-list-item-id-property-79717
  path: fsreqProductionControlCutListItemSwap.ProductionControlCutListItemID_Property.md
- title: fsreqProductionControlCutListItemSwap.QuantityToSwap Property
  kind: Property
  slug: quantity-swap-property-79718
  path: fsreqProductionControlCutListItemSwap.QuantityToSwap_Property.md
- title: fsreqProductionControlCutListItemSwap.SwapWithItem Property
  kind: Property
  slug: swap-item-property-79719
  path: fsreqProductionControlCutListItemSwap.SwapWithItem_Property.md
---

# fsreqProductionControlCutListItemSwap Class

Swap an inventory item associated with a cut list for another inventory item.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlCutListItemSwap

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlCutListItemSwap : fsreqCommand
```

The fsreqProductionControlCutListItemSwap type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlCutListItemSwap](fsreqProductionControlCutListItemSwap_Constructor.md) | fsreqProductionControlCutListItemSwap class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AllowGradeSubstitutions](fsreqProductionControlCutListItemSwap.AllowGradeSubstitutions_Property.md) |  |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ProductionControlCutListItemID](fsreqProductionControlCutListItemSwap.ProductionControlCutListItemID_Property.md) |  |
| Public property | [QuantityToSwap](fsreqProductionControlCutListItemSwap.QuantityToSwap_Property.md) |  |
| Public property | [SwapWithItem](fsreqProductionControlCutListItemSwap.SwapWithItem_Property.md) | A single swappable item from response to Swap\_GetAvailable |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
