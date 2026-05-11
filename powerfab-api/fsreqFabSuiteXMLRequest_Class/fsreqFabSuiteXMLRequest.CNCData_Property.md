---
title: fsreqFabSuiteXMLRequest.CNCData Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/cnc-data-property-78442
slug: cnc-data-property-78442
node_id: 78442
kind: Property
parent: fsreqFabSuiteXMLRequest Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-fab-suite-xml-request-class-78437
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqFabSuiteXMLRequest Class
- fsreqFabSuiteXMLRequest Properties
- fsreqFabSuiteXMLRequest.CNCData Property
children: []
---

# fsreqFabSuiteXMLRequest.CNCData Property

Retrieves the CNC data for the specified parts.
An XMLWarning element will be included in the response if no CNC file has been loaded for a requested piece mark.

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[XmlElementAttribute("CNCData")]
public List<fsreqCNCData> CNCData { get; set; }
```

#### Property Value

Type: List&lt;[fsreqCNCData](../fsreqCNCData_Class/_index.md)&gt;

See Also

#### Reference

[fsreqFabSuiteXMLRequest Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
