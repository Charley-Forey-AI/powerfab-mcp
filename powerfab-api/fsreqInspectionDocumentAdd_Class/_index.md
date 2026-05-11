---
title: fsreqInspectionDocumentAdd Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inspection-document-add-class-79335
slug: fsreq-inspection-document-add-class-79335
node_id: 79335
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInspectionDocumentAdd Class
children:
- title: fsreqInspectionDocumentAdd Constructor
  kind: Constructor
  slug: fsreq-inspection-document-add-constructor-79336
  path: fsreqInspectionDocumentAdd_Constructor.md
- title: fsreqInspectionDocumentAdd.DocumentText Property
  kind: Property
  slug: document-text-property-79338
  path: fsreqInspectionDocumentAdd.DocumentText_Property.md
- title: fsreqInspectionDocumentAdd.FileDataBase64 Property
  kind: Property
  slug: file-data-base64-property-79339
  path: fsreqInspectionDocumentAdd.FileDataBase64_Property.md
- title: fsreqInspectionDocumentAdd.Filename Property
  kind: Property
  slug: filename-property-79340
  path: fsreqInspectionDocumentAdd.Filename_Property.md
- title: fsreqInspectionDocumentAdd.InspectionTestRecordID Property
  kind: Property
  slug: inspection-test-record-id-property-79341
  path: fsreqInspectionDocumentAdd.InspectionTestRecordID_Property.md
---

# fsreqInspectionDocumentAdd Class

Adds a document to the document index and associates it with the given inspection record.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInspectionDocumentAdd

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInspectionDocumentAdd : fsreqCommand
```

The fsreqInspectionDocumentAdd type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInspectionDocumentAdd](fsreqInspectionDocumentAdd_Constructor.md) | Initializes a new instance of the fsreqInspectionDocumentAdd class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DocumentText](fsreqInspectionDocumentAdd.DocumentText_Property.md) | Text notation to include with the document. |
| Public property | [FileDataBase64](fsreqInspectionDocumentAdd.FileDataBase64_Property.md) | The base64 representation of the file contents. |
| Public property | [Filename](fsreqInspectionDocumentAdd.Filename_Property.md) | The filename of the document. |
| Public property | [InspectionTestRecordID](fsreqInspectionDocumentAdd.InspectionTestRecordID_Property.md) | The inspection test record to add the document to. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
