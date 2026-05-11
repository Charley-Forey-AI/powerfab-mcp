---
title: 'Code example: Connect Tekla PowerFab database remotely'
url: https://developer.tekla.com/documentation/code-example-connect-tekla-powerfab-database-remotely
slug: code-example-connect-tekla-powerfab-database-remotely
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Connect Tekla PowerFab database remotely'
updated: 7 May 2024
---

# Code example: Connect Tekla PowerFab database remotely

Get code

[Tekla PowerFab Remote Connection Demo Program](https://developer.tekla.com/sites/default/files/files/download-codefile/file/TeklaPowerFabRemoteConnectionDemo_2.zip "Open archive in new window")9.72 MB

## With Remote Server the debug logging is easier than with direct connection

There are two ways to connect to Tekla PowerFab: direct and remote. In this guide you will see how to connect remotely with the Tekla PowerFab database using the Tekla PowerFab Open API.

We recommend that you use the remote connection instead of a direct connection, as the remote interface supports logging.

Note that the names Tekla PowerFab and FabSuite are used in some places in the API and this article as we strive to maintain backward compatibility with existing integrations.

To get started, check out this [introduction video](https://youtu.be/nBa3Yl66f1A).

## Tekla PowerFab Remote Service required

The remote connection required that the user has the Tekla PowerFab Remote Service (used for Tekla PowerFab GO, as well as Automated Events like database backups and scheduled reporting) installed and running on the PowerFab server. In PowerFab Office/EPM, create an External User, and give that user permissions to log in and view jobs. You could optionally start out giving the external user full permissions to everything, then when your tool is working, you can remove privileges that are unnecessary. Update the code to use the proper IP address of the remote server, port used by the remote server, username and password, then add any command available.

## Creating the remote connection with Tekla PowerFab

Follow these steps to create the remote connection.

1. Create new **TeklaPowerFabAPI** object that uses the **ITeklaPowerFabAPI** interface. You will execute the requests against the **TeklaPowerFabAPI** object and get responses back in xml string.

   ```
       public partial class RemoteConnection : Form
       {
           TeklaPowerFab.TeklaPowerFabAPI.ITeklaPowerFabAPI fsAPI = new TeklaPowerFab.TeklaPowerFabAPI.TeklaPowerFabAPI();
   ```
2. **connectionGUID is** returned by a successful **ConnectRemote** command. Save the ConnectionGUID for use with subsequent commands.

   ```
           private string connectionGUID = ""; // returned by a successful ConnectRemote command, must be set for each subsequent command.
   ```
3. When user clicks the Connect button, create new request object **fsreqFabSuiteXMLRequest:**

   ```
           private void ConnectButton_Click(object sender, EventArgs e)
           {
               //declare the request object
               reqFabSuiteAPI.fsreqFabSuiteXMLRequest request = new reqFabSuiteAPI.fsreqFabSuiteXMLRequest();
   ```
4. Create new **connectRemote** object to be requested. Use the user name and password defined earlier:

   ```
               //declare and populate the ConnectRemote command object
               reqFabSuiteAPI.fsreqConnectRemote connectRemoteCommand = new reqFabSuiteAPI.fsreqConnectRemote();
               connectRemoteCommand.Username = ExternalUsernameTextBox.Text;
               connectRemoteCommand.Password = PasswordTextBox.Text;
   ```
5. Request object takes a list as a property, so set the **connectRemote** as the first item in the list:

   ```
               //set the ConnectRemote command object in the request object
               request.ConnectRemote = new List<reqFabSuiteAPI.fsreqConnectRemote>();
               request.ConnectRemote.Add(connectRemoteCommand);
   ```
6. Establish a remote connection to the Tekla PowerFab database by executing the request. Execution will respond with **fsresFabSuiteXMLResponse** object:

   ```
               //execute the command and get the response object
               resFabSuiteAPI.fsresFabSuiteXMLResponse response = executeCommand(request);
   ```
7. Check that the remote connection was created and there were no errors:

   ```
               //first check for an XMLError element
               if (response.XMLError != null && response.XMLError.Count > 0)
                   MessageBox.Show(response.XMLError[0]); //fatal error
               else
               {
                   //The get the ConnectRemote response object and check if it was successful
                   resFabSuiteAPI.fsresConnectRemote connectRemoteResponse = response.ConnectRemote[0];
                   if (!connectRemoteResponse.Successful)
                       MessageBox.Show(connectRemoteResponse.ErrorMessage);  //command failed
                   else
                   {
                       // command successful, save the ConnectionGUID for use with subsequent commands.
                       connectionGUID = connectRemoteResponse.ConnectionGUID;
                       StatusTextBox.Text = "Connected!";
                   }
               }
   ```
