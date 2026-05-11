---
title: fsreqCreateInventoryLocationSweep Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-create-inventory-location-sweep-class-77704
slug: fsreq-create-inventory-location-sweep-class-77704
node_id: 77704
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCreateInventoryLocationSweep Class
children:
- title: fsreqCreateInventoryLocationSweep Constructor
  kind: Constructor
  slug: fsreq-create-inventory-location-sweep-constructor-77705
  path: fsreqCreateInventoryLocationSweep_Constructor.md
- title: fsreqCreateInventoryLocationSweep.Location Property
  kind: Property
  slug: location-property-77707
  path: fsreqCreateInventoryLocationSweep.Location_Property.md
- title: fsreqCreateInventoryLocationSweep.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-77708
  path: fsreqCreateInventoryLocationSweep.SecondaryLocation_Property.md
---

# fsreqCreateInventoryLocationSweep Class

Creates a location sweep for the given location.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqCreateInventoryLocationSweep

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqCreateInventoryLocationSweep : fsreqCommand
```

The fsreqCreateInventoryLocationSweep type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqCreateInventoryLocationSweep](fsreqCreateInventoryLocationSweep_Constructor.md) | Initializes a new instance of the fsreqCreateInventoryLocationSweep class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Location](fsreqCreateInventoryLocationSweep.Location_Property.md) | Inventory location to create the sweep for. |
| Public property | [SecondaryLocation](fsreqCreateInventoryLocationSweep.SecondaryLocation_Property.md) | Secondary inventory location to create the sweep for. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
