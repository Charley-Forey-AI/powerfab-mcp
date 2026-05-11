---
title: fsreqPurchaseOrderShippingMethod_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-shipping-methodupdate-class-80145
slug: fsreq-purchase-order-shipping-methodupdate-class-80145
node_id: 80145
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderShippingMethod_Update Class
children:
- title: fsreqPurchaseOrderShippingMethod_Update Constructor
  kind: Constructor
  slug: fsreq-purchase-order-shipping-methodupdate-constructor-80146
  path: fsreqPurchaseOrderShippingMethod_Update_Constructor.md
- title: fsreqPurchaseOrderShippingMethod_Update.DefaultShippingMethod Property
  kind: Property
  slug: default-shipping-method-property-80148
  path: fsreqPurchaseOrderShippingMethod_Update.DefaultShippingMethod_Property.md
- title: fsreqPurchaseOrderShippingMethod_Update.Description Property
  kind: Property
  slug: description-property-80149
  path: fsreqPurchaseOrderShippingMethod_Update.Description_Property.md
- title: fsreqPurchaseOrderShippingMethod_Update.PurchaseOrderShippingMethodID Property
  kind: Property
  slug: purchase-order-shipping-method-id-property-80150
  path: fsreqPurchaseOrderShippingMethod_Update.PurchaseOrderShippingMethodID_Property.md
- title: fsreqPurchaseOrderShippingMethod_Update.ShippingMethodMapping Property
  kind: Property
  slug: shipping-method-mapping-property-80151
  path: fsreqPurchaseOrderShippingMethod_Update.ShippingMethodMapping_Property.md
---

# fsreqPurchaseOrderShippingMethod_Update Class

Updates PurchaseOrderShippingMethod

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderShippingMethod\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderShippingMethod_Update : fsreqCommand
```

The fsreqPurchaseOrderShippingMethod\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderShippingMethod\_Update](fsreqPurchaseOrderShippingMethod_Update_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderShippingMethod\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultShippingMethod](fsreqPurchaseOrderShippingMethod_Update.DefaultShippingMethod_Property.md) | DefaultShippingMethod |
| Public property | [Description](fsreqPurchaseOrderShippingMethod_Update.Description_Property.md) | Description |
| Public property | [PurchaseOrderShippingMethodID](fsreqPurchaseOrderShippingMethod_Update.PurchaseOrderShippingMethodID_Property.md) | PurchaseOrderShippingMethodID |
| Public property | [ShippingMethodMapping](fsreqPurchaseOrderShippingMethod_Update.ShippingMethodMapping_Property.md) | ShippingMethodMapping |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
