---
title: fsreqCostCode_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-cost-codeget-class-77676
slug: fsreq-cost-codeget-class-77676
node_id: 77676
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCostCode_Get Class
children:
- title: fsreqCostCode_Get Constructor
  kind: Constructor
  slug: fsreq-cost-codeget-constructor-77677
  path: fsreqCostCode_Get_Constructor.md
- title: fsreqCostCode_Get.CostCodeID Property
  kind: Property
  slug: cost-code-id-property-77679
  path: fsreqCostCode_Get.CostCodeID_Property.md
- title: fsreqCostCode_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-77680
  path: fsreqCostCode_Get.LastLogID_Property.md
---

# fsreqCostCode_Get Class

Retrieves one or more cost codes for Purchasing.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqCostCode\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqCostCode_Get : fsreqCommand
```

The fsreqCostCode\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqCostCode\_Get](fsreqCostCode_Get_Constructor.md) | fsreqCostCode\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CostCodeID](fsreqCostCode_Get.CostCodeID_Property.md) | CostCodeID |
| Public property | [LastLogID](fsreqCostCode_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
