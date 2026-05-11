---
title: fsreqNestResult Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-nest-result-class-79593
slug: fsreq-nest-result-class-79593
node_id: 79593
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqNestResult Class
children:
- title: fsreqNestResult Constructor
  kind: Constructor
  slug: fsreq-nest-result-constructor-79594
  path: fsreqNestResult_Constructor.md
- title: fsreqNestResult.MaterialUsed Property
  kind: Property
  slug: material-used-property-79596
  path: fsreqNestResult.MaterialUsed_Property.md
- title: fsreqNestResult.NestedParts Property
  kind: Property
  slug: nested-parts-property-79597
  path: fsreqNestResult.NestedParts_Property.md
- title: fsreqNestResult.NestExtra1 Property
  kind: Property
  slug: nest-extra1-property-79598
  path: fsreqNestResult.NestExtra1_Property.md
- title: fsreqNestResult.NestExtra2 Property
  kind: Property
  slug: nest-extra2-property-79599
  path: fsreqNestResult.NestExtra2_Property.md
- title: fsreqNestResult.NestID Property
  kind: Property
  slug: nest-id-property-79600
  path: fsreqNestResult.NestID_Property.md
- title: fsreqNestResult.NestImageBase64 Property
  kind: Property
  slug: nest-image-base64-property-79601
  path: fsreqNestResult.NestImageBase64_Property.md
- title: fsreqNestResult.NestImageFilename Property
  kind: Property
  slug: nest-image-filename-property-79602
  path: fsreqNestResult.NestImageFilename_Property.md
- title: fsreqNestResult.OutputFilename Property
  kind: Property
  slug: output-filename-property-79603
  path: fsreqNestResult.OutputFilename_Property.md
- title: fsreqNestResult.Quantity Property
  kind: Property
  slug: quantity-property-79604
  path: fsreqNestResult.Quantity_Property.md
- title: fsreqNestResult.Remnant Property
  kind: Property
  slug: remnant-property-79605
  path: fsreqNestResult.Remnant_Property.md
---

# fsreqNestResult Class

A single nest to be saved by SaveNest command.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqNestResult

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqNestResult
```

The fsreqNestResult type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqNestResult](fsreqNestResult_Constructor.md) | fsreqNestResult class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [MaterialUsed](fsreqNestResult.MaterialUsed_Property.md) | Material Used Object |
| Public property | [NestedParts](fsreqNestResult.NestedParts_Property.md) | Nested Parts object |
| Public property | [NestExtra1](fsreqNestResult.NestExtra1_Property.md) | Extra field 1 for external extra data |
| Public property | [NestExtra2](fsreqNestResult.NestExtra2_Property.md) | Extra field 2 for external extra data |
| Public property | [NestID](fsreqNestResult.NestID_Property.md) | Unique Identifer of this Nest. If nest generates an error, it will be returned as NestGUID |
| Public property | [NestImageBase64](fsreqNestResult.NestImageBase64_Property.md) | Base64 text of nest image. |
| Public property | [NestImageFilename](fsreqNestResult.NestImageFilename_Property.md) | Filename to store nest images as |
| Public property | [OutputFilename](fsreqNestResult.OutputFilename_Property.md) | File path of NC file sent to machine |
| Public property | [Quantity](fsreqNestResult.Quantity_Property.md) | Number of times this nest is to be cut. |
| Public property | [Remnant](fsreqNestResult.Remnant_Property.md) | List of remnant objects |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
