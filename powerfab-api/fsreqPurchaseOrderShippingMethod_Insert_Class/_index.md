---
title: fsreqPurchaseOrderShippingMethod_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-shipping-methodinsert-class-80139
slug: fsreq-purchase-order-shipping-methodinsert-class-80139
node_id: 80139
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderShippingMethod_Insert Class
children:
- title: fsreqPurchaseOrderShippingMethod_Insert Constructor
  kind: Constructor
  slug: fsreq-purchase-order-shipping-methodinsert-constructor-80140
  path: fsreqPurchaseOrderShippingMethod_Insert_Constructor.md
- title: fsreqPurchaseOrderShippingMethod_Insert.DefaultShippingMethod Property
  kind: Property
  slug: default-shipping-method-property-80142
  path: fsreqPurchaseOrderShippingMethod_Insert.DefaultShippingMethod_Property.md
- title: fsreqPurchaseOrderShippingMethod_Insert.Description Property
  kind: Property
  slug: description-property-80143
  path: fsreqPurchaseOrderShippingMethod_Insert.Description_Property.md
- title: fsreqPurchaseOrderShippingMethod_Insert.ShippingMethodMapping Property
  kind: Property
  slug: shipping-method-mapping-property-80144
  path: fsreqPurchaseOrderShippingMethod_Insert.ShippingMethodMapping_Property.md
---

# fsreqPurchaseOrderShippingMethod_Insert Class

Inserts PurchaseOrderShippingMethod

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderShippingMethod\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderShippingMethod_Insert : fsreqCommand
```

The fsreqPurchaseOrderShippingMethod\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderShippingMethod\_Insert](fsreqPurchaseOrderShippingMethod_Insert_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderShippingMethod\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultShippingMethod](fsreqPurchaseOrderShippingMethod_Insert.DefaultShippingMethod_Property.md) | DefaultShippingMethod |
| Public property | [Description](fsreqPurchaseOrderShippingMethod_Insert.Description_Property.md) | Description |
| Public property | [ShippingMethodMapping](fsreqPurchaseOrderShippingMethod_Insert.ShippingMethodMapping_Property.md) | ShippingMethodMapping |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
