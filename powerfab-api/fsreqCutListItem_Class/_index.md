---
title: fsreqCutListItem Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-cut-list-item-class-77719
slug: fsreq-cut-list-item-class-77719
node_id: 77719
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCutListItem Class
children:
- title: fsreqCutListItem Constructor
  kind: Constructor
  slug: fsreq-cut-list-item-constructor-77720
  path: fsreqCutListItem_Constructor.md
- title: fsreqCutListItem.CalculateRemnant Property
  kind: Property
  slug: calculate-remnant-property-77722
  path: fsreqCutListItem.CalculateRemnant_Property.md
- title: fsreqCutListItem.CutListItemID Property
  kind: Property
  slug: cut-list-item-id-property-77723
  path: fsreqCutListItem.CutListItemID_Property.md
- title: fsreqCutListItem.NestExtra1 Property
  kind: Property
  slug: nest-extra1-property-77724
  path: fsreqCutListItem.NestExtra1_Property.md
- title: fsreqCutListItem.NestExtra2 Property
  kind: Property
  slug: nest-extra2-property-77725
  path: fsreqCutListItem.NestExtra2_Property.md
- title: fsreqCutListItem.NestID Property
  kind: Property
  slug: nest-id-property-77726
  path: fsreqCutListItem.NestID_Property.md
- title: fsreqCutListItem.Remnant Property
  kind: Property
  slug: remnant-property-77727
  path: fsreqCutListItem.Remnant_Property.md
---

# fsreqCutListItem Class

A CutListItem for the SetCutListItemNestID command

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqCutListItem

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqCutListItem
```

The fsreqCutListItem type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqCutListItem](fsreqCutListItem_Constructor.md) | fsreqCutListItem class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [CalculateRemnant](fsreqCutListItem.CalculateRemnant_Property.md) | FabSuite automatically calculate remnant. If included and false and remnant type is omitted, remnant is zero. |
| Public property | [CutListItemID](fsreqCutListItem.CutListItemID_Property.md) | CutListID that is set from GetCutList command |
| Public property | [NestExtra1](fsreqCutListItem.NestExtra1_Property.md) | Extra field 1 for external extra data |
| Public property | [NestExtra2](fsreqCutListItem.NestExtra2_Property.md) | Extra field 2 for external extra data |
| Public property | [NestID](fsreqCutListItem.NestID_Property.md) | Nest ID in external software (a Nest GUID) |
| Public property | [Remnant](fsreqCutListItem.Remnant_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
