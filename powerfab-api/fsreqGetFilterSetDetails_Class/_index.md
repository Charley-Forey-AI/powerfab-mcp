---
title: fsreqGetFilterSetDetails Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-filter-set-details-class-79031
slug: fsreq-get-filter-set-details-class-79031
node_id: 79031
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetFilterSetDetails Class
children:
- title: fsreqGetFilterSetDetails Constructor
  kind: Constructor
  slug: fsreq-get-filter-set-details-constructor-79032
  path: fsreqGetFilterSetDetails_Constructor.md
- title: fsreqGetFilterSetDetails.FilterSetSubType Property
  kind: Property
  slug: filter-set-sub-type-property-79034
  path: fsreqGetFilterSetDetails.FilterSetSubType_Property.md
- title: fsreqGetFilterSetDetails.FilterSetType Property
  kind: Property
  slug: filter-set-type-property-79035
  path: fsreqGetFilterSetDetails.FilterSetType_Property.md
---

# fsreqGetFilterSetDetails Class

Retrieves the fields and types for a filter.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetFilterSetDetails

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetFilterSetDetails : fsreqCommand
```

The fsreqGetFilterSetDetails type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetFilterSetDetails](fsreqGetFilterSetDetails_Constructor.md) | Initializes a new instance of the fsreqGetFilterSetDetails class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FilterSetSubType](fsreqGetFilterSetDetails.FilterSetSubType_Property.md) | The Filter Set SubType to be retrieved |
| Public property | [FilterSetType](fsreqGetFilterSetDetails.FilterSetType_Property.md) | The Filter Set type to be retrieved |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
