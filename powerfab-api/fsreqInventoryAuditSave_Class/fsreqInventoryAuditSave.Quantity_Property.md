---
title: fsreqInventoryAuditSave.Quantity Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/quantity-property-79372
slug: quantity-property-79372
node_id: 79372
kind: Property
parent: fsreqInventoryAuditSave Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-inventory-audit-save-class-79368
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqInventoryAuditSave Class
- fsreqInventoryAuditSave Properties
- fsreqInventoryAuditSave.Quantity Property
children: []
---

# fsreqInventoryAuditSave.Quantity Property

Quantity for that serial #.
If serialized then the quantity should always be 1.
Quantity greater than one for material such as bolts, nuts, washers, etc. where a single barcode serial #
represents a larger quantity of material.

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[XmlElementAttribute(DataType = "integer")]
public string Quantity { get; set; }
```

#### Property Value

Type: String

See Also

#### Reference

[fsreqInventoryAuditSave Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
