---
title: fsreqIntermediateCompanyCodes Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-intermediate-company-codes-class-79354
slug: fsreq-intermediate-company-codes-class-79354
node_id: 79354
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqIntermediateCompanyCodes Class
children:
- title: fsreqIntermediateCompanyCodes Constructor
  kind: Constructor
  slug: fsreq-intermediate-company-codes-constructor-79355
  path: fsreqIntermediateCompanyCodes_Constructor.md
- title: fsreqIntermediateCompanyCodes.JobNumber Property
  kind: Property
  slug: job-number-property-79357
  path: fsreqIntermediateCompanyCodes.JobNumber_Property.md
---

# fsreqIntermediateCompanyCodes Class

Retrieves the valid company codes for intermediate shipping that the specified job contains.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqIntermediateCompanyCodes

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqIntermediateCompanyCodes : fsreqCommand
```

The fsreqIntermediateCompanyCodes type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqIntermediateCompanyCodes](fsreqIntermediateCompanyCodes_Constructor.md) | Initializes a new instance of the fsreqIntermediateCompanyCodes class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [JobNumber](fsreqIntermediateCompanyCodes.JobNumber_Property.md) | The JobNumber of the job to retrieve the intermediate shipping company codes. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
