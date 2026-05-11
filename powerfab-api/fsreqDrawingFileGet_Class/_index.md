---
title: fsreqDrawingFileGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-file-get-class-77781
slug: fsreq-drawing-file-get-class-77781
node_id: 77781
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingFileGet Class
children:
- title: fsreqDrawingFileGet Constructor
  kind: Constructor
  slug: fsreq-drawing-file-get-constructor-77782
  path: fsreqDrawingFileGet_Constructor.md
- title: fsreqDrawingFileGet.DrawingID Property
  kind: Property
  slug: drawing-id-property-77784
  path: fsreqDrawingFileGet.DrawingID_Property.md
- title: fsreqDrawingFileGet.DrawingRevisionID Property
  kind: Property
  slug: drawing-revision-id-property-77785
  path: fsreqDrawingFileGet.DrawingRevisionID_Property.md
- title: fsreqDrawingFileGet.FileName Property
  kind: Property
  slug: file-name-property-77786
  path: fsreqDrawingFileGet.FileName_Property.md
---

# fsreqDrawingFileGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingFileGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingFileGet : fsreqCommand
```

The fsreqDrawingFileGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingFileGet](fsreqDrawingFileGet_Constructor.md) | Initializes a new instance of the fsreqDrawingFileGet class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DrawingID](fsreqDrawingFileGet.DrawingID_Property.md) |  |
| Public property | [DrawingRevisionID](fsreqDrawingFileGet.DrawingRevisionID_Property.md) |  |
| Public property | [FileName](fsreqDrawingFileGet.FileName_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
