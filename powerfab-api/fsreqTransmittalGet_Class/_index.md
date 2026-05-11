---
title: fsreqTransmittalGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-transmittal-get-class-80586
slug: fsreq-transmittal-get-class-80586
node_id: 80586
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqTransmittalGet Class
children:
- title: fsreqTransmittalGet Constructor
  kind: Constructor
  slug: fsreq-transmittal-get-constructor-80587
  path: fsreqTransmittalGet_Constructor.md
- title: fsreqTransmittalGet.GetOptions Property
  kind: Property
  slug: get-options-property-80589
  path: fsreqTransmittalGet.GetOptions_Property.md
- title: fsreqTransmittalGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-80590
  path: fsreqTransmittalGet.LastLogID_Property.md
- title: fsreqTransmittalGet.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80591
  path: fsreqTransmittalGet.ProductionControlID_Property.md
- title: fsreqTransmittalGet.ProjectID Property
  kind: Property
  slug: project-id-property-80592
  path: fsreqTransmittalGet.ProjectID_Property.md
- title: fsreqTransmittalGet.TransmittalID Property
  kind: Property
  slug: transmittal-id-property-80593
  path: fsreqTransmittalGet.TransmittalID_Property.md
---

# fsreqTransmittalGet Class

ProjectID, ProductionControlID, or TransmittalID must be specified.
If LastLogID is specified then the result will only include the records that have changed since that log position.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqTransmittalGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqTransmittalGet : fsreqCommand
```

The fsreqTransmittalGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqTransmittalGet](fsreqTransmittalGet_Constructor.md) | fsreqTransmittalGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqTransmittalGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqTransmittalGet.LastLogID_Property.md) |  |
| Public property | [ProductionControlID](fsreqTransmittalGet.ProductionControlID_Property.md) |  |
| Public property | [ProjectID](fsreqTransmittalGet.ProjectID_Property.md) |  |
| Public property | [TransmittalID](fsreqTransmittalGet.TransmittalID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
