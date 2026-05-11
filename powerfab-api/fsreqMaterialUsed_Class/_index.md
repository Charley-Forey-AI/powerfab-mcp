---
title: fsreqMaterialUsed Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-material-used-class-79558
slug: fsreq-material-used-class-79558
node_id: 79558
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqMaterialUsed Class
children:
- title: fsreqMaterialUsed Constructor
  kind: Constructor
  slug: fsreq-material-used-constructor-79559
  path: fsreqMaterialUsed_Constructor.md
- title: fsreqMaterialUsed.Dimensions Property
  kind: Property
  slug: dimensions-property-79561
  path: fsreqMaterialUsed.Dimensions_Property.md
- title: fsreqMaterialUsed.ExternalInventoryID Property
  kind: Property
  slug: external-inventory-id-property-79562
  path: fsreqMaterialUsed.ExternalInventoryID_Property.md
- title: fsreqMaterialUsed.ExternalInventoryLinkID Property
  kind: Property
  slug: external-inventory-link-id-property-79563
  path: fsreqMaterialUsed.ExternalInventoryLinkID_Property.md
- title: fsreqMaterialUsed.FabSuiteInventoryID Property
  kind: Property
  slug: fab-suite-inventory-id-property-79564
  path: fsreqMaterialUsed.FabSuiteInventoryID_Property.md
- title: fsreqMaterialUsed.ForceExternalInventoryLinkID Property
  kind: Property
  slug: force-external-inventory-link-id-property-79565
  path: fsreqMaterialUsed.ForceExternalInventoryLinkID_Property.md
- title: fsreqMaterialUsed.Grade Property
  kind: Property
  slug: grade-property-79566
  path: fsreqMaterialUsed.Grade_Property.md
- title: fsreqMaterialUsed.Length Property
  kind: Property
  slug: length-property-79567
  path: fsreqMaterialUsed.Length_Property.md
- title: fsreqMaterialUsed.Location Property
  kind: Property
  slug: location-property-79568
  path: fsreqMaterialUsed.Location_Property.md
- title: fsreqMaterialUsed.ParentRemnantID Property
  kind: Property
  slug: parent-remnant-id-property-79569
  path: fsreqMaterialUsed.ParentRemnantID_Property.md
- title: fsreqMaterialUsed.ParentRemnantName Property
  kind: Property
  slug: parent-remnant-name-property-79570
  path: fsreqMaterialUsed.ParentRemnantName_Property.md
- title: fsreqMaterialUsed.ParentRemnantPowerFabID Property
  kind: Property
  slug: parent-remnant-power-fab-id-property-79571
  path: fsreqMaterialUsed.ParentRemnantPowerFabID_Property.md
- title: fsreqMaterialUsed.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-79572
  path: fsreqMaterialUsed.SecondaryLocation_Property.md
- title: fsreqMaterialUsed.Shape Property
  kind: Property
  slug: shape-property-79573
  path: fsreqMaterialUsed.Shape_Property.md
- title: fsreqMaterialUsed.ShapeDimensions Property
  kind: Property
  slug: shape-dimensions-property-79574
  path: fsreqMaterialUsed.ShapeDimensions_Property.md
- title: fsreqMaterialUsed.Width Property
  kind: Property
  slug: width-property-79575
  path: fsreqMaterialUsed.Width_Property.md
---

# fsreqMaterialUsed Class

A piece of material to be reserved in inventory or ordered for this nest.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqMaterialUsed

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqMaterialUsed
```

The fsreqMaterialUsed type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqMaterialUsed](fsreqMaterialUsed_Constructor.md) | fsreqMaterialUsed class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Dimensions](fsreqMaterialUsed.Dimensions_Property.md) | Dimensions of material. When combined with shape, it denotes the ShapeDimensions. |
| Public property | [ExternalInventoryID](fsreqMaterialUsed.ExternalInventoryID_Property.md) | Inventory ID of this material in external software. |
| Public property | [ExternalInventoryLinkID](fsreqMaterialUsed.ExternalInventoryLinkID_Property.md) | External link ID of this item in PowerFab. Either this or FabSuiteInventoryID may be used. |
| Public property | [FabSuiteInventoryID](fsreqMaterialUsed.FabSuiteInventoryID_Property.md) | External link ID of this item in PowerFab. |
| Public property | [ForceExternalInventoryLinkID](fsreqMaterialUsed.ForceExternalInventoryLinkID_Property.md) | If set to true and a matching Inventory Item for ExternalInventoryLinkID cannot be used, then the nest will fail. |
| Public property | [Grade](fsreqMaterialUsed.Grade_Property.md) | Grade of material. |
| Public property | [Length](fsreqMaterialUsed.Length_Property.md) | The length of the material. |
| Public property | [Location](fsreqMaterialUsed.Location_Property.md) | Location of material. |
| Public property | [ParentRemnantID](fsreqMaterialUsed.ParentRemnantID_Property.md) | Same as Parent Remnant Name, but called "ID" because we return it as "RemnantID" from SaveNest. |
| Public property | [ParentRemnantName](fsreqMaterialUsed.ParentRemnantName_Property.md) | Remnant Name of parent remnant in PowerFab |
| Public property | [ParentRemnantPowerFabID](fsreqMaterialUsed.ParentRemnantPowerFabID_Property.md) | RemnantID of parent remnant in PowerFab |
| Public property | [SecondaryLocation](fsreqMaterialUsed.SecondaryLocation_Property.md) | Secondary Location of material. |
| Public property | [Shape](fsreqMaterialUsed.Shape_Property.md) | Shape of Material. ShapeDimensions OR Shape and Dimensions is required. |
| Public property | [ShapeDimensions](fsreqMaterialUsed.ShapeDimensions_Property.md) | Name of Material. ShapeDimensions OR Shape and Dimensions is required. |
| Public property | [Width](fsreqMaterialUsed.Width_Property.md) | The width of the material used (for plate). |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
