---
title: fsreqPurchaseOrder_UpdateSyncStatus Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-orderupdate-sync-status-class-80033
slug: fsreq-purchase-orderupdate-sync-status-class-80033
node_id: 80033
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrder_UpdateSyncStatus Class
children:
- title: fsreqPurchaseOrder_UpdateSyncStatus Constructor
  kind: Constructor
  slug: fsreq-purchase-orderupdate-sync-status-constructor-80034
  path: fsreqPurchaseOrder_UpdateSyncStatus_Constructor.md
- title: fsreqPurchaseOrder_UpdateSyncStatus.PurchaseOrderID Property
  kind: Property
  slug: purchase-order-id-property-80036
  path: fsreqPurchaseOrder_UpdateSyncStatus.PurchaseOrderID_Property.md
- title: fsreqPurchaseOrder_UpdateSyncStatus.SyncMessage Property
  kind: Property
  slug: sync-message-property-80037
  path: fsreqPurchaseOrder_UpdateSyncStatus.SyncMessage_Property.md
- title: fsreqPurchaseOrder_UpdateSyncStatus.SyncStatus Property
  kind: Property
  slug: sync-status-property-80038
  path: fsreqPurchaseOrder_UpdateSyncStatus.SyncStatus_Property.md
---

# fsreqPurchaseOrder_UpdateSyncStatus Class

Updates the syncStatus and syncMessage of one Purchase Order.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrder\_UpdateSyncStatus

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrder_UpdateSyncStatus : fsreqCommand
```

The fsreqPurchaseOrder\_UpdateSyncStatus type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrder\_UpdateSyncStatus](fsreqPurchaseOrder_UpdateSyncStatus_Constructor.md) | fsreqPurchaseOrder\_UpdateSyncStatus class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [PurchaseOrderID](fsreqPurchaseOrder_UpdateSyncStatus.PurchaseOrderID_Property.md) | PurchaseOrderID |
| Public property | [SyncMessage](fsreqPurchaseOrder_UpdateSyncStatus.SyncMessage_Property.md) | SyncMessage to update |
| Public property | [SyncStatus](fsreqPurchaseOrder_UpdateSyncStatus.SyncStatus_Property.md) | SyncStatus to update |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
