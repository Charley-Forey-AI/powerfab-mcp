---
title: fsreqFirm_Insert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-firminsert-class-78801
slug: fsreq-firminsert-class-78801
node_id: 78801
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFirm_Insert Class
children:
- title: fsreqFirm_Insert Constructor
  kind: Constructor
  slug: fsreq-firminsert-constructor-78802
  path: fsreqFirm_Insert_Constructor.md
- title: fsreqFirm_Insert.Code Property
  kind: Property
  slug: code-property-78804
  path: fsreqFirm_Insert.Code_Property.md
- title: fsreqFirm_Insert.CreditLimit Property
  kind: Property
  slug: credit-limit-property-78805
  path: fsreqFirm_Insert.CreditLimit_Property.md
- title: fsreqFirm_Insert.DefaultBillToAddressID Property
  kind: Property
  slug: default-bill-address-id-property-78806
  path: fsreqFirm_Insert.DefaultBillToAddressID_Property.md
- title: fsreqFirm_Insert.DefaultContactID Property
  kind: Property
  slug: default-contact-id-property-78807
  path: fsreqFirm_Insert.DefaultContactID_Property.md
- title: fsreqFirm_Insert.DefaultCostCodeID Property
  kind: Property
  slug: default-cost-code-id-property-78808
  path: fsreqFirm_Insert.DefaultCostCodeID_Property.md
- title: fsreqFirm_Insert.DefaultCostTypeID Property
  kind: Property
  slug: default-cost-type-id-property-78809
  path: fsreqFirm_Insert.DefaultCostTypeID_Property.md
- title: fsreqFirm_Insert.DefaultMillAddressID Property
  kind: Property
  slug: default-mill-address-id-property-78810
  path: fsreqFirm_Insert.DefaultMillAddressID_Property.md
- title: fsreqFirm_Insert.DefaultShipToAddressID Property
  kind: Property
  slug: default-ship-address-id-property-78811
  path: fsreqFirm_Insert.DefaultShipToAddressID_Property.md
- title: fsreqFirm_Insert.FirmTypeID Property
  kind: Property
  slug: firm-type-id-property-78812
  path: fsreqFirm_Insert.FirmTypeID_Property.md
- title: fsreqFirm_Insert.IsSubcontractor Property
  kind: Property
  slug: subcontractor-property-78813
  path: fsreqFirm_Insert.IsSubcontractor_Property.md
- title: fsreqFirm_Insert.Name Property
  kind: Property
  slug: name-property-78814
  path: fsreqFirm_Insert.Name_Property.md
- title: fsreqFirm_Insert.Notes Property
  kind: Property
  slug: notes-property-78815
  path: fsreqFirm_Insert.Notes_Property.md
- title: fsreqFirm_Insert.PrimaryCurrencyID Property
  kind: Property
  slug: primary-currency-id-property-78816
  path: fsreqFirm_Insert.PrimaryCurrencyID_Property.md
---

# fsreqFirm_Insert Class

Adds a new firm.

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqFirm\_Insert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqFirm_Insert : fsreqCommand
```

The fsreqFirm\_Insert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqFirm\_Insert](fsreqFirm_Insert_Constructor.md) | fsreqFirm\_Insert class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Code](fsreqFirm_Insert.Code_Property.md) | Code of new firm |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CreditLimit](fsreqFirm_Insert.CreditLimit_Property.md) | Credit Limit of new firm |
| Public property | [DefaultBillToAddressID](fsreqFirm_Insert.DefaultBillToAddressID_Property.md) | Default Bill-To address ID |
| Public property | [DefaultContactID](fsreqFirm_Insert.DefaultContactID_Property.md) | Default Contact ID |
| Public property | [DefaultCostCodeID](fsreqFirm_Insert.DefaultCostCodeID_Property.md) | Default cost code of new firm |
| Public property | [DefaultCostTypeID](fsreqFirm_Insert.DefaultCostTypeID_Property.md) | Default cost code of new firm |
| Public property | [DefaultMillAddressID](fsreqFirm_Insert.DefaultMillAddressID_Property.md) | Default Mill address ID |
| Public property | [DefaultShipToAddressID](fsreqFirm_Insert.DefaultShipToAddressID_Property.md) | Default Ship-To address ID |
| Public property | [FirmTypeID](fsreqFirm_Insert.FirmTypeID_Property.md) | ID of firm type for new firm |
| Public property | [IsSubcontractor](fsreqFirm_Insert.IsSubcontractor_Property.md) | IsSubcontractor value of new firm |
| Public property | [Name](fsreqFirm_Insert.Name_Property.md) | Name of new firm |
| Public property | [Notes](fsreqFirm_Insert.Notes_Property.md) | Notes for new firm |
| Public property | [PrimaryCurrencyID](fsreqFirm_Insert.PrimaryCurrencyID_Property.md) | Currency ID of new firm |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
