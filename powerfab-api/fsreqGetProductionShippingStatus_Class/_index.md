---
title: fsreqGetProductionShippingStatus Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-production-shipping-status-class-79200
slug: fsreq-get-production-shipping-status-class-79200
node_id: 79200
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProductionShippingStatus Class
children:
- title: fsreqGetProductionShippingStatus Constructor
  kind: Constructor
  slug: fsreq-get-production-shipping-status-constructor-79201
  path: fsreqGetProductionShippingStatus_Constructor.md
- title: fsreqGetProductionShippingStatus.ExcludeAccessoriesWithoutPieceLoadTracking Property
  kind: Property
  slug: exclude-accessories-without-piece-load-tracking-property-79203
  path: fsreqGetProductionShippingStatus.ExcludeAccessoriesWithoutPieceLoadTracking_Property.md
- title: fsreqGetProductionShippingStatus.Filters Property
  kind: Property
  slug: filters-property-79204
  path: fsreqGetProductionShippingStatus.Filters_Property.md
- title: fsreqGetProductionShippingStatus.JobNumber Property
  kind: Property
  slug: job-number-property-79205
  path: fsreqGetProductionShippingStatus.JobNumber_Property.md
- title: fsreqGetProductionShippingStatus.Limit Property
  kind: Property
  slug: limit-property-79206
  path: fsreqGetProductionShippingStatus.Limit_Property.md
- title: fsreqGetProductionShippingStatus.Offset Property
  kind: Property
  slug: offset-property-79207
  path: fsreqGetProductionShippingStatus.Offset_Property.md
- title: fsreqGetProductionShippingStatus.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79208
  path: fsreqGetProductionShippingStatus.ProductionControlID_Property.md
- title: fsreqGetProductionShippingStatus.StatusOfOnlyMainMembers Property
  kind: Property
  slug: status-only-main-members-property-79209
  path: fsreqGetProductionShippingStatus.StatusOfOnlyMainMembers_Property.md
- title: fsreqGetProductionShippingStatus.SummaryField Property
  kind: Property
  slug: summary-field-property-79210
  path: fsreqGetProductionShippingStatus.SummaryField_Property.md
---

# fsreqGetProductionShippingStatus Class

Retrieves the production status for a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProductionShippingStatus

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProductionShippingStatus : fsreqCommand
```

The fsreqGetProductionShippingStatus type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProductionShippingStatus](fsreqGetProductionShippingStatus_Constructor.md) | fsreqGetProductionShippingStatus class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [ExcludeAccessoriesWithoutPieceLoadTracking](fsreqGetProductionShippingStatus.ExcludeAccessoriesWithoutPieceLoadTracking_Property.md) | If not specified then defaults to true. |
| Public property | [Filters](fsreqGetProductionShippingStatus.Filters_Property.md) |  |
| Public property | [JobNumber](fsreqGetProductionShippingStatus.JobNumber_Property.md) |  |
| Public property | [Limit](fsreqGetProductionShippingStatus.Limit_Property.md) |  |
| Public property | [Offset](fsreqGetProductionShippingStatus.Offset_Property.md) |  |
| Public property | [ProductionControlID](fsreqGetProductionShippingStatus.ProductionControlID_Property.md) |  |
| Public property | [StatusOfOnlyMainMembers](fsreqGetProductionShippingStatus.StatusOfOnlyMainMembers_Property.md) | If not specified then defaults to false. |
| Public property | [SummaryField](fsreqGetProductionShippingStatus.SummaryField_Property.md) | Field(s) to group the production status on. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
