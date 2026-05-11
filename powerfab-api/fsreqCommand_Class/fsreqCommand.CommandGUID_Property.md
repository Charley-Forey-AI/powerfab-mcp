---
title: fsreqCommand.CommandGUID Property
url: https://developer.tekla.com/doc/tekla-powerfab/2026/command-guid-property-77658
slug: command-guid-property-77658
node_id: 77658
kind: Property
parent: fsreqCommand Class
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-command-class-77654
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqCommand Class
- fsreqCommand Properties
- fsreqCommand.CommandGUID Property
children: []
---

# fsreqCommand.CommandGUID Property

A GUID identifying this particular XML command.
If a command fails due to a communication failure the client has no way of knowing
if it has been processed.
Each command that makes changes (as opposed to just retrieving data) will check the
CommandGUID against the GUIDs that have already been processed. If the GUID has
already been processed then it will not be re-processed and instead return with an
error. This allows the client to saftely re-try a failed command without risking
unintended changes.

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[XmlElementAttribute(DataType = "token")]
public string CommandGUID { get; set; }
```

#### Property Value

Type: String

See Also

#### Reference

[fsreqCommand Class](_index.md)

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
