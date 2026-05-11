---
title: fsreqDrawingRevisionInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-revision-insert-class-77878
slug: fsreq-drawing-revision-insert-class-77878
node_id: 77878
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingRevisionInsert Class
children:
- title: fsreqDrawingRevisionInsert Constructor
  kind: Constructor
  slug: fsreq-drawing-revision-insert-constructor-77879
  path: fsreqDrawingRevisionInsert_Constructor.md
- title: fsreqDrawingRevisionInsert.CheckedBy Property
  kind: Property
  slug: checked-property-77881
  path: fsreqDrawingRevisionInsert.CheckedBy_Property.md
- title: fsreqDrawingRevisionInsert.DateChecked Property
  kind: Property
  slug: date-checked-property-77882
  path: fsreqDrawingRevisionInsert.DateChecked_Property.md
- title: fsreqDrawingRevisionInsert.DateReceived Property
  kind: Property
  slug: date-received-property-77883
  path: fsreqDrawingRevisionInsert.DateReceived_Property.md
- title: fsreqDrawingRevisionInsert.DateRevised Property
  kind: Property
  slug: date-revised-property-77884
  path: fsreqDrawingRevisionInsert.DateRevised_Property.md
- title: fsreqDrawingRevisionInsert.Description Property
  kind: Property
  slug: description-property-77885
  path: fsreqDrawingRevisionInsert.Description_Property.md
- title: fsreqDrawingRevisionInsert.DrawingID Property
  kind: Property
  slug: drawing-id-property-77886
  path: fsreqDrawingRevisionInsert.DrawingID_Property.md
- title: fsreqDrawingRevisionInsert.ReleaseNumber Property
  kind: Property
  slug: release-number-property-77887
  path: fsreqDrawingRevisionInsert.ReleaseNumber_Property.md
- title: fsreqDrawingRevisionInsert.RevisedBy Property
  kind: Property
  slug: revised-property-77888
  path: fsreqDrawingRevisionInsert.RevisedBy_Property.md
- title: fsreqDrawingRevisionInsert.Revision Property
  kind: Property
  slug: revision-property-77889
  path: fsreqDrawingRevisionInsert.Revision_Property.md
---

# fsreqDrawingRevisionInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingRevisionInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingRevisionInsert : fsreqCommand
```

The fsreqDrawingRevisionInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingRevisionInsert](fsreqDrawingRevisionInsert_Constructor.md) | fsreqDrawingRevisionInsert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CheckedBy](fsreqDrawingRevisionInsert.CheckedBy_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateChecked](fsreqDrawingRevisionInsert.DateChecked_Property.md) |  |
| Public property | [DateReceived](fsreqDrawingRevisionInsert.DateReceived_Property.md) |  |
| Public property | [DateRevised](fsreqDrawingRevisionInsert.DateRevised_Property.md) |  |
| Public property | [Description](fsreqDrawingRevisionInsert.Description_Property.md) |  |
| Public property | [DrawingID](fsreqDrawingRevisionInsert.DrawingID_Property.md) |  |
| Public property | [ReleaseNumber](fsreqDrawingRevisionInsert.ReleaseNumber_Property.md) |  |
| Public property | [RevisedBy](fsreqDrawingRevisionInsert.RevisedBy_Property.md) |  |
| Public property | [Revision](fsreqDrawingRevisionInsert.Revision_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
