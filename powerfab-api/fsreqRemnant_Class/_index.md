---
title: fsreqRemnant Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-remnant-class-80284
slug: fsreq-remnant-class-80284
node_id: 80284
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqRemnant Class
children:
- title: fsreqRemnant Constructor
  kind: Constructor
  slug: fsreq-remnant-constructor-80285
  path: fsreqRemnant_Constructor.md
- title: fsreqRemnant.Area Property
  kind: Property
  slug: area-property-80287
  path: fsreqRemnant.Area_Property.md
- title: fsreqRemnant.Dimensions Property
  kind: Property
  slug: dimensions-property-80288
  path: fsreqRemnant.Dimensions_Property.md
- title: fsreqRemnant.Grade Property
  kind: Property
  slug: grade-property-80289
  path: fsreqRemnant.Grade_Property.md
- title: fsreqRemnant.Length Property
  kind: Property
  slug: length-property-80290
  path: fsreqRemnant.Length_Property.md
- title: fsreqRemnant.Quantity Property
  kind: Property
  slug: quantity-property-80291
  path: fsreqRemnant.Quantity_Property.md
- title: fsreqRemnant.RemnantDefinition Property
  kind: Property
  slug: remnant-definition-property-80292
  path: fsreqRemnant.RemnantDefinition_Property.md
- title: fsreqRemnant.RemnantDefinitionFilename Property
  kind: Property
  slug: remnant-definition-filename-property-80293
  path: fsreqRemnant.RemnantDefinitionFilename_Property.md
- title: fsreqRemnant.RemnantID Property
  kind: Property
  slug: remnant-id-property-80294
  path: fsreqRemnant.RemnantID_Property.md
- title: fsreqRemnant.RemnantImageBase64 Property
  kind: Property
  slug: remnant-image-base64-property-80295
  path: fsreqRemnant.RemnantImageBase64_Property.md
- title: fsreqRemnant.RemnantImageFilename Property
  kind: Property
  slug: remnant-image-filename-property-80296
  path: fsreqRemnant.RemnantImageFilename_Property.md
- title: fsreqRemnant.RemnantName Property
  kind: Property
  slug: remnant-name-property-80297
  path: fsreqRemnant.RemnantName_Property.md
- title: fsreqRemnant.Shape Property
  kind: Property
  slug: shape-property-80298
  path: fsreqRemnant.Shape_Property.md
- title: fsreqRemnant.ShapeDimensions Property
  kind: Property
  slug: shape-dimensions-property-80299
  path: fsreqRemnant.ShapeDimensions_Property.md
- title: fsreqRemnant.Type Property
  kind: Property
  slug: type-property-80300
  path: fsreqRemnant.Type_Property.md
- title: fsreqRemnant.Weight Property
  kind: Property
  slug: weight-property-80301
  path: fsreqRemnant.Weight_Property.md
- title: fsreqRemnant.Width Property
  kind: Property
  slug: width-property-80302
  path: fsreqRemnant.Width_Property.md
---

# fsreqRemnant Class

A remnant created by this nest in the SaveNest command.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqRemnant

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqRemnant
```

The fsreqRemnant type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqRemnant](fsreqRemnant_Constructor.md) | fsreqRemnant class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Area](fsreqRemnant.Area_Property.md) | The area of the remnant if it's a plate. |
| Public property | [Dimensions](fsreqRemnant.Dimensions_Property.md) | Dimensions of remnant. |
| Public property | [Grade](fsreqRemnant.Grade_Property.md) | Grade of material. |
| Public property | [Length](fsreqRemnant.Length_Property.md) | The length of the material. |
| Public property | [Quantity](fsreqRemnant.Quantity_Property.md) | Quantity of remnant. |
| Public property | [RemnantDefinition](fsreqRemnant.RemnantDefinition_Property.md) | Text of remnant image. |
| Public property | [RemnantDefinitionFilename](fsreqRemnant.RemnantDefinitionFilename_Property.md) | Filename to store remnant definition as. |
| Public property | [RemnantID](fsreqRemnant.RemnantID_Property.md) | FabSuite RemnantID assigned to this remnant. |
| Public property | [RemnantImageBase64](fsreqRemnant.RemnantImageBase64_Property.md) | Base64 text of remnant image. |
| Public property | [RemnantImageFilename](fsreqRemnant.RemnantImageFilename_Property.md) | Filename to store remnant images as |
| Public property | [RemnantName](fsreqRemnant.RemnantName_Property.md) | Name assigned to this remnant. |
| Public property | [Shape](fsreqRemnant.Shape_Property.md) | Shape of Remnant - should match Shape of MaterialUsed. ShapeDimensions OR Shape and Dimensions is required. |
| Public property | [ShapeDimensions](fsreqRemnant.ShapeDimensions_Property.md) | Name of Material. ShapeDimensions OR Shape and Dimensions is required. |
| Public property | [Type](fsreqRemnant.Type_Property.md) | The type of remnant created. |
| Public property | [Weight](fsreqRemnant.Weight_Property.md) | The weight of the remnant. |
| Public property | [Width](fsreqRemnant.Width_Property.md) | The width of the material when it's a plate. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
