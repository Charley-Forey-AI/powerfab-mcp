---
title: fsreqGetInspectionTestRecords Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inspection-test-records-class-79036
slug: fsreq-get-inspection-test-records-class-79036
node_id: 79036
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInspectionTestRecords Class
children:
- title: fsreqGetInspectionTestRecords Constructor
  kind: Constructor
  slug: fsreq-get-inspection-test-records-constructor-79037
  path: fsreqGetInspectionTestRecords_Constructor.md
- title: fsreqGetInspectionTestRecords.Filters Property
  kind: Property
  slug: filters-property-79039
  path: fsreqGetInspectionTestRecords.Filters_Property.md
- title: fsreqGetInspectionTestRecords.IncludeDetails Property
  kind: Property
  slug: include-details-property-79040
  path: fsreqGetInspectionTestRecords.IncludeDetails_Property.md
- title: fsreqGetInspectionTestRecords.IncludeInspectors Property
  kind: Property
  slug: include-inspectors-property-79041
  path: fsreqGetInspectionTestRecords.IncludeInspectors_Property.md
- title: fsreqGetInspectionTestRecords.IncludeLocations Property
  kind: Property
  slug: include-locations-property-79042
  path: fsreqGetInspectionTestRecords.IncludeLocations_Property.md
- title: fsreqGetInspectionTestRecords.InspectionTestID Property
  kind: Property
  slug: inspection-test-id-property-79043
  path: fsreqGetInspectionTestRecords.InspectionTestID_Property.md
- title: fsreqGetInspectionTestRecords.InspectionTestRecordID Property
  kind: Property
  slug: inspection-test-record-id-property-79044
  path: fsreqGetInspectionTestRecords.InspectionTestRecordID_Property.md
- title: fsreqGetInspectionTestRecords.JobNumber Property
  kind: Property
  slug: job-number-property-79045
  path: fsreqGetInspectionTestRecords.JobNumber_Property.md
- title: fsreqGetInspectionTestRecords.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79046
  path: fsreqGetInspectionTestRecords.ProductionControlID_Property.md
- title: fsreqGetInspectionTestRecords.TestCategory Property
  kind: Property
  slug: test-category-property-79047
  path: fsreqGetInspectionTestRecords.TestCategory_Property.md
- title: fsreqGetInspectionTestRecords.TestDateMax Property
  kind: Property
  slug: test-date-max-property-79048
  path: fsreqGetInspectionTestRecords.TestDateMax_Property.md
- title: fsreqGetInspectionTestRecords.TestDateMin Property
  kind: Property
  slug: test-date-min-property-79049
  path: fsreqGetInspectionTestRecords.TestDateMin_Property.md
- title: fsreqGetInspectionTestRecords.TestPurpose Property
  kind: Property
  slug: test-purpose-property-79050
  path: fsreqGetInspectionTestRecords.TestPurpose_Property.md
- title: fsreqGetInspectionTestRecords.TestType Property
  kind: Property
  slug: test-type-property-79051
  path: fsreqGetInspectionTestRecords.TestType_Property.md
---

# fsreqGetInspectionTestRecords Class

Retrieves the details of an inspection test record and it's test definition.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInspectionTestRecords

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInspectionTestRecords : fsreqCommand
```

The fsreqGetInspectionTestRecords type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInspectionTestRecords](fsreqGetInspectionTestRecords_Constructor.md) | fsreqGetInspectionTestRecords class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetInspectionTestRecords.Filters_Property.md) |  |
| Public property | [IncludeDetails](fsreqGetInspectionTestRecords.IncludeDetails_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [IncludeInspectors](fsreqGetInspectionTestRecords.IncludeInspectors_Property.md) | Indicates if the list of inspectors should be retrieved. |
| Public property | [IncludeLocations](fsreqGetInspectionTestRecords.IncludeLocations_Property.md) | Indicates if the list of inspection locations should be retrieved. |
| Public property | [InspectionTestID](fsreqGetInspectionTestRecords.InspectionTestID_Property.md) | The test to retrieve test records from. |
| Public property | [InspectionTestRecordID](fsreqGetInspectionTestRecords.InspectionTestRecordID_Property.md) | The ID number of a test record to retrieve. |
| Public property | [JobNumber](fsreqGetInspectionTestRecords.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetInspectionTestRecords.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |
| Public property | [TestCategory](fsreqGetInspectionTestRecords.TestCategory_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestDateMax](fsreqGetInspectionTestRecords.TestDateMax_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestDateMin](fsreqGetInspectionTestRecords.TestDateMin_Property.md) | Indicates if the field values and document information should be retrieved. |
| Public property | [TestPurpose](fsreqGetInspectionTestRecords.TestPurpose_Property.md) | The purpose of the tests to retrieve, indicates the type of test subject. |
| Public property | [TestType](fsreqGetInspectionTestRecords.TestType_Property.md) | Indicates if the field values and document information should be retrieved. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
