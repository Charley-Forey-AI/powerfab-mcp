---
title: fsreqProductionControlCutListItemSwapGetAvailable Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-cut-list-item-swap-get-available-class-79741
slug: fsreq-production-control-cut-list-item-swap-get-available-class-79741
node_id: 79741
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlCutListItemSwapGetAvailable Class
children:
- title: fsreqProductionControlCutListItemSwapGetAvailable Constructor
  kind: Constructor
  slug: fsreq-production-control-cut-list-item-swap-get-available-constructor-79742
  path: fsreqProductionControlCutListItemSwapGetAvailable_Constructor.md
- title: fsreqProductionControlCutListItemSwapGetAvailable.AllowGradeSubstitutions Property
  kind: Property
  slug: allow-grade-substitutions-property-79744
  path: fsreqProductionControlCutListItemSwapGetAvailable.AllowGradeSubstitutions_Property.md
- title: fsreqProductionControlCutListItemSwapGetAvailable.ProductionControlCutListItemID Property
  kind: Property
  slug: production-control-cut-list-item-id-property-79745
  path: fsreqProductionControlCutListItemSwapGetAvailable.ProductionControlCutListItemID_Property.md
---

# fsreqProductionControlCutListItemSwapGetAvailable Class

Given a Production Control Cut List Item ID, return a list of inventory items that can be swapped with the one on the cut list.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlCutListItemSwapGetAvailable

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlCutListItemSwapGetAvailable : fsreqCommand
```

The fsreqProductionControlCutListItemSwapGetAvailable type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlCutListItemSwapGetAvailable](fsreqProductionControlCutListItemSwapGetAvailable_Constructor.md) | Initializes a new instance of the fsreqProductionControlCutListItemSwapGetAvailable class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AllowGradeSubstitutions](fsreqProductionControlCutListItemSwapGetAvailable.AllowGradeSubstitutions_Property.md) |  |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ProductionControlCutListItemID](fsreqProductionControlCutListItemSwapGetAvailable.ProductionControlCutListItemID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
