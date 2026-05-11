---
title: Updating Your Extension for New PowerFab Releases
url: https://developer.tekla.com/documentation/updating-your-extension-new-powerfab-releases
slug: updating-your-extension-new-powerfab-releases
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Updating Your Extension for New PowerFab Releases
updated: 4 Nov 2025
---

# Updating Your Extension for New PowerFab Releases

When PowerFab releases a new version, your existing extensions continue working without changes. To access new API features, simply reference the updated DLL from the latest PowerFab installation directory and rebuild your program.

## To use new functionality

1. **Install the latest Tekla PowerFab**
2. **Locate the updated DLL** in the install directory:
   - Path: `Tekla.PowerFab.Interface.Extension\[your .NET version]\`
   - File: `Tekla.PowerFab.Extension.dll` (.NET 6/8) or `Tekla.EPM.Extension.dll` (.NET 4)
3. **Reference the DLL** directly from its install location (don't copy it)
4. **Rebuild your program** — new fields and commands are now available

**Note for .NET 6/8 users:** If using `Tekla.PowerFab.Extension.dll`, remove any copies of `fabsuite-xml-request-v0108.cs`, `fabsuite-xml-response-v0108.cs`, and matching `.xsd` files from your project. These are already included in the DLL.
