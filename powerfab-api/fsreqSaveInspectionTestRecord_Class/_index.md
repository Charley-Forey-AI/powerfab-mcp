---
title: fsreqSaveInspectionTestRecord Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-save-inspection-test-record-class-80340
slug: fsreq-save-inspection-test-record-class-80340
node_id: 80340
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSaveInspectionTestRecord Class
children:
- title: fsreqSaveInspectionTestRecord Constructor
  kind: Constructor
  slug: fsreq-save-inspection-test-record-constructor-80341
  path: fsreqSaveInspectionTestRecord_Constructor.md
- title: fsreqSaveInspectionTestRecord.InspectionTestID Property
  kind: Property
  slug: inspection-test-id-property-80343
  path: fsreqSaveInspectionTestRecord.InspectionTestID_Property.md
- title: fsreqSaveInspectionTestRecord.InspectionTestLocationID Property
  kind: Property
  slug: inspection-test-location-id-property-80344
  path: fsreqSaveInspectionTestRecord.InspectionTestLocationID_Property.md
- title: fsreqSaveInspectionTestRecord.InspectionTestRecordID Property
  kind: Property
  slug: inspection-test-record-id-property-80345
  path: fsreqSaveInspectionTestRecord.InspectionTestRecordID_Property.md
- title: fsreqSaveInspectionTestRecord.InspectionTestSubject Property
  kind: Property
  slug: inspection-test-subject-property-80346
  path: fsreqSaveInspectionTestRecord.InspectionTestSubject_Property.md
- title: fsreqSaveInspectionTestRecord.InspectionTestVersionID Property
  kind: Property
  slug: inspection-test-version-id-property-80347
  path: fsreqSaveInspectionTestRecord.InspectionTestVersionID_Property.md
- title: fsreqSaveInspectionTestRecord.InspectorFirmContactID Property
  kind: Property
  slug: inspector-firm-contact-id-property-80348
  path: fsreqSaveInspectionTestRecord.InspectorFirmContactID_Property.md
- title: fsreqSaveInspectionTestRecord.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-80349
  path: fsreqSaveInspectionTestRecord.InstanceNumbers_Property.md
- title: fsreqSaveInspectionTestRecord.ParentInspectionTestRecordID Property
  kind: Property
  slug: parent-inspection-test-record-id-property-80350
  path: fsreqSaveInspectionTestRecord.ParentInspectionTestRecordID_Property.md
- title: fsreqSaveInspectionTestRecord.Quantity Property
  kind: Property
  slug: quantity-property-80351
  path: fsreqSaveInspectionTestRecord.Quantity_Property.md
- title: fsreqSaveInspectionTestRecord.TestDateTime Property
  kind: Property
  slug: test-date-time-property-80352
  path: fsreqSaveInspectionTestRecord.TestDateTime_Property.md
- title: fsreqSaveInspectionTestRecord.TestHours Property
  kind: Property
  slug: test-hours-property-80353
  path: fsreqSaveInspectionTestRecord.TestHours_Property.md
- title: fsreqSaveInspectionTestRecord.TestRecordDocument Property
  kind: Property
  slug: test-record-document-property-80354
  path: fsreqSaveInspectionTestRecord.TestRecordDocument_Property.md
- title: fsreqSaveInspectionTestRecord.TestRecordField Property
  kind: Property
  slug: test-record-field-property-80355
  path: fsreqSaveInspectionTestRecord.TestRecordField_Property.md
---

# fsreqSaveInspectionTestRecord Class

Saves an inspection test record.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSaveInspectionTestRecord

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSaveInspectionTestRecord : fsreqCommand
```

The fsreqSaveInspectionTestRecord type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSaveInspectionTestRecord](fsreqSaveInspectionTestRecord_Constructor.md) | fsreqSaveInspectionTestRecord class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [InspectionTestID](fsreqSaveInspectionTestRecord.InspectionTestID_Property.md) |  |
| Public property | [InspectionTestLocationID](fsreqSaveInspectionTestRecord.InspectionTestLocationID_Property.md) |  |
| Public property | [InspectionTestRecordID](fsreqSaveInspectionTestRecord.InspectionTestRecordID_Property.md) | If specified then this record will be updated. |
| Public property | [InspectionTestSubject](fsreqSaveInspectionTestRecord.InspectionTestSubject_Property.md) |  |
| Public property | [InspectionTestVersionID](fsreqSaveInspectionTestRecord.InspectionTestVersionID_Property.md) |  |
| Public property | [InspectorFirmContactID](fsreqSaveInspectionTestRecord.InspectorFirmContactID_Property.md) |  |
| Public property | [InstanceNumbers](fsreqSaveInspectionTestRecord.InstanceNumbers_Property.md) |  |
| Public property | [ParentInspectionTestRecordID](fsreqSaveInspectionTestRecord.ParentInspectionTestRecordID_Property.md) | If specified then the new record will be a follow-up to this parent test record. |
| Public property | [Quantity](fsreqSaveInspectionTestRecord.Quantity_Property.md) |  |
| Public property | [TestDateTime](fsreqSaveInspectionTestRecord.TestDateTime_Property.md) |  |
| Public property | [TestHours](fsreqSaveInspectionTestRecord.TestHours_Property.md) |  |
| Public property | [TestRecordDocument](fsreqSaveInspectionTestRecord.TestRecordDocument_Property.md) |  |
| Public property | [TestRecordField](fsreqSaveInspectionTestRecord.TestRecordField_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
