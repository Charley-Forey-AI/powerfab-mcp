---
title: fsreqMachine_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-machineget-class-79537
slug: fsreq-machineget-class-79537
node_id: 79537
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqMachine_Get Class
children:
- title: fsreqMachine_Get Constructor
  kind: Constructor
  slug: fsreq-machineget-constructor-79538
  path: fsreqMachine_Get_Constructor.md
- title: fsreqMachine_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-79540
  path: fsreqMachine_Get.LastLogID_Property.md
- title: fsreqMachine_Get.MachineGroupID Property
  kind: Property
  slug: machine-group-id-property-79541
  path: fsreqMachine_Get.MachineGroupID_Property.md
- title: fsreqMachine_Get.MachineID Property
  kind: Property
  slug: machine-id-property-79542
  path: fsreqMachine_Get.MachineID_Property.md
---

# fsreqMachine_Get Class

Retrieves the machines.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqMachine\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqMachine_Get : fsreqCommand
```

The fsreqMachine\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqMachine\_Get](fsreqMachine_Get_Constructor.md) | fsreqMachine\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LastLogID](fsreqMachine_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |
| Public property | [MachineGroupID](fsreqMachine_Get.MachineGroupID_Property.md) | MachineGroupID |
| Public property | [MachineID](fsreqMachine_Get.MachineID_Property.md) | MachineID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
