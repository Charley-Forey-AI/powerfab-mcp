---
title: fsreqGetInspectionTestRecordsCondensed Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inspection-test-records-condensed-class-79052
slug: fsreq-get-inspection-test-records-condensed-class-79052
node_id: 79052
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInspectionTestRecordsCondensed Class
children:
- title: fsreqGetInspectionTestRecordsCondensed Constructor
  kind: Constructor
  slug: fsreq-get-inspection-test-records-condensed-constructor-79053
  path: fsreqGetInspectionTestRecordsCondensed_Constructor.md
- title: fsreqGetInspectionTestRecordsCondensed.Filters Property
  kind: Property
  slug: filters-property-79055
  path: fsreqGetInspectionTestRecordsCondensed.Filters_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.InspectionTestID Property
  kind: Property
  slug: inspection-test-id-property-79056
  path: fsreqGetInspectionTestRecordsCondensed.InspectionTestID_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.InspectionTestRecordID Property
  kind: Property
  slug: inspection-test-record-id-property-79057
  path: fsreqGetInspectionTestRecordsCondensed.InspectionTestRecordID_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.JobNumber Property
  kind: Property
  slug: job-number-property-79058
  path: fsreqGetInspectionTestRecordsCondensed.JobNumber_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79059
  path: fsreqGetInspectionTestRecordsCondensed.ProductionControlID_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.TestCategory Property
  kind: Property
  slug: test-category-property-79060
  path: fsreqGetInspectionTestRecordsCondensed.TestCategory_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.TestDateMax Property
  kind: Property
  slug: test-date-max-property-79061
  path: fsreqGetInspectionTestRecordsCondensed.TestDateMax_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.TestDateMin Property
  kind: Property
  slug: test-date-min-property-79062
  path: fsreqGetInspectionTestRecordsCondensed.TestDateMin_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.TestPurpose Property
  kind: Property
  slug: test-purpose-property-79063
  path: fsreqGetInspectionTestRecordsCondensed.TestPurpose_Property.md
- title: fsreqGetInspectionTestRecordsCondensed.TestType Property
  kind: Property
  slug: test-type-property-79064
  path: fsreqGetInspectionTestRecordsCondensed.TestType_Property.md
---

# fsreqGetInspectionTestRecordsCondensed Class

Retrieves the condensed details of a set of inspection test records.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInspectionTestRecordsCondensed

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInspectionTestRecordsCondensed : fsreqCommand
```

The fsreqGetInspectionTestRecordsCondensed type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInspectionTestRecordsCondensed](fsreqGetInspectionTestRecordsCondensed_Constructor.md) | fsreqGetInspectionTestRecordsCondensed class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetInspectionTestRecordsCondensed.Filters_Property.md) |  |
| Public property | [InspectionTestID](fsreqGetInspectionTestRecordsCondensed.InspectionTestID_Property.md) | The test to retrieve test records from. |
| Public property | [InspectionTestRecordID](fsreqGetInspectionTestRecordsCondensed.InspectionTestRecordID_Property.md) | The ID number of a test record to retrieve. |
| Public property | [JobNumber](fsreqGetInspectionTestRecordsCondensed.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetInspectionTestRecordsCondensed.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |
| Public property | [TestCategory](fsreqGetInspectionTestRecordsCondensed.TestCategory_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestDateMax](fsreqGetInspectionTestRecordsCondensed.TestDateMax_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestDateMin](fsreqGetInspectionTestRecordsCondensed.TestDateMin_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestPurpose](fsreqGetInspectionTestRecordsCondensed.TestPurpose_Property.md) | The purpose of the tests to retrieve, indicates the type of test subject. |
| Public property | [TestType](fsreqGetInspectionTestRecordsCondensed.TestType_Property.md) | Indicates if the field values and document information should be retrieved. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
