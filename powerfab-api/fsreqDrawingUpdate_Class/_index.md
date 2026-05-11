---
title: fsreqDrawingUpdate Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-update-class-77902
slug: fsreq-drawing-update-class-77902
node_id: 77902
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingUpdate Class
children:
- title: fsreqDrawingUpdate Constructor
  kind: Constructor
  slug: fsreq-drawing-update-constructor-77903
  path: fsreqDrawingUpdate_Constructor.md
- title: fsreqDrawingUpdate.ApprovalStatusID Property
  kind: Property
  slug: approval-status-id-property-77905
  path: fsreqDrawingUpdate.ApprovalStatusID_Property.md
- title: fsreqDrawingUpdate.Category Property
  kind: Property
  slug: category-property-77906
  path: fsreqDrawingUpdate.Category_Property.md
- title: fsreqDrawingUpdate.CheckedBy Property
  kind: Property
  slug: checked-property-77907
  path: fsreqDrawingUpdate.CheckedBy_Property.md
- title: fsreqDrawingUpdate.DateChecked Property
  kind: Property
  slug: date-checked-property-77908
  path: fsreqDrawingUpdate.DateChecked_Property.md
- title: fsreqDrawingUpdate.DateDetailed Property
  kind: Property
  slug: date-detailed-property-77909
  path: fsreqDrawingUpdate.DateDetailed_Property.md
- title: fsreqDrawingUpdate.DateReceived Property
  kind: Property
  slug: date-received-property-77910
  path: fsreqDrawingUpdate.DateReceived_Property.md
- title: fsreqDrawingUpdate.Description Property
  kind: Property
  slug: description-property-77911
  path: fsreqDrawingUpdate.Description_Property.md
- title: fsreqDrawingUpdate.DetailedBy Property
  kind: Property
  slug: detailed-property-77912
  path: fsreqDrawingUpdate.DetailedBy_Property.md
- title: fsreqDrawingUpdate.DetailingHours Property
  kind: Property
  slug: detailing-hours-property-77913
  path: fsreqDrawingUpdate.DetailingHours_Property.md
- title: fsreqDrawingUpdate.DrawingID Property
  kind: Property
  slug: drawing-id-property-77914
  path: fsreqDrawingUpdate.DrawingID_Property.md
- title: fsreqDrawingUpdate.DrawingLogID Property
  kind: Property
  slug: drawing-log-id-property-77915
  path: fsreqDrawingUpdate.DrawingLogID_Property.md
- title: fsreqDrawingUpdate.DrawingNumberDisplay Property
  kind: Property
  slug: drawing-number-display-property-77916
  path: fsreqDrawingUpdate.DrawingNumberDisplay_Property.md
- title: fsreqDrawingUpdate.PackageNumber Property
  kind: Property
  slug: package-number-property-77917
  path: fsreqDrawingUpdate.PackageNumber_Property.md
- title: fsreqDrawingUpdate.ProjectID Property
  kind: Property
  slug: project-id-property-77918
  path: fsreqDrawingUpdate.ProjectID_Property.md
- title: fsreqDrawingUpdate.ReleaseNumber Property
  kind: Property
  slug: release-number-property-77919
  path: fsreqDrawingUpdate.ReleaseNumber_Property.md
- title: fsreqDrawingUpdate.ReSubmit Property
  kind: Property
  slug: re-submit-property-77920
  path: fsreqDrawingUpdate.ReSubmit_Property.md
- title: fsreqDrawingUpdate.ShopIssueDate Property
  kind: Property
  slug: shop-issue-date-property-77921
  path: fsreqDrawingUpdate.ShopIssueDate_Property.md
---

# fsreqDrawingUpdate Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingUpdate

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingUpdate : fsreqCommand
```

The fsreqDrawingUpdate type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingUpdate](fsreqDrawingUpdate_Constructor.md) | fsreqDrawingUpdate class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ApprovalStatusID](fsreqDrawingUpdate.ApprovalStatusID_Property.md) |  |
| Public property | [Category](fsreqDrawingUpdate.Category_Property.md) |  |
| Public property | [CheckedBy](fsreqDrawingUpdate.CheckedBy_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateChecked](fsreqDrawingUpdate.DateChecked_Property.md) |  |
| Public property | [DateDetailed](fsreqDrawingUpdate.DateDetailed_Property.md) |  |
| Public property | [DateReceived](fsreqDrawingUpdate.DateReceived_Property.md) |  |
| Public property | [Description](fsreqDrawingUpdate.Description_Property.md) |  |
| Public property | [DetailedBy](fsreqDrawingUpdate.DetailedBy_Property.md) |  |
| Public property | [DetailingHours](fsreqDrawingUpdate.DetailingHours_Property.md) |  |
| Public property | [DrawingID](fsreqDrawingUpdate.DrawingID_Property.md) |  |
| Public property | [DrawingLogID](fsreqDrawingUpdate.DrawingLogID_Property.md) |  |
| Public property | [DrawingNumberDisplay](fsreqDrawingUpdate.DrawingNumberDisplay_Property.md) |  |
| Public property | [PackageNumber](fsreqDrawingUpdate.PackageNumber_Property.md) |  |
| Public property | [ProjectID](fsreqDrawingUpdate.ProjectID_Property.md) |  |
| Public property | [ReleaseNumber](fsreqDrawingUpdate.ReleaseNumber_Property.md) |  |
| Public property | [ReSubmit](fsreqDrawingUpdate.ReSubmit_Property.md) |  |
| Public property | [ShopIssueDate](fsreqDrawingUpdate.ShopIssueDate_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
