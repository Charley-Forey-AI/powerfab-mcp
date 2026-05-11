---
title: Connection Management
url: https://developer.tekla.com/documentation/connection-management
slug: connection-management
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Connection Management
updated: 13 Feb 2025
---

# Connection Management

### **ConnectRemote**

**Description:** Establishes a connection to the Tekla PowerFab Remote Server service.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectRemote>
    <Username>your_username</Username>
    <Password>your_password</Password>
  </ConnectRemote>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <ConnectRemote>
    <Successful>true</Successful>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
  </ConnectRemote>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();

//declare and populate the ConnectRemote command object
reqPowerFabAPI.fsreqConnectRemote connectRemoteCommand = new reqPowerFabAPI.fsreqConnectRemote();
connectRemoteCommand.Username = username;
connectRemoteCommand.Password = password;

//set the ConnectRemote command object in the request object
request.ConnectRemote = new List<reqPowerFabAPI.fsreqConnectRemote>();
request.ConnectRemote.Add(connectRemoteCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the ConnectRemote response object and check if it was successful
    resPowerFabAPI.fsresConnectRemote connectRemoteResponse = response.ConnectRemote.First();
    if (!connectRemoteResponse.Successful)
        MessageBox.Show(connectRemoteResponse.ErrorMessage); //command failed
    else
    {
        //The command was successful, grab the ConnectionGUID
        connectionGUID = connectRemoteResponse.ConnectionGUID; //save this value as it is used for all subsequent commands.
        MessageBox.Show("ConnectionGUID: " + connectionGUID);
    }
}
```

**Notes:**

- The `Username` and `Password` elements are required.
- The `ConnectionGUID` element in the response is required for all subsequent API calls.

### **CloseRemote**

**Description:** Closes the connection to the Tekla PowerFab Remote Server service.

**Request:**

```
<FabSuiteXMLRequest>
  <CloseRemote>
  </CloseRemote>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <CloseRemote>
    <Successful>true</Successful>
  </CloseRemote>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

//declare and populate the CloseRemote command object
reqPowerFabAPI.fsreqCloseRemote command = new reqPowerFabAPI.fsreqCloseRemote();

request.CloseRemote = new List<reqPowerFabAPI.fsreqCloseRemote>();
request.CloseRemote.Add(command);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the CloseRemote response object and check if it was successful
    resPowerFabAPI.fsresCloseRemote closeRemoteResponse = response.CloseRemote.First();
    if (!closeRemoteResponse.Successful)
        MessageBox.Show(closeRemoteResponse.ErrorMessage); //command failed
    else
    {
        connectionGUID = ""; // clear the connectionGUID now that we have disconnected.
        MessageBox.Show("disconnected successfully");
    }
}
```

**Notes:**

- It is good practice to close the connection when it is no longer needed.

**End of Section: Connection Management**
