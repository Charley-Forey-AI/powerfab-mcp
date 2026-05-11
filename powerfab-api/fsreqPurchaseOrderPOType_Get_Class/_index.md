---
title: fsreqPurchaseOrderPOType_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-po-typeget-class-80112
slug: fsreq-purchase-order-po-typeget-class-80112
node_id: 80112
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPOType_Get Class
children:
- title: fsreqPurchaseOrderPOType_Get Constructor
  kind: Constructor
  slug: fsreq-purchase-order-po-typeget-constructor-80113
  path: fsreqPurchaseOrderPOType_Get_Constructor.md
- title: fsreqPurchaseOrderPOType_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80115
  path: fsreqPurchaseOrderPOType_Get.LastLogID_Property.md
- title: fsreqPurchaseOrderPOType_Get.PurchaseOrderPOTypeID Property
  kind: Property
  slug: purchase-order-po-type-id-property-80116
  path: fsreqPurchaseOrderPOType_Get.PurchaseOrderPOTypeID_Property.md
---

# fsreqPurchaseOrderPOType_Get Class

Retrieves PurchaseOrderPOType.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPOType\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPOType_Get : fsreqCommand
```

The fsreqPurchaseOrderPOType\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPOType\_Get](fsreqPurchaseOrderPOType_Get_Constructor.md) | fsreqPurchaseOrderPOType\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqPurchaseOrderPOType_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [PurchaseOrderPOTypeID](fsreqPurchaseOrderPOType_Get.PurchaseOrderPOTypeID_Property.md) | PurchaseOrderPOTypeID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
