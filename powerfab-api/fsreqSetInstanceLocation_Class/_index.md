---
title: fsreqSetInstanceLocation Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-set-instance-location-class-80429
slug: fsreq-set-instance-location-class-80429
node_id: 80429
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSetInstanceLocation Class
children:
- title: fsreqSetInstanceLocation Constructor
  kind: Constructor
  slug: fsreq-set-instance-location-constructor-80430
  path: fsreqSetInstanceLocation_Constructor.md
- title: fsreqSetInstanceLocation.InstanceLocation Property
  kind: Property
  slug: instance-location-property-80432
  path: fsreqSetInstanceLocation.InstanceLocation_Property.md
- title: fsreqSetInstanceLocation.InstanceNumbers Property
  kind: Property
  slug: instance-numbers-property-80433
  path: fsreqSetInstanceLocation.InstanceNumbers_Property.md
- title: fsreqSetInstanceLocation.JobNumber Property
  kind: Property
  slug: job-number-property-80434
  path: fsreqSetInstanceLocation.JobNumber_Property.md
- title: fsreqSetInstanceLocation.LotNumber Property
  kind: Property
  slug: lot-number-property-80435
  path: fsreqSetInstanceLocation.LotNumber_Property.md
- title: fsreqSetInstanceLocation.MainMark Property
  kind: Property
  slug: main-mark-property-80436
  path: fsreqSetInstanceLocation.MainMark_Property.md
- title: fsreqSetInstanceLocation.PieceMark Property
  kind: Property
  slug: piece-mark-property-80437
  path: fsreqSetInstanceLocation.PieceMark_Property.md
- title: fsreqSetInstanceLocation.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80438
  path: fsreqSetInstanceLocation.ProductionControlID_Property.md
- title: fsreqSetInstanceLocation.Quantity Property
  kind: Property
  slug: quantity-property-80439
  path: fsreqSetInstanceLocation.Quantity_Property.md
- title: fsreqSetInstanceLocation.Sequence Property
  kind: Property
  slug: sequence-property-80440
  path: fsreqSetInstanceLocation.Sequence_Property.md
- title: fsreqSetInstanceLocation.SerialNumber Property
  kind: Property
  slug: serial-number-property-80441
  path: fsreqSetInstanceLocation.SerialNumber_Property.md
---

# fsreqSetInstanceLocation Class

Sets the location of a part instance.
Either ProductionControlID or JobNumber must be specified.
Either InstanceNumbers or (SerialNumber and Quantity) must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSetInstanceLocation

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSetInstanceLocation : fsreqCommand
```

The fsreqSetInstanceLocation type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSetInstanceLocation](fsreqSetInstanceLocation_Constructor.md) | Initializes a new instance of the fsreqSetInstanceLocation class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [InstanceLocation](fsreqSetInstanceLocation.InstanceLocation_Property.md) |  |
| Public property | [InstanceNumbers](fsreqSetInstanceLocation.InstanceNumbers_Property.md) |  |
| Public property | [JobNumber](fsreqSetInstanceLocation.JobNumber_Property.md) |  |
| Public property | [LotNumber](fsreqSetInstanceLocation.LotNumber_Property.md) |  |
| Public property | [MainMark](fsreqSetInstanceLocation.MainMark_Property.md) |  |
| Public property | [PieceMark](fsreqSetInstanceLocation.PieceMark_Property.md) |  |
| Public property | [ProductionControlID](fsreqSetInstanceLocation.ProductionControlID_Property.md) |  |
| Public property | [Quantity](fsreqSetInstanceLocation.Quantity_Property.md) |  |
| Public property | [Sequence](fsreqSetInstanceLocation.Sequence_Property.md) |  |
| Public property | [SerialNumber](fsreqSetInstanceLocation.SerialNumber_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
