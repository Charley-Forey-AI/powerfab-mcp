---
title: fsreqFirmAddresses_Get Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-addressesget-class-78891
slug: fsreq-firm-addressesget-class-78891
node_id: 78891
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmAddresses_Get Class
children:
- title: fsreqFirmAddresses_Get Constructor
  kind: Constructor
  slug: fsreq-firm-addressesget-constructor-78892
  path: fsreqFirmAddresses_Get_Constructor.md
- title: fsreqFirmAddresses_Get.FirmAddressID Property
  kind: Property
  slug: firm-address-id-property-78894
  path: fsreqFirmAddresses_Get.FirmAddressID_Property.md
- title: fsreqFirmAddresses_Get.FirmID Property
  kind: Property
  slug: firm-id-property-78895
  path: fsreqFirmAddresses_Get.FirmID_Property.md
- title: fsreqFirmAddresses_Get.GetOptions Property
  kind: Property
  slug: get-options-property-78896
  path: fsreqFirmAddresses_Get.GetOptions_Property.md
- title: fsreqFirmAddresses_Get.LastLogID Property
  kind: Property
  slug: last-log-id-property-78897
  path: fsreqFirmAddresses_Get.LastLogID_Property.md
---

# fsreqFirmAddresses_Get Class

Retrieves one or more firm addresses.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmAddresses\_Get

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmAddresses_Get : fsreqCommand
```

The fsreqFirmAddresses\_Get type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmAddresses\_Get](fsreqFirmAddresses_Get_Constructor.md) | fsreqFirmAddresses\_Get class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FirmAddressID](fsreqFirmAddresses_Get.FirmAddressID_Property.md) | FirmAddressID ID to retrieve |
| Public property | [FirmID](fsreqFirmAddresses_Get.FirmID_Property.md) | Retrieve contracts for firm |
| Public property | [GetOptions](fsreqFirmAddresses_Get.GetOptions_Property.md) | Additional options |
| Public property | [LastLogID](fsreqFirmAddresses_Get.LastLogID_Property.md) | Retrieves changes since LastLogID |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
