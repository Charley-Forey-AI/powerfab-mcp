---
title: fsreqNestSolutionGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-nest-solution-get-class-79606
slug: fsreq-nest-solution-get-class-79606
node_id: 79606
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqNestSolutionGet Class
children:
- title: fsreqNestSolutionGet Constructor
  kind: Constructor
  slug: fsreq-nest-solution-get-constructor-79607
  path: fsreqNestSolutionGet_Constructor.md
- title: fsreqNestSolutionGet.GetOptions Property
  kind: Property
  slug: get-options-property-79609
  path: fsreqNestSolutionGet.GetOptions_Property.md
- title: fsreqNestSolutionGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-79610
  path: fsreqNestSolutionGet.LastLogID_Property.md
- title: fsreqNestSolutionGet.NestSolutionID Property
  kind: Property
  slug: nest-solution-id-property-79611
  path: fsreqNestSolutionGet.NestSolutionID_Property.md
---

# fsreqNestSolutionGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqNestSolutionGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqNestSolutionGet : fsreqCommand
```

The fsreqNestSolutionGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqNestSolutionGet](fsreqNestSolutionGet_Constructor.md) | fsreqNestSolutionGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqNestSolutionGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqNestSolutionGet.LastLogID_Property.md) |  |
| Public property | [NestSolutionID](fsreqNestSolutionGet.NestSolutionID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
