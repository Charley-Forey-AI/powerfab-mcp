---
title: fsreqGetInventorySummary Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inventory-summary-class-79115
slug: fsreq-get-inventory-summary-class-79115
node_id: 79115
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInventorySummary Class
children:
- title: fsreqGetInventorySummary Constructor
  kind: Constructor
  slug: fsreq-get-inventory-summary-constructor-79116
  path: fsreqGetInventorySummary_Constructor.md
- title: fsreqGetInventorySummary.Filters Property
  kind: Property
  slug: filters-property-79118
  path: fsreqGetInventorySummary.Filters_Property.md
- title: fsreqGetInventorySummary.InputDisplayUnits Property
  kind: Property
  slug: input-display-units-property-79119
  path: fsreqGetInventorySummary.InputDisplayUnits_Property.md
- title: fsreqGetInventorySummary.Limit Property
  kind: Property
  slug: limit-property-79120
  path: fsreqGetInventorySummary.Limit_Property.md
- title: fsreqGetInventorySummary.Offset Property
  kind: Property
  slug: offset-property-79121
  path: fsreqGetInventorySummary.Offset_Property.md
- title: fsreqGetInventorySummary.SummaryField Property
  kind: Property
  slug: summary-field-property-79122
  path: fsreqGetInventorySummary.SummaryField_Property.md
---

# fsreqGetInventorySummary Class

Retrieves summary information from inventory.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInventorySummary

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInventorySummary : fsreqCommand
```

The fsreqGetInventorySummary type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInventorySummary](fsreqGetInventorySummary_Constructor.md) | fsreqGetInventorySummary class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetInventorySummary.Filters_Property.md) |  |
| Public property | [InputDisplayUnits](fsreqGetInventorySummary.InputDisplayUnits_Property.md) |  |
| Public property | [Limit](fsreqGetInventorySummary.Limit_Property.md) |  |
| Public property | [Offset](fsreqGetInventorySummary.Offset_Property.md) |  |
| Public property | [SummaryField](fsreqGetInventorySummary.SummaryField_Property.md) | Field(s) to group the summary information on. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
