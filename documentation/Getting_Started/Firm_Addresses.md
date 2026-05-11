---
title: Firm Addresses
url: https://developer.tekla.com/documentation/firm-addresses
slug: firm-addresses
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Firm Addresses
updated: 13 Feb 2025
---

# Firm Addresses

### **FirmAddress\_Get**

**Description:** Retrieves a specific firm address from Tekla PowerFab. [cite: 38]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmAddress_Get>
    <FirmAddressID>123</FirmAddressID>
  </FirmAddress_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmAddress_Get>
    <Successful>true</Successful>
    <FirmAddress>
      <FirmAddressID>123</FirmAddressID>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
  </FirmAddress_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command. [cite: 11]

reqPowerFabAPI.fsreqFirmAddress_Get getFirmAddressCommand = new reqPowerFabAPI.fsreqFirmAddress_Get();
getFirmAddressCommand.FirmAddressID = "123";

request.FirmAddress_Get = new List<reqPowerFabAPI.fsreqFirmAddress_Get>();
request.FirmAddress_Get.Add(getFirmAddressCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the FirmAddress_Get response object and check if it was successful
    resPowerFabAPI.fsresFirmAddress_Get getFirmAddressResponse = response.FirmAddress_Get.First();
    if (!getFirmAddressResponse.Successful)
        MessageBox.Show(getFirmAddressResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the firm address
        resPowerFabAPI.fsresFirmAddress firmAddress = getFirmAddressResponse.FirmAddress.First();
        MessageBox.Show("Firm Address ID:" + firmAddress.FirmAddressID.ToString() + ", Firm ID: " + firmAddress.FirmID.ToString() +
            ", Address 1: " + firmAddress.Address1 +
            ", City: " + firmAddress.City +
            ", State: " + firmAddress.State +
            ", Zip: " + firmAddress.Zip +
            ", Country: " + firmAddress.Country +
            ", Is Ship To: " + firmAddress.IsShipTo.ToString());
    }
}
```

**Notes:**

- The `FirmAddressID` element is required. [cite: 38]

### **FirmAddresses\_Get**

**Description:** Retrieves all firm addresses from Tekla PowerFab. [cite: 39]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmAddresses_Get/>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmAddresses_Get>
    <Successful>true</Successful>
    <FirmAddress>
      <FirmAddressID>123</FirmAddressID>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
    <FirmAddress>
      <FirmAddressID>456</FirmAddressID>
      <FirmID>789</FirmID>
      <Address1>456 Oak Avenue</Address1>
      <City>Otherville</City>
      <State>NY</State>
      <Zip>67890</Zip>
      <Country>USA</Country>
      <IsShipTo>false</IsShipTo>
    </FirmAddress>
  </FirmAddresses_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command. [cite: 11]

reqPowerFabAPI.fsreqFirmAddresses_Get getFirmAddressesCommand = new reqPowerFabAPI.fsreqFirmAddresses_Get();

request.FirmAddresses_Get = new List<reqPowerFabAPI.fsreqFirmAddresses_Get>();
request.FirmAddresses_Get.Add(getFirmAddressesCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the FirmAddresses_Get response object and check if it was successful
    resPowerFabAPI.fsresFirmAddresses_Get getFirmAddressesResponse = response.FirmAddresses_Get.First();
    if (!getFirmAddressesResponse.Successful)
        MessageBox.Show(getFirmAddressesResponse.ErrorMessage); //command failed
    else
    {
        // command successful, show the firm addresses
        List<resPowerFabAPI.fsresFirmAddress> firmAddresses = getFirmAddressesResponse.FirmAddress;
        string firmAddressesString = "";
        foreach (resPowerFabAPI.fsresFirmAddress firmAddress in firmAddresses)
        {
            firmAddressesString += "Firm Address ID:" + firmAddress.FirmAddressID.ToString() + ", Firm ID: " + firmAddress.FirmID.ToString() +
                ", Address 1: " + firmAddress.Address1 +
                ", City: " + firmAddress.City +
                ", State: " + firmAddress.State +
                ", Zip: " + firmAddress.Zip +
                ", Country: " + firmAddress.Country +
                ", Is Ship To: " + firmAddress.IsShipTo.ToString() + Environment.NewLine;
        }
        MessageBox.Show(firmAddressesString);
    }
}
```

**Notes:**

- You can use filters to limit the firm addresses returned. [cite: 39]

### **FirmAddress\_Insert**

**Description:** Inserts a new firm address into Tekla PowerFab. [cite: 40]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmAddress_Insert>
    <FirmAddress>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
  </FirmAddress_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmAddress_Insert>
    <Successful>true</Successful>
    <FirmAddress>
      <FirmAddressID>123</FirmAddressID>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
  </FirmAddress_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmID`, `Address1`, `City`, `State`, `Zip`, `Country`, and `IsShipTo` elements are required. [cite: 40]

### **FirmAddress\_Update**

**Description:** Updates an existing firm address in Tekla PowerFab. [cite: 41]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmAddress_Update>
    <FirmAddress>
      <FirmAddressID>123</FirmAddressID>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
  </FirmAddress_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmAddress_Update>
    <Successful>true</Successful>
    <FirmAddress>
      <FirmAddressID>123</FirmAddressID>
      <FirmID>456</FirmID>
      <Address1>123 Main Street</Address1>
      <City>Anytown</City>
      <State>CA</State>
      <Zip>12345</Zip>
      <Country>USA</Country>
      <IsShipTo>true</IsShipTo>
    </FirmAddress>
  </FirmAddress_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmAddressID`, `FirmID`, `Address1`, `City`, `State`, `Zip`, `Country`, and `IsShipTo` elements are required. [cite: 41]

### **FirmAddress\_Delete**

**Description:** Deletes one or more firm addresses from Tekla PowerFab. [cite: 42]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmAddress_Delete>
    <FirmAddressID>123</FirmAddressID>
    <FirmAddressID>456</FirmAddressID>
  </FirmAddress_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmAddress_Delete>
    <Successful>true</Successful>
  </FirmAddress_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `FirmAddressID` element is required. [cite: 42]

**End of Section: Firm Addresses**
