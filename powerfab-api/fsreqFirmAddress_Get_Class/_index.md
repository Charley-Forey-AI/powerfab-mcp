---
title: fsreqFirmAddress_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-addressget-class-78838
slug: fsreq-firm-addressget-class-78838
node_id: 78838
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmAddress_Get Class
children:
- title: fsreqFirmAddress_Get Constructor
  kind: Constructor
  slug: fsreq-firm-addressget-constructor-78839
  path: fsreqFirmAddress_Get_Constructor.md
- title: fsreqFirmAddress_Get.BillToAddresses Property
  kind: Property
  slug: bill-addresses-property-78841
  path: fsreqFirmAddress_Get.BillToAddresses_Property.md
- title: fsreqFirmAddress_Get.FirmAddressID Property
  kind: Property
  slug: firm-address-id-property-78842
  path: fsreqFirmAddress_Get.FirmAddressID_Property.md
- title: fsreqFirmAddress_Get.FirmID Property
  kind: Property
  slug: firm-id-property-78843
  path: fsreqFirmAddress_Get.FirmID_Property.md
- title: fsreqFirmAddress_Get.FirmType Property
  kind: Property
  slug: firm-type-property-78844
  path: fsreqFirmAddress_Get.FirmType_Property.md
- title: fsreqFirmAddress_Get.IncludeInactive Property
  kind: Property
  slug: include-inactive-property-78845
  path: fsreqFirmAddress_Get.IncludeInactive_Property.md
- title: fsreqFirmAddress_Get.MillAddresses Property
  kind: Property
  slug: mill-addresses-property-78846
  path: fsreqFirmAddress_Get.MillAddresses_Property.md
- title: fsreqFirmAddress_Get.ShipToAddresses Property
  kind: Property
  slug: ship-addresses-property-78847
  path: fsreqFirmAddress_Get.ShipToAddresses_Property.md
---

# fsreqFirmAddress_Get Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmAddress\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmAddress_Get : fsreqCommand
```

The fsreqFirmAddress\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmAddress\_Get](fsreqFirmAddress_Get_Constructor.md) | fsreqFirmAddress\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [BillToAddresses](fsreqFirmAddress_Get.BillToAddresses_Property.md) |  |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FirmAddressID](fsreqFirmAddress_Get.FirmAddressID_Property.md) |  |
| Public property | [FirmID](fsreqFirmAddress_Get.FirmID_Property.md) |  |
| Public property | [FirmType](fsreqFirmAddress_Get.FirmType_Property.md) |  |
| Public property | [IncludeInactive](fsreqFirmAddress_Get.IncludeInactive_Property.md) |  |
| Public property | [MillAddresses](fsreqFirmAddress_Get.MillAddresses_Property.md) |  |
| Public property | [ShipToAddresses](fsreqFirmAddress_Get.ShipToAddresses_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
