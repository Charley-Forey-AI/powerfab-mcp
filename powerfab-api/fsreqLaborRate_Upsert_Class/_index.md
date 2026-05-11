---
title: fsreqLaborRate_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-labor-rateupsert-class-79508
slug: fsreq-labor-rateupsert-class-79508
node_id: 79508
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqLaborRate_Upsert Class
children:
- title: fsreqLaborRate_Upsert Constructor
  kind: Constructor
  slug: fsreq-labor-rateupsert-constructor-79509
  path: fsreqLaborRate_Upsert_Constructor.md
- title: fsreqLaborRate_Upsert.Description Property
  kind: Property
  slug: description-property-79511
  path: fsreqLaborRate_Upsert.Description_Property.md
- title: fsreqLaborRate_Upsert.LaborRate Property
  kind: Property
  slug: labor-rate-property-79512
  path: fsreqLaborRate_Upsert.LaborRate_Property.md
- title: fsreqLaborRate_Upsert.LaborRateID Property
  kind: Property
  slug: labor-rate-id-property-79513
  path: fsreqLaborRate_Upsert.LaborRateID_Property.md
- title: fsreqLaborRate_Upsert.SpecialMeaning Property
  kind: Property
  slug: special-meaning-property-79514
  path: fsreqLaborRate_Upsert.SpecialMeaning_Property.md
---

# fsreqLaborRate_Upsert Class

Inserts or updates a Labor Rate in Tekla PowerFab.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqLaborRate\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqLaborRate_Upsert : fsreqCommand
```

The fsreqLaborRate\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqLaborRate\_Upsert](fsreqLaborRate_Upsert_Constructor.md) | fsreqLaborRate\_Upsert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Description](fsreqLaborRate_Upsert.Description_Property.md) | Description |
| Public property | [LaborRate](fsreqLaborRate_Upsert.LaborRate_Property.md) | LaborRate |
| Public property | [LaborRateID](fsreqLaborRate_Upsert.LaborRateID_Property.md) | LaborRateID |
| Public property | [SpecialMeaning](fsreqLaborRate_Upsert.SpecialMeaning_Property.md) | SpecialMeaning |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
