---
title: fsreqRemnant_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-remnantget-class-80303
slug: fsreq-remnantget-class-80303
node_id: 80303
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqRemnant_Get Class
children:
- title: fsreqRemnant_Get Constructor
  kind: Constructor
  slug: fsreq-remnantget-constructor-80304
  path: fsreqRemnant_Get_Constructor.md
- title: fsreqRemnant_Get.RemnantID Property
  kind: Property
  slug: remnant-id-property-80306
  path: fsreqRemnant_Get.RemnantID_Property.md
- title: fsreqRemnant_Get.RemnantName Property
  kind: Property
  slug: remnant-name-property-80307
  path: fsreqRemnant_Get.RemnantName_Property.md
---

# fsreqRemnant_Get Class

Retrieves one or more remnants

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqRemnant\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqRemnant_Get : fsreqCommand
```

The fsreqRemnant\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqRemnant\_Get](fsreqRemnant_Get_Constructor.md) | fsreqRemnant\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [RemnantID](fsreqRemnant_Get.RemnantID_Property.md) | Internal RemnantID of remnant to retrieve (PowerFab RemnantID ) |
| Public property | [RemnantName](fsreqRemnant_Get.RemnantName_Property.md) | Remnant Name of remnant to retrieve (PowerFab RemnantID ) |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
