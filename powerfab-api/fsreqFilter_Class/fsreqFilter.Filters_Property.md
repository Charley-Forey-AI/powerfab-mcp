---
title: fsreqFilter.Filters Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/filters-property-78706
slug: filters-property-78706
node_id: 78706
kind: Property
parent: fsreqFilter Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-class-78702
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilter Class
- fsreqFilter Properties
- fsreqFilter.Filters Property
children: []
---

# fsreqFilter.Filters Property

The set of nested filter conditions. If specified then it will be considered to be an 'AND'
condition on top of the current filter. If multiple nested filters are specified then each of
the Filters elements are considered to be an 'OR' condition with respect to each other.
For example, this set of filters:

ShapeWJobNumberABCJobNumberDEFOnOrder0PONumber123456

Could be considered to be equivalent to the sql expression:
Shape='W' AND
(
(JobNumber IN ('ABC', 'DEF') AND OnOrder=0)
OR
PONumber='123456'
)
Nested Filters elements are accepted but is currently only processed by the GetInventory, and GetPricingInformation commands.

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[XmlElementAttribute("Filters")]
public List<fsreqFilters> Filters { get; set; }
```

#### Property Value

Type: List&lt;[fsreqFilters](../fsreqFilters_Class/_index.md)&gt;

See Also

#### Reference

[fsreqFilter Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
