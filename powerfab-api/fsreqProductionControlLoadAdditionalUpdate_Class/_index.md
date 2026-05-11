---
title: fsreqProductionControlLoadAdditionalUpdate Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-additional-update-class-79804
slug: fsreq-production-control-load-additional-update-class-79804
node_id: 79804
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadAdditionalUpdate Class
children:
- title: fsreqProductionControlLoadAdditionalUpdate Constructor
  kind: Constructor
  slug: fsreq-production-control-load-additional-update-constructor-79805
  path: fsreqProductionControlLoadAdditionalUpdate_Constructor.md
- title: fsreqProductionControlLoadAdditionalUpdate.Description Property
  kind: Property
  slug: description-property-79807
  path: fsreqProductionControlLoadAdditionalUpdate.Description_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.Notes Property
  kind: Property
  slug: notes-property-79808
  path: fsreqProductionControlLoadAdditionalUpdate.Notes_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.PerformReverseTFS Property
  kind: Property
  slug: perform-reverse-tfs-property-79809
  path: fsreqProductionControlLoadAdditionalUpdate.PerformReverseTFS_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79810
  path: fsreqProductionControlLoadAdditionalUpdate.ProductionControlLoadID_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.ProductionControlTrucksAdditionalID Property
  kind: Property
  slug: production-control-trucks-additional-id-property-79811
  path: fsreqProductionControlLoadAdditionalUpdate.ProductionControlTrucksAdditionalID_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.Quantity Property
  kind: Property
  slug: quantity-property-79812
  path: fsreqProductionControlLoadAdditionalUpdate.Quantity_Property.md
- title: fsreqProductionControlLoadAdditionalUpdate.WeightEach Property
  kind: Property
  slug: weight-each-property-79813
  path: fsreqProductionControlLoadAdditionalUpdate.WeightEach_Property.md
---

# fsreqProductionControlLoadAdditionalUpdate Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadAdditionalUpdate

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadAdditionalUpdate : fsreqCommand
```

The fsreqProductionControlLoadAdditionalUpdate type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadAdditionalUpdate](fsreqProductionControlLoadAdditionalUpdate_Constructor.md) | Initializes a new instance of the fsreqProductionControlLoadAdditionalUpdate class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Description](fsreqProductionControlLoadAdditionalUpdate.Description_Property.md) |  |
| Public property | [Notes](fsreqProductionControlLoadAdditionalUpdate.Notes_Property.md) |  |
| Public property | [PerformReverseTFS](fsreqProductionControlLoadAdditionalUpdate.PerformReverseTFS_Property.md) | If true and this update is for reducing the quantity of inventory record, then perform a reverse TFS and add that material back into inventory. |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadAdditionalUpdate.ProductionControlLoadID_Property.md) |  |
| Public property | [ProductionControlTrucksAdditionalID](fsreqProductionControlLoadAdditionalUpdate.ProductionControlTrucksAdditionalID_Property.md) |  |
| Public property | [Quantity](fsreqProductionControlLoadAdditionalUpdate.Quantity_Property.md) |  |
| Public property | [WeightEach](fsreqProductionControlLoadAdditionalUpdate.WeightEach_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
