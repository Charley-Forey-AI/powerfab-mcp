---
title: fsreqGetRFIDetails Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-rfi-details-class-79261
slug: fsreq-get-rfi-details-class-79261
node_id: 79261
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetRFIDetails Class
children:
- title: fsreqGetRFIDetails Constructor
  kind: Constructor
  slug: fsreq-get-rfi-details-constructor-79262
  path: fsreqGetRFIDetails_Constructor.md
- title: fsreqGetRFIDetails.FilterSet Property
  kind: Property
  slug: filter-set-property-79264
  path: fsreqGetRFIDetails.FilterSet_Property.md
- title: fsreqGetRFIDetails.IncludeAttachedFiles Property
  kind: Property
  slug: include-attached-files-property-79265
  path: fsreqGetRFIDetails.IncludeAttachedFiles_Property.md
- title: fsreqGetRFIDetails.JobNumber Property
  kind: Property
  slug: job-number-property-79266
  path: fsreqGetRFIDetails.JobNumber_Property.md
- title: fsreqGetRFIDetails.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79267
  path: fsreqGetRFIDetails.ProductionControlID_Property.md
- title: fsreqGetRFIDetails.RequestForInformationID Property
  kind: Property
  slug: request-information-id-property-79268
  path: fsreqGetRFIDetails.RequestForInformationID_Property.md
- title: fsreqGetRFIDetails.RFINumber Property
  kind: Property
  slug: rfi-number-property-79269
  path: fsreqGetRFIDetails.RFINumber_Property.md
---

# fsreqGetRFIDetails Class

Retrieves the details of one or more requests for information.
If neither RequestForInformationID nor RFINumber are specified, the RFIs received will be limited by the filters

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetRFIDetails

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetRFIDetails : fsreqCommand
```

The fsreqGetRFIDetails type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetRFIDetails](fsreqGetRFIDetails_Constructor.md) | fsreqGetRFIDetails class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterSet](fsreqGetRFIDetails.FilterSet_Property.md) |  |
| Public property | [IncludeAttachedFiles](fsreqGetRFIDetails.IncludeAttachedFiles_Property.md) |  |
| Public property | [JobNumber](fsreqGetRFIDetails.JobNumber_Property.md) | The JobNumber of the job to retrieve the RFIs from. |
| Public property | [ProductionControlID](fsreqGetRFIDetails.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the RFIs from. |
| Public property | [RequestForInformationID](fsreqGetRFIDetails.RequestForInformationID_Property.md) | The RequestForInformationID requested. |
| Public property | [RFINumber](fsreqGetRFIDetails.RFINumber_Property.md) | The Number of the RFI requested. Specifying both is not necessary. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
