---
title: fsreqProductionControlLoadIsDuplicateLoadNumber Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-duplicate-load-number-class-79859
slug: fsreq-production-control-load-duplicate-load-number-class-79859
node_id: 79859
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadIsDuplicateLoadNumber Class
children:
- title: fsreqProductionControlLoadIsDuplicateLoadNumber Constructor
  kind: Constructor
  slug: fsreq-production-control-load-duplicate-load-number-constructor-79860
  path: fsreqProductionControlLoadIsDuplicateLoadNumber_Constructor.md
- title: fsreqProductionControlLoadIsDuplicateLoadNumber.LoadNumber Property
  kind: Property
  slug: load-number-property-79862
  path: fsreqProductionControlLoadIsDuplicateLoadNumber.LoadNumber_Property.md
- title: fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79863
  path: fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlID_Property.md
- title: fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlLoadID Property
  kind: Property
  slug: production-control-load-id-property-79864
  path: fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlLoadID_Property.md
---

# fsreqProductionControlLoadIsDuplicateLoadNumber Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadIsDuplicateLoadNumber

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadIsDuplicateLoadNumber : fsreqCommand
```

The fsreqProductionControlLoadIsDuplicateLoadNumber type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadIsDuplicateLoadNumber](fsreqProductionControlLoadIsDuplicateLoadNumber_Constructor.md) | Initializes a new instance of the fsreqProductionControlLoadIsDuplicateLoadNumber class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [LoadNumber](fsreqProductionControlLoadIsDuplicateLoadNumber.LoadNumber_Property.md) |  |
| Public property | [ProductionControlID](fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlID_Property.md) |  |
| Public property | [ProductionControlLoadID](fsreqProductionControlLoadIsDuplicateLoadNumber.ProductionControlLoadID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
