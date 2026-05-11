---
title: fsreqPurchaseOrderPOType_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-po-typeupdate-class-80123
slug: fsreq-purchase-order-po-typeupdate-class-80123
node_id: 80123
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPOType_Update Class
children:
- title: fsreqPurchaseOrderPOType_Update Constructor
  kind: Constructor
  slug: fsreq-purchase-order-po-typeupdate-constructor-80124
  path: fsreqPurchaseOrderPOType_Update_Constructor.md
- title: fsreqPurchaseOrderPOType_Update.DefaultPOType Property
  kind: Property
  slug: default-po-type-property-80126
  path: fsreqPurchaseOrderPOType_Update.DefaultPOType_Property.md
- title: fsreqPurchaseOrderPOType_Update.Description Property
  kind: Property
  slug: description-property-80127
  path: fsreqPurchaseOrderPOType_Update.Description_Property.md
- title: fsreqPurchaseOrderPOType_Update.POTypeMapping Property
  kind: Property
  slug: po-type-mapping-property-80128
  path: fsreqPurchaseOrderPOType_Update.POTypeMapping_Property.md
- title: fsreqPurchaseOrderPOType_Update.PurchaseOrderPOTypeID Property
  kind: Property
  slug: purchase-order-po-type-id-property-80129
  path: fsreqPurchaseOrderPOType_Update.PurchaseOrderPOTypeID_Property.md
---

# fsreqPurchaseOrderPOType_Update Class

Updates PurchaseOrderPOType

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPOType\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPOType_Update : fsreqCommand
```

The fsreqPurchaseOrderPOType\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPOType\_Update](fsreqPurchaseOrderPOType_Update_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderPOType\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultPOType](fsreqPurchaseOrderPOType_Update.DefaultPOType_Property.md) | DefaultPOType |
| Public property | [Description](fsreqPurchaseOrderPOType_Update.Description_Property.md) | Description |
| Public property | [POTypeMapping](fsreqPurchaseOrderPOType_Update.POTypeMapping_Property.md) | POTypeMapping |
| Public property | [PurchaseOrderPOTypeID](fsreqPurchaseOrderPOType_Update.PurchaseOrderPOTypeID_Property.md) | PurchaseOrderPOTypeID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
