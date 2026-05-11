---
title: fsreqPurchaseOrderSubcontractItemGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-subcontract-item-get-class-80156
slug: fsreq-purchase-order-subcontract-item-get-class-80156
node_id: 80156
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderSubcontractItemGet Class
children:
- title: fsreqPurchaseOrderSubcontractItemGet Constructor
  kind: Constructor
  slug: fsreq-purchase-order-subcontract-item-get-constructor-80157
  path: fsreqPurchaseOrderSubcontractItemGet_Constructor.md
- title: fsreqPurchaseOrderSubcontractItemGet.GetOptions Property
  kind: Property
  slug: get-options-property-80159
  path: fsreqPurchaseOrderSubcontractItemGet.GetOptions_Property.md
- title: fsreqPurchaseOrderSubcontractItemGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-80160
  path: fsreqPurchaseOrderSubcontractItemGet.LastLogID_Property.md
- title: fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderID Property
  kind: Property
  slug: purchase-order-id-property-80161
  path: fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderID_Property.md
- title: fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderSubcontractItemID Property
  kind: Property
  slug: purchase-order-subcontract-item-id-property-80162
  path: fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderSubcontractItemID_Property.md
---

# fsreqPurchaseOrderSubcontractItemGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderSubcontractItemGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderSubcontractItemGet : fsreqCommand
```

The fsreqPurchaseOrderSubcontractItemGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderSubcontractItemGet](fsreqPurchaseOrderSubcontractItemGet_Constructor.md) | fsreqPurchaseOrderSubcontractItemGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqPurchaseOrderSubcontractItemGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqPurchaseOrderSubcontractItemGet.LastLogID_Property.md) | Get changes since this LogID |
| Public property | [PurchaseOrderID](fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderID_Property.md) | ID of Purchase Order to get SubContract Items from |
| Public property | [PurchaseOrderSubcontractItemID](fsreqPurchaseOrderSubcontractItemGet.PurchaseOrderSubcontractItemID_Property.md) | ID of SubContract Item to get |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
