---
title: fsreqGetTransmittalDetails Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-transmittal-details-class-79312
slug: fsreq-get-transmittal-details-class-79312
node_id: 79312
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetTransmittalDetails Class
children:
- title: fsreqGetTransmittalDetails Constructor
  kind: Constructor
  slug: fsreq-get-transmittal-details-constructor-79313
  path: fsreqGetTransmittalDetails_Constructor.md
- title: fsreqGetTransmittalDetails.FilterSet Property
  kind: Property
  slug: filter-set-property-79315
  path: fsreqGetTransmittalDetails.FilterSet_Property.md
- title: fsreqGetTransmittalDetails.IncludeAttachedFiles Property
  kind: Property
  slug: include-attached-files-property-79316
  path: fsreqGetTransmittalDetails.IncludeAttachedFiles_Property.md
- title: fsreqGetTransmittalDetails.IncludeDrawings Property
  kind: Property
  slug: include-drawings-property-79317
  path: fsreqGetTransmittalDetails.IncludeDrawings_Property.md
- title: fsreqGetTransmittalDetails.JobNumber Property
  kind: Property
  slug: job-number-property-79318
  path: fsreqGetTransmittalDetails.JobNumber_Property.md
- title: fsreqGetTransmittalDetails.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79319
  path: fsreqGetTransmittalDetails.ProductionControlID_Property.md
- title: fsreqGetTransmittalDetails.TransmittalID Property
  kind: Property
  slug: transmittal-id-property-79320
  path: fsreqGetTransmittalDetails.TransmittalID_Property.md
- title: fsreqGetTransmittalDetails.TransmittalNumber Property
  kind: Property
  slug: transmittal-number-property-79321
  path: fsreqGetTransmittalDetails.TransmittalNumber_Property.md
---

# fsreqGetTransmittalDetails Class

Retrieves the details of one or more transmittals.
If neither TransmittalID nor TransmittalNumber are specified, the transmittals received will be limited by the filters

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetTransmittalDetails

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetTransmittalDetails : fsreqCommand
```

The fsreqGetTransmittalDetails type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetTransmittalDetails](fsreqGetTransmittalDetails_Constructor.md) | fsreqGetTransmittalDetails class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterSet](fsreqGetTransmittalDetails.FilterSet_Property.md) |  |
| Public property | [IncludeAttachedFiles](fsreqGetTransmittalDetails.IncludeAttachedFiles_Property.md) | If specified and set to true, files attached to the transmittal will be included in response. |
| Public property | [IncludeDrawings](fsreqGetTransmittalDetails.IncludeDrawings_Property.md) | If specified and set to true, transmittal drawings will be included in response. |
| Public property | [JobNumber](fsreqGetTransmittalDetails.JobNumber_Property.md) | The JobNumber of the job to retrieve the transmittals from. |
| Public property | [ProductionControlID](fsreqGetTransmittalDetails.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the transmittals from. |
| Public property | [TransmittalID](fsreqGetTransmittalDetails.TransmittalID_Property.md) | The TransmittalID requested. |
| Public property | [TransmittalNumber](fsreqGetTransmittalDetails.TransmittalNumber_Property.md) | The Number of the transmittal requested. Specifying both is not necessary. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
