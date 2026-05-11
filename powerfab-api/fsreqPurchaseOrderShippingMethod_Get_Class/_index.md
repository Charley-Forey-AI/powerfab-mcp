---
title: fsreqPurchaseOrderShippingMethod_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-shipping-methodget-class-80134
slug: fsreq-purchase-order-shipping-methodget-class-80134
node_id: 80134
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderShippingMethod_Get Class
children:
- title: fsreqPurchaseOrderShippingMethod_Get Constructor
  kind: Constructor
  slug: fsreq-purchase-order-shipping-methodget-constructor-80135
  path: fsreqPurchaseOrderShippingMethod_Get_Constructor.md
- title: fsreqPurchaseOrderShippingMethod_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80137
  path: fsreqPurchaseOrderShippingMethod_Get.LastLogID_Property.md
- title: fsreqPurchaseOrderShippingMethod_Get.PurchaseOrderShippingMethodID Property
  kind: Property
  slug: purchase-order-shipping-method-id-property-80138
  path: fsreqPurchaseOrderShippingMethod_Get.PurchaseOrderShippingMethodID_Property.md
---

# fsreqPurchaseOrderShippingMethod_Get Class

Retrieves PurchaseOrderShippingMethod.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderShippingMethod\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderShippingMethod_Get : fsreqCommand
```

The fsreqPurchaseOrderShippingMethod\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderShippingMethod\_Get](fsreqPurchaseOrderShippingMethod_Get_Constructor.md) | fsreqPurchaseOrderShippingMethod\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqPurchaseOrderShippingMethod_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [PurchaseOrderShippingMethodID](fsreqPurchaseOrderShippingMethod_Get.PurchaseOrderShippingMethodID_Property.md) | PurchaseOrderShippingMethodID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
