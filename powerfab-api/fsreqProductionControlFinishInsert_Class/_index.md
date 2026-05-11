---
title: fsreqProductionControlFinishInsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-finish-insert-class-79755
slug: fsreq-production-control-finish-insert-class-79755
node_id: 79755
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlFinishInsert Class
children:
- title: fsreqProductionControlFinishInsert Constructor
  kind: Constructor
  slug: fsreq-production-control-finish-insert-constructor-79756
  path: fsreqProductionControlFinishInsert_Constructor.md
- title: fsreqProductionControlFinishInsert.Abbreviation Property
  kind: Property
  slug: abbreviation-property-79758
  path: fsreqProductionControlFinishInsert.Abbreviation_Property.md
- title: fsreqProductionControlFinishInsert.DefaultShippingRouteID Property
  kind: Property
  slug: default-shipping-route-id-property-79759
  path: fsreqProductionControlFinishInsert.DefaultShippingRouteID_Property.md
- title: fsreqProductionControlFinishInsert.Description Property
  kind: Property
  slug: description-property-79760
  path: fsreqProductionControlFinishInsert.Description_Property.md
---

# fsreqProductionControlFinishInsert Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlFinishInsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlFinishInsert : fsreqCommand
```

The fsreqProductionControlFinishInsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlFinishInsert](fsreqProductionControlFinishInsert_Constructor.md) | Initializes a new instance of the fsreqProductionControlFinishInsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Abbreviation](fsreqProductionControlFinishInsert.Abbreviation_Property.md) |  |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DefaultShippingRouteID](fsreqProductionControlFinishInsert.DefaultShippingRouteID_Property.md) |  |
| Public property | [Description](fsreqProductionControlFinishInsert.Description_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
