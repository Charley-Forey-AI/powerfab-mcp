---
title: fsreqInventoryAuditScan Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-audit-scan-class-79374
slug: fsreq-inventory-audit-scan-class-79374
node_id: 79374
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryAuditScan Class
children:
- title: fsreqInventoryAuditScan Constructor
  kind: Constructor
  slug: fsreq-inventory-audit-scan-constructor-79375
  path: fsreqInventoryAuditScan_Constructor.md
- title: fsreqInventoryAuditScan.AuditSerialNumber Property
  kind: Property
  slug: audit-serial-number-property-79377
  path: fsreqInventoryAuditScan.AuditSerialNumber_Property.md
---

# fsreqInventoryAuditScan Class

Retrieves the details of an audit serial #.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqInventoryAuditScan

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqInventoryAuditScan : fsreqCommand
```

The fsreqInventoryAuditScan type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqInventoryAuditScan](fsreqInventoryAuditScan_Constructor.md) | Initializes a new instance of the fsreqInventoryAuditScan class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [AuditSerialNumber](fsreqInventoryAuditScan.AuditSerialNumber_Property.md) | Serial # from the FabSuite inventory report: Audit w/ Barcodes. Represents a set of values for: Shape, Grade, Dimensions, Length, PO #, B/L #, Heat #, Heat Serial #, Location, and Secondary Location. |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
