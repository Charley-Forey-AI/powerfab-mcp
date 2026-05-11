---
title: fsreqGetDrawings Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-drawings-class-78992
slug: fsreq-get-drawings-class-78992
node_id: 78992
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetDrawings Class
children:
- title: fsreqGetDrawings Constructor
  kind: Constructor
  slug: fsreq-get-drawings-constructor-78993
  path: fsreqGetDrawings_Constructor.md
- title: fsreqGetDrawings.Filters Property
  kind: Property
  slug: filters-property-78995
  path: fsreqGetDrawings.Filters_Property.md
- title: fsreqGetDrawings.IncludeDrawingFiles Property
  kind: Property
  slug: include-drawing-files-property-78996
  path: fsreqGetDrawings.IncludeDrawingFiles_Property.md
- title: fsreqGetDrawings.InspectionTests Property
  kind: Property
  slug: inspection-tests-property-78997
  path: fsreqGetDrawings.InspectionTests_Property.md
- title: fsreqGetDrawings.JobNumber Property
  kind: Property
  slug: job-number-property-78998
  path: fsreqGetDrawings.JobNumber_Property.md
- title: fsreqGetDrawings.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78999
  path: fsreqGetDrawings.ProductionControlID_Property.md
---

# fsreqGetDrawings Class

Retrieves the list of drawings in a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetDrawings

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetDrawings : fsreqCommand
```

The fsreqGetDrawings type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetDrawings](fsreqGetDrawings_Constructor.md) | fsreqGetDrawings class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetDrawings.Filters_Property.md) |  |
| Public property | [IncludeDrawingFiles](fsreqGetDrawings.IncludeDrawingFiles_Property.md) | If true then the drawing files should be retrieved along with the response. |
| Public property | [InspectionTests](fsreqGetDrawings.InspectionTests_Property.md) | If true then the inspection test summary is retrieved along with the category details. |
| Public property | [JobNumber](fsreqGetDrawings.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetDrawings.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
