---
title: Assemblies
url: https://developer.tekla.com/documentation/assemblies
slug: assemblies
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Assemblies
updated: 19 Feb 2025
---

# Assemblies

## **Assemblies**

- `GetAssemblies` Description: Retrieves assemblies from Tekla PowerFab.

**Request (XML)**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <GetAssemblies>
  <JobNumber>your_job_number</JobNumber>
  </GetAssemblies>
</FabSuiteXMLRequest>
```

**Response (XML)**

```
<FabSuiteXMLResponse>
<GetAssemblies>
  <Successful>true</Successful>
  <Assembly>
    <AssemblyID>123</AssemblyID>
    <AssemblyName>Assembly 1</AssemblyName>
  </Assembly>
  <Assembly>
    <AssemblyID>456</AssemblyID>
    <AssemblyName>Assembly 2</AssemblyName>
  </Assembly>
</GetAssemblies>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- You can use filters to limit the assemblies returned.
