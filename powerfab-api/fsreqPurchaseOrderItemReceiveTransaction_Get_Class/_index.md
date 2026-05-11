---
title: fsreqPurchaseOrderItemReceiveTransaction_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-item-receive-transactionget-class-80074
slug: fsreq-purchase-order-item-receive-transactionget-class-80074
node_id: 80074
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderItemReceiveTransaction_Get Class
children:
- title: fsreqPurchaseOrderItemReceiveTransaction_Get Constructor
  kind: Constructor
  slug: fsreq-purchase-order-item-receive-transactionget-constructor-80075
  path: fsreqPurchaseOrderItemReceiveTransaction_Get_Constructor.md
- title: fsreqPurchaseOrderItemReceiveTransaction_Get.ExportedSinceUnixTime Property
  kind: Property
  slug: exported-unix-time-property-80077
  path: fsreqPurchaseOrderItemReceiveTransaction_Get.ExportedSinceUnixTime_Property.md
- title: fsreqPurchaseOrderItemReceiveTransaction_Get.GetOptions Property
  kind: Property
  slug: get-options-property-80078
  path: fsreqPurchaseOrderItemReceiveTransaction_Get.GetOptions_Property.md
---

# fsreqPurchaseOrderItemReceiveTransaction_Get Class

Retrieves PurchaseOrderItems receiving transactions.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderItemReceiveTransaction\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderItemReceiveTransaction_Get : fsreqCommand
```

The fsreqPurchaseOrderItemReceiveTransaction\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderItemReceiveTransaction\_Get](fsreqPurchaseOrderItemReceiveTransaction_Get_Constructor.md) | fsreqPurchaseOrderItemReceiveTransaction\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExportedSinceUnixTime](fsreqPurchaseOrderItemReceiveTransaction_Get.ExportedSinceUnixTime_Property.md) |  |
| Public property | [GetOptions](fsreqPurchaseOrderItemReceiveTransaction_Get.GetOptions_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
