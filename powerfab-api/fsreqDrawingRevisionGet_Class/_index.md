---
title: fsreqDrawingRevisionGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-revision-get-class-77869
slug: fsreq-drawing-revision-get-class-77869
node_id: 77869
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingRevisionGet Class
children:
- title: fsreqDrawingRevisionGet Constructor
  kind: Constructor
  slug: fsreq-drawing-revision-get-constructor-77870
  path: fsreqDrawingRevisionGet_Constructor.md
- title: fsreqDrawingRevisionGet.DrawingID Property
  kind: Property
  slug: drawing-id-property-77872
  path: fsreqDrawingRevisionGet.DrawingID_Property.md
- title: fsreqDrawingRevisionGet.DrawingRevisionID Property
  kind: Property
  slug: drawing-revision-id-property-77873
  path: fsreqDrawingRevisionGet.DrawingRevisionID_Property.md
- title: fsreqDrawingRevisionGet.GetOptions Property
  kind: Property
  slug: get-options-property-77874
  path: fsreqDrawingRevisionGet.GetOptions_Property.md
- title: fsreqDrawingRevisionGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-77875
  path: fsreqDrawingRevisionGet.LastLogID_Property.md
- title: fsreqDrawingRevisionGet.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-77876
  path: fsreqDrawingRevisionGet.ProductionControlID_Property.md
- title: fsreqDrawingRevisionGet.ProjectID Property
  kind: Property
  slug: project-id-property-77877
  path: fsreqDrawingRevisionGet.ProjectID_Property.md
---

# fsreqDrawingRevisionGet Class

ProjectID, ProductionControlID, DrawingID, or DrawingRevisionID must be specified.
If LastLogID is specified then the result will only include the records that have changed since that log position.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingRevisionGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingRevisionGet : fsreqCommand
```

The fsreqDrawingRevisionGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingRevisionGet](fsreqDrawingRevisionGet_Constructor.md) | fsreqDrawingRevisionGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DrawingID](fsreqDrawingRevisionGet.DrawingID_Property.md) |  |
| Public property | [DrawingRevisionID](fsreqDrawingRevisionGet.DrawingRevisionID_Property.md) |  |
| Public property | [GetOptions](fsreqDrawingRevisionGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqDrawingRevisionGet.LastLogID_Property.md) |  |
| Public property | [ProductionControlID](fsreqDrawingRevisionGet.ProductionControlID_Property.md) |  |
| Public property | [ProjectID](fsreqDrawingRevisionGet.ProjectID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
