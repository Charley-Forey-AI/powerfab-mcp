---
title: fsreqDrawingLogInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-log-insert-class-77853
slug: fsreq-drawing-log-insert-class-77853
node_id: 77853
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingLogInsert Class
children:
- title: fsreqDrawingLogInsert Constructor
  kind: Constructor
  slug: fsreq-drawing-log-insert-constructor-77854
  path: fsreqDrawingLogInsert_Constructor.md
- title: fsreqDrawingLogInsert.DrawingLogName Property
  kind: Property
  slug: drawing-log-name-property-77856
  path: fsreqDrawingLogInsert.DrawingLogName_Property.md
- title: fsreqDrawingLogInsert.DrawingType Property
  kind: Property
  slug: drawing-type-property-77857
  path: fsreqDrawingLogInsert.DrawingType_Property.md
- title: fsreqDrawingLogInsert.PDCLink Property
  kind: Property
  slug: pdc-link-property-77858
  path: fsreqDrawingLogInsert.PDCLink_Property.md
- title: fsreqDrawingLogInsert.ProjectID Property
  kind: Property
  slug: project-id-property-77859
  path: fsreqDrawingLogInsert.ProjectID_Property.md
- title: fsreqDrawingLogInsert.SubdirectoryPath Property
  kind: Property
  slug: subdirectory-path-property-77860
  path: fsreqDrawingLogInsert.SubdirectoryPath_Property.md
---

# fsreqDrawingLogInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingLogInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingLogInsert : fsreqCommand
```

The fsreqDrawingLogInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingLogInsert](fsreqDrawingLogInsert_Constructor.md) | Initializes a new instance of the fsreqDrawingLogInsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DrawingLogName](fsreqDrawingLogInsert.DrawingLogName_Property.md) |  |
| Public property | [DrawingType](fsreqDrawingLogInsert.DrawingType_Property.md) |  |
| Public property | [PDCLink](fsreqDrawingLogInsert.PDCLink_Property.md) |  |
| Public property | [ProjectID](fsreqDrawingLogInsert.ProjectID_Property.md) |  |
| Public property | [SubdirectoryPath](fsreqDrawingLogInsert.SubdirectoryPath_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
