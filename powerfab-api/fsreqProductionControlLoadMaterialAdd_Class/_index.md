---
title: fsreqProductionControlLoadMaterialAdd Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-material-add-class-79865
slug: fsreq-production-control-load-material-add-class-79865
node_id: 79865
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadMaterialAdd Class
children:
- title: fsreqProductionControlLoadMaterialAdd Constructor
  kind: Constructor
  slug: fsreq-production-control-load-material-add-constructor-79866
  path: fsreqProductionControlLoadMaterialAdd_Constructor.md
- title: fsreqProductionControlLoadMaterialAdd.AddItem Property
  kind: Property
  slug: add-item-property-79868
  path: fsreqProductionControlLoadMaterialAdd.AddItem_Property.md
- title: fsreqProductionControlLoadMaterialAdd.DateLoaded Property
  kind: Property
  slug: date-loaded-property-79869
  path: fsreqProductionControlLoadMaterialAdd.DateLoaded_Property.md
- title: fsreqProductionControlLoadMaterialAdd.LoadItemsOnAssign Property
  kind: Property
  slug: load-items-assign-property-79870
  path: fsreqProductionControlLoadMaterialAdd.LoadItemsOnAssign_Property.md
- title: fsreqProductionControlLoadMaterialAdd.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79871
  path: fsreqProductionControlLoadMaterialAdd.ProductionControlLoadID_Property.md
---

# fsreqProductionControlLoadMaterialAdd Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadMaterialAdd

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadMaterialAdd : fsreqCommand
```

The fsreqProductionControlLoadMaterialAdd type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadMaterialAdd](fsreqProductionControlLoadMaterialAdd_Constructor.md) | fsreqProductionControlLoadMaterialAdd class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AddItem](fsreqProductionControlLoadMaterialAdd.AddItem_Property.md) |  |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateLoaded](fsreqProductionControlLoadMaterialAdd.DateLoaded_Property.md) |  |
| Public property | [LoadItemsOnAssign](fsreqProductionControlLoadMaterialAdd.LoadItemsOnAssign_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadMaterialAdd.ProductionControlLoadID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
