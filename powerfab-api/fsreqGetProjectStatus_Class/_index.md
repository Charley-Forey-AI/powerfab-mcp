---
title: fsreqGetProjectStatus Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-project-status-class-79227
slug: fsreq-get-project-status-class-79227
node_id: 79227
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetProjectStatus Class
children:
- title: fsreqGetProjectStatus Constructor
  kind: Constructor
  slug: fsreq-get-project-status-constructor-79228
  path: fsreqGetProjectStatus_Constructor.md
- title: fsreqGetProjectStatus.Filters Property
  kind: Property
  slug: filters-property-79230
  path: fsreqGetProjectStatus.Filters_Property.md
- title: fsreqGetProjectStatus.IncludeAssemblies Property
  kind: Property
  slug: include-assemblies-property-79231
  path: fsreqGetProjectStatus.IncludeAssemblies_Property.md
- title: fsreqGetProjectStatus.IncludeCategories Property
  kind: Property
  slug: include-categories-property-79232
  path: fsreqGetProjectStatus.IncludeCategories_Property.md
- title: fsreqGetProjectStatus.IncludeChangeOrders Property
  kind: Property
  slug: include-change-orders-property-79233
  path: fsreqGetProjectStatus.IncludeChangeOrders_Property.md
- title: fsreqGetProjectStatus.IncludeCutLists Property
  kind: Property
  slug: include-cut-lists-property-79234
  path: fsreqGetProjectStatus.IncludeCutLists_Property.md
- title: fsreqGetProjectStatus.IncludeDrawings Property
  kind: Property
  slug: include-drawings-property-79235
  path: fsreqGetProjectStatus.IncludeDrawings_Property.md
- title: fsreqGetProjectStatus.IncludeLots Property
  kind: Property
  slug: include-lots-property-79236
  path: fsreqGetProjectStatus.IncludeLots_Property.md
- title: fsreqGetProjectStatus.IncludeMaterialStatus Property
  kind: Property
  slug: include-material-status-property-79237
  path: fsreqGetProjectStatus.IncludeMaterialStatus_Property.md
- title: fsreqGetProjectStatus.IncludeProductionStatus Property
  kind: Property
  slug: include-production-status-property-79238
  path: fsreqGetProjectStatus.IncludeProductionStatus_Property.md
- title: fsreqGetProjectStatus.IncludeRFIs Property
  kind: Property
  slug: include-rf-property-79239
  path: fsreqGetProjectStatus.IncludeRFIs_Property.md
- title: fsreqGetProjectStatus.IncludeSequences Property
  kind: Property
  slug: include-sequences-property-79240
  path: fsreqGetProjectStatus.IncludeSequences_Property.md
- title: fsreqGetProjectStatus.IncludeShipStatus Property
  kind: Property
  slug: include-ship-status-property-79241
  path: fsreqGetProjectStatus.IncludeShipStatus_Property.md
- title: fsreqGetProjectStatus.IncludeSubCategories Property
  kind: Property
  slug: include-sub-categories-property-79242
  path: fsreqGetProjectStatus.IncludeSubCategories_Property.md
- title: fsreqGetProjectStatus.IncludeTransmittals Property
  kind: Property
  slug: include-transmittals-property-79243
  path: fsreqGetProjectStatus.IncludeTransmittals_Property.md
- title: fsreqGetProjectStatus.JobNumber Property
  kind: Property
  slug: job-number-property-79244
  path: fsreqGetProjectStatus.JobNumber_Property.md
- title: fsreqGetProjectStatus.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79245
  path: fsreqGetProjectStatus.ProductionControlID_Property.md
---

# fsreqGetProjectStatus Class

Retrieves summary information about the job including:
Assemblies
Drawings
Sequences
Lots
Categories
Sub-Categories
RFIs
Change Orders
Transmittals
Cut Lists
Material Status
Production Status
Shipping Status
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetProjectStatus

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetProjectStatus : fsreqCommand
```

The fsreqGetProjectStatus type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetProjectStatus](fsreqGetProjectStatus_Constructor.md) | fsreqGetProjectStatus class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetProjectStatus.Filters_Property.md) | Filter object to restrict results |
| Public property | [IncludeAssemblies](fsreqGetProjectStatus.IncludeAssemblies_Property.md) | Include assembly information - true/false. |
| Public property | [IncludeCategories](fsreqGetProjectStatus.IncludeCategories_Property.md) | Include category information - true/false. |
| Public property | [IncludeChangeOrders](fsreqGetProjectStatus.IncludeChangeOrders_Property.md) | Include change order information - true/false. |
| Public property | [IncludeCutLists](fsreqGetProjectStatus.IncludeCutLists_Property.md) | Include cut lists - true/false. with attribute SharedOnly - true/false |
| Public property | [IncludeDrawings](fsreqGetProjectStatus.IncludeDrawings_Property.md) | Include drawing information - true/false. |
| Public property | [IncludeLots](fsreqGetProjectStatus.IncludeLots_Property.md) | Include lot information - true/false. |
| Public property | [IncludeMaterialStatus](fsreqGetProjectStatus.IncludeMaterialStatus_Property.md) | Include material status - true/false. |
| Public property | [IncludeProductionStatus](fsreqGetProjectStatus.IncludeProductionStatus_Property.md) | Include production status - true/false. |
| Public property | [IncludeRFIs](fsreqGetProjectStatus.IncludeRFIs_Property.md) | Include RFI information - true/false. |
| Public property | [IncludeSequences](fsreqGetProjectStatus.IncludeSequences_Property.md) | Include sequence information - true/false. |
| Public property | [IncludeShipStatus](fsreqGetProjectStatus.IncludeShipStatus_Property.md) | Include ship status - true/false. |
| Public property | [IncludeSubCategories](fsreqGetProjectStatus.IncludeSubCategories_Property.md) | Include sub-category information - true/false. |
| Public property | [IncludeTransmittals](fsreqGetProjectStatus.IncludeTransmittals_Property.md) | Include transmittal information - true/false. |
| Public property | [JobNumber](fsreqGetProjectStatus.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetProjectStatus.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
