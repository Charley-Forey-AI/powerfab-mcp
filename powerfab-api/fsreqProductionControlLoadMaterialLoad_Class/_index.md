---
title: fsreqProductionControlLoadMaterialLoad Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-material-load-class-79879
slug: fsreq-production-control-load-material-load-class-79879
node_id: 79879
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadMaterialLoad Class
children:
- title: fsreqProductionControlLoadMaterialLoad Constructor
  kind: Constructor
  slug: fsreq-production-control-load-material-load-constructor-79880
  path: fsreqProductionControlLoadMaterialLoad_Constructor.md
- title: fsreqProductionControlLoadMaterialLoad.DateLoaded Property
  kind: Property
  slug: date-loaded-property-79882
  path: fsreqProductionControlLoadMaterialLoad.DateLoaded_Property.md
- title: fsreqProductionControlLoadMaterialLoad.LoadItem Property
  kind: Property
  slug: load-item-property-79883
  path: fsreqProductionControlLoadMaterialLoad.LoadItem_Property.md
- title: fsreqProductionControlLoadMaterialLoad.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79884
  path: fsreqProductionControlLoadMaterialLoad.ProductionControlLoadID_Property.md
---

# fsreqProductionControlLoadMaterialLoad Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadMaterialLoad

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadMaterialLoad : fsreqCommand
```

The fsreqProductionControlLoadMaterialLoad type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadMaterialLoad](fsreqProductionControlLoadMaterialLoad_Constructor.md) | fsreqProductionControlLoadMaterialLoad class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateLoaded](fsreqProductionControlLoadMaterialLoad.DateLoaded_Property.md) |  |
| Public property | [LoadItem](fsreqProductionControlLoadMaterialLoad.LoadItem_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadMaterialLoad.ProductionControlLoadID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
