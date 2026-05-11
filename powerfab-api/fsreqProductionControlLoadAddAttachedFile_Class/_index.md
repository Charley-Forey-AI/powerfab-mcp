---
title: fsreqProductionControlLoadAddAttachedFile Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-add-attached-file-class-79783
slug: fsreq-production-control-load-add-attached-file-class-79783
node_id: 79783
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadAddAttachedFile Class
children:
- title: fsreqProductionControlLoadAddAttachedFile Constructor
  kind: Constructor
  slug: fsreq-production-control-load-add-attached-file-constructor-79784
  path: fsreqProductionControlLoadAddAttachedFile_Constructor.md
- title: fsreqProductionControlLoadAddAttachedFile.DocumentText Property
  kind: Property
  slug: document-text-property-79786
  path: fsreqProductionControlLoadAddAttachedFile.DocumentText_Property.md
- title: fsreqProductionControlLoadAddAttachedFile.FileDataBase64 Property
  kind: Property
  slug: file-data-base64-property-79787
  path: fsreqProductionControlLoadAddAttachedFile.FileDataBase64_Property.md
- title: fsreqProductionControlLoadAddAttachedFile.Filename Property
  kind: Property
  slug: filename-property-79788
  path: fsreqProductionControlLoadAddAttachedFile.Filename_Property.md
- title: fsreqProductionControlLoadAddAttachedFile.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79789
  path: fsreqProductionControlLoadAddAttachedFile.ProductionControlLoadID_Property.md
---

# fsreqProductionControlLoadAddAttachedFile Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadAddAttachedFile

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadAddAttachedFile : fsreqCommand
```

The fsreqProductionControlLoadAddAttachedFile type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadAddAttachedFile](fsreqProductionControlLoadAddAttachedFile_Constructor.md) | Initializes a new instance of the fsreqProductionControlLoadAddAttachedFile class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DocumentText](fsreqProductionControlLoadAddAttachedFile.DocumentText_Property.md) |  |
| Public property | [FileDataBase64](fsreqProductionControlLoadAddAttachedFile.FileDataBase64_Property.md) |  |
| Public property | [Filename](fsreqProductionControlLoadAddAttachedFile.Filename_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadAddAttachedFile.ProductionControlLoadID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
