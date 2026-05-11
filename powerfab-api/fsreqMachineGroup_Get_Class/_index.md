---
title: fsreqMachineGroup_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-machine-groupget-class-79543
slug: fsreq-machine-groupget-class-79543
node_id: 79543
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqMachineGroup_Get Class
children:
- title: fsreqMachineGroup_Get Constructor
  kind: Constructor
  slug: fsreq-machine-groupget-constructor-79544
  path: fsreqMachineGroup_Get_Constructor.md
- title: fsreqMachineGroup_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-79546
  path: fsreqMachineGroup_Get.LastLogID_Property.md
- title: fsreqMachineGroup_Get.MachineGroupID Property
  kind: Property
  slug: machine-group-id-property-79547
  path: fsreqMachineGroup_Get.MachineGroupID_Property.md
---

# fsreqMachineGroup_Get Class

Retrieves the machine groups.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqMachineGroup\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqMachineGroup_Get : fsreqCommand
```

The fsreqMachineGroup\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqMachineGroup\_Get](fsreqMachineGroup_Get_Constructor.md) | fsreqMachineGroup\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqMachineGroup_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [MachineGroupID](fsreqMachineGroup_Get.MachineGroupID_Property.md) | MachineGroupID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
