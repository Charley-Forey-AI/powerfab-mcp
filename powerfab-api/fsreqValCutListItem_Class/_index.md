---
title: fsreqValCutListItem Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-val-cut-list-item-class-80611
slug: fsreq-val-cut-list-item-class-80611
node_id: 80611
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqValCutListItem Class
children:
- title: fsreqValCutListItem Constructor
  kind: Constructor
  slug: fsreq-val-cut-list-item-constructor-80612
  path: fsreqValCutListItem_Constructor.md
- title: fsreqValCutListItem.BillOfLadingNumber Property
  kind: Property
  slug: bill-lading-number-property-80614
  path: fsreqValCutListItem.BillOfLadingNumber_Property.md
- title: fsreqValCutListItem.CountryOfOrigin Property
  kind: Property
  slug: country-origin-property-80615
  path: fsreqValCutListItem.CountryOfOrigin_Property.md
- title: fsreqValCutListItem.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-80616
  path: fsreqValCutListItem.CutListItemID_Property.md
- title: fsreqValCutListItem.CutListSerialNumber Property
  kind: Property
  slug: cut-list-serial-number-property-80617
  path: fsreqValCutListItem.CutListSerialNumber_Property.md
- title: fsreqValCutListItem.ExernalNestID Property
  kind: Property
  slug: exernal-nest-id-property-80618
  path: fsreqValCutListItem.ExernalNestID_Property.md
- title: fsreqValCutListItem.HeatNumber Property
  kind: Property
  slug: heat-number-property-80619
  path: fsreqValCutListItem.HeatNumber_Property.md
- title: fsreqValCutListItem.HeatSerialNumber Property
  kind: Property
  slug: heat-serial-number-property-80620
  path: fsreqValCutListItem.HeatSerialNumber_Property.md
- title: fsreqValCutListItem.IncludeCNCData Property
  kind: Property
  slug: include-cnc-data-property-80621
  path: fsreqValCutListItem.IncludeCNCData_Property.md
- title: fsreqValCutListItem.IncludeCutListItemParts Property
  kind: Property
  slug: include-cut-list-item-parts-property-80622
  path: fsreqValCutListItem.IncludeCutListItemParts_Property.md
- title: fsreqValCutListItem.InventorySerialNumber Property
  kind: Property
  slug: inventory-serial-number-property-80623
  path: fsreqValCutListItem.InventorySerialNumber_Property.md
- title: fsreqValCutListItem.Location Property
  kind: Property
  slug: location-property-80624
  path: fsreqValCutListItem.Location_Property.md
- title: fsreqValCutListItem.NestID Property
  kind: Property
  slug: nest-id-property-80625
  path: fsreqValCutListItem.NestID_Property.md
- title: fsreqValCutListItem.PartNumber Property
  kind: Property
  slug: part-number-property-80626
  path: fsreqValCutListItem.PartNumber_Property.md
- title: fsreqValCutListItem.PONumber Property
  kind: Property
  slug: po-number-property-80627
  path: fsreqValCutListItem.PONumber_Property.md
- title: fsreqValCutListItem.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-80628
  path: fsreqValCutListItem.SecondaryLocation_Property.md
- title: fsreqValCutListItem.ValidateForCut Property
  kind: Property
  slug: validate-cut-property-80629
  path: fsreqValCutListItem.ValidateForCut_Property.md
---

# fsreqValCutListItem Class

Validates that a cutting detail and inventory stock is valid.
Either CutListItemID or CutListSerialNumber must be specified.
Either InventorySerialNumber or (PONumber AND HeatNumber) must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqValCutListItem

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqValCutListItem : fsreqCommand
```

The fsreqValCutListItem type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqValCutListItem](fsreqValCutListItem_Constructor.md) | Initializes a new instance of the fsreqValCutListItem class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BillOfLadingNumber](fsreqValCutListItem.BillOfLadingNumber_Property.md) | B/L # of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CountryOfOrigin](fsreqValCutListItem.CountryOfOrigin_Property.md) | Country of origin of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [CutListItemID](fsreqValCutListItem.CutListItemID_Property.md) | Unique ID of the cutting detail on a cut list. |
| Public property | [CutListSerialNumber](fsreqValCutListItem.CutListSerialNumber_Property.md) | Serial number from the FabSuite report: Shop PC/PO Cutting List w/ Barcodes. |
| Public property | [ExernalNestID](fsreqValCutListItem.ExernalNestID_Property.md) | Index into ExternalNests table for nest being cut. |
| Public property | [HeatNumber](fsreqValCutListItem.HeatNumber_Property.md) | Heat # of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [HeatSerialNumber](fsreqValCutListItem.HeatSerialNumber_Property.md) | Heat Serial # of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [IncludeCNCData](fsreqValCutListItem.IncludeCNCData_Property.md) | true - CNC data will be retrieved for the parts on the cutting detail. Has no effect if IncludeCutListItemParts=false. |
| Public property | [IncludeCutListItemParts](fsreqValCutListItem.IncludeCutListItemParts_Property.md) | true - Information on the parts in the cutting detail will be retrieved. |
| Public property | [InventorySerialNumber](fsreqValCutListItem.InventorySerialNumber_Property.md) | Serial number of the inventory stock used. |
| Public property | [Location](fsreqValCutListItem.Location_Property.md) | Inventory location of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [NestID](fsreqValCutListItem.NestID_Property.md) | Nest ID or barcode for nest being cut. |
| Public property | [PartNumber](fsreqValCutListItem.PartNumber_Property.md) | Inventory part # of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [PONumber](fsreqValCutListItem.PONumber_Property.md) | PO # of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [SecondaryLocation](fsreqValCutListItem.SecondaryLocation_Property.md) | Inventory secondary location of the inventory stock used. Has no effect if InventorySerialNumber is specified. |
| Public property | [ValidateForCut](fsreqValCutListItem.ValidateForCut_Property.md) | true - Does an extra step of validation to make sure that the inventory material is in stock and ready to be cut. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
