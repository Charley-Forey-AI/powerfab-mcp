---
title: fsreqPurchaseOrderSubcontractItemUpdate Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-subcontract-item-update-class-80192
slug: fsreq-purchase-order-subcontract-item-update-class-80192
node_id: 80192
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderSubcontractItemUpdate Class
children:
- title: fsreqPurchaseOrderSubcontractItemUpdate Constructor
  kind: Constructor
  slug: fsreq-purchase-order-subcontract-item-update-constructor-80193
  path: fsreqPurchaseOrderSubcontractItemUpdate_Constructor.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.BasePrice Property
  kind: Property
  slug: base-price-property-80195
  path: fsreqPurchaseOrderSubcontractItemUpdate.BasePrice_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Category Property
  kind: Property
  slug: category-property-80196
  path: fsreqPurchaseOrderSubcontractItemUpdate.Category_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Comment Property
  kind: Property
  slug: comment-property-80197
  path: fsreqPurchaseOrderSubcontractItemUpdate.Comment_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.CostCodeID Property
  kind: Property
  slug: cost-code-id-property-80198
  path: fsreqPurchaseOrderSubcontractItemUpdate.CostCodeID_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.CostTypeID Property
  kind: Property
  slug: cost-type-id-property-80199
  path: fsreqPurchaseOrderSubcontractItemUpdate.CostTypeID_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.DatePromised Property
  kind: Property
  slug: date-promised-property-80200
  path: fsreqPurchaseOrderSubcontractItemUpdate.DatePromised_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.DateRequired Property
  kind: Property
  slug: date-required-property-80201
  path: fsreqPurchaseOrderSubcontractItemUpdate.DateRequired_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Description Property
  kind: Property
  slug: description-property-80202
  path: fsreqPurchaseOrderSubcontractItemUpdate.Description_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.ItemID Property
  kind: Property
  slug: item-id-property-80203
  path: fsreqPurchaseOrderSubcontractItemUpdate.ItemID_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.JobNumber Property
  kind: Property
  slug: job-number-property-80204
  path: fsreqPurchaseOrderSubcontractItemUpdate.JobNumber_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Length Property
  kind: Property
  slug: length-property-80205
  path: fsreqPurchaseOrderSubcontractItemUpdate.Length_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.LotNumber Property
  kind: Property
  slug: lot-number-property-80206
  path: fsreqPurchaseOrderSubcontractItemUpdate.LotNumber_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderID Property
  kind: Property
  slug: purchase-order-id-property-80207
  path: fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderID_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderSubcontractItemID Property
  kind: Property
  slug: purchase-order-subcontract-item-id-property-80208
  path: fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderSubcontractItemID_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.PurchasingNote Property
  kind: Property
  slug: purchasing-note-property-80209
  path: fsreqPurchaseOrderSubcontractItemUpdate.PurchasingNote_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Quantity Property
  kind: Property
  slug: quantity-property-80210
  path: fsreqPurchaseOrderSubcontractItemUpdate.Quantity_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Sequence Property
  kind: Property
  slug: sequence-property-80211
  path: fsreqPurchaseOrderSubcontractItemUpdate.Sequence_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.SubCategory Property
  kind: Property
  slug: sub-category-property-80212
  path: fsreqPurchaseOrderSubcontractItemUpdate.SubCategory_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.SurfaceArea Property
  kind: Property
  slug: surface-area-property-80213
  path: fsreqPurchaseOrderSubcontractItemUpdate.SurfaceArea_Property.md
- title: fsreqPurchaseOrderSubcontractItemUpdate.Weight Property
  kind: Property
  slug: weight-property-80214
  path: fsreqPurchaseOrderSubcontractItemUpdate.Weight_Property.md
---

# fsreqPurchaseOrderSubcontractItemUpdate Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderSubcontractItemUpdate

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderSubcontractItemUpdate : fsreqCommand
```

The fsreqPurchaseOrderSubcontractItemUpdate type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderSubcontractItemUpdate](fsreqPurchaseOrderSubcontractItemUpdate_Constructor.md) | fsreqPurchaseOrderSubcontractItemUpdate class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BasePrice](fsreqPurchaseOrderSubcontractItemUpdate.BasePrice_Property.md) | Base Price of this SubContract Item |
| Public property | [Category](fsreqPurchaseOrderSubcontractItemUpdate.Category_Property.md) | Category of this SubContract Item |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Comment](fsreqPurchaseOrderSubcontractItemUpdate.Comment_Property.md) | Comment of this SubContract Item |
| Public property | [CostCodeID](fsreqPurchaseOrderSubcontractItemUpdate.CostCodeID_Property.md) | Cost Code ID of this SubContract Item |
| Public property | [CostTypeID](fsreqPurchaseOrderSubcontractItemUpdate.CostTypeID_Property.md) | Cost Type ID of this SubContract Item |
| Public property | [DatePromised](fsreqPurchaseOrderSubcontractItemUpdate.DatePromised_Property.md) | Date Promised of this SubContract Item |
| Public property | [DateRequired](fsreqPurchaseOrderSubcontractItemUpdate.DateRequired_Property.md) | Date Required of this SubContract Item |
| Public property | [Description](fsreqPurchaseOrderSubcontractItemUpdate.Description_Property.md) | Description of this SubContract Item |
| Public property | [ItemID](fsreqPurchaseOrderSubcontractItemUpdate.ItemID_Property.md) | ItemID in Purchase Order this SubContract Item will have |
| Public property | [JobNumber](fsreqPurchaseOrderSubcontractItemUpdate.JobNumber_Property.md) | JobNumber of this SubContract Item |
| Public property | [Length](fsreqPurchaseOrderSubcontractItemUpdate.Length_Property.md) | Length of this SubContract Item |
| Public property | [LotNumber](fsreqPurchaseOrderSubcontractItemUpdate.LotNumber_Property.md) | Lot Number of this SubContract Item |
| Public property | [PurchaseOrderID](fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderID_Property.md) | ID of Purchase Order this SubContract Item will be added to |
| Public property | [PurchaseOrderSubcontractItemID](fsreqPurchaseOrderSubcontractItemUpdate.PurchaseOrderSubcontractItemID_Property.md) | ID of Purchase Order this SubContract Item will be added to |
| Public property | [PurchasingNote](fsreqPurchaseOrderSubcontractItemUpdate.PurchasingNote_Property.md) | Purchasing Note on this SubContract Item |
| Public property | [Quantity](fsreqPurchaseOrderSubcontractItemUpdate.Quantity_Property.md) | Quantity of this SubContract Item |
| Public property | [Sequence](fsreqPurchaseOrderSubcontractItemUpdate.Sequence_Property.md) | Sequence of this SubContract Item |
| Public property | [SubCategory](fsreqPurchaseOrderSubcontractItemUpdate.SubCategory_Property.md) | SubCategory of this SubContract Item |
| Public property | [SurfaceArea](fsreqPurchaseOrderSubcontractItemUpdate.SurfaceArea_Property.md) | Surface Area of this SubContract Item |
| Public property | [Weight](fsreqPurchaseOrderSubcontractItemUpdate.Weight_Property.md) | Weight of this SubContract Item in grams(?) |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
