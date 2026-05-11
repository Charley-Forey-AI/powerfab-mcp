---
title: fsreqProductionControlLoadMaterialReturn Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-material-return-class-79902
slug: fsreq-production-control-load-material-return-class-79902
node_id: 79902
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadMaterialReturn Class
children:
- title: fsreqProductionControlLoadMaterialReturn Constructor
  kind: Constructor
  slug: fsreq-production-control-load-material-return-constructor-79903
  path: fsreqProductionControlLoadMaterialReturn_Constructor.md
- title: fsreqProductionControlLoadMaterialReturn.DateReturned Property
  kind: Property
  slug: date-returned-property-79905
  path: fsreqProductionControlLoadMaterialReturn.DateReturned_Property.md
- title: fsreqProductionControlLoadMaterialReturn.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79906
  path: fsreqProductionControlLoadMaterialReturn.ProductionControlLoadID_Property.md
- title: fsreqProductionControlLoadMaterialReturn.ReturnItem Property
  kind: Property
  slug: return-item-property-79907
  path: fsreqProductionControlLoadMaterialReturn.ReturnItem_Property.md
---

# fsreqProductionControlLoadMaterialReturn Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadMaterialReturn

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadMaterialReturn : fsreqCommand
```

The fsreqProductionControlLoadMaterialReturn type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadMaterialReturn](fsreqProductionControlLoadMaterialReturn_Constructor.md) | fsreqProductionControlLoadMaterialReturn class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateReturned](fsreqProductionControlLoadMaterialReturn.DateReturned_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadMaterialReturn.ProductionControlLoadID_Property.md) |  |
| Public property | [ReturnItem](fsreqProductionControlLoadMaterialReturn.ReturnItem_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
