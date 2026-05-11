---
title: fsreqCNCData Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-cnc-data-class-77646
slug: fsreq-cnc-data-class-77646
node_id: 77646
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCNCData Class
children:
- title: fsreqCNCData Constructor
  kind: Constructor
  slug: fsreq-cnc-data-constructor-77647
  path: fsreqCNCData_Constructor.md
- title: fsreqCNCData.CNCFileID Property
  kind: Property
  slug: cnc-file-id-property-77649
  path: fsreqCNCData.CNCFileID_Property.md
- title: fsreqCNCData.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-77650
  path: fsreqCNCData.CutListItemID_Property.md
- title: fsreqCNCData.JobNumber Property
  kind: Property
  slug: job-number-property-77651
  path: fsreqCNCData.JobNumber_Property.md
- title: fsreqCNCData.PieceMark Property
  kind: Property
  slug: piece-mark-property-77652
  path: fsreqCNCData.PieceMark_Property.md
- title: fsreqCNCData.ZipFiles Property
  kind: Property
  slug: zip-files-property-77653
  path: fsreqCNCData.ZipFiles_Property.md
---

# fsreqCNCData Class

Retrieves the CNC data for the specified parts.
An XMLWarning element will be included in the response if no CNC file has been loaded for a requested piece mark.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqCNCData

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqCNCData : fsreqCommand
```

The fsreqCNCData type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqCNCData](fsreqCNCData_Constructor.md) | fsreqCNCData class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CNCFileID](fsreqCNCData.CNCFileID_Property.md) | Unique identifier from the CNCFiles table for the file to retrieve. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CutListItemID](fsreqCNCData.CutListItemID_Property.md) | The cut list item, the CNC data from the parts in the cutting detail should be retrieved. |
| Public property | [JobNumber](fsreqCNCData.JobNumber_Property.md) | PDC job to retrieve information from. |
| Public property | [PieceMark](fsreqCNCData.PieceMark_Property.md) | Piece mark to retrieve the CNC data from. |
| Public property | [ZipFiles](fsreqCNCData.ZipFiles_Property.md) | If true then the retrieved files are compressed into a single zip file. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
