---
title: fsreqDepartment_Upsert Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-departmentupsert-class-77746
slug: fsreq-departmentupsert-class-77746
node_id: 77746
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqDepartment_Upsert Class
children:
- title: fsreqDepartment_Upsert Constructor
  kind: Constructor
  slug: fsreq-departmentupsert-constructor-77747
  path: fsreqDepartment_Upsert_Constructor.md
- title: fsreqDepartment_Upsert.DepartmentID Property
  kind: Property
  slug: department-id-property-77749
  path: fsreqDepartment_Upsert.DepartmentID_Property.md
- title: fsreqDepartment_Upsert.DepartmentNumber Property
  kind: Property
  slug: department-number-property-77750
  path: fsreqDepartment_Upsert.DepartmentNumber_Property.md
- title: fsreqDepartment_Upsert.Name Property
  kind: Property
  slug: name-property-77751
  path: fsreqDepartment_Upsert.Name_Property.md
---

# fsreqDepartment_Upsert Class

Inserts or updates into Tekla PowerFab Department

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqDepartment\_Upsert

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqDepartment_Upsert : fsreqCommand
```

The fsreqDepartment\_Upsert type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqDepartment\_Upsert](fsreqDepartment_Upsert_Constructor.md) | Initializes a new instance of the fsreqDepartment\_Upsert class |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [DepartmentID](fsreqDepartment_Upsert.DepartmentID_Property.md) | DepartmentID |
| Public property | [DepartmentNumber](fsreqDepartment_Upsert.DepartmentNumber_Property.md) | DepartmentNumber |
| Public property | [Name](fsreqDepartment_Upsert.Name_Property.md) | Name of Department |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
