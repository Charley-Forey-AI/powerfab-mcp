---
title: Firms
url: https://developer.tekla.com/documentation/firms
slug: firms
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Firms
updated: 13 Feb 2025
---

# Firms

### **Firm\_Get**

**Description:** Retrieves firms from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Firm_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Firm_Get>
    <Successful>true</Successful>
    <Firm>
      <FirmID>123</FirmID>
      <FirmName>Firm 1</FirmName>
    </Firm>
    <Firm>
      <FirmID>456</FirmID>
      <FirmName>Firm 2</FirmName>
    </Firm>
  </Firm_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

reqPowerFabAPI.fsreqFirm_Get getFirmsCommand = new reqPowerFabAPI.fsreqFirm_Get();

request.Firm_Get = new List<reqPowerFabAPI.fsreqFirm_Get>();
request.Firm_Get.Add(getFirmsCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the Firm_Get response object and check if it was successful
    resPowerFabAPI.fsresFirm_Get getFirmsResponse = response.Firm_Get.First();
    if (!getFirmsResponse.Successful)
        MessageBox.Show(getFirmsResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the firms
        List<resPowerFabAPI.fsresFirm> firms = getFirmsResponse.Firm;
        string firmsString = "";
        foreach (resPowerFabAPI.fsresFirm firm in firms)
        {
            firmsString += "Firm ID:" + firm.FirmID.ToString() + ", Firm Name: " + firm.FirmName + Environment.NewLine;
        }
        MessageBox.Show(firmsString);
    }
}
```

**Notes:**

- You can use filters to limit the firms returned.

### **Firm\_Insert**

**Description:** Inserts a new firm into Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Firm_Insert>
    <Firm>
      <FirmName>Firm 1</FirmName>
    </Firm>
  </Firm_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Firm_Insert>
    <Successful>true</Successful>
    <Firm>
      <FirmID>123</FirmID>
      <FirmName>Firm 1</FirmName>
    </Firm>
  </Firm_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmName` element is required.

### **Firm\_Update**

**Description:** Updates an existing firm in Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Firm_Update>
    <Firm>
      <FirmID>123</FirmID>
      <FirmName>Firm 1</FirmName>
    </Firm>
  </Firm_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Firm_Update>
    <Successful>true</Successful>
    <Firm>
      <FirmID>123</FirmID>
      <FirmName>Firm 1</FirmName>
    </Firm>
  </Firm_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmID` and `FirmName` elements are required.

### **Firm\_Delete**

**Description:** Deletes one or more firms from Tekla PowerFab.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <Firm_Delete>
    <FirmID>123</FirmID>
    <FirmID>456</FirmID>
  </Firm_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <Firm_Delete>
    <Successful>true</Successful>
  </Firm_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `FirmID` element is required.

**End of Section: Firms**
