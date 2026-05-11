---
title: fsreqFilterSelectionsPRJGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-selections-prj-get-class-78741
slug: fsreq-filter-selections-prj-get-class-78741
node_id: 78741
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilterSelectionsPRJGet Class
children:
- title: fsreqFilterSelectionsPRJGet Constructor
  kind: Constructor
  slug: fsreq-filter-selections-prj-get-constructor-78742
  path: fsreqFilterSelectionsPRJGet_Constructor.md
- title: fsreqFilterSelectionsPRJGet.FilterName Property
  kind: Property
  slug: filter-name-property-78744
  path: fsreqFilterSelectionsPRJGet.FilterName_Property.md
- title: fsreqFilterSelectionsPRJGet.FilterSet Property
  kind: Property
  slug: filter-set-property-78745
  path: fsreqFilterSelectionsPRJGet.FilterSet_Property.md
- title: fsreqFilterSelectionsPRJGet.GetOptions Property
  kind: Property
  slug: get-options-property-78746
  path: fsreqFilterSelectionsPRJGet.GetOptions_Property.md
- title: fsreqFilterSelectionsPRJGet.ProjectID Property
  kind: Property
  slug: project-id-property-78747
  path: fsreqFilterSelectionsPRJGet.ProjectID_Property.md
---

# fsreqFilterSelectionsPRJGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFilterSelectionsPRJGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFilterSelectionsPRJGet : fsreqCommand
```

The fsreqFilterSelectionsPRJGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFilterSelectionsPRJGet](fsreqFilterSelectionsPRJGet_Constructor.md) | fsreqFilterSelectionsPRJGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterName](fsreqFilterSelectionsPRJGet.FilterName_Property.md) |  |
| Public property | [FilterSet](fsreqFilterSelectionsPRJGet.FilterSet_Property.md) |  |
| Public property | [GetOptions](fsreqFilterSelectionsPRJGet.GetOptions_Property.md) |  |
| Public property | [ProjectID](fsreqFilterSelectionsPRJGet.ProjectID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
