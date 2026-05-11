---
title: fsreqWorkPackageGroup1List_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-group1-listget-class-80945
slug: fsreq-work-package-group1-listget-class-80945
node_id: 80945
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageGroup1List_Get Class
children:
- title: fsreqWorkPackageGroup1List_Get Constructor
  kind: Constructor
  slug: fsreq-work-package-group1-listget-constructor-80946
  path: fsreqWorkPackageGroup1List_Get_Constructor.md
- title: fsreqWorkPackageGroup1List_Get.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80948
  path: fsreqWorkPackageGroup1List_Get.ProductionControlID_Property.md
---

# fsreqWorkPackageGroup1List_Get Class

Retrieves the list of in-use values for Group1 in this production Control Job.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageGroup1List\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageGroup1List_Get : fsreqCommand
```

The fsreqWorkPackageGroup1List\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageGroup1List\_Get](fsreqWorkPackageGroup1List_Get_Constructor.md) | fsreqWorkPackageGroup1List\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ProductionControlID](fsreqWorkPackageGroup1List_Get.ProductionControlID_Property.md) | Production Control ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
