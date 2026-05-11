---
title: fsreqAdditionalDrop Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-additional-drop-class-77631
slug: fsreq-additional-drop-class-77631
node_id: 77631
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqAdditionalDrop Class
children:
- title: fsreqAdditionalDrop Constructor
  kind: Constructor
  slug: fsreq-additional-drop-constructor-77632
  path: fsreqAdditionalDrop_Constructor.md
- title: fsreqAdditionalDrop.DropJobReserve Property
  kind: Property
  slug: drop-job-reserve-property-77634
  path: fsreqAdditionalDrop.DropJobReserve_Property.md
- title: fsreqAdditionalDrop.DropLength Property
  kind: Property
  slug: drop-length-property-77635
  path: fsreqAdditionalDrop.DropLength_Property.md
- title: fsreqAdditionalDrop.DropLocation Property
  kind: Property
  slug: drop-location-property-77636
  path: fsreqAdditionalDrop.DropLocation_Property.md
- title: fsreqAdditionalDrop.DropSecondaryLocation Property
  kind: Property
  slug: drop-secondary-location-property-77637
  path: fsreqAdditionalDrop.DropSecondaryLocation_Property.md
- title: fsreqAdditionalDrop.DropSerialNumber Property
  kind: Property
  slug: drop-serial-number-property-77638
  path: fsreqAdditionalDrop.DropSerialNumber_Property.md
- title: fsreqAdditionalDrop.DropWidth Property
  kind: Property
  slug: drop-width-property-77639
  path: fsreqAdditionalDrop.DropWidth_Property.md
---

# fsreqAdditionalDrop Class

The TFSCut command has elements for a single piece of drop from the cut.
This element represents additional drops from the same cut.

Inheritance Hierarchy

System.Object  
  FabSuiteRequestApi.fsreqAdditionalDrop

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqAdditionalDrop
```

The fsreqAdditionalDrop type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqAdditionalDrop](fsreqAdditionalDrop_Constructor.md) | fsreqAdditionalDrop class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [DropJobReserve](fsreqAdditionalDrop.DropJobReserve_Property.md) | Job # that the drop should be reserved for. |
| Public property | [DropLength](fsreqAdditionalDrop.DropLength_Property.md) | Length of additional drop from TFS Cut |
| Public property | [DropLocation](fsreqAdditionalDrop.DropLocation_Property.md) | Location of additional drop from TFS Cut |
| Public property | [DropSecondaryLocation](fsreqAdditionalDrop.DropSecondaryLocation_Property.md) | Secondary Location of additional drop from TFS Cut |
| Public property | [DropSerialNumber](fsreqAdditionalDrop.DropSerialNumber_Property.md) | The stock serial # to use for the drop. |
| Public property | [DropWidth](fsreqAdditionalDrop.DropWidth_Property.md) | Width of additional drop from TFS Cut |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
