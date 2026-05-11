---
title: 'Code example: Unlocking Enhanced Integration by Creating a Work Order and Nesting Extension for Tekla PowerFab'
url: https://developer.tekla.com/documentation/code-example-external-nesting-extension
slug: code-example-external-nesting-extension
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Unlocking Enhanced Integration by Creating a Work Order and Nesting Extension for Tekla PowerFab'
updated: 19 Jul 2025
---

# Code example: Unlocking Enhanced Integration by Creating a Work Order and Nesting Extension for Tekla PowerFab

*This example program and accompanying video demonstration are designed to guide you through the process of developing a powerful Extension for Tekla PowerFab. This extension will establish a seamless, bidirectional connection between PowerFab and your nesting software, significantly streamlining your fabrication workflow.*

*By leveraging the Tekla PowerFab Extensions API, you can bridge the gap between your optimized nesting strategies and PowerFab's robust material management and production tracking capabilities. This integration empowers you to automate critical steps, reduce manual data entry, and maintain real-time accuracy across your projects.*

Get code

[Extension Demo Code](https://developer.tekla.com/sites/default/files/files/download-codefile/file/ExternalNestingWorkflowDemo%20-%20dotNET8_0.zip "Open archive in new window")776.54 KB

[This video](https://youtu.be/tjvlAFaVUIU?si=fC_rXyepko8g0A-3) and [example program](https://developer.tekla.com/tekla-powerfab/tekla-powerfab-open-api-documentation#code-examples) will meticulously demonstrate how to:

- **Enable and Configure Extensions within Tekla PowerFab:** Learn the foundational steps to activate and set up the Extensions environment within your PowerFab instance, preparing it for custom integrations.
- **Develop a Custom Extension for Enhanced Tekla PowerFab Integration:** Gain practical insights into the structure and principles of creating an Extension, tailored to improve the efficiency and accuracy of your PowerFab operations.
- **Automate Nesting Data Transfer with** `SaveNest`**:** Discover how to programmatically execute a `SaveNest` operation directly from your nesting software. This crucial step will not only save your optimized nests to PowerFab but also intelligently reserve existing inventory and/or automatically create requisitions for any required material that is not in stock.
- **Record Piecetracking Hours:** Understand how to submit piecetracking hours directly from your nesting software or an external application. This allows for accurate real-time labor tracking associated with the nesting and cutting process, providing valuable data for cost analysis and production efficiency. The example program will illustrate how to send this time-tracking information back to PowerFab, linking it to specific pieces or assemblies.
- **Streamline Production Tracking with** `TFSCut`**:** Understand how to utilize the `TFSCut` function to process a "Take From Stock" action within PowerFab. This effectively marks your nest as "cut," triggers updates to the production status of all associated parts, and provides accurate real-time visibility into the fabricatior's manufacturing progress.

This resource will empower you to unlock new levels of efficiency and data synchronization, transforming your clients' fabrication processes by tightly integrating your nesting software with the powerful capabilities of Tekla PowerFab.
