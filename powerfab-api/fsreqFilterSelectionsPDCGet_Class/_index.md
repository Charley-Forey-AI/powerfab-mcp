---
title: fsreqFilterSelectionsPDCGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-selections-pdc-get-class-78733
slug: fsreq-filter-selections-pdc-get-class-78733
node_id: 78733
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilterSelectionsPDCGet Class
children:
- title: fsreqFilterSelectionsPDCGet Constructor
  kind: Constructor
  slug: fsreq-filter-selections-pdc-get-constructor-78734
  path: fsreqFilterSelectionsPDCGet_Constructor.md
- title: fsreqFilterSelectionsPDCGet.FilterName Property
  kind: Property
  slug: filter-name-property-78736
  path: fsreqFilterSelectionsPDCGet.FilterName_Property.md
- title: fsreqFilterSelectionsPDCGet.FilterSet Property
  kind: Property
  slug: filter-set-property-78737
  path: fsreqFilterSelectionsPDCGet.FilterSet_Property.md
- title: fsreqFilterSelectionsPDCGet.GetOptions Property
  kind: Property
  slug: get-options-property-78738
  path: fsreqFilterSelectionsPDCGet.GetOptions_Property.md
- title: fsreqFilterSelectionsPDCGet.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78739
  path: fsreqFilterSelectionsPDCGet.ProductionControlID_Property.md
- title: fsreqFilterSelectionsPDCGet.SubType Property
  kind: Property
  slug: sub-type-property-78740
  path: fsreqFilterSelectionsPDCGet.SubType_Property.md
---

# fsreqFilterSelectionsPDCGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFilterSelectionsPDCGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFilterSelectionsPDCGet : fsreqCommand
```

The fsreqFilterSelectionsPDCGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFilterSelectionsPDCGet](fsreqFilterSelectionsPDCGet_Constructor.md) | fsreqFilterSelectionsPDCGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterName](fsreqFilterSelectionsPDCGet.FilterName_Property.md) |  |
| Public property | [FilterSet](fsreqFilterSelectionsPDCGet.FilterSet_Property.md) |  |
| Public property | [GetOptions](fsreqFilterSelectionsPDCGet.GetOptions_Property.md) |  |
| Public property | [ProductionControlID](fsreqFilterSelectionsPDCGet.ProductionControlID_Property.md) |  |
| Public property | [SubType](fsreqFilterSelectionsPDCGet.SubType_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
