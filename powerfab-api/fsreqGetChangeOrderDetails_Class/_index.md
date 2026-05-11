---
title: fsreqGetChangeOrderDetails Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-change-order-details-class-78966
slug: fsreq-get-change-order-details-class-78966
node_id: 78966
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetChangeOrderDetails Class
children:
- title: fsreqGetChangeOrderDetails Constructor
  kind: Constructor
  slug: fsreq-get-change-order-details-constructor-78967
  path: fsreqGetChangeOrderDetails_Constructor.md
- title: fsreqGetChangeOrderDetails.ChangeOrderID Property
  kind: Property
  slug: change-order-id-property-78969
  path: fsreqGetChangeOrderDetails.ChangeOrderID_Property.md
- title: fsreqGetChangeOrderDetails.ChangeOrderNumber Property
  kind: Property
  slug: change-order-number-property-78970
  path: fsreqGetChangeOrderDetails.ChangeOrderNumber_Property.md
- title: fsreqGetChangeOrderDetails.FilterSet Property
  kind: Property
  slug: filter-set-property-78971
  path: fsreqGetChangeOrderDetails.FilterSet_Property.md
- title: fsreqGetChangeOrderDetails.IncludeAttachedFiles Property
  kind: Property
  slug: include-attached-files-property-78972
  path: fsreqGetChangeOrderDetails.IncludeAttachedFiles_Property.md
- title: fsreqGetChangeOrderDetails.JobNumber Property
  kind: Property
  slug: job-number-property-78973
  path: fsreqGetChangeOrderDetails.JobNumber_Property.md
- title: fsreqGetChangeOrderDetails.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78974
  path: fsreqGetChangeOrderDetails.ProductionControlID_Property.md
---

# fsreqGetChangeOrderDetails Class

Retrieves the details of one or more Change Order.
If neither ChangeOrderID nor ChangeOrderNumber are specified, the change orders received will be limited by the filters

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetChangeOrderDetails

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetChangeOrderDetails : fsreqCommand
```

The fsreqGetChangeOrderDetails type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetChangeOrderDetails](fsreqGetChangeOrderDetails_Constructor.md) | fsreqGetChangeOrderDetails class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ChangeOrderID](fsreqGetChangeOrderDetails.ChangeOrderID_Property.md) | The ChangeOrderID requested. |
| Public property | [ChangeOrderNumber](fsreqGetChangeOrderDetails.ChangeOrderNumber_Property.md) | The Number of the Change Order requested. Specifying both is not necessary. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterSet](fsreqGetChangeOrderDetails.FilterSet_Property.md) |  |
| Public property | [IncludeAttachedFiles](fsreqGetChangeOrderDetails.IncludeAttachedFiles_Property.md) |  |
| Public property | [JobNumber](fsreqGetChangeOrderDetails.JobNumber_Property.md) | The JobNumber of the job to retrieve the transmittals from. |
| Public property | [ProductionControlID](fsreqGetChangeOrderDetails.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the transmittals from. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
