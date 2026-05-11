---
title: fsreqInventoryLocationSweepComplete Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-location-sweep-complete-class-79396
slug: fsreq-inventory-location-sweep-complete-class-79396
node_id: 79396
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryLocationSweepComplete Class
children:
- title: fsreqInventoryLocationSweepComplete Constructor
  kind: Constructor
  slug: fsreq-inventory-location-sweep-complete-constructor-79397
  path: fsreqInventoryLocationSweepComplete_Constructor.md
- title: fsreqInventoryLocationSweepComplete.InventoryLocationSweepSerialNumber Property
  kind: Property
  slug: inventory-location-sweep-serial-number-property-79399
  path: fsreqInventoryLocationSweepComplete.InventoryLocationSweepSerialNumber_Property.md
- title: fsreqInventoryLocationSweepComplete.NewLocation Property
  kind: Property
  slug: new-location-property-79400
  path: fsreqInventoryLocationSweepComplete.NewLocation_Property.md
- title: fsreqInventoryLocationSweepComplete.NewSecondaryLocation Property
  kind: Property
  slug: new-secondary-location-property-79401
  path: fsreqInventoryLocationSweepComplete.NewSecondaryLocation_Property.md
---

# fsreqInventoryLocationSweepComplete Class

Completes the given location sweep.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryLocationSweepComplete

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryLocationSweepComplete : fsreqCommand
```

The fsreqInventoryLocationSweepComplete type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryLocationSweepComplete](fsreqInventoryLocationSweepComplete_Constructor.md) | Initializes a new instance of the fsreqInventoryLocationSweepComplete class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [InventoryLocationSweepSerialNumber](fsreqInventoryLocationSweepComplete.InventoryLocationSweepSerialNumber_Property.md) | Serial # representing the location sweep. |
| Public property | [NewLocation](fsreqInventoryLocationSweepComplete.NewLocation_Property.md) | Location to move material that was on this location sweep but was not scanned into. |
| Public property | [NewSecondaryLocation](fsreqInventoryLocationSweepComplete.NewSecondaryLocation_Property.md) | Secondary location to move material that was on this location sweep but was not scanned into. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
