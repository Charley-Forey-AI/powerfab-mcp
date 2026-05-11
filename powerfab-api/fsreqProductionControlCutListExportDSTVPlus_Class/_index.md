---
title: fsreqProductionControlCutListExportDSTVPlus Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-cut-list-export-dstv-plus-class-79708
slug: fsreq-production-control-cut-list-export-dstv-plus-class-79708
node_id: 79708
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlCutListExportDSTVPlus Class
children:
- title: fsreqProductionControlCutListExportDSTVPlus Constructor
  kind: Constructor
  slug: fsreq-production-control-cut-list-export-dstv-plus-constructor-79709
  path: fsreqProductionControlCutListExportDSTVPlus_Constructor.md
- title: fsreqProductionControlCutListExportDSTVPlus.CutListID Property
  kind: Property
  slug: cut-list-id-property-79711
  path: fsreqProductionControlCutListExportDSTVPlus.CutListID_Property.md
- title: fsreqProductionControlCutListExportDSTVPlus.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-79712
  path: fsreqProductionControlCutListExportDSTVPlus.CutListItemID_Property.md
---

# fsreqProductionControlCutListExportDSTVPlus Class

Exports DSTV Plus zip file for a cut list or cut list items

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlCutListExportDSTVPlus

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlCutListExportDSTVPlus : fsreqCommand
```

The fsreqProductionControlCutListExportDSTVPlus type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlCutListExportDSTVPlus](fsreqProductionControlCutListExportDSTVPlus_Constructor.md) | fsreqProductionControlCutListExportDSTVPlus class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CutListID](fsreqProductionControlCutListExportDSTVPlus.CutListID_Property.md) |  |
| Public property | [CutListItemID](fsreqProductionControlCutListExportDSTVPlus.CutListItemID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
