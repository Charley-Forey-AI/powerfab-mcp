---
title: fsreqInputDisplayUnits Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-input-display-units-class-79322
slug: fsreq-input-display-units-class-79322
node_id: 79322
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInputDisplayUnits Class
children:
- title: fsreqInputDisplayUnits Constructor
  kind: Constructor
  slug: fsreq-input-display-units-constructor-79323
  path: fsreqInputDisplayUnits_Constructor.md
- title: fsreqInputDisplayUnits.LengthTypeIDImperial Property
  kind: Property
  slug: length-type-id-imperial-property-79325
  path: fsreqInputDisplayUnits.LengthTypeIDImperial_Property.md
- title: fsreqInputDisplayUnits.LengthTypeIDMetric Property
  kind: Property
  slug: length-type-id-metric-property-79326
  path: fsreqInputDisplayUnits.LengthTypeIDMetric_Property.md
- title: fsreqInputDisplayUnits.LengthUOM Property
  kind: Property
  slug: length-uom-property-79327
  path: fsreqInputDisplayUnits.LengthUOM_Property.md
- title: fsreqInputDisplayUnits.PriceUOM Property
  kind: Property
  slug: price-uom-property-79328
  path: fsreqInputDisplayUnits.PriceUOM_Property.md
- title: fsreqInputDisplayUnits.SizeUOM Property
  kind: Property
  slug: size-uom-property-79329
  path: fsreqInputDisplayUnits.SizeUOM_Property.md
- title: fsreqInputDisplayUnits.WeightUOM Property
  kind: Property
  slug: weight-uom-property-79330
  path: fsreqInputDisplayUnits.WeightUOM_Property.md
---

# fsreqInputDisplayUnits Class

Specify the unit-of-measure values to use for input and display purposes.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqInputDisplayUnits

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInputDisplayUnits
```

The fsreqInputDisplayUnits type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInputDisplayUnits](fsreqInputDisplayUnits_Constructor.md) | Initializes a new instance of the fsreqInputDisplayUnits class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [LengthTypeIDImperial](fsreqInputDisplayUnits.LengthTypeIDImperial_Property.md) | Length format when in imperial mode: 1 - Feet, Inches, 16ths 2 - Feet, Inches 3 - Inches, 16ths 4 - Decimal Feet 5 - Decimal Inches (2 Places) 6 - Decimal Inches 7 - Feet, Inches, 16ths (Free-Form) |
| Public property | [LengthTypeIDMetric](fsreqInputDisplayUnits.LengthTypeIDMetric_Property.md) | Length format when in metric mode: 1 - Meters 2 - Centimeters 3 - Millimeters |
| Public property | [LengthUOM](fsreqInputDisplayUnits.LengthUOM_Property.md) | Length display and input. |
| Public property | [PriceUOM](fsreqInputDisplayUnits.PriceUOM_Property.md) | Unit Price display and input. |
| Public property | [SizeUOM](fsreqInputDisplayUnits.SizeUOM_Property.md) | Dimension display and input. |
| Public property | [WeightUOM](fsreqInputDisplayUnits.WeightUOM_Property.md) | Weight display and input. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
