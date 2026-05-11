---
title: fsreqPurchaseOrderFOB_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-fobget-class-80043
slug: fsreq-purchase-order-fobget-class-80043
node_id: 80043
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderFOB_Get Class
children:
- title: fsreqPurchaseOrderFOB_Get Constructor
  kind: Constructor
  slug: fsreq-purchase-order-fobget-constructor-80044
  path: fsreqPurchaseOrderFOB_Get_Constructor.md
- title: fsreqPurchaseOrderFOB_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80046
  path: fsreqPurchaseOrderFOB_Get.LastLogID_Property.md
- title: fsreqPurchaseOrderFOB_Get.PurchaseOrderFOBID Property
  kind: Property
  slug: purchase-order-fobid-property-80047
  path: fsreqPurchaseOrderFOB_Get.PurchaseOrderFOBID_Property.md
---

# fsreqPurchaseOrderFOB_Get Class

Retrieves PurchaseOrderFOB.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderFOB\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderFOB_Get : fsreqCommand
```

The fsreqPurchaseOrderFOB\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderFOB\_Get](fsreqPurchaseOrderFOB_Get_Constructor.md) | fsreqPurchaseOrderFOB\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqPurchaseOrderFOB_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [PurchaseOrderFOBID](fsreqPurchaseOrderFOB_Get.PurchaseOrderFOBID_Property.md) | PurchaseOrderFOBID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
