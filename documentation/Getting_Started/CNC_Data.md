---
title: CNC Data
url: https://developer.tekla.com/documentation/cnc-data
slug: cnc-data
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- CNC Data
updated: 13 Feb 2025
---

# CNC Data

**Description:** Retrieves CNC data from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <CNCData>
    <CNCFileID>123</CNCFileID>
    <CutListItemID>456</CutListItemID>
    <ZipFiles>true</ZipFiles>
  </CNCData>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CNCData>
    <Successful>true</Successful>
    <PieceMarkCNCData>
      <PieceMark>PM123</PieceMark>
      <CNCFile>
        <FileName>file1.nc</FileName>
        <FileContents>base64-encoded file contents</FileContents>
      </CNCFile>
      <CNCFile>
        <FileName>file2.nc</FileName>
        <FileContents>base64-encoded file contents</FileContents>
      </CNCFile>
    </PieceMarkCNCData>
    <ZippedCNCFiles>
      <FileName>cnc_data.zip</FileName>
      <FileContents>base64-encoded zip file contents</FileContents>
    </ZippedCNCFiles>
  </CNCData>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `CNCFileID` and `CutListItemID` elements are required.
- The `ZipFiles` element is optional. If it is set to true, the CNC files will be returned in a zip file.

**End of Section: CNC Data**
