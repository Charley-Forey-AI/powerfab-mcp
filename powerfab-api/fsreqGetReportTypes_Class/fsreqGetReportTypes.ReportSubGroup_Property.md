---
title: fsreqGetReportTypes.ReportSubGroup Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/report-sub-group-property-79259
slug: report-sub-group-property-79259
node_id: 79259
kind: Property
parent: fsreqGetReportTypes Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-report-types-class-79255
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetReportTypes Class
- fsreqGetReportTypes Properties
- fsreqGetReportTypes.ReportSubGroup Property
children: []
---

# fsreqGetReportTypes.ReportSubGroup Property

The report sub-group from which to retrieve the available reports.
Must match an available sub-group for the given ReportGroup:
Inspection
- Test Record
- Test Record (Field)
- Test Record (Field Summary)
ProductionControlShippingTicket
- Shipping Ticket

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[XmlElementAttribute("ReportSubGroup", DataType = "token")]
public List<string> ReportSubGroup { get; set; }
```

#### Property Value

Type: List&lt;String&gt;

See Also

#### Reference

[fsreqGetReportTypes Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
