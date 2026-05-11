---
title: fsreqInventoryRemnant_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-remnantupsert-class-79482
slug: fsreq-inventory-remnantupsert-class-79482
node_id: 79482
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryRemnant_Upsert Class
children:
- title: fsreqInventoryRemnant_Upsert Constructor
  kind: Constructor
  slug: fsreq-inventory-remnantupsert-constructor-79483
  path: fsreqInventoryRemnant_Upsert_Constructor.md
- title: fsreqInventoryRemnant_Upsert.Remnant Property
  kind: Property
  slug: remnant-property-79485
  path: fsreqInventoryRemnant_Upsert.Remnant_Property.md
- title: fsreqInventoryRemnant_Upsert.SourceApplication Property
  kind: Property
  slug: source-application-property-79486
  path: fsreqInventoryRemnant_Upsert.SourceApplication_Property.md
- title: fsreqInventoryRemnant_Upsert.SourceApplicationVersion Property
  kind: Property
  slug: source-application-version-property-79487
  path: fsreqInventoryRemnant_Upsert.SourceApplicationVersion_Property.md
---

# fsreqInventoryRemnant_Upsert Class

Inserts or updates an external remnant into Tekla EPM INventory

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryRemnant\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryRemnant_Upsert : fsreqCommand
```

The fsreqInventoryRemnant\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryRemnant\_Upsert](fsreqInventoryRemnant_Upsert_Constructor.md) | fsreqInventoryRemnant\_Upsert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Remnant](fsreqInventoryRemnant_Upsert.Remnant_Property.md) |  |
| Public property | [SourceApplication](fsreqInventoryRemnant_Upsert.SourceApplication_Property.md) | Name of application creating this nest. |
| Public property | [SourceApplicationVersion](fsreqInventoryRemnant_Upsert.SourceApplicationVersion_Property.md) | Version of source application. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
