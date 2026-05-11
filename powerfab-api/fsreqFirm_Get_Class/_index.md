---
title: fsreqFirm_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firmget-class-78786
slug: fsreq-firmget-class-78786
node_id: 78786
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirm_Get Class
children:
- title: fsreqFirm_Get Constructor
  kind: Constructor
  slug: fsreq-firmget-constructor-78787
  path: fsreqFirm_Get_Constructor.md
- title: fsreqFirm_Get.FirmID Property
  kind: Property
  slug: firm-id-property-78789
  path: fsreqFirm_Get.FirmID_Property.md
- title: fsreqFirm_Get.FirmTypeID Property
  kind: Property
  slug: firm-type-id-property-78790
  path: fsreqFirm_Get.FirmTypeID_Property.md
- title: fsreqFirm_Get.GetOptions Property
  kind: Property
  slug: get-options-property-78791
  path: fsreqFirm_Get.GetOptions_Property.md
- title: fsreqFirm_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-78792
  path: fsreqFirm_Get.LastLogID_Property.md
---

# fsreqFirm_Get Class

Retrieves one or more firms.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirm\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirm_Get : fsreqCommand
```

The fsreqFirm\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirm\_Get](fsreqFirm_Get_Constructor.md) | fsreqFirm\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FirmID](fsreqFirm_Get.FirmID_Property.md) | FirmID to retrieve |
| Public property | [FirmTypeID](fsreqFirm_Get.FirmTypeID_Property.md) | FirmTypeID to retrieve all firms of specified types |
| Public property | [GetOptions](fsreqFirm_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqFirm_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
