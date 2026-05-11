---
title: Extension
url: https://developer.tekla.com/documentation/extension
slug: extension
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Extension
updated: 13 Feb 2025
---

# Extension

The TeklaPowerFabExternalNestingWorkflowDemo code example program and video demonstration will help you get started creating an Extension for Tekla PowerFab to establish a connection between PowerFab and your own nesting software. [cite: 140]

The video and example program will demonstrate how to:

- Enable Extensions in Tekla PowerFab [cite: 140]
- Create an Extension to improve your integration with Tekla PowerFab [cite: 140]
- Perform a SaveNest from your nesting software, to save your nest to PowerFab, reserve inventory and/or create a requisition to order required material. [cite: 141]
- Perform a TFSCut, to process a Take From Stock in PowerFab, effectively marking the nest as cut and updating production status of the parts [cite: 142]

Link to the video: <https://youtu.be/tjvlAFaVUIU> [cite: 143]

### **ExtensionCommand**

**Description:** Executes an extension command in Tekla PowerFab. [cite: 139]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <ExtensionCommand>
    <ExtensionName>MyExtension</ExtensionName>
    <CommandName>MyCommand</CommandName>
    <CommandParameters>
      <Parameter>
        <Name>param1</Name>
        <Value>value1</Value>
      </Parameter>
      <Parameter>
        <Name>param2</Name>
        <Value>value2</Value>
      </Parameter>
    </CommandParameters>
  </ExtensionCommand>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <ExtensionCommand>
    <Successful>true</Successful>
    <CommandResult>
      <Result>Success</Result>
      <Message>Command executed successfully.</Message>
    </CommandResult>
  </ExtensionCommand>
</FabSuiteXMLResponse>
```

**Code Example:**

```
//The following example is a very simple example of how to use the ExtensionCommand API call.
//This example assumes you have a PowerFab Extension installed that has a command named "MyCommand".
//This command takes two parameters: "param1" and "param2".

//declare the request object
reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
request.ConnectionGUID = connectionGUID; // make sure to set the ConnectionGUID, value returned from the initial ConnectRemote command.

//declare and populate the ExtensionCommand command object
reqPowerFabAPI.fsreqExtensionCommand extensionCommand = new reqPowerFabAPI.fsreqExtensionCommand();
extensionCommand.ExtensionName = "MyExtension";
extensionCommand.CommandName = "MyCommand";

// populate the command parameters
List<reqPowerFabAPI.fsreqCommandParameter> commandParameters = new List<reqPowerFabAPI.fsreqCommandParameter>();
commandParameters.Add(new reqPowerFabAPI.fsreqCommandParameter() { Name = "param1", Value = "value1" });
commandParameters.Add(new reqPowerFabAPI.fsreqCommandParameter() { Name = "param2", Value = "value2" });
extensionCommand.CommandParameters = commandParameters.ToArray();

request.ExtensionCommand = new List<reqPowerFabAPI.fsreqExtensionCommand>();
request.ExtensionCommand.Add(extensionCommand);

//execute the command and get the response object
resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);

//first check for an XMLError element
if (response.XMLError!= null && response.XMLError.Count > 0)
    MessageBox.Show(response.XMLError); //fatal error
else
{
    //The get the ExtensionCommand response object and check if it was successful
    resPowerFabAPI.fsresExtensionCommand extensionCommandResponse = response.ExtensionCommand.First();
    if (!extensionCommandResponse.Successful)
        MessageBox.Show(extensionCommandResponse.ErrorMessage); //command failed
    else
    {
        //The get the CommandResult response object
        resPowerFabAPI.fsresCommandResult commandResult = extensionCommandResponse.CommandResult.First();
        if (commandResult.Result!= "Success")
            MessageBox.Show(commandResult.Message); //command failed
        else
        {
            //The command was successful
            MessageBox.Show(commandResult.Message);
        }
    }
}
```

**Notes:**

- The `ExtensionName` and `CommandName` elements are required. [cite: 139]
- The `CommandParameters` element is optional. [cite: 139]

**End of Section: Extension**
