---
title: fsreqFirmAddress_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-addressupdate-class-78872
slug: fsreq-firm-addressupdate-class-78872
node_id: 78872
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmAddress_Update Class
children:
- title: fsreqFirmAddress_Update Constructor
  kind: Constructor
  slug: fsreq-firm-addressupdate-constructor-78873
  path: fsreqFirmAddress_Update_Constructor.md
- title: fsreqFirmAddress_Update.Active Property
  kind: Property
  slug: active-property-78875
  path: fsreqFirmAddress_Update.Active_Property.md
- title: fsreqFirmAddress_Update.Address1 Property
  kind: Property
  slug: address1-property-78876
  path: fsreqFirmAddress_Update.Address1_Property.md
- title: fsreqFirmAddress_Update.Address2 Property
  kind: Property
  slug: address2-property-78877
  path: fsreqFirmAddress_Update.Address2_Property.md
- title: fsreqFirmAddress_Update.Attn Property
  kind: Property
  slug: attn-property-78878
  path: fsreqFirmAddress_Update.Attn_Property.md
- title: fsreqFirmAddress_Update.City Property
  kind: Property
  slug: city-property-78879
  path: fsreqFirmAddress_Update.City_Property.md
- title: fsreqFirmAddress_Update.Country Property
  kind: Property
  slug: country-property-78880
  path: fsreqFirmAddress_Update.Country_Property.md
- title: fsreqFirmAddress_Update.Description Property
  kind: Property
  slug: description-property-78881
  path: fsreqFirmAddress_Update.Description_Property.md
- title: fsreqFirmAddress_Update.Email Property
  kind: Property
  slug: email-property-78882
  path: fsreqFirmAddress_Update.Email_Property.md
- title: fsreqFirmAddress_Update.Fax Property
  kind: Property
  slug: fax-property-78883
  path: fsreqFirmAddress_Update.Fax_Property.md
- title: fsreqFirmAddress_Update.FirmAddressID Property
  kind: Property
  slug: firm-address-id-property-78884
  path: fsreqFirmAddress_Update.FirmAddressID_Property.md
- title: fsreqFirmAddress_Update.IsBillTo Property
  kind: Property
  slug: bill-property-78885
  path: fsreqFirmAddress_Update.IsBillTo_Property.md
- title: fsreqFirmAddress_Update.IsMill Property
  kind: Property
  slug: mill-property-78886
  path: fsreqFirmAddress_Update.IsMill_Property.md
- title: fsreqFirmAddress_Update.IsShipTo Property
  kind: Property
  slug: ship-property-78887
  path: fsreqFirmAddress_Update.IsShipTo_Property.md
- title: fsreqFirmAddress_Update.Phone Property
  kind: Property
  slug: phone-property-78888
  path: fsreqFirmAddress_Update.Phone_Property.md
- title: fsreqFirmAddress_Update.State Property
  kind: Property
  slug: state-property-78889
  path: fsreqFirmAddress_Update.State_Property.md
- title: fsreqFirmAddress_Update.Zip Property
  kind: Property
  slug: zip-property-78890
  path: fsreqFirmAddress_Update.Zip_Property.md
---

# fsreqFirmAddress_Update Class

updates a firm Address.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmAddress\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmAddress_Update : fsreqCommand
```

The fsreqFirmAddress\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmAddress\_Update](fsreqFirmAddress_Update_Constructor.md) | Initializes a new instance of the fsreqFirmAddress\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Active](fsreqFirmAddress_Update.Active_Property.md) | True if Address is active |
| Public property | [Address1](fsreqFirmAddress_Update.Address1_Property.md) | First line of Address |
| Public property | [Address2](fsreqFirmAddress_Update.Address2_Property.md) | Second line of Address |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Attn](fsreqFirmAddress_Update.Attn_Property.md) | Attn line of Address |
| Public property | [City](fsreqFirmAddress_Update.City_Property.md) | City of Address |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Country](fsreqFirmAddress_Update.Country_Property.md) | Country of Address |
| Public property | [Description](fsreqFirmAddress_Update.Description_Property.md) | Description of Address |
| Public property | [Email](fsreqFirmAddress_Update.Email_Property.md) | Email for this address |
| Public property | [Fax](fsreqFirmAddress_Update.Fax_Property.md) | Fax number of Address |
| Public property | [FirmAddressID](fsreqFirmAddress_Update.FirmAddressID_Property.md) | FirmAddress to update |
| Public property | [IsBillTo](fsreqFirmAddress_Update.IsBillTo_Property.md) | True if Address is default billTo address |
| Public property | [IsMill](fsreqFirmAddress_Update.IsMill_Property.md) | True if Address is a mill |
| Public property | [IsShipTo](fsreqFirmAddress_Update.IsShipTo_Property.md) | True if Address is the default shipTo address |
| Public property | [Phone](fsreqFirmAddress_Update.Phone_Property.md) | Phone number of Address |
| Public property | [State](fsreqFirmAddress_Update.State_Property.md) | State of Address |
| Public property | [Zip](fsreqFirmAddress_Update.Zip_Property.md) | Zip code of address |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
