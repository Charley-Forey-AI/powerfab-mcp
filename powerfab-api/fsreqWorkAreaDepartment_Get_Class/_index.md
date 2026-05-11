---
title: fsreqWorkAreaDepartment_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-area-departmentget-class-80671
slug: fsreq-work-area-departmentget-class-80671
node_id: 80671
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkAreaDepartment_Get Class
children:
- title: fsreqWorkAreaDepartment_Get Constructor
  kind: Constructor
  slug: fsreq-work-area-departmentget-constructor-80672
  path: fsreqWorkAreaDepartment_Get_Constructor.md
- title: fsreqWorkAreaDepartment_Get.DepartmentID Property
  kind: Property
  slug: department-id-property-80674
  path: fsreqWorkAreaDepartment_Get.DepartmentID_Property.md
- title: fsreqWorkAreaDepartment_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80675
  path: fsreqWorkAreaDepartment_Get.LastLogID_Property.md
- title: fsreqWorkAreaDepartment_Get.WorkAreaDepartmentID Property
  kind: Property
  slug: work-area-department-id-property-80676
  path: fsreqWorkAreaDepartment_Get.WorkAreaDepartmentID_Property.md
- title: fsreqWorkAreaDepartment_Get.WorkAreaID Property
  kind: Property
  slug: work-area-id-property-80677
  path: fsreqWorkAreaDepartment_Get.WorkAreaID_Property.md
- title: fsreqWorkAreaDepartment_Get.WorkshopID Property
  kind: Property
  slug: workshop-id-property-80678
  path: fsreqWorkAreaDepartment_Get.WorkshopID_Property.md
---

# fsreqWorkAreaDepartment_Get Class

Retrieves one or more work area resources.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkAreaDepartment\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkAreaDepartment_Get : fsreqCommand
```

The fsreqWorkAreaDepartment\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkAreaDepartment\_Get](fsreqWorkAreaDepartment_Get_Constructor.md) | fsreqWorkAreaDepartment\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentID](fsreqWorkAreaDepartment_Get.DepartmentID_Property.md) | Department ID |
| Public property | [LastLogID](fsreqWorkAreaDepartment_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [WorkAreaDepartmentID](fsreqWorkAreaDepartment_Get.WorkAreaDepartmentID_Property.md) | Work Area Department ID |
| Public property | [WorkAreaID](fsreqWorkAreaDepartment_Get.WorkAreaID_Property.md) | Work area ID |
| Public property | [WorkshopID](fsreqWorkAreaDepartment_Get.WorkshopID_Property.md) | Workshop ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
