---
title: fsreqGetStations Class
url: https://developer.tekla.com/doc/tekla-powerfab/2026/fsreq-get-stations-class-79282
slug: fsreq-get-stations-class-79282
node_id: 79282
kind: Class
parent: FabSuiteRequestApi Namespace
parent_url: https://developer.tekla.com/doc/tekla-powerfab/2026/fab-suite-request-api-77584
breadcrumb:
- FabSuiteRequestApi Namespace
- fsreqGetStations Class
children:
- title: fsreqGetStations Constructor
  kind: Constructor
  slug: fsreq-get-stations-constructor-79283
  path: fsreqGetStations_Constructor.md
- title: fsreqGetStations.Filters Property
  kind: Property
  slug: filters-property-79285
  path: fsreqGetStations.Filters_Property.md
- title: fsreqGetStations.IncludeCompleted Property
  kind: Property
  slug: include-completed-property-79286
  path: fsreqGetStations.IncludeCompleted_Property.md
- title: fsreqGetStations.IncludeIfPreviousStationNotCompleted Property
  kind: Property
  slug: include-if-previous-station-not-completed-property-79287
  path: fsreqGetStations.IncludeIfPreviousStationNotCompleted_Property.md
- title: fsreqGetStations.IncludeRemaining Property
  kind: Property
  slug: include-remaining-property-79288
  path: fsreqGetStations.IncludeRemaining_Property.md
- title: fsreqGetStations.JobNumber Property
  kind: Property
  slug: job-number-property-79289
  path: fsreqGetStations.JobNumber_Property.md
- title: fsreqGetStations.ProductionControlID Property
  kind: Property
  slug: production-control-id-property-79290
  path: fsreqGetStations.ProductionControlID_Property.md
- title: fsreqGetStations.StationName Property
  kind: Property
  slug: station-name-property-79291
  path: fsreqGetStations.StationName_Property.md
- title: fsreqGetStations.Type Property
  kind: Property
  slug: type-property-79292
  path: fsreqGetStations.Type_Property.md
---

# fsreqGetStations Class

Retrieves the completed/remaining status and details by station.
Either ProductionControlID or JobNumber must be specified.
This command can be used a few different ways:
1. Retrieve the list of stations.
IncludeCompleted = false, IncludeRemaining = false
3. Retrieve the details of the completed material for each station.
IncludeCompleted = true, IncludeRemaining = false
4. Retrieve the details of the remaining material for each station.
IncludeCompleted = false, IncludeRemaining = true

Inheritance Hierarchy

System.Object  
  [FabSuiteRequestApi.fsreqCommand](../fsreqCommand_Class/_index.md)  
    FabSuiteRequestApi.fsreqGetStations

**Namespace:**
 [FabSuiteRequestApi](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)  
**Assembly:**
 FabSuiteRequestApi (in FabSuiteRequestApi.dll) Version: 1.0.0.0 (1.0.0.0)

Syntax

C#

```
[SerializableAttribute]
[XmlTypeAttribute(Namespace = "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd")]
public class fsreqGetStations : fsreqCommand
```

The fsreqGetStations type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [fsreqGetStations](fsreqGetStations_Constructor.md) | fsreqGetStations class constructor |

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [APILog](../fsreqCommand_Class/fsreqCommand.APILog_Property.md) | Indicates if this command should be logged to the database. The command must be of a type that supports logging to the database in order to take effect. Currently the commands supporting this option are: TFSCut (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [CommandGUID](../fsreqCommand_Class/fsreqCommand.CommandGUID_Property.md) | A GUID identifying this particular XML command. If a command fails due to a communication failure the client has no way of knowing if it has been processed. Each command that makes changes (as opposed to just retrieving data) will check the CommandGUID against the GUIDs that have already been processed. If the GUID has already been processed then it will not be re-processed and instead return with an error. This allows the client to saftely re-try a failed command without risking unintended changes. (Inherited from [fsreqCommand](../fsreqCommand_Class/_index.md).) |
| Public property | [Filters](fsreqGetStations.Filters_Property.md) | Optional filter object to filter results returned. |
| Public property | [IncludeCompleted](fsreqGetStations.IncludeCompleted_Property.md) | Indicates if the details of the completed material should be retrieved. |
| Public property | [IncludeIfPreviousStationNotCompleted](fsreqGetStations.IncludeIfPreviousStationNotCompleted_Property.md) | Indicates if the details of the stations should be included when they have not completed the previous station. |
| Public property | [IncludeRemaining](fsreqGetStations.IncludeRemaining_Property.md) | Indicates if the details of the remaining material should be retrieved. |
| Public property | [JobNumber](fsreqGetStations.JobNumber_Property.md) | The JobNumber of the job to retrieve the status of. |
| Public property | [ProductionControlID](fsreqGetStations.ProductionControlID_Property.md) | The ProductionControlID of the job to retrieve the status of. |
| Public property | [StationName](fsreqGetStations.StationName_Property.md) | The station to restrict the result to. If this element is not specified then information from all stations will be retrieved. |
| Public property | [Type](fsreqGetStations.Type_Property.md) | The station type to restrict the results to. If this element is not specified then information from all stations of all types will be retrieved. |

See Also

#### Reference

[FabSuiteRequestApi Namespace](https://developer.tekla.com/topic/en/21/50/ed077099-d6b1-2530-8df9-7430abf615b0)
