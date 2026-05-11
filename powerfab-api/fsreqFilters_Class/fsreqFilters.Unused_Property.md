---
title: fsreqFilters.Unused Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/unused-property-78726
slug: unused-property-78726
node_id: 78726
kind: Property
parent: fsreqFilters Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filters-class-78722
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilters Class
- fsreqFilters Properties
- fsreqFilters.Unused Property
children: []
---

# fsreqFilters.Unused Property

This element is not intended to actually be used. It's sole purpose is to work around a
problem with MS Visual Studio's xsd tool that generates c# classes from an xsd schema.
With this tool if an element consists solely of a single element that may occur 1-many times
then that parent element is ignored and the classes are generated with a multi-dimensional array
of the inner element.
In this case, where fsreqFilters is used it would appear in the classes instead as being
a multi-dimensional array of fsreqFilter. Adding a second element, titled Unused here, avoids
this issue.

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
public bool Unused { get; set; }
```

#### Property Value

Type: Boolean

See Also

#### Reference

[fsreqFilters Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
