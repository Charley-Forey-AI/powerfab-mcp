---
title: fsreqFirmAddress_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-addressinsert-class-78854
slug: fsreq-firm-addressinsert-class-78854
node_id: 78854
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmAddress_Insert Class
children:
- title: fsreqFirmAddress_Insert Constructor
  kind: Constructor
  slug: fsreq-firm-addressinsert-constructor-78855
  path: fsreqFirmAddress_Insert_Constructor.md
- title: fsreqFirmAddress_Insert.Address1 Property
  kind: Property
  slug: address1-property-78857
  path: fsreqFirmAddress_Insert.Address1_Property.md
- title: fsreqFirmAddress_Insert.Address2 Property
  kind: Property
  slug: address2-property-78858
  path: fsreqFirmAddress_Insert.Address2_Property.md
- title: fsreqFirmAddress_Insert.Attn Property
  kind: Property
  slug: attn-property-78859
  path: fsreqFirmAddress_Insert.Attn_Property.md
- title: fsreqFirmAddress_Insert.City Property
  kind: Property
  slug: city-property-78860
  path: fsreqFirmAddress_Insert.City_Property.md
- title: fsreqFirmAddress_Insert.Country Property
  kind: Property
  slug: country-property-78861
  path: fsreqFirmAddress_Insert.Country_Property.md
- title: fsreqFirmAddress_Insert.Description Property
  kind: Property
  slug: description-property-78862
  path: fsreqFirmAddress_Insert.Description_Property.md
- title: fsreqFirmAddress_Insert.Email Property
  kind: Property
  slug: email-property-78863
  path: fsreqFirmAddress_Insert.Email_Property.md
- title: fsreqFirmAddress_Insert.Fax Property
  kind: Property
  slug: fax-property-78864
  path: fsreqFirmAddress_Insert.Fax_Property.md
- title: fsreqFirmAddress_Insert.FirmID Property
  kind: Property
  slug: firm-id-property-78865
  path: fsreqFirmAddress_Insert.FirmID_Property.md
- title: fsreqFirmAddress_Insert.IsBillTo Property
  kind: Property
  slug: bill-property-78866
  path: fsreqFirmAddress_Insert.IsBillTo_Property.md
- title: fsreqFirmAddress_Insert.IsMill Property
  kind: Property
  slug: mill-property-78867
  path: fsreqFirmAddress_Insert.IsMill_Property.md
- title: fsreqFirmAddress_Insert.IsShipTo Property
  kind: Property
  slug: ship-property-78868
  path: fsreqFirmAddress_Insert.IsShipTo_Property.md
- title: fsreqFirmAddress_Insert.Phone Property
  kind: Property
  slug: phone-property-78869
  path: fsreqFirmAddress_Insert.Phone_Property.md
- title: fsreqFirmAddress_Insert.State Property
  kind: Property
  slug: state-property-78870
  path: fsreqFirmAddress_Insert.State_Property.md
- title: fsreqFirmAddress_Insert.Zip Property
  kind: Property
  slug: zip-property-78871
  path: fsreqFirmAddress_Insert.Zip_Property.md
---

# fsreqFirmAddress_Insert Class

Adds a new firm Address.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmAddress\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmAddress_Insert : fsreqCommand
```

The fsreqFirmAddress\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmAddress\_Insert](fsreqFirmAddress_Insert_Constructor.md) | Initializes a new instance of the fsreqFirmAddress\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Address1](fsreqFirmAddress_Insert.Address1_Property.md) | First line of Address |
| Public property | [Address2](fsreqFirmAddress_Insert.Address2_Property.md) | Second line of Address |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Attn](fsreqFirmAddress_Insert.Attn_Property.md) | Attn line of Address |
| Public property | [City](fsreqFirmAddress_Insert.City_Property.md) | City of Address |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Country](fsreqFirmAddress_Insert.Country_Property.md) | Country of Address |
| Public property | [Description](fsreqFirmAddress_Insert.Description_Property.md) | Description of Address |
| Public property | [Email](fsreqFirmAddress_Insert.Email_Property.md) | Email for this address |
| Public property | [Fax](fsreqFirmAddress_Insert.Fax_Property.md) | Fax number of Address |
| Public property | [FirmID](fsreqFirmAddress_Insert.FirmID_Property.md) | ID of firm this Address is added for |
| Public property | [IsBillTo](fsreqFirmAddress_Insert.IsBillTo_Property.md) | True if Address is default billTo address |
| Public property | [IsMill](fsreqFirmAddress_Insert.IsMill_Property.md) | True if Address is a mill |
| Public property | [IsShipTo](fsreqFirmAddress_Insert.IsShipTo_Property.md) | True if Address is the default shipTo address |
| Public property | [Phone](fsreqFirmAddress_Insert.Phone_Property.md) | Phone number of Address |
| Public property | [State](fsreqFirmAddress_Insert.State_Property.md) | State of Address |
| Public property | [Zip](fsreqFirmAddress_Insert.Zip_Property.md) | Zip code of address |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
