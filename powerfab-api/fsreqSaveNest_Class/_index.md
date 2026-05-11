---
title: fsreqSaveNest Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-save-nest-class-80369
slug: fsreq-save-nest-class-80369
node_id: 80369
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSaveNest Class
children:
- title: fsreqSaveNest Constructor
  kind: Constructor
  slug: fsreq-save-nest-constructor-80370
  path: fsreqSaveNest_Constructor.md
- title: fsreqSaveNest.CombinationRunID Property
  kind: Property
  slug: combination-run-id-property-80372
  path: fsreqSaveNest.CombinationRunID_Property.md
- title: fsreqSaveNest.CreationDateTime Property
  kind: Property
  slug: creation-date-time-property-80373
  path: fsreqSaveNest.CreationDateTime_Property.md
- title: fsreqSaveNest.DeleteNestID Property
  kind: Property
  slug: delete-nest-id-property-80374
  path: fsreqSaveNest.DeleteNestID_Property.md
- title: fsreqSaveNest.NestResult Property
  kind: Property
  slug: nest-result-property-80375
  path: fsreqSaveNest.NestResult_Property.md
- title: fsreqSaveNest.PurchaseOrderNumber Property
  kind: Property
  slug: purchase-order-number-property-80376
  path: fsreqSaveNest.PurchaseOrderNumber_Property.md
- title: fsreqSaveNest.RequisitionNumber Property
  kind: Property
  slug: requisition-number-property-80377
  path: fsreqSaveNest.RequisitionNumber_Property.md
- title: fsreqSaveNest.SourceApplication Property
  kind: Property
  slug: source-application-property-80378
  path: fsreqSaveNest.SourceApplication_Property.md
- title: fsreqSaveNest.SourceApplicationVersion Property
  kind: Property
  slug: source-application-version-property-80379
  path: fsreqSaveNest.SourceApplicationVersion_Property.md
---

# fsreqSaveNest Class

Saves the result of a nest performed in External Software to FabSuite.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSaveNest

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSaveNest : fsreqCommand
```

The fsreqSaveNest type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSaveNest](fsreqSaveNest_Constructor.md) | fsreqSaveNest class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CombinationRunID](fsreqSaveNest.CombinationRunID_Property.md) | FabSuite Combining Run that this Nest is for. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CreationDateTime](fsreqSaveNest.CreationDateTime_Property.md) | Date/Time that nest was performed. |
| Public property | [DeleteNestID](fsreqSaveNest.DeleteNestID_Property.md) | Delete the Nest with this ID |
| Public property | [NestResult](fsreqSaveNest.NestResult_Property.md) | Nest Result object |
| Public property | [PurchaseOrderNumber](fsreqSaveNest.PurchaseOrderNumber_Property.md) | FabSuite Purchase Order to add material for purchase. If specified and the purchaseOrder exists, this will be used instead of RequisitionNumber when we need to purchase material |
| Public property | [RequisitionNumber](fsreqSaveNest.RequisitionNumber_Property.md) | FabSuite Requisition to add material for purchase |
| Public property | [SourceApplication](fsreqSaveNest.SourceApplication_Property.md) | Name of application creating this nest. |
| Public property | [SourceApplicationVersion](fsreqSaveNest.SourceApplicationVersion_Property.md) | Version of source application. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
