---
title: fsreqPurchaseOrderFOB_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-fobupdate-class-80054
slug: fsreq-purchase-order-fobupdate-class-80054
node_id: 80054
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderFOB_Update Class
children:
- title: fsreqPurchaseOrderFOB_Update Constructor
  kind: Constructor
  slug: fsreq-purchase-order-fobupdate-constructor-80055
  path: fsreqPurchaseOrderFOB_Update_Constructor.md
- title: fsreqPurchaseOrderFOB_Update.DefaultFOB Property
  kind: Property
  slug: default-fob-property-80057
  path: fsreqPurchaseOrderFOB_Update.DefaultFOB_Property.md
- title: fsreqPurchaseOrderFOB_Update.Description Property
  kind: Property
  slug: description-property-80058
  path: fsreqPurchaseOrderFOB_Update.Description_Property.md
- title: fsreqPurchaseOrderFOB_Update.FOBMapping Property
  kind: Property
  slug: fob-mapping-property-80059
  path: fsreqPurchaseOrderFOB_Update.FOBMapping_Property.md
- title: fsreqPurchaseOrderFOB_Update.PurchaseOrderFOBID Property
  kind: Property
  slug: purchase-order-fobid-property-80060
  path: fsreqPurchaseOrderFOB_Update.PurchaseOrderFOBID_Property.md
---

# fsreqPurchaseOrderFOB_Update Class

Updates PurchaseOrderFOB

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderFOB\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderFOB_Update : fsreqCommand
```

The fsreqPurchaseOrderFOB\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderFOB\_Update](fsreqPurchaseOrderFOB_Update_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderFOB\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultFOB](fsreqPurchaseOrderFOB_Update.DefaultFOB_Property.md) | DefaultFOB |
| Public property | [Description](fsreqPurchaseOrderFOB_Update.Description_Property.md) | Description |
| Public property | [FOBMapping](fsreqPurchaseOrderFOB_Update.FOBMapping_Property.md) | FOBMapping |
| Public property | [PurchaseOrderFOBID](fsreqPurchaseOrderFOB_Update.PurchaseOrderFOBID_Property.md) | PurchaseOrderFOBID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
