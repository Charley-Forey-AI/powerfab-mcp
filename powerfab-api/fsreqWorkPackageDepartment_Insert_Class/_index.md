---
title: fsreqWorkPackageDepartment_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-departmentinsert-class-80857
slug: fsreq-work-package-departmentinsert-class-80857
node_id: 80857
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartment_Insert Class
children:
- title: fsreqWorkPackageDepartment_Insert Constructor
  kind: Constructor
  slug: fsreq-work-package-departmentinsert-constructor-80858
  path: fsreqWorkPackageDepartment_Insert_Constructor.md
- title: fsreqWorkPackageDepartment_Insert.DepartmentID Property
  kind: Property
  slug: department-id-property-80860
  path: fsreqWorkPackageDepartment_Insert.DepartmentID_Property.md
- title: fsreqWorkPackageDepartment_Insert.Hours Property
  kind: Property
  slug: hours-property-80861
  path: fsreqWorkPackageDepartment_Insert.Hours_Property.md
- title: fsreqWorkPackageDepartment_Insert.Weight Property
  kind: Property
  slug: weight-property-80862
  path: fsreqWorkPackageDepartment_Insert.Weight_Property.md
- title: fsreqWorkPackageDepartment_Insert.WorkAreaDepartmentScheduleID Property
  kind: Property
  slug: work-area-department-schedule-id-property-80863
  path: fsreqWorkPackageDepartment_Insert.WorkAreaDepartmentScheduleID_Property.md
- title: fsreqWorkPackageDepartment_Insert.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80864
  path: fsreqWorkPackageDepartment_Insert.WorkPackageID_Property.md
---

# fsreqWorkPackageDepartment_Insert Class

Inserts a work package departments.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartment\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartment_Insert : fsreqCommand
```

The fsreqWorkPackageDepartment\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartment\_Insert](fsreqWorkPackageDepartment_Insert_Constructor.md) | Initializes a new instance of the fsreqWorkPackageDepartment\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentID](fsreqWorkPackageDepartment_Insert.DepartmentID_Property.md) | Department ID |
| Public property | [Hours](fsreqWorkPackageDepartment_Insert.Hours_Property.md) | Hours |
| Public property | [Weight](fsreqWorkPackageDepartment_Insert.Weight_Property.md) | Weight |
| Public property | [WorkAreaDepartmentScheduleID](fsreqWorkPackageDepartment_Insert.WorkAreaDepartmentScheduleID_Property.md) | WorkAreaDepartmentScheduleID |
| Public property | [WorkPackageID](fsreqWorkPackageDepartment_Insert.WorkPackageID_Property.md) | Work Package ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
