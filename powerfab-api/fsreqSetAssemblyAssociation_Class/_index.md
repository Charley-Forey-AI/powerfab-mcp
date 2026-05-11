---
title: fsreqSetAssemblyAssociation Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-set-assembly-association-class-80408
slug: fsreq-set-assembly-association-class-80408
node_id: 80408
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqSetAssemblyAssociation Class
children:
- title: fsreqSetAssemblyAssociation Constructor
  kind: Constructor
  slug: fsreq-set-assembly-association-constructor-80409
  path: fsreqSetAssemblyAssociation_Constructor.md
- title: fsreqSetAssemblyAssociation.AccessoryInstanceNumbers Property
  kind: Property
  slug: accessory-instance-numbers-property-80411
  path: fsreqSetAssemblyAssociation.AccessoryInstanceNumbers_Property.md
- title: fsreqSetAssemblyAssociation.AccessoryPieceMark Property
  kind: Property
  slug: accessory-piece-mark-property-80412
  path: fsreqSetAssemblyAssociation.AccessoryPieceMark_Property.md
- title: fsreqSetAssemblyAssociation.AccessoryQuantity Property
  kind: Property
  slug: accessory-quantity-property-80413
  path: fsreqSetAssemblyAssociation.AccessoryQuantity_Property.md
- title: fsreqSetAssemblyAssociation.AccessorySerialNumber Property
  kind: Property
  slug: accessory-serial-number-property-80414
  path: fsreqSetAssemblyAssociation.AccessorySerialNumber_Property.md
- title: fsreqSetAssemblyAssociation.AssemblyInstanceNumber Property
  kind: Property
  slug: assembly-instance-number-property-80415
  path: fsreqSetAssemblyAssociation.AssemblyInstanceNumber_Property.md
- title: fsreqSetAssemblyAssociation.AssemblySerialNumber Property
  kind: Property
  slug: assembly-serial-number-property-80416
  path: fsreqSetAssemblyAssociation.AssemblySerialNumber_Property.md
- title: fsreqSetAssemblyAssociation.JobNumber Property
  kind: Property
  slug: job-number-property-80417
  path: fsreqSetAssemblyAssociation.JobNumber_Property.md
- title: fsreqSetAssemblyAssociation.LotNumber Property
  kind: Property
  slug: lot-number-property-80418
  path: fsreqSetAssemblyAssociation.LotNumber_Property.md
- title: fsreqSetAssemblyAssociation.MainMark Property
  kind: Property
  slug: main-mark-property-80419
  path: fsreqSetAssemblyAssociation.MainMark_Property.md
- title: fsreqSetAssemblyAssociation.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-80420
  path: fsreqSetAssemblyAssociation.ProductionControlID_Property.md
- title: fsreqSetAssemblyAssociation.Sequence Property
  kind: Property
  slug: sequence-property-80421
  path: fsreqSetAssemblyAssociation.Sequence_Property.md
---

# fsreqSetAssemblyAssociation Class

Sets the association between one or more instances of an accessory part with an instance of the assembly.
Either ProductionControlID or JobNumber must be specified.
Either AssemblyInstanceNumber or AssemblySerialNumber must be specified.
Either AccessoryInstanceNumbers or (AccessorySerialNumber and AccessoryQuantity) must be specified.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqSetAssemblyAssociation

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqSetAssemblyAssociation : fsreqCommand
```

The fsreqSetAssemblyAssociation type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqSetAssemblyAssociation](fsreqSetAssemblyAssociation_Constructor.md) | Initializes a new instance of the fsreqSetAssemblyAssociation class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AccessoryInstanceNumbers](fsreqSetAssemblyAssociation.AccessoryInstanceNumbers_Property.md) |  |
| Public property | [AccessoryPieceMark](fsreqSetAssemblyAssociation.AccessoryPieceMark_Property.md) |  |
| Public property | [AccessoryQuantity](fsreqSetAssemblyAssociation.AccessoryQuantity_Property.md) |  |
| Public property | [AccessorySerialNumber](fsreqSetAssemblyAssociation.AccessorySerialNumber_Property.md) |  |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [AssemblyInstanceNumber](fsreqSetAssemblyAssociation.AssemblyInstanceNumber_Property.md) |  |
| Public property | [AssemblySerialNumber](fsreqSetAssemblyAssociation.AssemblySerialNumber_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [JobNumber](fsreqSetAssemblyAssociation.JobNumber_Property.md) |  |
| Public property | [LotNumber](fsreqSetAssemblyAssociation.LotNumber_Property.md) |  |
| Public property | [MainMark](fsreqSetAssemblyAssociation.MainMark_Property.md) |  |
| Public property | [ProductionControlID](fsreqSetAssemblyAssociation.ProductionControlID_Property.md) |  |
| Public property | [Sequence](fsreqSetAssemblyAssociation.Sequence_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
