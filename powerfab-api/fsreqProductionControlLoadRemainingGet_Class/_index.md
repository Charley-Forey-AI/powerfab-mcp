---
title: fsreqProductionControlLoadRemainingGet Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-production-control-load-remaining-get-class-79936
slug: fsreq-production-control-load-remaining-get-class-79936
node_id: 79936
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqProductionControlLoadRemainingGet Class
children:
- title: fsreqProductionControlLoadRemainingGet Constructor
  kind: Constructor
  slug: fsreq-production-control-load-remaining-get-constructor-79937
  path: fsreqProductionControlLoadRemainingGet_Constructor.md
- title: fsreqProductionControlLoadRemainingGet.GetOptions Property
  kind: Property
  slug: get-options-property-79939
  path: fsreqProductionControlLoadRemainingGet.GetOptions_Property.md
- title: fsreqProductionControlLoadRemainingGet.LastLogID Property
  kind: Property
  slug: last-log-id-property-79940
  path: fsreqProductionControlLoadRemainingGet.LastLogID_Property.md
- title: fsreqProductionControlLoadRemainingGet.MainMarkDisplay Property
  kind: Property
  slug: main-mark-display-property-79941
  path: fsreqProductionControlLoadRemainingGet.MainMarkDisplay_Property.md
- title: fsreqProductionControlLoadRemainingGet.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79942
  path: fsreqProductionControlLoadRemainingGet.ProductionControlID_Property.md
- title: fsreqProductionControlLoadRemainingGet.ShippedFromFirmAddressID Property
  kind: Property
  slug: shipped-firm-address-id-property-79943
  path: fsreqProductionControlLoadRemainingGet.ShippedFromFirmAddressID_Property.md
- title: fsreqProductionControlLoadRemainingGet.ShippedToFirmID Property
  kind: Property
  slug: shipped-firm-id-property-79944
  path: fsreqProductionControlLoadRemainingGet.ShippedToFirmID_Property.md
- title: fsreqProductionControlLoadRemainingGet.ShippingDestinationGroupID Property
  kind: Property
  slug: shipping-destination-group-id-property-79945
  path: fsreqProductionControlLoadRemainingGet.ShippingDestinationGroupID_Property.md
---

# fsreqProductionControlLoadRemainingGet Class

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqProductionControlLoadRemainingGet

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqProductionControlLoadRemainingGet : fsreqCommand
```

The fsreqProductionControlLoadRemainingGet type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqProductionControlLoadRemainingGet](fsreqProductionControlLoadRemainingGet_Constructor.md) | fsreqProductionControlLoadRemainingGet class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [GetOptions](fsreqProductionControlLoadRemainingGet.GetOptions_Property.md) |  |
| Public property | [LastLogID](fsreqProductionControlLoadRemainingGet.LastLogID_Property.md) |  |
| Public property | [MainMarkDisplay](fsreqProductionControlLoadRemainingGet.MainMarkDisplay_Property.md) |  |
| Public property | [ProductionControlID](fsreqProductionControlLoadRemainingGet.ProductionControlID_Property.md) |  |
| Public property | [ShippedFromFirmAddressID](fsreqProductionControlLoadRemainingGet.ShippedFromFirmAddressID_Property.md) |  |
| Public property | [ShippedToFirmID](fsreqProductionControlLoadRemainingGet.ShippedToFirmID_Property.md) |  |
| Public property | [ShippingDestinationGroupID](fsreqProductionControlLoadRemainingGet.ShippingDestinationGroupID_Property.md) |  |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
