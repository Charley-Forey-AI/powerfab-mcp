---
title: fsreqPurchaseOrderPOType_Delete Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-po-typedelete-class-80108
slug: fsreq-purchase-order-po-typedelete-class-80108
node_id: 80108
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPOType_Delete Class
children:
- title: fsreqPurchaseOrderPOType_Delete Constructor
  kind: Constructor
  slug: fsreq-purchase-order-po-typedelete-constructor-80109
  path: fsreqPurchaseOrderPOType_Delete_Constructor.md
- title: fsreqPurchaseOrderPOType_Delete.PurchaseOrderPOTypeID Property
  kind: Property
  slug: purchase-order-po-type-id-property-80111
  path: fsreqPurchaseOrderPOType_Delete.PurchaseOrderPOTypeID_Property.md
---

# fsreqPurchaseOrderPOType_Delete Class

Deletes PurchaseOrderPOType

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPOType\_Delete

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPOType_Delete : fsreqCommand
```

The fsreqPurchaseOrderPOType\_Delete type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPOType\_Delete](fsreqPurchaseOrderPOType_Delete_Constructor.md) | fsreqPurchaseOrderPOType\_Delete class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [PurchaseOrderPOTypeID](fsreqPurchaseOrderPOType_Delete.PurchaseOrderPOTypeID_Property.md) | PurchaseOrderPOTypeID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
