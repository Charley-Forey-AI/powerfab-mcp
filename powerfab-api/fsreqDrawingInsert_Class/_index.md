---
title: fsreqDrawingInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-drawing-insert-class-77815
slug: fsreq-drawing-insert-class-77815
node_id: 77815
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDrawingInsert Class
children:
- title: fsreqDrawingInsert Constructor
  kind: Constructor
  slug: fsreq-drawing-insert-constructor-77816
  path: fsreqDrawingInsert_Constructor.md
- title: fsreqDrawingInsert.ApprovalStatusID Property
  kind: Property
  slug: approval-status-id-property-77818
  path: fsreqDrawingInsert.ApprovalStatusID_Property.md
- title: fsreqDrawingInsert.Category Property
  kind: Property
  slug: category-property-77819
  path: fsreqDrawingInsert.Category_Property.md
- title: fsreqDrawingInsert.CheckedBy Property
  kind: Property
  slug: checked-property-77820
  path: fsreqDrawingInsert.CheckedBy_Property.md
- title: fsreqDrawingInsert.DateChecked Property
  kind: Property
  slug: date-checked-property-77821
  path: fsreqDrawingInsert.DateChecked_Property.md
- title: fsreqDrawingInsert.DateDetailed Property
  kind: Property
  slug: date-detailed-property-77822
  path: fsreqDrawingInsert.DateDetailed_Property.md
- title: fsreqDrawingInsert.DateReceived Property
  kind: Property
  slug: date-received-property-77823
  path: fsreqDrawingInsert.DateReceived_Property.md
- title: fsreqDrawingInsert.Description Property
  kind: Property
  slug: description-property-77824
  path: fsreqDrawingInsert.Description_Property.md
- title: fsreqDrawingInsert.DetailedBy Property
  kind: Property
  slug: detailed-property-77825
  path: fsreqDrawingInsert.DetailedBy_Property.md
- title: fsreqDrawingInsert.DetailingHours Property
  kind: Property
  slug: detailing-hours-property-77826
  path: fsreqDrawingInsert.DetailingHours_Property.md
- title: fsreqDrawingInsert.DrawingLogID Property
  kind: Property
  slug: drawing-log-id-property-77827
  path: fsreqDrawingInsert.DrawingLogID_Property.md
- title: fsreqDrawingInsert.DrawingNumberDisplay Property
  kind: Property
  slug: drawing-number-display-property-77828
  path: fsreqDrawingInsert.DrawingNumberDisplay_Property.md
- title: fsreqDrawingInsert.PackageNumber Property
  kind: Property
  slug: package-number-property-77829
  path: fsreqDrawingInsert.PackageNumber_Property.md
- title: fsreqDrawingInsert.ProjectID Property
  kind: Property
  slug: project-id-property-77830
  path: fsreqDrawingInsert.ProjectID_Property.md
- title: fsreqDrawingInsert.ReleaseNumber Property
  kind: Property
  slug: release-number-property-77831
  path: fsreqDrawingInsert.ReleaseNumber_Property.md
- title: fsreqDrawingInsert.ReSubmit Property
  kind: Property
  slug: re-submit-property-77832
  path: fsreqDrawingInsert.ReSubmit_Property.md
- title: fsreqDrawingInsert.ShopIssueDate Property
  kind: Property
  slug: shop-issue-date-property-77833
  path: fsreqDrawingInsert.ShopIssueDate_Property.md
---

# fsreqDrawingInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDrawingInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDrawingInsert : fsreqCommand
```

The fsreqDrawingInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDrawingInsert](fsreqDrawingInsert_Constructor.md) | Initializes a new instance of the fsreqDrawingInsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ApprovalStatusID](fsreqDrawingInsert.ApprovalStatusID_Property.md) |  |
| Public property | [Category](fsreqDrawingInsert.Category_Property.md) |  |
| Public property | [CheckedBy](fsreqDrawingInsert.CheckedBy_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateChecked](fsreqDrawingInsert.DateChecked_Property.md) |  |
| Public property | [DateDetailed](fsreqDrawingInsert.DateDetailed_Property.md) |  |
| Public property | [DateReceived](fsreqDrawingInsert.DateReceived_Property.md) |  |
| Public property | [Description](fsreqDrawingInsert.Description_Property.md) |  |
| Public property | [DetailedBy](fsreqDrawingInsert.DetailedBy_Property.md) |  |
| Public property | [DetailingHours](fsreqDrawingInsert.DetailingHours_Property.md) |  |
| Public property | [DrawingLogID](fsreqDrawingInsert.DrawingLogID_Property.md) |  |
| Public property | [DrawingNumberDisplay](fsreqDrawingInsert.DrawingNumberDisplay_Property.md) |  |
| Public property | [PackageNumber](fsreqDrawingInsert.PackageNumber_Property.md) |  |
| Public property | [ProjectID](fsreqDrawingInsert.ProjectID_Property.md) |  |
| Public property | [ReleaseNumber](fsreqDrawingInsert.ReleaseNumber_Property.md) |  |
| Public property | [ReSubmit](fsreqDrawingInsert.ReSubmit_Property.md) |  |
| Public property | [ShopIssueDate](fsreqDrawingInsert.ShopIssueDate_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
