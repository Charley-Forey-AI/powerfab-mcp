---
title: fsreqWorkPackage_OffsetFutureWorkPackage Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-work-packageoffset-future-work-package-class-80808
slug: fsreq-work-packageoffset-future-work-package-class-80808
node_id: 80808
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqWorkPackage_OffsetFutureWorkPackage Class
children:
- title: fsreqWorkPackage_OffsetFutureWorkPackage Constructor
  kind: Constructor
  slug: fsreq-work-packageoffset-future-work-package-constructor-80809
  path: fsreqWorkPackage_OffsetFutureWorkPackage_Constructor.md
- title: fsreqWorkPackage_OffsetFutureWorkPackage.FutureWorkPackageID Property
  kind: Property
  slug: future-work-package-id-property-80811
  path: fsreqWorkPackage_OffsetFutureWorkPackage.FutureWorkPackageID_Property.md
- title: fsreqWorkPackage_OffsetFutureWorkPackage.WorkPackageID Property
  kind: Property
  slug: work-package-id-property-80812
  path: fsreqWorkPackage_OffsetFutureWorkPackage.WorkPackageID_Property.md
---

# fsreqWorkPackage_OffsetFutureWorkPackage Class

Schedules one or more work packages.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqWorkPackage\_OffsetFutureWorkPackage

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqWorkPackage_OffsetFutureWorkPackage : fsreqCommand
```

The fsreqWorkPackage\_OffsetFutureWorkPackage type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqWorkPackage\_OffsetFutureWorkPackage](fsreqWorkPackage_OffsetFutureWorkPackage_Constructor.md) | fsreqWorkPackage\_OffsetFutureWorkPackage class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [FutureWorkPackageID](fsreqWorkPackage_OffsetFutureWorkPackage.FutureWorkPackageID_Property.md) | The future work packages to offset |
| Public property | [WorkPackageID](fsreqWorkPackage_OffsetFutureWorkPackage.WorkPackageID_Property.md) | The production work package |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
