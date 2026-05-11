---
title: fsreqEstimateSummaryGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-estimate-summary-get-class-78400
slug: fsreq-estimate-summary-get-class-78400
node_id: 78400
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqEstimateSummaryGet Class
children:
- title: fsreqEstimateSummaryGet Constructor
  kind: Constructor
  slug: fsreq-estimate-summary-get-constructor-78401
  path: fsreqEstimateSummaryGet_Constructor.md
- title: fsreqEstimateSummaryGet.EstimateID Property
  kind: Property
  slug: estimate-id-property-78403
  path: fsreqEstimateSummaryGet.EstimateID_Property.md
---

# fsreqEstimateSummaryGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqEstimateSummaryGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqEstimateSummaryGet : fsreqCommand
```

The fsreqEstimateSummaryGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqEstimateSummaryGet](fsreqEstimateSummaryGet_Constructor.md) | fsreqEstimateSummaryGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [EstimateID](fsreqEstimateSummaryGet.EstimateID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
