---
title: 'Code example: ShopFloorSave'
url: https://developer.tekla.com/documentation/code-example-shopfloorsave
slug: code-example-shopfloorsave
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: ShopFloorSave'
updated: 8 Sep 2023
---

# Code example: ShopFloorSave

Get code

[Tekla PowerFab API Shop Floor Save Demo](https://developer.tekla.com/sites/default/files/files/download-codefile/file/TeklaPowerFabShopFloorSaveWorkflowDemo_1.zip "Open archive in new window")486.37 KB

## Prerequisite

Start with the project outlined in the [Connect Tekla PowerFab database remotely](Code_example_Connect_Tekla_PowerFab_database_remotely.md) article and video.

### Update Production Status in Tekla PowerFab

The download link above takes to you a Microsoft Visual Studio project of a simple program that

1. Connects remotely to the Tekla PowerFab database
2. Retrieves a list of Production Control jobs and IDs
3. Retrieve a list of Stations and a list of parts ready for each station
4. Update Production Status when a station has been completed for a part or assembly

This workflow is particularly useful for stations that don't directly affect inventory, such as a welding station, assembly station, or paint station.

[Follow along with an overview of the ShopFloorSave workflow with this video](https://youtu.be/AS_I96iqLK4).
