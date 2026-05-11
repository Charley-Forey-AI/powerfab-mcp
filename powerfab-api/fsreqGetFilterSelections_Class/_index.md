---
title: fsreqGetFilterSelections Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-filter-selections-class-79000
slug: fsreq-get-filter-selections-class-79000
node_id: 79000
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetFilterSelections Class
children:
- title: fsreqGetFilterSelections Constructor
  kind: Constructor
  slug: fsreq-get-filter-selections-constructor-79001
  path: fsreqGetFilterSelections_Constructor.md
- title: fsreqGetFilterSelections.FilterName Property
  kind: Property
  slug: filter-name-property-79003
  path: fsreqGetFilterSelections.FilterName_Property.md
- title: fsreqGetFilterSelections.FilterSet Property
  kind: Property
  slug: filter-set-property-79004
  path: fsreqGetFilterSelections.FilterSet_Property.md
- title: fsreqGetFilterSelections.FilterSetSubType Property
  kind: Property
  slug: filter-set-sub-type-property-79005
  path: fsreqGetFilterSelections.FilterSetSubType_Property.md
- title: fsreqGetFilterSelections.FilterSetType Property
  kind: Property
  slug: filter-set-type-property-79006
  path: fsreqGetFilterSelections.FilterSetType_Property.md
- title: fsreqGetFilterSelections.JobNumber Property
  kind: Property
  slug: job-number-property-79007
  path: fsreqGetFilterSelections.JobNumber_Property.md
- title: fsreqGetFilterSelections.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79008
  path: fsreqGetFilterSelections.ProductionControlID_Property.md
---

# fsreqGetFilterSelections Class

Retrieves the selections from a selection filter

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetFilterSelections

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetFilterSelections : fsreqCommand
```

The fsreqGetFilterSelections type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetFilterSelections](fsreqGetFilterSelections_Constructor.md) | fsreqGetFilterSelections class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterName](fsreqGetFilterSelections.FilterName_Property.md) | The Filter to retrieve |
| Public property | [FilterSet](fsreqGetFilterSelections.FilterSet_Property.md) | The Filter Set to pass filter on |
| Public property | [FilterSetSubType](fsreqGetFilterSelections.FilterSetSubType_Property.md) | The Filter Set SubType to be retrieved |
| Public property | [FilterSetType](fsreqGetFilterSelections.FilterSetType_Property.md) | The Filter Set type to be retrieved |
| Public property | [JobNumber](fsreqGetFilterSelections.JobNumber_Property.md) |  |
| Public property | [ProductionControlID](fsreqGetFilterSelections.ProductionControlID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
