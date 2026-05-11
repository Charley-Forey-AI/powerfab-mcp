---
title: fsreqNestPart Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-nest-part-class-79581
slug: fsreq-nest-part-class-79581
node_id: 79581
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqNestPart Class
children:
- title: fsreqNestPart Constructor
  kind: Constructor
  slug: fsreq-nest-part-constructor-79582
  path: fsreqNestPart_Constructor.md
- title: fsreqNestPart.JobNumber Property
  kind: Property
  slug: job-number-property-79584
  path: fsreqNestPart.JobNumber_Property.md
- title: fsreqNestPart.Length Property
  kind: Property
  slug: length-property-79585
  path: fsreqNestPart.Length_Property.md
- title: fsreqNestPart.LotNumber Property
  kind: Property
  slug: lot-number-property-79586
  path: fsreqNestPart.LotNumber_Property.md
- title: fsreqNestPart.MainMark Property
  kind: Property
  slug: main-mark-property-79587
  path: fsreqNestPart.MainMark_Property.md
- title: fsreqNestPart.PieceMark Property
  kind: Property
  slug: piece-mark-property-79588
  path: fsreqNestPart.PieceMark_Property.md
- title: fsreqNestPart.Quantity Property
  kind: Property
  slug: quantity-property-79589
  path: fsreqNestPart.Quantity_Property.md
- title: fsreqNestPart.Sequence Property
  kind: Property
  slug: sequence-property-79590
  path: fsreqNestPart.Sequence_Property.md
- title: fsreqNestPart.Width Property
  kind: Property
  slug: width-property-79591
  path: fsreqNestPart.Width_Property.md
- title: fsreqNestPart.WorkPackageNumber Property
  kind: Property
  slug: work-package-number-property-79592
  path: fsreqNestPart.WorkPackageNumber_Property.md
---

# fsreqNestPart Class

A single part that is nested on to material in this nest on SaveNest command

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqNestPart

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqNestPart
```

The fsreqNestPart type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqNestPart](fsreqNestPart_Constructor.md) | fsreqNestPart class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [JobNumber](fsreqNestPart.JobNumber_Property.md) | Job this part is on. |
| Public property | [Length](fsreqNestPart.Length_Property.md) | The length of the material. Best practice is to include, but only required if FabSuite does not have this job. |
| Public property | [LotNumber](fsreqNestPart.LotNumber_Property.md) | Lot of Part. |
| Public property | [MainMark](fsreqNestPart.MainMark_Property.md) | Shape of Part. |
| Public property | [PieceMark](fsreqNestPart.PieceMark_Property.md) | Piecemark of Part. |
| Public property | [Quantity](fsreqNestPart.Quantity_Property.md) | Quantity of Part. |
| Public property | [Sequence](fsreqNestPart.Sequence_Property.md) | Sequence of Part. |
| Public property | [Width](fsreqNestPart.Width_Property.md) | The width of the material when it's a plate. Best practice is to include, but only required if FabSuite does not have this job. |
| Public property | [WorkPackageNumber](fsreqNestPart.WorkPackageNumber_Property.md) | Work package number of Part. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
