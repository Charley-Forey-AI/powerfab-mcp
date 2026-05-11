---
title: fsreqFilter Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-class-78702
slug: fsreq-filter-class-78702
node_id: 78702
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilter Class
children:
- title: fsreqFilter Constructor
  kind: Constructor
  slug: fsreq-filter-constructor-78703
  path: fsreqFilter_Constructor.md
- title: fsreqFilter.FilterDisplay Property
  kind: Property
  slug: filter-display-property-78705
  path: fsreqFilter.FilterDisplay_Property.md
- title: fsreqFilter.Filters Property
  kind: Property
  slug: filters-property-78706
  path: fsreqFilter.Filters_Property.md
- title: fsreqFilter.FilterType Property
  kind: Property
  slug: filter-type-property-78707
  path: fsreqFilter.FilterType_Property.md
- title: fsreqFilter.FilterValue Property
  kind: Property
  slug: filter-value-property-78708
  path: fsreqFilter.FilterValue_Property.md
- title: fsreqFilter.FilterValueMax Property
  kind: Property
  slug: filter-value-max-property-78709
  path: fsreqFilter.FilterValueMax_Property.md
- title: fsreqFilter.MatchType Property
  kind: Property
  slug: match-type-property-78710
  path: fsreqFilter.MatchType_Property.md
---

# fsreqFilter Class

A filter type and value.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqFilter

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFilter
```

The fsreqFilter type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFilter](fsreqFilter_Constructor.md) | fsreqFilter class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [FilterDisplay](fsreqFilter.FilterDisplay_Property.md) | The value that the field should be restricted to. |
| Public property | [Filters](fsreqFilter.Filters_Property.md) | The set of nested filter conditions. If specified then it will be considered to be an 'AND' condition on top of the current filter. If multiple nested filters are specified then each of the Filters elements are considered to be an 'OR' condition with respect to each other. For example, this set of filters: |
| Public property | [FilterType](fsreqFilter.FilterType_Property.md) | The field that the filter applies to. |
| Public property | [FilterValue](fsreqFilter.FilterValue_Property.md) | The value that the field should be restricted to. |
| Public property | [FilterValueMax](fsreqFilter.FilterValueMax_Property.md) | If specified then this becomes a range filter with FilterValue being the bottom value of the range and FilterValueMax being the upper value. |
| Public property | [MatchType](fsreqFilter.MatchType_Property.md) | The type of match that should be used to apply the filter. The default match type if this element is not specified is EXACT. Not all match types are valid for every filter. The PREFIX, SUFFIX, and ANY match types are only valid for the filter types: MainMark DrawingNumber Sequence LotNumber Category SubCategory |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
