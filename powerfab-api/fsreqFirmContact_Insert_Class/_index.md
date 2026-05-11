---
title: fsreqFirmContact_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firm-contactinsert-class-78914
slug: fsreq-firm-contactinsert-class-78914
node_id: 78914
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirmContact_Insert Class
children:
- title: fsreqFirmContact_Insert Constructor
  kind: Constructor
  slug: fsreq-firm-contactinsert-constructor-78915
  path: fsreqFirmContact_Insert_Constructor.md
- title: fsreqFirmContact_Insert.Active Property
  kind: Property
  slug: active-property-78917
  path: fsreqFirmContact_Insert.Active_Property.md
- title: fsreqFirmContact_Insert.Email Property
  kind: Property
  slug: email-property-78918
  path: fsreqFirmContact_Insert.Email_Property.md
- title: fsreqFirmContact_Insert.ExternalID Property
  kind: Property
  slug: external-id-property-78919
  path: fsreqFirmContact_Insert.ExternalID_Property.md
- title: fsreqFirmContact_Insert.Fax Property
  kind: Property
  slug: fax-property-78920
  path: fsreqFirmContact_Insert.Fax_Property.md
- title: fsreqFirmContact_Insert.FirmID Property
  kind: Property
  slug: firm-id-property-78921
  path: fsreqFirmContact_Insert.FirmID_Property.md
- title: fsreqFirmContact_Insert.Inspector Property
  kind: Property
  slug: inspector-property-78922
  path: fsreqFirmContact_Insert.Inspector_Property.md
- title: fsreqFirmContact_Insert.InspectorID Property
  kind: Property
  slug: inspector-id-property-78923
  path: fsreqFirmContact_Insert.InspectorID_Property.md
- title: fsreqFirmContact_Insert.MobilePhone Property
  kind: Property
  slug: mobile-phone-property-78924
  path: fsreqFirmContact_Insert.MobilePhone_Property.md
- title: fsreqFirmContact_Insert.Name Property
  kind: Property
  slug: name-property-78925
  path: fsreqFirmContact_Insert.Name_Property.md
- title: fsreqFirmContact_Insert.Pager Property
  kind: Property
  slug: pager-property-78926
  path: fsreqFirmContact_Insert.Pager_Property.md
- title: fsreqFirmContact_Insert.Phone Property
  kind: Property
  slug: phone-property-78927
  path: fsreqFirmContact_Insert.Phone_Property.md
---

# fsreqFirmContact_Insert Class

Adds a new firm contact.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirmContact\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirmContact_Insert : fsreqCommand
```

The fsreqFirmContact\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirmContact\_Insert](fsreqFirmContact_Insert_Constructor.md) | Initializes a new instance of the fsreqFirmContact\_Insert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Active](fsreqFirmContact_Insert.Active_Property.md) | True if contact is active |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Email](fsreqFirmContact_Insert.Email_Property.md) | Email of contact |
| Public property | [ExternalID](fsreqFirmContact_Insert.ExternalID_Property.md) | External ID of this contact is added to |
| Public property | [Fax](fsreqFirmContact_Insert.Fax_Property.md) | Fax number of contact |
| Public property | [FirmID](fsreqFirmContact_Insert.FirmID_Property.md) | ID of firm this contact is added to |
| Public property | [Inspector](fsreqFirmContact_Insert.Inspector_Property.md) | True if contact is an inspector |
| Public property | [InspectorID](fsreqFirmContact_Insert.InspectorID_Property.md) | Inspector ID of contact, if inspector |
| Public property | [MobilePhone](fsreqFirmContact_Insert.MobilePhone_Property.md) | Mobile phone number of contact |
| Public property | [Name](fsreqFirmContact_Insert.Name_Property.md) | Name of contact |
| Public property | [Pager](fsreqFirmContact_Insert.Pager_Property.md) | Pager number of contact |
| Public property | [Phone](fsreqFirmContact_Insert.Phone_Property.md) | Phone number of contact |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
