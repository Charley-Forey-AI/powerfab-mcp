---
title: fsreqGetNestImage Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-nest-image-class-79161
slug: fsreq-get-nest-image-class-79161
node_id: 79161
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetNestImage Class
children:
- title: fsreqGetNestImage Constructor
  kind: Constructor
  slug: fsreq-get-nest-image-constructor-79162
  path: fsreqGetNestImage_Constructor.md
- title: fsreqGetNestImage.ImageFormat Property
  kind: Property
  slug: image-format-property-79164
  path: fsreqGetNestImage.ImageFormat_Property.md
- title: fsreqGetNestImage.MaximumHeight Property
  kind: Property
  slug: maximum-height-property-79165
  path: fsreqGetNestImage.MaximumHeight_Property.md
- title: fsreqGetNestImage.MaximumWidth Property
  kind: Property
  slug: maximum-width-property-79166
  path: fsreqGetNestImage.MaximumWidth_Property.md
- title: fsreqGetNestImage.MinimumHeight Property
  kind: Property
  slug: minimum-height-property-79167
  path: fsreqGetNestImage.MinimumHeight_Property.md
- title: fsreqGetNestImage.MinimumWidth Property
  kind: Property
  slug: minimum-width-property-79168
  path: fsreqGetNestImage.MinimumWidth_Property.md
- title: fsreqGetNestImage.ProductionControlCutListBarcodeID Property
  kind: Property
  slug: production-control-cut-list-barcode-id-property-79169
  path: fsreqGetNestImage.ProductionControlCutListBarcodeID_Property.md
- title: fsreqGetNestImage.ProductionControlCutListItemID Property
  kind: Property
  slug: production-control-cut-list-item-id-property-79170
  path: fsreqGetNestImage.ProductionControlCutListItemID_Property.md
---

# fsreqGetNestImage Class

Retrieves the image for the given nest.
Either ProductionControlCutListItemID or ProductionControlCutListBarcodeID must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetNestImage

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetNestImage : fsreqCommand
```

The fsreqGetNestImage type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetNestImage](fsreqGetNestImage_Constructor.md) | Initializes a new instance of the fsreqGetNestImage class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ImageFormat](fsreqGetNestImage.ImageFormat_Property.md) | The format in which to retrieve the image. If not specified then the image will be either JPG (for generated images) or the original format (for external nest images). |
| Public property | [MaximumHeight](fsreqGetNestImage.MaximumHeight_Property.md) | The maximum height of the image, if necessary the image will be scaled down to match. |
| Public property | [MaximumWidth](fsreqGetNestImage.MaximumWidth_Property.md) | The maximum width of the image, if necessary the image will be scaled down to match. |
| Public property | [MinimumHeight](fsreqGetNestImage.MinimumHeight_Property.md) | The minimum height of the image, if necessary the image will be scaled up to match. |
| Public property | [MinimumWidth](fsreqGetNestImage.MinimumWidth_Property.md) | The minimum width of the image, if necessary the image will be scaled up to match. |
| Public property | [ProductionControlCutListBarcodeID](fsreqGetNestImage.ProductionControlCutListBarcodeID_Property.md) | The cut list serial # from which to retrieve the nest image. |
| Public property | [ProductionControlCutListItemID](fsreqGetNestImage.ProductionControlCutListItemID_Property.md) | The cut list item from which to retrieve the nest image. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
