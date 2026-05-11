---
title: fsreqGetCutList Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-cut-list-class-78981
slug: fsreq-get-cut-list-class-78981
node_id: 78981
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetCutList Class
children:
- title: fsreqGetCutList Constructor
  kind: Constructor
  slug: fsreq-get-cut-list-constructor-78982
  path: fsreqGetCutList_Constructor.md
- title: fsreqGetCutList.CutListID Property
  kind: Property
  slug: cut-list-id-property-78984
  path: fsreqGetCutList.CutListID_Property.md
- title: fsreqGetCutList.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-78985
  path: fsreqGetCutList.CutListItemID_Property.md
- title: fsreqGetCutList.EDIDescription Property
  kind: Property
  slug: edi-description-property-78986
  path: fsreqGetCutList.EDIDescription_Property.md
- title: fsreqGetCutList.Filters Property
  kind: Property
  slug: filters-property-78987
  path: fsreqGetCutList.Filters_Property.md
---

# fsreqGetCutList Class

Retrieves the details of a cut list.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetCutList

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetCutList : fsreqCommand
```

The fsreqGetCutList type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetCutList](fsreqGetCutList_Constructor.md) | fsreqGetCutList class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CutListID](fsreqGetCutList.CutListID_Property.md) | The unique identifier of the cut list. |
| Public property | [CutListItemID](fsreqGetCutList.CutListItemID_Property.md) | The unique identifier of the cut list items to retrieve. |
| Public property | [EDIDescription](fsreqGetCutList.EDIDescription_Property.md) | Optional. Include and set to True to receive EDI compliant description in result field of description |
| Public property | [Filters](fsreqGetCutList.Filters_Property.md) | Filter results |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
