---
title: fsreqGetNestData Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-nest-data-class-79156
slug: fsreq-get-nest-data-class-79156
node_id: 79156
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetNestData Class
children:
- title: fsreqGetNestData Constructor
  kind: Constructor
  slug: fsreq-get-nest-data-constructor-79157
  path: fsreqGetNestData_Constructor.md
- title: fsreqGetNestData.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-79159
  path: fsreqGetNestData.CutListItemID_Property.md
- title: fsreqGetNestData.ZipFiles Property
  kind: Property
  slug: zip-files-property-79160
  path: fsreqGetNestData.ZipFiles_Property.md
---

# fsreqGetNestData Class

Retrieves the data file for the given nest.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetNestData

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetNestData : fsreqCommand
```

The fsreqGetNestData type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetNestData](fsreqGetNestData_Constructor.md) | fsreqGetNestData class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CutListItemID](fsreqGetNestData.CutListItemID_Property.md) | The cut list items from which to retrieve the nest data file. |
| Public property | [ZipFiles](fsreqGetNestData.ZipFiles_Property.md) | If true then the retrieved files are compressed into a single zip file. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
