---
title: 'Code example: SaveNest (saving a nest) with Future Remnants'
url: https://developer.tekla.com/documentation/code-example-savenest-saving-future-remnants
slug: code-example-savenest-saving-future-remnants
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: SaveNest (saving a nest) with Future Remnants'
updated: 4 Dec 2025
---

# Code example: SaveNest (saving a nest) with Future Remnants

## Future Remnants in PowerFab

Tekla PowerFab now includes the ability to nest onto a Future Remnant.  A Future Remnant is defined as the remnant of a nest that has not yet been cut.  PowerFab is now making these remnants available to the software that defined the nest, in order to allow additional parts to be added on to the remnant before cutting.

Download

[Example Program demonstrating SaveNest](https://developer.tekla.com/sites/default/files/files/download-file/file/ExternalNestingWorkflowDemo.zip "Open archive in new window")462.29 KB

### Overview

After a nest from an external software is saved (using SaveNest in our API), the nest appears in Inventory or on a Requisition.  The user can access the details of the nest and see the image that you sent through SaveNest.  On subsequent nests created through PowerFab Combining, when an external software or an extension is used, PowerFab will include these remnants in nests exported to the same software (your remnant will not be available to a different software for nesting).  They will have a type “FutureRemnant”, and the RemnantID or Name that you sent in will be included in the data, so that you can match it in your system.

To nest on to this uncut remnant, simply include the ID of the remnant in the MaterialUsed element in the next SaveNest. When this plate is cut, the first nest will be cut, and the remnant will remain nested with any parts that were saved to the future nest.

## Receiving Future Remnants in a Nesting Request

In the nesting request, future remnants created by the software that you’re sending a nest to will be included with a type “FutureRemnant”  We saw this in the video as Available Inventory from the second nest, and it looks like this in the example code.  In the WorkOrder.AvailableInventory object, Type is set to “FutureRemnant”.

How it looks in the example program:

Example of Future Remnant in the Example Porgram

The code - “FutureRemnant” is in inventoryItem.Type:

Code in Example program showing InventoryItem object and Type

### Use the new nesting export format

In order to use the new format of nesting request, which includes Future Remnants, open Administration Settings (File->Administration, then Administration->Settings), and UN-check “Use OLD FabSuite Schema in XML exports”

PowerFab Screenshot of Administration Settings

## Add a namespace override

Also, make sure to use a Namespace override.  You’ll want this too, making sure that the name of the schema for the response file you get will be forced to match what you expect.  If we update our API and change the name as part of the update, and you don’t have a Namespace override, then our update breaks your software.  We don’t want this.

Code Snipped showing NameSpace Override

### Saving to a Future Remnant

When your software has decided to nest on to a future remnant, communicate that in the SaveNest command using the “MaterialUsed” element.  For using a piece of inventory stock, you would normally send “ExternalInventoryID” or “ExternalInventoryLinkID”.  For using a future remnant, use “ParentRemnantID”, “ParentRemnantName” or “ParentRemnantPowerFabID” instead.  

Code Snippet showing ParentRemnantPowerFabID in use

ParentRemnantID, and ParentRemnantName were supplied by your software in the prior SaveNest command (If RemnantName was blank, both fields contain what you sent in “RemnantID”).  ParentRemnantPowerFabID was returned to you in the saveNest results to communicate the ID that PowerFab assigned to your remnant.  Using any of these in “MaterialUsed” is adequate to identify the remnant you want to use.  All other nesting information in SaveNest remains the same.

### Verifying results of SaveNest

SaveNest will include information on what item the nest was saved onto in its response.  Specifically “SavedTo” will contain “Inventory”, “Requisition” or now “FutureRemnant”, letting you know what actually happened.

Code Snipped showing result of Saved Nest to a Future Remnant

## Troubleshooting

API commands that you send to PowerFab with the APILog value set to “All” will be logged in PowerFab, and both the request and response can be viewed in PowerFab by going to Maintenance->Integration Settings->API Log.

Screenshot of the API Log

Here’s the code to set in your command:

Code Snipped to use API log in .CS code

## Cutting a Future Remnant

A future remnant cannot be cut in PowerFab until the prior nest that creates the remnant is cut.  To perform the cut, use TFSCut in the API (send in the externalNestID, just like you always have), or cut it from PowerFab desktop or PowerFab GO.  When a nest is cut, only the first parts are cut from the nest - NOT the parts on the remnant.  After it’s cut, the remnant, with the parts that were nested on to that future remnant remains nested in inventory, and will have to be cut with a subsequent TFSCut or user operation.

## Conclusion

We hope you find this new capability useful and profitable.  Please feel free to reach out to PowerFab support for help setting up PowerFab in order to test this functionality with your software.

Here's a video showing the use of the example program in the download.

Video file

[

](/sites/default/files/2025-10/externalnesting-futureremnants-demo_1.mp4)

And a slide deck about Future Remnants:

Document

[techme\_2025\_presentation\_-\_amy\_-\_future\_remnants.pdf](https://developer.tekla.com/sites/default/files/2025-10/techme_2025_presentation_-_amy_-_future_remnants.pdf "Open file in new window")6.56 MB
