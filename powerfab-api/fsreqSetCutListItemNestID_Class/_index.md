---
title: fsreqSetCutListItemNestID Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-set-cut-list-item-nest-id-class-80422
slug: fsreq-set-cut-list-item-nest-id-class-80422
node_id: 80422
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSetCutListItemNestID Class
children:
- title: fsreqSetCutListItemNestID Constructor
  kind: Constructor
  slug: fsreq-set-cut-list-item-nest-id-constructor-80423
  path: fsreqSetCutListItemNestID_Constructor.md
- title: fsreqSetCutListItemNestID.CreationDateTime Property
  kind: Property
  slug: creation-date-time-property-80425
  path: fsreqSetCutListItemNestID.CreationDateTime_Property.md
- title: fsreqSetCutListItemNestID.CutListItem Property
  kind: Property
  slug: cut-list-item-property-80426
  path: fsreqSetCutListItemNestID.CutListItem_Property.md
- title: fsreqSetCutListItemNestID.SourceApplication Property
  kind: Property
  slug: source-application-property-80427
  path: fsreqSetCutListItemNestID.SourceApplication_Property.md
- title: fsreqSetCutListItemNestID.SourceApplicationVersion Property
  kind: Property
  slug: source-application-version-property-80428
  path: fsreqSetCutListItemNestID.SourceApplicationVersion_Property.md
---

# fsreqSetCutListItemNestID Class

At least one CutListItem must be defined

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSetCutListItemNestID

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSetCutListItemNestID : fsreqCommand
```

The fsreqSetCutListItemNestID type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSetCutListItemNestID](fsreqSetCutListItemNestID_Constructor.md) | fsreqSetCutListItemNestID class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CreationDateTime](fsreqSetCutListItemNestID.CreationDateTime_Property.md) | Date/Time that nest was performed. |
| Public property | [CutListItem](fsreqSetCutListItemNestID.CutListItem_Property.md) |  |
| Public property | [SourceApplication](fsreqSetCutListItemNestID.SourceApplication_Property.md) | Name of application creating this nest. |
| Public property | [SourceApplicationVersion](fsreqSetCutListItemNestID.SourceApplicationVersion_Property.md) | Version of source application. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
