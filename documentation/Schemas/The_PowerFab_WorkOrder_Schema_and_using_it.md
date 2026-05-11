---
title: The PowerFab WorkOrder Schema and using it
url: https://developer.tekla.com/documentation/workorder-schema-usage
slug: workorder-schema-usage
kind: Guide
section: Schemas
section_folder: Schemas
breadcrumb:
- Tekla PowerFab
- The PowerFab WorkOrder Schema and using it
updated: 23 Oct 2025
---

# The PowerFab WorkOrder Schema and using it

Tekla PowerFab 2025i support for future remnants introduces a new schema for the XML export of a work order.  The old schema was called FabSuiteWorkOrder0102.xsd, and the new one is called PowerFabWorkOrder.xsd.  This article shows the differences between the two.

In order to use the new schema for exports, uncheck “Use OLD FabSuite Schema in XML exports”.  This is found in File->Administration, then Administration->Settings.

Screenshot showing PowerFab Administration settings

The changes between the old and new schemas for exporting an XML Nesting request are as follows:

In the root element:

- Destination - the name of the software intended to consume this file (added)

Within the AvailableInventory element:

- BasePrice (unused and removed)
- ExternalRemnantID (unused and removed, now use RemnantName)
- FabSuiteRemnantID (replaced with RemnantPowerFabID)
- GUID (unused and removed)
- ShapeID, GradeID, SizeID (removed, internal only)
- CostCode, CostType (added)
- RemnantDefinitionFilename (added)
- RemnantPowerFabID, RemnantFabSuiteID, RemnantID (duplicate info, replacement for FabSuiteRemnantID)
- RemnantName (added - the name or ID given to the remnant by the software who created the remnant)

Within the WorkOrderPart element:

- FabSuiteID (removed, internal only)
- ModelingSoftwareID (removed, internal only)
- DrawingNumber (added)
- MillOfOrigin (added)
- WorkPackageNumber (added)
