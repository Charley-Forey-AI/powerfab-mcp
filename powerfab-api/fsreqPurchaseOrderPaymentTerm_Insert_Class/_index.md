---
title: fsreqPurchaseOrderPaymentTerm_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-payment-terminsert-class-80093
slug: fsreq-purchase-order-payment-terminsert-class-80093
node_id: 80093
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPaymentTerm_Insert Class
children:
- title: fsreqPurchaseOrderPaymentTerm_Insert Constructor
  kind: Constructor
  slug: fsreq-purchase-order-payment-terminsert-constructor-80094
  path: fsreqPurchaseOrderPaymentTerm_Insert_Constructor.md
- title: fsreqPurchaseOrderPaymentTerm_Insert.DefaultPaymentTerm Property
  kind: Property
  slug: default-payment-term-property-80096
  path: fsreqPurchaseOrderPaymentTerm_Insert.DefaultPaymentTerm_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Insert.Description Property
  kind: Property
  slug: description-property-80097
  path: fsreqPurchaseOrderPaymentTerm_Insert.Description_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Insert.Discount Property
  kind: Property
  slug: discount-property-80098
  path: fsreqPurchaseOrderPaymentTerm_Insert.Discount_Property.md
- title: fsreqPurchaseOrderPaymentTerm_Insert.PaymentTermMapping Property
  kind: Property
  slug: payment-term-mapping-property-80099
  path: fsreqPurchaseOrderPaymentTerm_Insert.PaymentTermMapping_Property.md
---

# fsreqPurchaseOrderPaymentTerm_Insert Class

Inserts PurchaseOrderPaymentTerm

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPaymentTerm\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPaymentTerm_Insert : fsreqCommand
```

The fsreqPurchaseOrderPaymentTerm\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPaymentTerm\_Insert](fsreqPurchaseOrderPaymentTerm_Insert_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderPaymentTerm\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultPaymentTerm](fsreqPurchaseOrderPaymentTerm_Insert.DefaultPaymentTerm_Property.md) | DefaultPaymentTerm |
| Public property | [Description](fsreqPurchaseOrderPaymentTerm_Insert.Description_Property.md) | Description |
| Public property | [Discount](fsreqPurchaseOrderPaymentTerm_Insert.Discount_Property.md) | Discount |
| Public property | [PaymentTermMapping](fsreqPurchaseOrderPaymentTerm_Insert.PaymentTermMapping_Property.md) | PaymentTermMapping |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
