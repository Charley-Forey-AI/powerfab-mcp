---
title: fsreqFilter.MatchType Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/match-type-property-78710
slug: match-type-property-78710
node_id: 78710
kind: Property
parent: fsreqFilter Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-class-78702
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilter Class
- fsreqFilter Properties
- fsreqFilter.MatchType Property
children: []
---

# fsreqFilter.MatchType Property

The type of match that should be used to apply the filter.
The default match type if this element is not specified is EXACT.
Not all match types are valid for every filter. The PREFIX, SUFFIX, and ANY
match types are only valid for the filter types:
MainMark
DrawingNumber
Sequence
LotNumber
Category
SubCategory

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
public fsreqFilterMatchType MatchType { get; set; }
```

#### Property Value

Type: [fsreqFilterMatchType](../fsreqFilterMatchType_Enumeration.md)

See Also

#### Reference

[fsreqFilter Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
