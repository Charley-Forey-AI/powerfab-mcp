---
title: fsreqSaveNestCombinationRunID Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-save-nest-combination-run-id-class-80380
slug: fsreq-save-nest-combination-run-id-class-80380
node_id: 80380
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSaveNestCombinationRunID Class
children:
- title: fsreqSaveNestCombinationRunID Constructor
  kind: Constructor
  slug: fsreq-save-nest-combination-run-id-constructor-80381
  path: fsreqSaveNestCombinationRunID_Constructor.md
- title: fsreqSaveNestCombinationRunID.ReloadInventory Property
  kind: Property
  slug: reload-inventory-property-80383
  path: fsreqSaveNestCombinationRunID.ReloadInventory_Property.md
- title: fsreqSaveNestCombinationRunID.SaveResults Property
  kind: Property
  slug: save-results-property-80384
  path: fsreqSaveNestCombinationRunID.SaveResults_Property.md
- title: fsreqSaveNestCombinationRunID.Value Property
  kind: Property
  slug: value-property-80385
  path: fsreqSaveNestCombinationRunID.Value_Property.md
---

# fsreqSaveNestCombinationRunID Class

FabSuite Combining Run that this Nest is for.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqSaveNestCombinationRunID

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSaveNestCombinationRunID
```

The fsreqSaveNestCombinationRunID type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSaveNestCombinationRunID](fsreqSaveNestCombinationRunID_Constructor.md) | Initializes a new instance of the fsreqSaveNestCombinationRunID class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [ReloadInventory](fsreqSaveNestCombinationRunID.ReloadInventory_Property.md) | Defaults to true, if set to false, available inventory for nest is restricted to that which was available when combining run what created |
| Public property | [SaveResults](fsreqSaveNestCombinationRunID.SaveResults_Property.md) | Defaults to true, if set to false, combining run will not be automatically saved, and allow the user to review before saving |
| Public property | [Value](fsreqSaveNestCombinationRunID.Value_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
