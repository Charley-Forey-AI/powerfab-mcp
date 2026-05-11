---
title: fsreqGetInspectionTestSubjects Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inspection-test-subjects-class-79084
slug: fsreq-get-inspection-test-subjects-class-79084
node_id: 79084
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInspectionTestSubjects Class
children:
- title: fsreqGetInspectionTestSubjects Constructor
  kind: Constructor
  slug: fsreq-get-inspection-test-subjects-constructor-79085
  path: fsreqGetInspectionTestSubjects_Constructor.md
- title: fsreqGetInspectionTestSubjects.ExtendedDetails Property
  kind: Property
  slug: extended-details-property-79087
  path: fsreqGetInspectionTestSubjects.ExtendedDetails_Property.md
- title: fsreqGetInspectionTestSubjects.Filters Property
  kind: Property
  slug: filters-property-79088
  path: fsreqGetInspectionTestSubjects.Filters_Property.md
- title: fsreqGetInspectionTestSubjects.InspectionTestVersionID Property
  kind: Property
  slug: inspection-test-version-id-property-79089
  path: fsreqGetInspectionTestSubjects.InspectionTestVersionID_Property.md
- title: fsreqGetInspectionTestSubjects.JobNumber Property
  kind: Property
  slug: job-number-property-79090
  path: fsreqGetInspectionTestSubjects.JobNumber_Property.md
- title: fsreqGetInspectionTestSubjects.Limit Property
  kind: Property
  slug: limit-property-79091
  path: fsreqGetInspectionTestSubjects.Limit_Property.md
- title: fsreqGetInspectionTestSubjects.Offset Property
  kind: Property
  slug: offset-property-79092
  path: fsreqGetInspectionTestSubjects.Offset_Property.md
- title: fsreqGetInspectionTestSubjects.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79093
  path: fsreqGetInspectionTestSubjects.ProductionControlID_Property.md
---

# fsreqGetInspectionTestSubjects Class

Retrieves the available subjects for the given inspection test.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInspectionTestSubjects

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInspectionTestSubjects : fsreqCommand
```

The fsreqGetInspectionTestSubjects type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInspectionTestSubjects](fsreqGetInspectionTestSubjects_Constructor.md) | fsreqGetInspectionTestSubjects class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExtendedDetails](fsreqGetInspectionTestSubjects.ExtendedDetails_Property.md) | If true then extended details of the parts are retrieved including drawing #, revision, approval status, shape, dimensions, length, and grade. |
| Public property | [Filters](fsreqGetInspectionTestSubjects.Filters_Property.md) |  |
| Public property | [InspectionTestVersionID](fsreqGetInspectionTestSubjects.InspectionTestVersionID_Property.md) | The test version that is being run. |
| Public property | [JobNumber](fsreqGetInspectionTestSubjects.JobNumber_Property.md) | The JobNumber of the job. |
| Public property | [Limit](fsreqGetInspectionTestSubjects.Limit_Property.md) |  |
| Public property | [Offset](fsreqGetInspectionTestSubjects.Offset_Property.md) |  |
| Public property | [ProductionControlID](fsreqGetInspectionTestSubjects.ProductionControlID_Property.md) | The ProductionControlID of the job. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
