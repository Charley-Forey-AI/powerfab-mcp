---
title: fsreqPurchaseOrderFOB_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-purchase-order-fobinsert-class-80048
slug: fsreq-purchase-order-fobinsert-class-80048
node_id: 80048
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPurchaseOrderFOB_Insert Class
children:
- title: fsreqPurchaseOrderFOB_Insert Constructor
  kind: Constructor
  slug: fsreq-purchase-order-fobinsert-constructor-80049
  path: fsreqPurchaseOrderFOB_Insert_Constructor.md
- title: fsreqPurchaseOrderFOB_Insert.DefaultFOB Property
  kind: Property
  slug: default-fob-property-80051
  path: fsreqPurchaseOrderFOB_Insert.DefaultFOB_Property.md
- title: fsreqPurchaseOrderFOB_Insert.Description Property
  kind: Property
  slug: description-property-80052
  path: fsreqPurchaseOrderFOB_Insert.Description_Property.md
- title: fsreqPurchaseOrderFOB_Insert.FOBMapping Property
  kind: Property
  slug: fob-mapping-property-80053
  path: fsreqPurchaseOrderFOB_Insert.FOBMapping_Property.md
---

# fsreqPurchaseOrderFOB_Insert Class

Inserts PurchaseOrderFOB

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPurchaseOrderFOB\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPurchaseOrderFOB_Insert : fsreqCommand
```

The fsreqPurchaseOrderFOB\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPurchaseOrderFOB\_Insert](fsreqPurchaseOrderFOB_Insert_Constructor.md) | Initializes a new instance of the fsreqPurchaseOrderFOB\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultFOB](fsreqPurchaseOrderFOB_Insert.DefaultFOB_Property.md) | DefaultFOB |
| Public property | [Description](fsreqPurchaseOrderFOB_Insert.Description_Property.md) | Description |
| Public property | [FOBMapping](fsreqPurchaseOrderFOB_Insert.FOBMapping_Property.md) | FOBMapping |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
