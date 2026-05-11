---
title: fsreqGetInspectionTests Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inspection-tests-class-79073
slug: fsreq-get-inspection-tests-class-79073
node_id: 79073
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInspectionTests Class
children:
- title: fsreqGetInspectionTests Constructor
  kind: Constructor
  slug: fsreq-get-inspection-tests-constructor-79074
  path: fsreqGetInspectionTests_Constructor.md
- title: fsreqGetInspectionTests.IncludeFields Property
  kind: Property
  slug: include-fields-property-79076
  path: fsreqGetInspectionTests.IncludeFields_Property.md
- title: fsreqGetInspectionTests.IncludeInspectors Property
  kind: Property
  slug: include-inspectors-property-79077
  path: fsreqGetInspectionTests.IncludeInspectors_Property.md
- title: fsreqGetInspectionTests.IncludeLocations Property
  kind: Property
  slug: include-locations-property-79078
  path: fsreqGetInspectionTests.IncludeLocations_Property.md
- title: fsreqGetInspectionTests.InspectionTestID Property
  kind: Property
  slug: inspection-test-id-property-79079
  path: fsreqGetInspectionTests.InspectionTestID_Property.md
- title: fsreqGetInspectionTests.InspectionTestVersionID Property
  kind: Property
  slug: inspection-test-version-id-property-79080
  path: fsreqGetInspectionTests.InspectionTestVersionID_Property.md
- title: fsreqGetInspectionTests.TestPurpose Property
  kind: Property
  slug: test-purpose-property-79081
  path: fsreqGetInspectionTests.TestPurpose_Property.md
- title: fsreqGetInspectionTests.TestType Property
  kind: Property
  slug: test-type-property-79082
  path: fsreqGetInspectionTests.TestType_Property.md
---

# fsreqGetInspectionTests Class

Retrieves a list of inspection tests and their definitions.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInspectionTests

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInspectionTests : fsreqCommand
```

The fsreqGetInspectionTests type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInspectionTests](fsreqGetInspectionTests_Constructor.md) | fsreqGetInspectionTests class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [IncludeFields](fsreqGetInspectionTests.IncludeFields_Property.md) | Indicates if the field definitions should be retrieved. |
| Public property | [IncludeInspectors](fsreqGetInspectionTests.IncludeInspectors_Property.md) | Indicates if the list of inspectors should be retrieved. |
| Public property | [IncludeLocations](fsreqGetInspectionTests.IncludeLocations_Property.md) | Indicates if the list of inspection locations should be retrieved. |
| Public property | [InspectionTestID](fsreqGetInspectionTests.InspectionTestID_Property.md) | The ID number of a test to retrieve. |
| Public property | [InspectionTestVersionID](fsreqGetInspectionTests.InspectionTestVersionID_Property.md) | The ID number representing the version of a test to retrieve. If not specified then the latest version is retrieved. Only has an effect if the InspectionTestID element is specified. |
| Public property | [TestPurpose](fsreqGetInspectionTests.TestPurpose_Property.md) | The purpose of the tests to retrieve, indicates the type of test subject. |
| Public property | [TestType](fsreqGetInspectionTests.TestType_Property.md) | The type of test to retrieve, for example: Production Load Employee Environmental Equipment General |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
