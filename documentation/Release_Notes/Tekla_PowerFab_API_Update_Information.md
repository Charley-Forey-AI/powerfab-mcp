---
title: Tekla PowerFab API Update Information
url: https://developer.tekla.com/documentation/tekla-powerfab-api-update-information
slug: tekla-powerfab-api-update-information
kind: Guide
section: Release notes
section_folder: Release_Notes
breadcrumb:
- Tekla PowerFab
- Tekla PowerFab API Update Information
updated: 16 Dec 2022
---

# Tekla PowerFab API Update Information

#### A new Tekla.PowerFab.API C# SDK project is now available that targets multiple .NET versions (3.5, 4.0, 4.5.2, 4.6.2, 4.7.2, 4.8, 6.0) in a Nuget package.

Minor code changes will be required when switching from FabSuiteAPI.dll to Tekla.PowerFab.API.dll:

Initializing the API goes from:

```
FabSuite.FabSuiteAPI.IFabSuiteAPI api = new FabSuite.FabSuiteAPI.FabSuiteAPI();
```

to:

```
TeklaPowerFab.TeklaPowerFabAPI.ITeklaPowerFabAPI api = new TeklaPowerFab.TeklaPowerFabAPI.TeklaPowerFabAPI();
```

Also the names of the functions use to execute the requests have changed:

- FabSuiteXML -> ExecuteDirect
- FabSuiteXML\_TCP -> ExecuteRemote

Tekla.PowerFab.API is available on nuget.org.
