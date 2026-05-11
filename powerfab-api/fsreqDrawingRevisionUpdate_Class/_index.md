---
title: fsreqDrawingRevisionUpdate Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-revision-update-class-77890
slug: fsreq-drawing-revision-update-class-77890
node_id: 77890
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingRevisionUpdate Class
children:
- title: fsreqDrawingRevisionUpdate Constructor
  kind: Constructor
  slug: fsreq-drawing-revision-update-constructor-77891
  path: fsreqDrawingRevisionUpdate_Constructor.md
- title: fsreqDrawingRevisionUpdate.CheckedBy Property
  kind: Property
  slug: checked-property-77893
  path: fsreqDrawingRevisionUpdate.CheckedBy_Property.md
- title: fsreqDrawingRevisionUpdate.DateChecked Property
  kind: Property
  slug: date-checked-property-77894
  path: fsreqDrawingRevisionUpdate.DateChecked_Property.md
- title: fsreqDrawingRevisionUpdate.DateReceived Property
  kind: Property
  slug: date-received-property-77895
  path: fsreqDrawingRevisionUpdate.DateReceived_Property.md
- title: fsreqDrawingRevisionUpdate.DateRevised Property
  kind: Property
  slug: date-revised-property-77896
  path: fsreqDrawingRevisionUpdate.DateRevised_Property.md
- title: fsreqDrawingRevisionUpdate.Description Property
  kind: Property
  slug: description-property-77897
  path: fsreqDrawingRevisionUpdate.Description_Property.md
- title: fsreqDrawingRevisionUpdate.DrawingRevisionID Property
  kind: Property
  slug: drawing-revision-id-property-77898
  path: fsreqDrawingRevisionUpdate.DrawingRevisionID_Property.md
- title: fsreqDrawingRevisionUpdate.ReleaseNumber Property
  kind: Property
  slug: release-number-property-77899
  path: fsreqDrawingRevisionUpdate.ReleaseNumber_Property.md
- title: fsreqDrawingRevisionUpdate.RevisedBy Property
  kind: Property
  slug: revised-property-77900
  path: fsreqDrawingRevisionUpdate.RevisedBy_Property.md
- title: fsreqDrawingRevisionUpdate.Revision Property
  kind: Property
  slug: revision-property-77901
  path: fsreqDrawingRevisionUpdate.Revision_Property.md
---

# fsreqDrawingRevisionUpdate Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingRevisionUpdate

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingRevisionUpdate : fsreqCommand
```

The fsreqDrawingRevisionUpdate type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingRevisionUpdate](fsreqDrawingRevisionUpdate_Constructor.md) | fsreqDrawingRevisionUpdate class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CheckedBy](fsreqDrawingRevisionUpdate.CheckedBy_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateChecked](fsreqDrawingRevisionUpdate.DateChecked_Property.md) |  |
| Public property | [DateReceived](fsreqDrawingRevisionUpdate.DateReceived_Property.md) |  |
| Public property | [DateRevised](fsreqDrawingRevisionUpdate.DateRevised_Property.md) |  |
| Public property | [Description](fsreqDrawingRevisionUpdate.Description_Property.md) |  |
| Public property | [DrawingRevisionID](fsreqDrawingRevisionUpdate.DrawingRevisionID_Property.md) |  |
| Public property | [ReleaseNumber](fsreqDrawingRevisionUpdate.ReleaseNumber_Property.md) |  |
| Public property | [RevisedBy](fsreqDrawingRevisionUpdate.RevisedBy_Property.md) |  |
| Public property | [Revision](fsreqDrawingRevisionUpdate.Revision_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
