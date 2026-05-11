---
title: fsreqGetCategories Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-categories-class-78959
slug: fsreq-get-categories-class-78959
node_id: 78959
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetCategories Class
children:
- title: fsreqGetCategories Constructor
  kind: Constructor
  slug: fsreq-get-categories-constructor-78960
  path: fsreqGetCategories_Constructor.md
- title: fsreqGetCategories.Filters Property
  kind: Property
  slug: filters-property-78962
  path: fsreqGetCategories.Filters_Property.md
- title: fsreqGetCategories.InspectionTests Property
  kind: Property
  slug: inspection-tests-property-78963
  path: fsreqGetCategories.InspectionTests_Property.md
- title: fsreqGetCategories.JobNumber Property
  kind: Property
  slug: job-number-property-78964
  path: fsreqGetCategories.JobNumber_Property.md
- title: fsreqGetCategories.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-78965
  path: fsreqGetCategories.ProductionControlID_Property.md
---

# fsreqGetCategories Class

Retrieves the list of categories in a job.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetCategories

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetCategories : fsreqCommand
```

The fsreqGetCategories type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetCategories](fsreqGetCategories_Constructor.md) | fsreqGetCategories class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetCategories.Filters_Property.md) |  |
| Public property | [InspectionTests](fsreqGetCategories.InspectionTests_Property.md) | If true then the inspection test summary is retrieved along with the category details. |
| Public property | [JobNumber](fsreqGetCategories.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetCategories.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
