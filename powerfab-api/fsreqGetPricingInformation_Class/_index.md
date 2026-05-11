---
title: fsreqGetPricingInformation Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-pricing-information-class-79175
slug: fsreq-get-pricing-information-class-79175
node_id: 79175
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetPricingInformation Class
children:
- title: fsreqGetPricingInformation Constructor
  kind: Constructor
  slug: fsreq-get-pricing-information-constructor-79176
  path: fsreqGetPricingInformation_Constructor.md
- title: fsreqGetPricingInformation.Filters Property
  kind: Property
  slug: filters-property-79178
  path: fsreqGetPricingInformation.Filters_Property.md
- title: fsreqGetPricingInformation.JobNumber Property
  kind: Property
  slug: job-number-property-79179
  path: fsreqGetPricingInformation.JobNumber_Property.md
---

# fsreqGetPricingInformation Class

Retrieves pricing information for the whole system or one job.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetPricingInformation

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetPricingInformation : fsreqCommand
```

The fsreqGetPricingInformation type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetPricingInformation](fsreqGetPricingInformation_Constructor.md) | fsreqGetPricingInformation class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetPricingInformation.Filters_Property.md) | Nested Filters elements are supported. |
| Public property | [JobNumber](fsreqGetPricingInformation.JobNumber_Property.md) | The job to retrieve the information from. If no JobNumber is specified then pricing for the whole system will be returned. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
