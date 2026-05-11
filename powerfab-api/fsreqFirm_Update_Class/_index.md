---
title: fsreqFirm_Update Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firmupdate-class-78817
slug: fsreq-firmupdate-class-78817
node_id: 78817
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirm_Update Class
children:
- title: fsreqFirm_Update Constructor
  kind: Constructor
  slug: fsreq-firmupdate-constructor-78818
  path: fsreqFirm_Update_Constructor.md
- title: fsreqFirm_Update.Code Property
  kind: Property
  slug: code-property-78820
  path: fsreqFirm_Update.Code_Property.md
- title: fsreqFirm_Update.CreditLimit Property
  kind: Property
  slug: credit-limit-property-78821
  path: fsreqFirm_Update.CreditLimit_Property.md
- title: fsreqFirm_Update.DefaultBillToAddressID Property
  kind: Property
  slug: default-bill-address-id-property-78822
  path: fsreqFirm_Update.DefaultBillToAddressID_Property.md
- title: fsreqFirm_Update.DefaultContactID Property
  kind: Property
  slug: default-contact-id-property-78823
  path: fsreqFirm_Update.DefaultContactID_Property.md
- title: fsreqFirm_Update.DefaultCostCodeID Property
  kind: Property
  slug: default-cost-code-id-property-78824
  path: fsreqFirm_Update.DefaultCostCodeID_Property.md
- title: fsreqFirm_Update.DefaultCostTypeID Property
  kind: Property
  slug: default-cost-type-id-property-78825
  path: fsreqFirm_Update.DefaultCostTypeID_Property.md
- title: fsreqFirm_Update.DefaultMillAddressID Property
  kind: Property
  slug: default-mill-address-id-property-78826
  path: fsreqFirm_Update.DefaultMillAddressID_Property.md
- title: fsreqFirm_Update.DefaultShipToAddressID Property
  kind: Property
  slug: default-ship-address-id-property-78827
  path: fsreqFirm_Update.DefaultShipToAddressID_Property.md
- title: fsreqFirm_Update.FirmID Property
  kind: Property
  slug: firm-id-property-78828
  path: fsreqFirm_Update.FirmID_Property.md
- title: fsreqFirm_Update.FirmTypeID Property
  kind: Property
  slug: firm-type-id-property-78829
  path: fsreqFirm_Update.FirmTypeID_Property.md
- title: fsreqFirm_Update.IsSubcontractor Property
  kind: Property
  slug: subcontractor-property-78830
  path: fsreqFirm_Update.IsSubcontractor_Property.md
- title: fsreqFirm_Update.Name Property
  kind: Property
  slug: name-property-78831
  path: fsreqFirm_Update.Name_Property.md
- title: fsreqFirm_Update.Notes Property
  kind: Property
  slug: notes-property-78832
  path: fsreqFirm_Update.Notes_Property.md
- title: fsreqFirm_Update.PrimaryCurrencyID Property
  kind: Property
  slug: primary-currency-id-property-78833
  path: fsreqFirm_Update.PrimaryCurrencyID_Property.md
---

# fsreqFirm_Update Class

updates a firm.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirm\_Update

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirm_Update : fsreqCommand
```

The fsreqFirm\_Update type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirm\_Update](fsreqFirm_Update_Constructor.md) | fsreqFirm\_Update class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Code](fsreqFirm_Update.Code_Property.md) | Code of firm |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CreditLimit](fsreqFirm_Update.CreditLimit_Property.md) | Credit Limit of firm |
| Public property | [DefaultBillToAddressID](fsreqFirm_Update.DefaultBillToAddressID_Property.md) | Default Bill-To address ID |
| Public property | [DefaultContactID](fsreqFirm_Update.DefaultContactID_Property.md) | Default Contact ID |
| Public property | [DefaultCostCodeID](fsreqFirm_Update.DefaultCostCodeID_Property.md) | Default cost code of firm |
| Public property | [DefaultCostTypeID](fsreqFirm_Update.DefaultCostTypeID_Property.md) | Default cost code of firm |
| Public property | [DefaultMillAddressID](fsreqFirm_Update.DefaultMillAddressID_Property.md) | Default Mill address ID |
| Public property | [DefaultShipToAddressID](fsreqFirm_Update.DefaultShipToAddressID_Property.md) | Default Ship-To address ID |
| Public property | [FirmID](fsreqFirm_Update.FirmID_Property.md) | ID of firm to update |
| Public property | [FirmTypeID](fsreqFirm_Update.FirmTypeID_Property.md) | ID of firm type for firm |
| Public property | [IsSubcontractor](fsreqFirm_Update.IsSubcontractor_Property.md) | IsSubcontractor value of firm |
| Public property | [Name](fsreqFirm_Update.Name_Property.md) | Name of firm |
| Public property | [Notes](fsreqFirm_Update.Notes_Property.md) | Notes for firm |
| Public property | [PrimaryCurrencyID](fsreqFirm_Update.PrimaryCurrencyID_Property.md) | Currency ID of firm |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
