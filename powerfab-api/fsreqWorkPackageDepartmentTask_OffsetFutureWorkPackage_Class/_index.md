---
title: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-department-taskoffset-future-work-package-class-80892
slug: fsreq-work-package-department-taskoffset-future-work-package-class-80892
node_id: 80892
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage Class
children:
- title: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage Constructor
  kind: Constructor
  slug: fsreq-work-package-department-taskoffset-future-work-package-constructor-80893
  path: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage_Constructor.md
- title: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.FutureWorkPackageID Property
  kind: Property
  slug: future-work-package-id-property-80895
  path: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.FutureWorkPackageID_Property.md
- title: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.WorkPackageDepartmentTaskID Property
  kind: Property
  slug: work-package-department-task-id-property-80896
  path: fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.WorkPackageDepartmentTaskID_Property.md
---

# fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage Class

Offsets against future work packages.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageDepartmentTask\_OffsetFutureWorkPackage

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage : fsreqCommand
```

The fsreqWorkPackageDepartmentTask\_OffsetFutureWorkPackage type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageDepartmentTask\_OffsetFutureWorkPackage](fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage_Constructor.md) | fsreqWorkPackageDepartmentTask\_OffsetFutureWorkPackage class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FutureWorkPackageID](fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.FutureWorkPackageID_Property.md) | The future work packages to offset |
| Public property | [WorkPackageDepartmentTaskID](fsreqWorkPackageDepartmentTask_OffsetFutureWorkPackage.WorkPackageDepartmentTaskID_Property.md) | The production Work Package Department Task ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
