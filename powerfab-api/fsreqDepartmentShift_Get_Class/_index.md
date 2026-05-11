---
title: fsreqDepartmentShift_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-department-shiftget-class-77756
slug: fsreq-department-shiftget-class-77756
node_id: 77756
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDepartmentShift_Get Class
children:
- title: fsreqDepartmentShift_Get Constructor
  kind: Constructor
  slug: fsreq-department-shiftget-constructor-77757
  path: fsreqDepartmentShift_Get_Constructor.md
- title: fsreqDepartmentShift_Get.DepartmentShiftID Property
  kind: Property
  slug: department-shift-id-property-77759
  path: fsreqDepartmentShift_Get.DepartmentShiftID_Property.md
- title: fsreqDepartmentShift_Get.GetOptions Property
  kind: Property
  slug: get-options-property-77760
  path: fsreqDepartmentShift_Get.GetOptions_Property.md
- title: fsreqDepartmentShift_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-77761
  path: fsreqDepartmentShift_Get.LastLogID_Property.md
---

# fsreqDepartmentShift_Get Class

Retrieves one or more department shifts.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDepartmentShift\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDepartmentShift_Get : fsreqCommand
```

The fsreqDepartmentShift\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDepartmentShift\_Get](fsreqDepartmentShift_Get_Constructor.md) | fsreqDepartmentShift\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentShiftID](fsreqDepartmentShift_Get.DepartmentShiftID_Property.md) | Department Shift ID |
| Public property | [GetOptions](fsreqDepartmentShift_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqDepartmentShift_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
