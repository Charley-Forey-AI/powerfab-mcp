---
title: fsreqPurchaseOrderSubcontractItemInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-subcontract-item-insert-class-80170
slug: fsreq-purchase-order-subcontract-item-insert-class-80170
node_id: 80170
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderSubcontractItemInsert Class
children:
- title: fsreqPurchaseOrderSubcontractItemInsert Constructor
  kind: Constructor
  slug: fsreq-purchase-order-subcontract-item-insert-constructor-80171
  path: fsreqPurchaseOrderSubcontractItemInsert_Constructor.md
- title: fsreqPurchaseOrderSubcontractItemInsert.BasePrice Property
  kind: Property
  slug: base-price-property-80173
  path: fsreqPurchaseOrderSubcontractItemInsert.BasePrice_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Category Property
  kind: Property
  slug: category-property-80174
  path: fsreqPurchaseOrderSubcontractItemInsert.Category_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Comment Property
  kind: Property
  slug: comment-property-80175
  path: fsreqPurchaseOrderSubcontractItemInsert.Comment_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.CostCodeID Property
  kind: Property
  slug: cost-code-id-property-80176
  path: fsreqPurchaseOrderSubcontractItemInsert.CostCodeID_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.CostTypeID Property
  kind: Property
  slug: cost-type-id-property-80177
  path: fsreqPurchaseOrderSubcontractItemInsert.CostTypeID_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.DatePromised Property
  kind: Property
  slug: date-promised-property-80178
  path: fsreqPurchaseOrderSubcontractItemInsert.DatePromised_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.DateRequired Property
  kind: Property
  slug: date-required-property-80179
  path: fsreqPurchaseOrderSubcontractItemInsert.DateRequired_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Description Property
  kind: Property
  slug: description-property-80180
  path: fsreqPurchaseOrderSubcontractItemInsert.Description_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.ItemID Property
  kind: Property
  slug: item-id-property-80181
  path: fsreqPurchaseOrderSubcontractItemInsert.ItemID_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.JobNumber Property
  kind: Property
  slug: job-number-property-80182
  path: fsreqPurchaseOrderSubcontractItemInsert.JobNumber_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Length Property
  kind: Property
  slug: length-property-80183
  path: fsreqPurchaseOrderSubcontractItemInsert.Length_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.LotNumber Property
  kind: Property
  slug: lot-number-property-80184
  path: fsreqPurchaseOrderSubcontractItemInsert.LotNumber_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.PurchaseOrderID Property
  kind: Property
  slug: purchase-order-id-property-80185
  path: fsreqPurchaseOrderSubcontractItemInsert.PurchaseOrderID_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.PurchasingNote Property
  kind: Property
  slug: purchasing-note-property-80186
  path: fsreqPurchaseOrderSubcontractItemInsert.PurchasingNote_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Quantity Property
  kind: Property
  slug: quantity-property-80187
  path: fsreqPurchaseOrderSubcontractItemInsert.Quantity_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Sequence Property
  kind: Property
  slug: sequence-property-80188
  path: fsreqPurchaseOrderSubcontractItemInsert.Sequence_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.SubCategory Property
  kind: Property
  slug: sub-category-property-80189
  path: fsreqPurchaseOrderSubcontractItemInsert.SubCategory_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.SurfaceArea Property
  kind: Property
  slug: surface-area-property-80190
  path: fsreqPurchaseOrderSubcontractItemInsert.SurfaceArea_Property.md
- title: fsreqPurchaseOrderSubcontractItemInsert.Weight Property
  kind: Property
  slug: weight-property-80191
  path: fsreqPurchaseOrderSubcontractItemInsert.Weight_Property.md
---

# fsreqPurchaseOrderSubcontractItemInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderSubcontractItemInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderSubcontractItemInsert : fsreqCommand
```

The fsreqPurchaseOrderSubcontractItemInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderSubcontractItemInsert](fsreqPurchaseOrderSubcontractItemInsert_Constructor.md) | fsreqPurchaseOrderSubcontractItemInsert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BasePrice](fsreqPurchaseOrderSubcontractItemInsert.BasePrice_Property.md) | Base Price of this SubContract Item |
| Public property | [Category](fsreqPurchaseOrderSubcontractItemInsert.Category_Property.md) | Category of this SubContract Item |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Comment](fsreqPurchaseOrderSubcontractItemInsert.Comment_Property.md) | Comment of this SubContract Item |
| Public property | [CostCodeID](fsreqPurchaseOrderSubcontractItemInsert.CostCodeID_Property.md) | Cost Code ID of this SubContract Item |
| Public property | [CostTypeID](fsreqPurchaseOrderSubcontractItemInsert.CostTypeID_Property.md) | Cost Type ID of this SubContract Item |
| Public property | [DatePromised](fsreqPurchaseOrderSubcontractItemInsert.DatePromised_Property.md) | Date Promised of this SubContract Item |
| Public property | [DateRequired](fsreqPurchaseOrderSubcontractItemInsert.DateRequired_Property.md) | Date Required of this SubContract Item |
| Public property | [Description](fsreqPurchaseOrderSubcontractItemInsert.Description_Property.md) | Description of this SubContract Item |
| Public property | [ItemID](fsreqPurchaseOrderSubcontractItemInsert.ItemID_Property.md) | ItemID in Purchase Order this SubContract Item will have |
| Public property | [JobNumber](fsreqPurchaseOrderSubcontractItemInsert.JobNumber_Property.md) | JobNumber of this SubContract Item |
| Public property | [Length](fsreqPurchaseOrderSubcontractItemInsert.Length_Property.md) | Length of this SubContract Item |
| Public property | [LotNumber](fsreqPurchaseOrderSubcontractItemInsert.LotNumber_Property.md) | Lot Number of this SubContract Item |
| Public property | [PurchaseOrderID](fsreqPurchaseOrderSubcontractItemInsert.PurchaseOrderID_Property.md) | ID of Purchase Order this SubContract Item will be added to |
| Public property | [PurchasingNote](fsreqPurchaseOrderSubcontractItemInsert.PurchasingNote_Property.md) | Purchasing Note on this SubContract Item |
| Public property | [Quantity](fsreqPurchaseOrderSubcontractItemInsert.Quantity_Property.md) | Quantity of this SubContract Item |
| Public property | [Sequence](fsreqPurchaseOrderSubcontractItemInsert.Sequence_Property.md) | Sequence of this SubContract Item |
| Public property | [SubCategory](fsreqPurchaseOrderSubcontractItemInsert.SubCategory_Property.md) | SubCategory of this SubContract Item |
| Public property | [SurfaceArea](fsreqPurchaseOrderSubcontractItemInsert.SurfaceArea_Property.md) | Surface Area of this SubContract Item |
| Public property | [Weight](fsreqPurchaseOrderSubcontractItemInsert.Weight_Property.md) | Weight of this SubContract Item in grams(?) |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
