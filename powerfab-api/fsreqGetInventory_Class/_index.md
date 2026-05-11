---
title: fsreqGetInventory Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-inventory-class-79099
slug: fsreq-get-inventory-class-79099
node_id: 79099
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetInventory Class
children:
- title: fsreqGetInventory Constructor
  kind: Constructor
  slug: fsreq-get-inventory-constructor-79100
  path: fsreqGetInventory_Constructor.md
- title: fsreqGetInventory.Filters Property
  kind: Property
  slug: filters-property-79102
  path: fsreqGetInventory.Filters_Property.md
- title: fsreqGetInventory.IncludeHistory Property
  kind: Property
  slug: include-history-property-79103
  path: fsreqGetInventory.IncludeHistory_Property.md
- title: fsreqGetInventory.IncludeInventory Property
  kind: Property
  slug: include-inventory-property-79104
  path: fsreqGetInventory.IncludeInventory_Property.md
- title: fsreqGetInventory.InventoryItemID Property
  kind: Property
  slug: inventory-item-id-property-79105
  path: fsreqGetInventory.InventoryItemID_Property.md
- title: fsreqGetInventory.LinkSoftware Property
  kind: Property
  slug: link-software-property-79106
  path: fsreqGetInventory.LinkSoftware_Property.md
- title: fsreqGetInventory.UseGradeSubstitutions Property
  kind: Property
  slug: use-grade-substitutions-property-79107
  path: fsreqGetInventory.UseGradeSubstitutions_Property.md
---

# fsreqGetInventory Class

Retrieves all of the records from the current inventory and/or inventory history.
Use IncludeInventory and IncludeHistory to specify that inventory and/or inventory history records should be retrieved.
If neither the IncludeInventory or IncludeHistory elements are included then the command will retrieve inventory records only.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetInventory

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetInventory : fsreqCommand
```

The fsreqGetInventory type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetInventory](fsreqGetInventory_Constructor.md) | fsreqGetInventory class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetInventory.Filters_Property.md) | Nested Filters elements are supported. |
| Public property | [IncludeHistory](fsreqGetInventory.IncludeHistory_Property.md) | Indicates if information from Inventory History should be retrieved. |
| Public property | [IncludeInventory](fsreqGetInventory.IncludeInventory_Property.md) | Indicates if information from Inventory should be retrieved. |
| Public property | [InventoryItemID](fsreqGetInventory.InventoryItemID_Property.md) | The unique identifier for the inventory records to retrieve. |
| Public property | [LinkSoftware](fsreqGetInventory.LinkSoftware_Property.md) | Send External Inventory IDs for this software |
| Public property | [UseGradeSubstitutions](fsreqGetInventory.UseGradeSubstitutions_Property.md) | Indicates if grade substitutions should be considered when a grade filter is applied. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
