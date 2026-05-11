---
title: fsreqShip Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-ship-class-80442
slug: fsreq-ship-class-80442
node_id: 80442
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqShip Class
children:
- title: fsreqShip Constructor
  kind: Constructor
  slug: fsreq-ship-constructor-80443
  path: fsreqShip_Constructor.md
- title: fsreqShip.CommitType Property
  kind: Property
  slug: commit-type-property-80445
  path: fsreqShip.CommitType_Property.md
- title: fsreqShip.Date Property
  kind: Property
  slug: date-property-80446
  path: fsreqShip.Date_Property.md
- title: fsreqShip.JobNumber Property
  kind: Property
  slug: job-number-property-80447
  path: fsreqShip.JobNumber_Property.md
- title: fsreqShip.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80448
  path: fsreqShip.ProductionControlID_Property.md
- title: fsreqShip.TruckNumber Property
  kind: Property
  slug: truck-number-property-80449
  path: fsreqShip.TruckNumber_Property.md
---

# fsreqShip Class

Ships or Un-Ships a load.
Either ProductionControlID or JobNumber must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqShip

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqShip : fsreqCommand
```

The fsreqShip type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqShip](fsreqShip_Constructor.md) | Initializes a new instance of the fsreqShip class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommitType](fsreqShip.CommitType_Property.md) | Type of action. |
| Public property | [Date](fsreqShip.Date_Property.md) |  |
| Public property | [JobNumber](fsreqShip.JobNumber_Property.md) |  |
| Public property | [ProductionControlID](fsreqShip.ProductionControlID_Property.md) |  |
| Public property | [TruckNumber](fsreqShip.TruckNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
