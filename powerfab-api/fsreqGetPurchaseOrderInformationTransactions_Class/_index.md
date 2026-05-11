---
title: fsreqGetPurchaseOrderInformationTransactions Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-purchase-order-information-transactions-class-79250
slug: fsreq-get-purchase-order-information-transactions-class-79250
node_id: 79250
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetPurchaseOrderInformationTransactions Class
children:
- title: fsreqGetPurchaseOrderInformationTransactions Constructor
  kind: Constructor
  slug: fsreq-get-purchase-order-information-transactions-constructor-79251
  path: fsreqGetPurchaseOrderInformationTransactions_Constructor.md
- title: fsreqGetPurchaseOrderInformationTransactions.LastLogID Property
  kind: Property
  slug: last-log-id-property-79253
  path: fsreqGetPurchaseOrderInformationTransactions.LastLogID_Property.md
- title: fsreqGetPurchaseOrderInformationTransactions.PONumber Property
  kind: Property
  slug: po-number-property-79254
  path: fsreqGetPurchaseOrderInformationTransactions.PONumber_Property.md
---

# fsreqGetPurchaseOrderInformationTransactions Class

Retrieves the changes that have been made to Purchase Order information.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetPurchaseOrderInformationTransactions

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetPurchaseOrderInformationTransactions : fsreqCommand
```

The fsreqGetPurchaseOrderInformationTransactions type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetPurchaseOrderInformationTransactions](fsreqGetPurchaseOrderInformationTransactions_Constructor.md) | fsreqGetPurchaseOrderInformationTransactions class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqGetPurchaseOrderInformationTransactions.LastLogID_Property.md) | The log ID that the purchase order transactions have already been read up to. Only retrieve transactions after this log ID. |
| Public property | [PONumber](fsreqGetPurchaseOrderInformationTransactions.PONumber_Property.md) | The purchase orders to retrieve the information from. If no PONumber elements are specified then all purchase orders will be returned. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
