---
title: fsreqPickListGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-pick-list-get-class-79648
slug: fsreq-pick-list-get-class-79648
node_id: 79648
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqPickListGet Class
children:
- title: fsreqPickListGet Constructor
  kind: Constructor
  slug: fsreq-pick-list-get-constructor-79649
  path: fsreqPickListGet_Constructor.md
- title: fsreqPickListGet.CutListID Property
  kind: Property
  slug: cut-list-id-property-79651
  path: fsreqPickListGet.CutListID_Property.md
- title: fsreqPickListGet.GetOptions Property
  kind: Property
  slug: get-options-property-79652
  path: fsreqPickListGet.GetOptions_Property.md
---

# fsreqPickListGet Class

Retrieve the required stock for a cut list

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqPickListGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqPickListGet : fsreqCommand
```

The fsreqPickListGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqPickListGet](fsreqPickListGet_Constructor.md) | fsreqPickListGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CutListID](fsreqPickListGet.CutListID_Property.md) | ID of cut list to retrieve stock for |
| Public property | [GetOptions](fsreqPickListGet.GetOptions_Property.md) | Options for what to retrieve |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
