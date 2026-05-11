---
title: fsreqWorkPackageDepartment_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-departmentget-class-80845
slug: fsreq-work-package-departmentget-class-80845
node_id: 80845
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartment_Get Class
children:
- title: fsreqWorkPackageDepartment_Get Constructor
  kind: Constructor
  slug: fsreq-work-package-departmentget-constructor-80846
  path: fsreqWorkPackageDepartment_Get_Constructor.md
- title: fsreqWorkPackageDepartment_Get.GetOptions Property
  kind: Property
  slug: get-options-property-80848
  path: fsreqWorkPackageDepartment_Get.GetOptions_Property.md
- title: fsreqWorkPackageDepartment_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80849
  path: fsreqWorkPackageDepartment_Get.LastLogID_Property.md
- title: fsreqWorkPackageDepartment_Get.WorkPackageDepartmentID Property
  kind: Property
  slug: work-package-department-id-property-80850
  path: fsreqWorkPackageDepartment_Get.WorkPackageDepartmentID_Property.md
- title: fsreqWorkPackageDepartment_Get.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80851
  path: fsreqWorkPackageDepartment_Get.WorkPackageID_Property.md
---

# fsreqWorkPackageDepartment_Get Class

Retrieves the work package departments.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartment\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartment_Get : fsreqCommand
```

The fsreqWorkPackageDepartment\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartment\_Get](fsreqWorkPackageDepartment_Get_Constructor.md) | fsreqWorkPackageDepartment\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqWorkPackageDepartment_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqWorkPackageDepartment_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [WorkPackageDepartmentID](fsreqWorkPackageDepartment_Get.WorkPackageDepartmentID_Property.md) | Work Package Department ID |
| Public property | [WorkPackageID](fsreqWorkPackageDepartment_Get.WorkPackageID_Property.md) | Work Package ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
