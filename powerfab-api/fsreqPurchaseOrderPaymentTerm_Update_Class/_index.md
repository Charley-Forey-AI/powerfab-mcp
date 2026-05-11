---
title: fsreqPurchaseOrderPaymentTerm_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-payment-termupdate-class-80100
slug: fsreq-purchase-order-payment-termupdate-class-80100
node_id: 80100
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPaymentTerm_Update Class
children:
- title: fsreqPurchaseOrderPaymentTerm_Update Constructor
  kind: Constructor
  slug: fsreq-purchase-order-payment-termupdate-constructor-80101
  path: fsreqPurchaseOrderPaymentTerm_Update_Constructor.md
- title: fsreqPurchaseOrderPaymentTerm_Update.DefaultPaymentTerm Property
  kind: Property
  slug: default-payment-term-property-80103
  path: fsreqPurchaseOrderPaymentTerm_Update.DefaultPaymentTerm_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Update.Description Property
  kind: Property
  slug: description-property-80104
  path: fsreqPurchaseOrderPaymentTerm_Update.Description_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Update.Discount Property
  kind: Property
  slug: discount-property-80105
  path: fsreqPurchaseOrderPaymentTerm_Update.Discount_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Update.PaymentTermMapping Property
  kind: Property
  slug: payment-term-mapping-property-80106
  path: fsreqPurchaseOrderPaymentTerm_Update.PaymentTermMapping_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Update.PurchaseOrderPaymentTermID Property
  kind: Property
  slug: purchase-order-payment-term-id-property-80107
  path: fsreqPurchaseOrderPaymentTerm_Update.PurchaseOrderPaymentTermID_Property.md
---

# fsreqPurchaseOrderPaymentTerm_Update Class

Updates PurchaseOrderPaymentTerm

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPaymentTerm\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPaymentTerm_Update : fsreqCommand
```

The fsreqPurchaseOrderPaymentTerm\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPaymentTerm\_Update](fsreqPurchaseOrderPaymentTerm_Update_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderPaymentTerm\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultPaymentTerm](fsreqPurchaseOrderPaymentTerm_Update.DefaultPaymentTerm_Property.md) | DefaultPaymentTerm |
| Public property | [Description](fsreqPurchaseOrderPaymentTerm_Update.Description_Property.md) | Description |
| Public property | [Discount](fsreqPurchaseOrderPaymentTerm_Update.Discount_Property.md) | Discount |
| Public property | [PaymentTermMapping](fsreqPurchaseOrderPaymentTerm_Update.PaymentTermMapping_Property.md) | PaymentTermMapping |
| Public property | [PurchaseOrderPaymentTermID](fsreqPurchaseOrderPaymentTerm_Update.PurchaseOrderPaymentTermID_Property.md) | PurchaseOrderPaymentTermID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
