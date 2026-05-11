---
title: fsreqPurchaseOrderPOType_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-po-typeinsert-class-80117
slug: fsreq-purchase-order-po-typeinsert-class-80117
node_id: 80117
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderPOType_Insert Class
children:
- title: fsreqPurchaseOrderPOType_Insert Constructor
  kind: Constructor
  slug: fsreq-purchase-order-po-typeinsert-constructor-80118
  path: fsreqPurchaseOrderPOType_Insert_Constructor.md
- title: fsreqPurchaseOrderPOType_Insert.DefaultPOType Property
  kind: Property
  slug: default-po-type-property-80120
  path: fsreqPurchaseOrderPOType_Insert.DefaultPOType_Property.md
- title: fsreqPurchaseOrderPOType_Insert.Description Property
  kind: Property
  slug: description-property-80121
  path: fsreqPurchaseOrderPOType_Insert.Description_Property.md
- title: fsreqPurchaseOrderPOType_Insert.POTypeMapping Property
  kind: Property
  slug: po-type-mapping-property-80122
  path: fsreqPurchaseOrderPOType_Insert.POTypeMapping_Property.md
---

# fsreqPurchaseOrderPOType_Insert Class

Inserts PurchaseOrderPOType

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderPOType\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderPOType_Insert : fsreqCommand
```

The fsreqPurchaseOrderPOType\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderPOType\_Insert](fsreqPurchaseOrderPOType_Insert_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderPOType\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultPOType](fsreqPurchaseOrderPOType_Insert.DefaultPOType_Property.md) | DefaultPOType |
| Public property | [Description](fsreqPurchaseOrderPOType_Insert.Description_Property.md) | Description |
| Public property | [POTypeMapping](fsreqPurchaseOrderPOType_Insert.POTypeMapping_Property.md) | POTypeMapping |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
