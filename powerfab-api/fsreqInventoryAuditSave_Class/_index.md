---
title: fsreqInventoryAuditSave Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-audit-save-class-79368
slug: fsreq-inventory-audit-save-class-79368
node_id: 79368
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryAuditSave Class
children:
- title: fsreqInventoryAuditSave Constructor
  kind: Constructor
  slug: fsreq-inventory-audit-save-constructor-79369
  path: fsreqInventoryAuditSave_Constructor.md
- title: fsreqInventoryAuditSave.AuditSerialNumber Property
  kind: Property
  slug: audit-serial-number-property-79371
  path: fsreqInventoryAuditSave.AuditSerialNumber_Property.md
- title: fsreqInventoryAuditSave.Quantity Property
  kind: Property
  slug: quantity-property-79372
  path: fsreqInventoryAuditSave.Quantity_Property.md
- title: fsreqInventoryAuditSave.SerialNumber Property
  kind: Property
  slug: serial-number-property-79373
  path: fsreqInventoryAuditSave.SerialNumber_Property.md
---

# fsreqInventoryAuditSave Class

Associates a barcode serial # with an audit serial # and saves the barcode SN in FabSuite's inventory.
If the SerialNumber does not yet exist in FabSuite's inventory then it will be associated with an inventory record
that has information matching the AuditSerialNumber.
If the SerialNumber is already in FabSuite's inventory then it will be moved to the location and secondary location
defined by the AuditSerialNumber as long as it matches the rest of the details.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryAuditSave

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryAuditSave : fsreqCommand
```

The fsreqInventoryAuditSave type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryAuditSave](fsreqInventoryAuditSave_Constructor.md) | Initializes a new instance of the fsreqInventoryAuditSave class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [AuditSerialNumber](fsreqInventoryAuditSave.AuditSerialNumber_Property.md) | Serial # from the FabSuite inventory report: Audit w/ Barcodes. Represents a set of values for: Shape, Grade, Dimensions, Length, PO #, B/L #, Heat #, Heat Serial #, Location, and Secondary Location. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Quantity](fsreqInventoryAuditSave.Quantity_Property.md) | Quantity for that serial #. If serialized then the quantity should always be 1. Quantity greater than one for material such as bolts, nuts, washers, etc. where a single barcode serial # represents a larger quantity of material. |
| Public property | [SerialNumber](fsreqInventoryAuditSave.SerialNumber_Property.md) | Serial # of the barcode label on the raw material. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
