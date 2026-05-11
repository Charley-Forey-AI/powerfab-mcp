---
title: fsreqDepartmentShift_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-department-shiftupsert-class-77766
slug: fsreq-department-shiftupsert-class-77766
node_id: 77766
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDepartmentShift_Upsert Class
children:
- title: fsreqDepartmentShift_Upsert Constructor
  kind: Constructor
  slug: fsreq-department-shiftupsert-constructor-77767
  path: fsreqDepartmentShift_Upsert_Constructor.md
- title: fsreqDepartmentShift_Upsert.DepartmentShiftID Property
  kind: Property
  slug: department-shift-id-property-77769
  path: fsreqDepartmentShift_Upsert.DepartmentShiftID_Property.md
- title: fsreqDepartmentShift_Upsert.HoursPerWeek Property
  kind: Property
  slug: hours-week-property-77770
  path: fsreqDepartmentShift_Upsert.HoursPerWeek_Property.md
- title: fsreqDepartmentShift_Upsert.IsActive Property
  kind: Property
  slug: active-property-77771
  path: fsreqDepartmentShift_Upsert.IsActive_Property.md
- title: fsreqDepartmentShift_Upsert.IsDeleted Property
  kind: Property
  slug: deleted-property-77772
  path: fsreqDepartmentShift_Upsert.IsDeleted_Property.md
- title: fsreqDepartmentShift_Upsert.Name Property
  kind: Property
  slug: name-property-77773
  path: fsreqDepartmentShift_Upsert.Name_Property.md
- title: fsreqDepartmentShift_Upsert.WeightPerWeek Property
  kind: Property
  slug: weight-week-property-77774
  path: fsreqDepartmentShift_Upsert.WeightPerWeek_Property.md
- title: fsreqDepartmentShift_Upsert.WorkAreaDepartmentID Property
  kind: Property
  slug: work-area-department-id-property-77775
  path: fsreqDepartmentShift_Upsert.WorkAreaDepartmentID_Property.md
- title: fsreqDepartmentShift_Upsert.WorkshopID Property
  kind: Property
  slug: workshop-id-property-77776
  path: fsreqDepartmentShift_Upsert.WorkshopID_Property.md
---

# fsreqDepartmentShift_Upsert Class

Inserts or updates a department shift into Tekla PowerFab

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDepartmentShift\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDepartmentShift_Upsert : fsreqCommand
```

The fsreqDepartmentShift\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDepartmentShift\_Upsert](fsreqDepartmentShift_Upsert_Constructor.md) | Initializes a new instance of the fsreqDepartmentShift\_Upsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentShiftID](fsreqDepartmentShift_Upsert.DepartmentShiftID_Property.md) | DepartmentShiftID - for update |
| Public property | [HoursPerWeek](fsreqDepartmentShift_Upsert.HoursPerWeek_Property.md) | Capacity of shift in hours. |
| Public property | [IsActive](fsreqDepartmentShift_Upsert.IsActive_Property.md) | True if shift is active. |
| Public property | [IsDeleted](fsreqDepartmentShift_Upsert.IsDeleted_Property.md) | True if shift has been deleted. |
| Public property | [Name](fsreqDepartmentShift_Upsert.Name_Property.md) | Name of shift. |
| Public property | [WeightPerWeek](fsreqDepartmentShift_Upsert.WeightPerWeek_Property.md) | Capacity of shift in metric tons. |
| Public property | [WorkAreaDepartmentID](fsreqDepartmentShift_Upsert.WorkAreaDepartmentID_Property.md) | ID of the workAreaDepartment used. Required for insert. |
| Public property | [WorkshopID](fsreqDepartmentShift_Upsert.WorkshopID_Property.md) | ID of workshop. Required for insert. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
