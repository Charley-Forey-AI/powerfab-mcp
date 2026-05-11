---
title: fsreqInventoryAdd Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-add-class-79358
slug: fsreq-inventory-add-class-79358
node_id: 79358
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryAdd Class
children:
- title: fsreqInventoryAdd Constructor
  kind: Constructor
  slug: fsreq-inventory-add-constructor-79359
  path: fsreqInventoryAdd_Constructor.md
- title: fsreqInventoryAdd.ExistingSerialNumber Property
  kind: Property
  slug: existing-serial-number-property-79361
  path: fsreqInventoryAdd.ExistingSerialNumber_Property.md
- title: fsreqInventoryAdd.Length Property
  kind: Property
  slug: length-property-79362
  path: fsreqInventoryAdd.Length_Property.md
- title: fsreqInventoryAdd.Location Property
  kind: Property
  slug: location-property-79363
  path: fsreqInventoryAdd.Location_Property.md
- title: fsreqInventoryAdd.NewSerialNumber Property
  kind: Property
  slug: new-serial-number-property-79364
  path: fsreqInventoryAdd.NewSerialNumber_Property.md
- title: fsreqInventoryAdd.Quantity Property
  kind: Property
  slug: quantity-property-79365
  path: fsreqInventoryAdd.Quantity_Property.md
- title: fsreqInventoryAdd.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-79366
  path: fsreqInventoryAdd.SecondaryLocation_Property.md
- title: fsreqInventoryAdd.Width Property
  kind: Property
  slug: width-property-79367
  path: fsreqInventoryAdd.Width_Property.md
---

# fsreqInventoryAdd Class

Adds a new inventory record based off the information from another.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryAdd

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryAdd : fsreqCommand
```

The fsreqInventoryAdd type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryAdd](fsreqInventoryAdd_Constructor.md) | Initializes a new instance of the fsreqInventoryAdd class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExistingSerialNumber](fsreqInventoryAdd.ExistingSerialNumber_Property.md) | The serial # representing an existing inventory record. |
| Public property | [Length](fsreqInventoryAdd.Length_Property.md) | The length in millimeters of the new inventory record. |
| Public property | [Location](fsreqInventoryAdd.Location_Property.md) | The location of the new inventory record. |
| Public property | [NewSerialNumber](fsreqInventoryAdd.NewSerialNumber_Property.md) | The serial # to assign to the new inventory record. |
| Public property | [Quantity](fsreqInventoryAdd.Quantity_Property.md) | The quantity of the new inventory record. |
| Public property | [SecondaryLocation](fsreqInventoryAdd.SecondaryLocation_Property.md) | The secondary location of the new inventory record. |
| Public property | [Width](fsreqInventoryAdd.Width_Property.md) | The width in millimeters of the new inventory record. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
