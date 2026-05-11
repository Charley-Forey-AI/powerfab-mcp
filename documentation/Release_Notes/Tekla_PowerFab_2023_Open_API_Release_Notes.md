---
title: Tekla PowerFab 2023 Open API Release Notes
url: https://developer.tekla.com/documentation/tekla-powerfab-2023-open-api-release-notes
slug: tekla-powerfab-2023-open-api-release-notes
kind: Guide
section: Release notes
section_folder: Release_Notes
breadcrumb:
- Tekla PowerFab
- Tekla PowerFab 2023 Open API Release Notes
updated: 7 Feb 2024
---

# Tekla PowerFab 2023 Open API Release Notes

Check here the Tekla PowerFab 2023 Open API release notes

.

API Release Notes for updates from Tekla PowerFab 2022i SP0 to Tekla PowerFab 2023:

- .NET 6 compatibility is now available with this NuGet package: <https://www.nuget.org/packages/Tekla.PowerFab.API>. Read more [here](https://developer.tekla.com/tekla-epm/documentation/tekla-powerfab-api-update-information).
- Added SqM and SqFt to allowable designations of area
- Added CurrencyValue and CurrencyUnitValue to complex types
- Added MillAddress to Firms
- Added Country, IsShipTo, IsBillTo, and IsMill to FirmAddress fields
- Added CostCode\_Get, CostCode\_Upsert, CostCode\_Delete commands
- Added FirmAddress\_Get command
- Added CutListItemID as a parameter to GetCutList
- Added MillOfOrigin to GetInventorySummary, InventoryRemnant object in InventoryRemnant\_Upsert,
- Added ProductionControlID to GetProductionControlJobs
- Added MillOfOrigin to InventoryMove, Receive, and TFSManual commands
- Added ProductionControlLoadID to TFSManual
- Added PerformReverseTFS boolean flag to Load and ProductionControlLoadAdditionalDelete commands
- Removed ProductionControlCutListItem parameter from ProductionControlCutListItemSwapGetAvailable and  ProductionControlCutListItemSwap.
- Changed InventoryItemID from a token to an integer in ProductionControlCutListItemSwapAvailable
- Added Shape and Dimensions parameters to ProductionControlCutListItemSwapAvailable
