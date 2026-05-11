---
title: fsreqFirmContact_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-contactupdate-class-78928
slug: fsreq-firm-contactupdate-class-78928
node_id: 78928
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmContact_Update Class
children:
- title: fsreqFirmContact_Update Constructor
  kind: Constructor
  slug: fsreq-firm-contactupdate-constructor-78929
  path: fsreqFirmContact_Update_Constructor.md
- title: fsreqFirmContact_Update.Active Property
  kind: Property
  slug: active-property-78931
  path: fsreqFirmContact_Update.Active_Property.md
- title: fsreqFirmContact_Update.Email Property
  kind: Property
  slug: email-property-78932
  path: fsreqFirmContact_Update.Email_Property.md
- title: fsreqFirmContact_Update.ExternalID Property
  kind: Property
  slug: external-id-property-78933
  path: fsreqFirmContact_Update.ExternalID_Property.md
- title: fsreqFirmContact_Update.Fax Property
  kind: Property
  slug: fax-property-78934
  path: fsreqFirmContact_Update.Fax_Property.md
- title: fsreqFirmContact_Update.FirmContactID Property
  kind: Property
  slug: firm-contact-id-property-78935
  path: fsreqFirmContact_Update.FirmContactID_Property.md
- title: fsreqFirmContact_Update.Inspector Property
  kind: Property
  slug: inspector-property-78936
  path: fsreqFirmContact_Update.Inspector_Property.md
- title: fsreqFirmContact_Update.InspectorID Property
  kind: Property
  slug: inspector-id-property-78937
  path: fsreqFirmContact_Update.InspectorID_Property.md
- title: fsreqFirmContact_Update.MobilePhone Property
  kind: Property
  slug: mobile-phone-property-78938
  path: fsreqFirmContact_Update.MobilePhone_Property.md
- title: fsreqFirmContact_Update.Name Property
  kind: Property
  slug: name-property-78939
  path: fsreqFirmContact_Update.Name_Property.md
- title: fsreqFirmContact_Update.Pager Property
  kind: Property
  slug: pager-property-78940
  path: fsreqFirmContact_Update.Pager_Property.md
- title: fsreqFirmContact_Update.Phone Property
  kind: Property
  slug: phone-property-78941
  path: fsreqFirmContact_Update.Phone_Property.md
---

# fsreqFirmContact_Update Class

updates a firm contact.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmContact\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmContact_Update : fsreqCommand
```

The fsreqFirmContact\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmContact\_Update](fsreqFirmContact_Update_Constructor.md) | Initializes a new instance of the fsreqFirmContact\_Update class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Active](fsreqFirmContact_Update.Active_Property.md) | True if contact is active |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Email](fsreqFirmContact_Update.Email_Property.md) | Email of contact |
| Public property | [ExternalID](fsreqFirmContact_Update.ExternalID_Property.md) | External ID of this contact is added to |
| Public property | [Fax](fsreqFirmContact_Update.Fax_Property.md) | Fax number of contact |
| Public property | [FirmContactID](fsreqFirmContact_Update.FirmContactID_Property.md) | FirmContact to update |
| Public property | [Inspector](fsreqFirmContact_Update.Inspector_Property.md) | True if contact is an inspector |
| Public property | [InspectorID](fsreqFirmContact_Update.InspectorID_Property.md) | Inspector ID of contact, if inspector |
| Public property | [MobilePhone](fsreqFirmContact_Update.MobilePhone_Property.md) | Mobile phone number of contact |
| Public property | [Name](fsreqFirmContact_Update.Name_Property.md) | Name of contact |
| Public property | [Pager](fsreqFirmContact_Update.Pager_Property.md) | Pager number of contact |
| Public property | [Phone](fsreqFirmContact_Update.Phone_Property.md) | Phone number of contact |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
