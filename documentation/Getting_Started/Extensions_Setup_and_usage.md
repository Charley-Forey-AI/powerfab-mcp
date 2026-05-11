---
title: 'Extensions: Setup and usage'
url: https://developer.tekla.com/documentation/extensions-setup-and-usage
slug: extensions-setup-and-usage
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- 'Extensions: Setup and usage'
updated: 12 Apr 2026
---

# Extensions: Setup and usage

The functionality of Tekla PowerFab can be extended through the use of Extensions.  These are C# (.NET) programs that accept a nesting request from a combining run in PowerFab.  Here’s how to set up PowerFab to use extensions.

## PowerFab Setup

Enable the extension Directory in Administration Settings

Screenshot showing PowerFab Administration Settings

Define your Extension Folder in Default Directories

Screenshot showing PowerFab Default Directories

Put your Extension .dll file in your Extension Folder

Screenshot showing Extensions directory with dll in it

Select “Extension” as your Nesting Software in a Combining Run

Screenshot showing choosing "Extension" as the nesting software in PowerFab

Export Parts for Nesting

Screenshot showing sending a nest to an extension for nesting

## Setup in your Extension

### Use Tekla.PowerFab.Extension

In your .NET extension (C#) program, you must have a dependency on Tekla.PowerFab.Extension.dll.  Find this in the same folder as Tekla.PowerFab.exe - where the program is installed. 

External Nesting Workflow Demo Dependencies

### Implement iExtension and iNestRequest

In order to work with PowerFab, your C# extension must implement iExtension and iNestRequest.

Code Snippet of External Nesting Workflow Demo class extending IExtension and INestRequest

### (Optional) Use the PowerFab API
