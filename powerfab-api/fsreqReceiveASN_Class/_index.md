---
title: fsreqReceiveASN Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-receive-asn-class-80272
slug: fsreq-receive-asn-class-80272
node_id: 80272
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqReceiveASN Class
children:
- title: fsreqReceiveASN Constructor
  kind: Constructor
  slug: fsreq-receive-asn-constructor-80273
  path: fsreqReceiveASN_Constructor.md
- title: fsreqReceiveASN.Location Property
  kind: Property
  slug: location-property-80275
  path: fsreqReceiveASN.Location_Property.md
- title: fsreqReceiveASN.ReceivingNotes Property
  kind: Property
  slug: receiving-notes-property-80276
  path: fsreqReceiveASN.ReceivingNotes_Property.md
- title: fsreqReceiveASN.ReceivingRemarks Property
  kind: Property
  slug: receiving-remarks-property-80277
  path: fsreqReceiveASN.ReceivingRemarks_Property.md
- title: fsreqReceiveASN.SecondaryLocation Property
  kind: Property
  slug: secondary-location-property-80278
  path: fsreqReceiveASN.SecondaryLocation_Property.md
- title: fsreqReceiveASN.SerialNumber Property
  kind: Property
  slug: serial-number-property-80279
  path: fsreqReceiveASN.SerialNumber_Property.md
---

# fsreqReceiveASN Class

Receives material based on a serial number from an ASN file that has been loaded into FabSuite.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqReceiveASN

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqReceiveASN : fsreqCommand
```

The fsreqReceiveASN type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqReceiveASN](fsreqReceiveASN_Constructor.md) | Initializes a new instance of the fsreqReceiveASN class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Location](fsreqReceiveASN.Location_Property.md) | The location to receive the material to. |
| Public property | [ReceivingNotes](fsreqReceiveASN.ReceivingNotes_Property.md) | Notes related to the receipt. |
| Public property | [ReceivingRemarks](fsreqReceiveASN.ReceivingRemarks_Property.md) | Remarks to associate with the received material. |
| Public property | [SecondaryLocation](fsreqReceiveASN.SecondaryLocation_Property.md) | The secondary location to receive the material to. |
| Public property | [SerialNumber](fsreqReceiveASN.SerialNumber_Property.md) | Serial # on the received material, must exist on an ASN that has been loaded into FabSuite. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
