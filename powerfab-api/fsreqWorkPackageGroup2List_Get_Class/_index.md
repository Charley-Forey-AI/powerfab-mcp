---
title: fsreqWorkPackageGroup2List_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-package-group2-listget-class-80949
slug: fsreq-work-package-group2-listget-class-80949
node_id: 80949
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackageGroup2List_Get Class
children:
- title: fsreqWorkPackageGroup2List_Get Constructor
  kind: Constructor
  slug: fsreq-work-package-group2-listget-constructor-80950
  path: fsreqWorkPackageGroup2List_Get_Constructor.md
- title: fsreqWorkPackageGroup2List_Get.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80952
  path: fsreqWorkPackageGroup2List_Get.ProductionControlID_Property.md
---

# fsreqWorkPackageGroup2List_Get Class

Retrieves the list of in-use values for Group2 in this production Control Job.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackageGroup2List\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackageGroup2List_Get : fsreqCommand
```

The fsreqWorkPackageGroup2List\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackageGroup2List\_Get](fsreqWorkPackageGroup2List_Get_Constructor.md) | fsreqWorkPackageGroup2List\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ProductionControlID](fsreqWorkPackageGroup2List_Get.ProductionControlID_Property.md) | Production Control ID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
