---
title: fsreqGetBillOfMaterials Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-bill-materials-class-78951
slug: fsreq-get-bill-materials-class-78951
node_id: 78951
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetBillOfMaterials Class
children:
- title: fsreqGetBillOfMaterials Constructor
  kind: Constructor
  slug: fsreq-get-bill-materials-constructor-78952
  path: fsreqGetBillOfMaterials_Constructor.md
- title: fsreqGetBillOfMaterials.Filters Property
  kind: Property
  slug: filters-property-78954
  path: fsreqGetBillOfMaterials.Filters_Property.md
- title: fsreqGetBillOfMaterials.JobNumber Property
  kind: Property
  slug: job-number-property-78955
  path: fsreqGetBillOfMaterials.JobNumber_Property.md
- title: fsreqGetBillOfMaterials.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78956
  path: fsreqGetBillOfMaterials.ProductionControlID_Property.md
- title: fsreqGetBillOfMaterials.RequestedField Property
  kind: Property
  slug: requested-field-property-78957
  path: fsreqGetBillOfMaterials.RequestedField_Property.md
---

# fsreqGetBillOfMaterials Class

Retrieves the bill of materials.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetBillOfMaterials

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetBillOfMaterials : fsreqCommand
```

The fsreqGetBillOfMaterials type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetBillOfMaterials](fsreqGetBillOfMaterials_Constructor.md) | fsreqGetBillOfMaterials class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetBillOfMaterials.Filters_Property.md) |  |
| Public property | [JobNumber](fsreqGetBillOfMaterials.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetBillOfMaterials.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |
| Public property | [RequestedField](fsreqGetBillOfMaterials.RequestedField_Property.md) | Field to include in the response. Main Mark will always be included in the response. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
