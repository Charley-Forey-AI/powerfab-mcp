---
title: fsreqWorkPackage_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-packageget-class-80759
slug: fsreq-work-packageget-class-80759
node_id: 80759
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackage_Get Class
children:
- title: fsreqWorkPackage_Get Constructor
  kind: Constructor
  slug: fsreq-work-packageget-constructor-80760
  path: fsreqWorkPackage_Get_Constructor.md
- title: fsreqWorkPackage_Get.GetOptions Property
  kind: Property
  slug: get-options-property-80762
  path: fsreqWorkPackage_Get.GetOptions_Property.md
- title: fsreqWorkPackage_Get.Group1 Property
  kind: Property
  slug: group1-property-80763
  path: fsreqWorkPackage_Get.Group1_Property.md
- title: fsreqWorkPackage_Get.Group2 Property
  kind: Property
  slug: group2-property-80764
  path: fsreqWorkPackage_Get.Group2_Property.md
- title: fsreqWorkPackage_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-80765
  path: fsreqWorkPackage_Get.LastLogID_Property.md
- title: fsreqWorkPackage_Get.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80766
  path: fsreqWorkPackage_Get.ProductionControlID_Property.md
- title: fsreqWorkPackage_Get.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80767
  path: fsreqWorkPackage_Get.WorkPackageID_Property.md
- title: fsreqWorkPackage_Get.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-80768
  path: fsreqWorkPackage_Get.WorkPackageNumber_Property.md
---

# fsreqWorkPackage_Get Class

Retrieves the work package.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackage\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackage_Get : fsreqCommand
```

The fsreqWorkPackage\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackage\_Get](fsreqWorkPackage_Get_Constructor.md) | fsreqWorkPackage\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqWorkPackage_Get.GetOptions_Property.md) | Additional options |
| Public property | [Group1](fsreqWorkPackage_Get.Group1_Property.md) | Group 1 |
| Public property | [Group2](fsreqWorkPackage_Get.Group2_Property.md) | Group 2 |
| Public property | [LastLogID](fsreqWorkPackage_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [ProductionControlID](fsreqWorkPackage_Get.ProductionControlID_Property.md) | Production Control ID |
| Public property | [WorkPackageID](fsreqWorkPackage_Get.WorkPackageID_Property.md) | Work Package ID |
| Public property | [WorkPackageNumber](fsreqWorkPackage_Get.WorkPackageNumber_Property.md) | Work Package Number |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
