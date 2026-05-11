---
title: fsreqNestSolutionTFSResult Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-nest-solution-tfs-result-class-79629
slug: fsreq-nest-solution-tfs-result-class-79629
node_id: 79629
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqNestSolutionTFSResult Class
children:
- title: fsreqNestSolutionTFSResult Constructor
  kind: Constructor
  slug: fsreq-nest-solution-tfs-result-constructor-79630
  path: fsreqNestSolutionTFSResult_Constructor.md
- title: fsreqNestSolutionTFSResult.Drop Property
  kind: Property
  slug: drop-property-79632
  path: fsreqNestSolutionTFSResult.Drop_Property.md
- title: fsreqNestSolutionTFSResult.IncludeAllResultParts Property
  kind: Property
  slug: include-all-result-parts-property-79633
  path: fsreqNestSolutionTFSResult.IncludeAllResultParts_Property.md
- title: fsreqNestSolutionTFSResult.NestSolutionResultID Property
  kind: Property
  slug: nest-solution-result-id-property-79634
  path: fsreqNestSolutionTFSResult.NestSolutionResultID_Property.md
- title: fsreqNestSolutionTFSResult.NestSolutionResultPartID Property
  kind: Property
  slug: nest-solution-result-part-id-property-79635
  path: fsreqNestSolutionTFSResult.NestSolutionResultPartID_Property.md
- title: fsreqNestSolutionTFSResult.NestSolutionResultPartQuantity Property
  kind: Property
  slug: nest-solution-result-part-quantity-property-79636
  path: fsreqNestSolutionTFSResult.NestSolutionResultPartQuantity_Property.md
- title: fsreqNestSolutionTFSResult.ResultLocation Property
  kind: Property
  slug: result-location-property-79637
  path: fsreqNestSolutionTFSResult.ResultLocation_Property.md
- title: fsreqNestSolutionTFSResult.ResultSecondaryLocation Property
  kind: Property
  slug: result-secondary-location-property-79638
  path: fsreqNestSolutionTFSResult.ResultSecondaryLocation_Property.md
---

# fsreqNestSolutionTFSResult Class

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqNestSolutionTFSResult

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqNestSolutionTFSResult
```

The fsreqNestSolutionTFSResult type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqNestSolutionTFSResult](fsreqNestSolutionTFSResult_Constructor.md) | fsreqNestSolutionTFSResult class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Drop](fsreqNestSolutionTFSResult.Drop_Property.md) | The drop that is remaining after the cuts are complete. |
| Public property | [IncludeAllResultParts](fsreqNestSolutionTFSResult.IncludeAllResultParts_Property.md) | If true, then all of the result parts are to be cut. If false, then NestSolutionResultPartID and NestSolutionResultPartQuantity must be populated with the specific result parts and quantities to cut. |
| Public property | [NestSolutionResultID](fsreqNestSolutionTFSResult.NestSolutionResultID_Property.md) | If true, then all of the result parts are to be cut. If false, then NestSolutionResultPartID and NestSolutionResultPartQuantity must be populated with the specific result parts and quantities to cut. |
| Public property | [NestSolutionResultPartID](fsreqNestSolutionTFSResult.NestSolutionResultPartID_Property.md) | If IncludeAllResultParts is false, the result part records that are to be cut. |
| Public property | [NestSolutionResultPartQuantity](fsreqNestSolutionTFSResult.NestSolutionResultPartQuantity_Property.md) | If IncludeAllResultParts is false, the quantities of the result part records that are to be cut. Must have the same number of elements as NestSolutionResultPartID. |
| Public property | [ResultLocation](fsreqNestSolutionTFSResult.ResultLocation_Property.md) | The location for the nest solution result. |
| Public property | [ResultSecondaryLocation](fsreqNestSolutionTFSResult.ResultSecondaryLocation_Property.md) | The secondary location for the nest solution result. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
