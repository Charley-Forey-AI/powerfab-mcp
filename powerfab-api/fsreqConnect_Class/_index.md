---
title: fsreqConnect Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-connect-class-77660
slug: fsreq-connect-class-77660
node_id: 77660
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqConnect Class
children:
- title: fsreqConnect Constructor
  kind: Constructor
  slug: fsreq-connect-constructor-77661
  path: fsreqConnect_Constructor.md
- title: fsreqConnect.IPAddress Property
  kind: Property
  slug: ip-address-property-77663
  path: fsreqConnect.IPAddress_Property.md
- title: fsreqConnect.Password Property
  kind: Property
  slug: password-property-77664
  path: fsreqConnect.Password_Property.md
- title: fsreqConnect.PortNumber Property
  kind: Property
  slug: port-number-property-77665
  path: fsreqConnect.PortNumber_Property.md
- title: fsreqConnect.Username Property
  kind: Property
  slug: username-property-77666
  path: fsreqConnect.Username_Property.md
---

# fsreqConnect Class

Establishes a connection to the FabSuite database. Cannot be called through a remote connection

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqConnect

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqConnect : fsreqCommand
```

The fsreqConnect type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqConnect](fsreqConnect_Constructor.md) | Initializes a new instance of the fsreqConnect class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [IPAddress](fsreqConnect.IPAddress_Property.md) | IP Address or computer name of the FabSuite database server. |
| Public property | [Password](fsreqConnect.Password_Property.md) | Password for the user. |
| Public property | [PortNumber](fsreqConnect.PortNumber_Property.md) | Port that the FabSuite database server is listening on (default - 3306). |
| Public property | [Username](fsreqConnect.Username_Property.md) | Username to log in with. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
