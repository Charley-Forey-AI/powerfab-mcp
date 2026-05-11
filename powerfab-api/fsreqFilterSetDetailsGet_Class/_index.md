---
title: fsreqFilterSetDetailsGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-filter-set-details-get-class-78748
slug: fsreq-filter-set-details-get-class-78748
node_id: 78748
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFilterSetDetailsGet Class
children:
- title: fsreqFilterSetDetailsGet Constructor
  kind: Constructor
  slug: fsreq-filter-set-details-get-constructor-78749
  path: fsreqFilterSetDetailsGet_Constructor.md
- title: fsreqFilterSetDetailsGet.SubType Property
  kind: Property
  slug: sub-type-property-78751
  path: fsreqFilterSetDetailsGet.SubType_Property.md
- title: fsreqFilterSetDetailsGet.Type Property
  kind: Property
  slug: type-property-78752
  path: fsreqFilterSetDetailsGet.Type_Property.md
---

# fsreqFilterSetDetailsGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFilterSetDetailsGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFilterSetDetailsGet : fsreqCommand
```

The fsreqFilterSetDetailsGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFilterSetDetailsGet](fsreqFilterSetDetailsGet_Constructor.md) | Initializes a new instance of the fsreqFilterSetDetailsGet class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [SubType](fsreqFilterSetDetailsGet.SubType_Property.md) |  |
| Public property | [Type](fsreqFilterSetDetailsGet.Type_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
