---
title: fsreqNestSolutionTFSDrop Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-nest-solution-tfs-drop-class-79620
slug: fsreq-nest-solution-tfs-drop-class-79620
node_id: 79620
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqNestSolutionTFSDrop Class
children:
- title: fsreqNestSolutionTFSDrop Constructor
  kind: Constructor
  slug: fsreq-nest-solution-tfs-drop-constructor-79621
  path: fsreqNestSolutionTFSDrop_Constructor.md
- title: fsreqNestSolutionTFSDrop.AddBackToNestSolution Property
  kind: Property
  slug: add-back-nest-solution-property-79623
  path: fsreqNestSolutionTFSDrop.AddBackToNestSolution_Property.md
- title: fsreqNestSolutionTFSDrop.JobNumber Property
  kind: Property
  slug: job-number-property-79624
  path: fsreqNestSolutionTFSDrop.JobNumber_Property.md
- title: fsreqNestSolutionTFSDrop.Length Property
  kind: Property
  slug: length-property-79625
  path: fsreqNestSolutionTFSDrop.Length_Property.md
- title: fsreqNestSolutionTFSDrop.Location Property
  kind: Property
  slug: location-property-79626
  path: fsreqNestSolutionTFSDrop.Location_Property.md
- title: fsreqNestSolutionTFSDrop.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-79627
  path: fsreqNestSolutionTFSDrop.SecondaryLocation_Property.md
- title: fsreqNestSolutionTFSDrop.UseStockDetailsFromNestSolutionRequiredID Property
  kind: Property
  slug: use-stock-details-nest-solution-required-id-property-79628
  path: fsreqNestSolutionTFSDrop.UseStockDetailsFromNestSolutionRequiredID_Property.md
---

# fsreqNestSolutionTFSDrop Class

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqNestSolutionTFSDrop

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqNestSolutionTFSDrop
```

The fsreqNestSolutionTFSDrop type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqNestSolutionTFSDrop](fsreqNestSolutionTFSDrop_Constructor.md) | Initializes a new instance of the fsreqNestSolutionTFSDrop class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AddBackToNestSolution](fsreqNestSolutionTFSDrop.AddBackToNestSolution_Property.md) | If true, and if only a portion of the total splice package is being cut, then the drop is added back to the original splice package for further processing. |
| Public property | [JobNumber](fsreqNestSolutionTFSDrop.JobNumber_Property.md) | Job Number of Drop |
| Public property | [Length](fsreqNestSolutionTFSDrop.Length_Property.md) | Length of drop |
| Public property | [Location](fsreqNestSolutionTFSDrop.Location_Property.md) | Location of Drop |
| Public property | [SecondaryLocation](fsreqNestSolutionTFSDrop.SecondaryLocation_Property.md) | Secondary Location of Drop |
| Public property | [UseStockDetailsFromNestSolutionRequiredID](fsreqNestSolutionTFSDrop.UseStockDetailsFromNestSolutionRequiredID_Property.md) | If specified, then the drop will use the supplier, po number, and heat number of that required stock record. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
