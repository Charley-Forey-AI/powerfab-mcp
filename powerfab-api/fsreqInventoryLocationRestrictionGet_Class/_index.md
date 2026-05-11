---
title: fsreqInventoryLocationRestrictionGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-location-restriction-get-class-79391
slug: fsreq-inventory-location-restriction-get-class-79391
node_id: 79391
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryLocationRestrictionGet Class
children:
- title: fsreqInventoryLocationRestrictionGet Constructor
  kind: Constructor
  slug: fsreq-inventory-location-restriction-get-constructor-79392
  path: fsreqInventoryLocationRestrictionGet_Constructor.md
- title: fsreqInventoryLocationRestrictionGet.InventoryLocationRestrictionID Property
  kind: Property
  slug: inventory-location-restriction-id-property-79394
  path: fsreqInventoryLocationRestrictionGet.InventoryLocationRestrictionID_Property.md
- title: fsreqInventoryLocationRestrictionGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-79395
  path: fsreqInventoryLocationRestrictionGet.LastLogID_Property.md
---

# fsreqInventoryLocationRestrictionGet Class

Gets the list of inventory location restrictions.
If LastLogID is specified then the result will only include the records that have changed since that log position.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryLocationRestrictionGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryLocationRestrictionGet : fsreqCommand
```

The fsreqInventoryLocationRestrictionGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryLocationRestrictionGet](fsreqInventoryLocationRestrictionGet_Constructor.md) | fsreqInventoryLocationRestrictionGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [InventoryLocationRestrictionID](fsreqInventoryLocationRestrictionGet.InventoryLocationRestrictionID_Property.md) |  |
| Public property | [LastLogID](fsreqInventoryLocationRestrictionGet.LastLogID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
