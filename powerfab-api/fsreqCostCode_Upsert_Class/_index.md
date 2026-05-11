---
title: fsreqCostCode_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-cost-codeupsert-class-77681
slug: fsreq-cost-codeupsert-class-77681
node_id: 77681
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCostCode_Upsert Class
children:
- title: fsreqCostCode_Upsert Constructor
  kind: Constructor
  slug: fsreq-cost-codeupsert-constructor-77682
  path: fsreqCostCode_Upsert_Constructor.md
- title: fsreqCostCode_Upsert.CostCode Property
  kind: Property
  slug: cost-code-property-77684
  path: fsreqCostCode_Upsert.CostCode_Property.md
- title: fsreqCostCode_Upsert.CostCodeID Property
  kind: Property
  slug: cost-code-id-property-77685
  path: fsreqCostCode_Upsert.CostCodeID_Property.md
- title: fsreqCostCode_Upsert.DefaultCostTypeID Property
  kind: Property
  slug: default-cost-type-id-property-77686
  path: fsreqCostCode_Upsert.DefaultCostTypeID_Property.md
- title: fsreqCostCode_Upsert.Description Property
  kind: Property
  slug: description-property-77687
  path: fsreqCostCode_Upsert.Description_Property.md
---

# fsreqCostCode_Upsert Class

Inserts or updates into Tekla PowerFab CostCode

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqCostCode\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqCostCode_Upsert : fsreqCommand
```

The fsreqCostCode\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqCostCode\_Upsert](fsreqCostCode_Upsert_Constructor.md) | Initializes a new instance of the fsreqCostCode\_Upsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CostCode](fsreqCostCode_Upsert.CostCode_Property.md) |  |
| Public property | [CostCodeID](fsreqCostCode_Upsert.CostCodeID_Property.md) |  |
| Public property | [DefaultCostTypeID](fsreqCostCode_Upsert.DefaultCostTypeID_Property.md) |  |
| Public property | [Description](fsreqCostCode_Upsert.Description_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
