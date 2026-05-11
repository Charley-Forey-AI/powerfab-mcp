---
title: fsreqProductionControlCutList_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-cut-listupdate-class-79696
slug: fsreq-production-control-cut-listupdate-class-79696
node_id: 79696
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlCutList_Update Class
children:
- title: fsreqProductionControlCutList_Update Constructor
  kind: Constructor
  slug: fsreq-production-control-cut-listupdate-constructor-79697
  path: fsreqProductionControlCutList_Update_Constructor.md
- title: fsreqProductionControlCutList_Update.DateRequired Property
  kind: Property
  slug: date-required-property-79699
  path: fsreqProductionControlCutList_Update.DateRequired_Property.md
- title: fsreqProductionControlCutList_Update.DateRequiredOffset Property
  kind: Property
  slug: date-required-offset-property-79700
  path: fsreqProductionControlCutList_Update.DateRequiredOffset_Property.md
- title: fsreqProductionControlCutList_Update.Description Property
  kind: Property
  slug: description-property-79701
  path: fsreqProductionControlCutList_Update.Description_Property.md
- title: fsreqProductionControlCutList_Update.MachineGroupID Property
  kind: Property
  slug: machine-group-id-property-79702
  path: fsreqProductionControlCutList_Update.MachineGroupID_Property.md
- title: fsreqProductionControlCutList_Update.MachineID Property
  kind: Property
  slug: machine-id-property-79703
  path: fsreqProductionControlCutList_Update.MachineID_Property.md
- title: fsreqProductionControlCutList_Update.Notes Property
  kind: Property
  slug: notes-property-79704
  path: fsreqProductionControlCutList_Update.Notes_Property.md
- title: fsreqProductionControlCutList_Update.Priority Property
  kind: Property
  slug: priority-property-79705
  path: fsreqProductionControlCutList_Update.Priority_Property.md
- title: fsreqProductionControlCutList_Update.ProductionControlCutListID Property
  kind: Property
  slug: production-control-cut-list-id-property-79706
  path: fsreqProductionControlCutList_Update.ProductionControlCutListID_Property.md
- title: fsreqProductionControlCutList_Update.WorkshopID Property
  kind: Property
  slug: workshop-id-property-79707
  path: fsreqProductionControlCutList_Update.WorkshopID_Property.md
---

# fsreqProductionControlCutList_Update Class

Updates one or more Production Control Cut Lists.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlCutList\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlCutList_Update : fsreqCommand
```

The fsreqProductionControlCutList\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlCutList\_Update](fsreqProductionControlCutList_Update_Constructor.md) | fsreqProductionControlCutList\_Update class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DateRequired](fsreqProductionControlCutList_Update.DateRequired_Property.md) | Date this cut list is required |
| Public property | [DateRequiredOffset](fsreqProductionControlCutList_Update.DateRequiredOffset_Property.md) | The number of days +/- to modify the date required |
| Public property | [Description](fsreqProductionControlCutList_Update.Description_Property.md) | Set the cut list description |
| Public property | [MachineGroupID](fsreqProductionControlCutList_Update.MachineGroupID_Property.md) | Select cut lists that are assigned to this machine group |
| Public property | [MachineID](fsreqProductionControlCutList_Update.MachineID_Property.md) | Select cut lists that are assigned to this machine |
| Public property | [Notes](fsreqProductionControlCutList_Update.Notes_Property.md) | Set the cut list notes |
| Public property | [Priority](fsreqProductionControlCutList_Update.Priority_Property.md) | The priority of the cut list |
| Public property | [ProductionControlCutListID](fsreqProductionControlCutList_Update.ProductionControlCutListID_Property.md) | CutListID |
| Public property | [WorkshopID](fsreqProductionControlCutList_Update.WorkshopID_Property.md) | Select cut lists that are assigned to this workshop |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
