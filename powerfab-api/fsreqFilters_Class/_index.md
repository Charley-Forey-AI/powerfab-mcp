---
title: fsreqFilters Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filters-class-78722
slug: fsreq-filters-class-78722
node_id: 78722
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilters Class
children:
- title: fsreqFilters Constructor
  kind: Constructor
  slug: fsreq-filters-constructor-78723
  path: fsreqFilters_Constructor.md
- title: fsreqFilters.Filter Property
  kind: Property
  slug: filter-property-78725
  path: fsreqFilters.Filter_Property.md
- title: fsreqFilters.Unused Property
  kind: Property
  slug: unused-property-78726
  path: fsreqFilters.Unused_Property.md
---

# fsreqFilters Class

A set of filters specifying the data that should be processed by the command.
If more than one Filter element specify the same FilterType then an 'or' condition is applied.
An 'and' condition is applied to different FilterType fields.
Ex.

DrawingNumber100DrawingNumber101Sequence5

Processed as DrawingNumber IN (100, 101) AND Sequence=5.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqFilters

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFilters
```

The fsreqFilters type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFilters](fsreqFilters_Constructor.md) | fsreqFilters class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Filter](fsreqFilters.Filter_Property.md) | A list of filter objects |
| Public property | [Unused](fsreqFilters.Unused_Property.md) | This element is not intended to actually be used. It's sole purpose is to work around a problem with MS Visual Studio's xsd tool that generates c# classes from an xsd schema. With this tool if an element consists solely of a single element that may occur 1-many times then that parent element is ignored and the classes are generated with a multi-dimensional array of the inner element. In this case, where fsreqFilters is used it would appear in the classes instead as being a multi-dimensional array of fsreqFilter. Adding a second element, titled Unused here, avoids this issue. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
