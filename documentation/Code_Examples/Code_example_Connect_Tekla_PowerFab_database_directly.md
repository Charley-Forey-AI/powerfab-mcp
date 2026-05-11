---
title: 'Code example: Connect Tekla PowerFab database directly'
url: https://developer.tekla.com/documentation/code-example-connect-tekla-powerfab-database-directly
slug: code-example-connect-tekla-powerfab-database-directly
kind: Guide
section: Code examples
section_folder: Code_Examples
breadcrumb:
- Tekla PowerFab
- 'Code example: Connect Tekla PowerFab database directly'
updated: 7 May 2024
---

# Code example: Connect Tekla PowerFab database directly

Get code

[Connect to the Tekla PowerFab Database and Read Production Control Jobs](https://developer.tekla.com/sites/default/files/files/download-codefile/file/TeklaPowerFabOpenAPIExample-Direct_1.zip "Open archive in new window")9.36 MB

## Use direct method if you do not have Tekla PowerFab Remote Service

There are two ways to connect Tekla PowerFab: direct and remote. In this guide, you will see how to connect directly with the Tekla PowerFab database using the Tekla PowerFab Open API.

The direct connection is useful if you do not have Tekla PowerFab GO, and therefore do not use the Tekla PowerFab Remote Service.

For this method, create a Tekla PowerFab user or use the admin user and password. Use the IP address and port of the Tekla PowerFab Database in your connect command. After you have a connection, use any available command you wish.

The code shown in this example is the same as in [t](https://developer.tekla.com/tekla-epm/documentation/code-example-production-control-jobs)he code example linked above.

## Creating direct connection to Tekla PowerFab

Follow these steps in order to create direct connection to Tekla PowerFab.

1. Create new **TeklaPowerFabAPI** object that uses the **ITeklaPowerFabAPI** interface. You will execute the requests against the **TEklaPowerFabAPI** object and get responses back in xml string.

   ```
       public partial class TeklaPowerFabOpenAPIExampleF : Form
       {
           TeklaPowerFab.TeklaPowerFabAPI.ITeklaPowerFabAPI fsAPI = new TeklaPowerFab.TeklaPowerFabAPI.TeklaPowerFabAPI();
   ```
2. Set following connection strings:
   - **connection\_ipAddress**: the IP address of the Tekla PowerFab database
   - **connection\_port**: the default port is 3306
   - **connection\_username**: the Tekla PowerFab user name
   - **connection\_password**: a Tekla PowerFab password

   ```
       string connection_ipAddress = "###.#.#.#";  
       string connection_port = "3306"; 
       string connection_username = "username"; 
       string connection_password = "password";
   ```
3. When user clicks the Connect button, create new request object **fsreqFabSuiteXMLRequest:**

   ```
           private void ConnectButton_Click(object sender, EventArgs e)
           {
               //declare the request object
               reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
   ```
4. Create new **connectCommand** object to be requested. Use the connection strings defined earlier:

   ```
               reqPowerFabAPI.fsreqConnect connectCommand = new reqPowerFabAPI.fsreqConnect();
               connectCommand.IPAddress = connection_ipAddress;
               connectCommand.PortNumber = connection_port;
               connectCommand.Username = connection_username;
               connectCommand.Password = connection_password;
   ```
5. Request object takes a list as a property, so set the **connectCommand** as the first item in the list:

   ```
               request.Connect = new fsreqConnect[1];
               request.Connect[0] = connectCommand;
   ```
6. Establish a connection to the Tekla PowerFab database by executing the request. Execution will respond with **fsresFabSuiteXMLResponse** object:

   ```
               resPowerFabAPI.fsresFabSuiteXMLResponse response = executeCommand(request);
   ```
7. Check that the connection was created and there were no errors:

   ```
              if (response.XMLError != null && response.XMLError.Length > 0)
                   MessageBox.Show(response.XMLError[0]);  //fatal error
               else
               {
                   //The get the Connect response object and check if it was successful
                   resPowerFabAPI.fsresConnect connectResponse = response.Connect[0];
                   if (!connectResponse.Successful)
                       MessageBox.Show(connectResponse.ErrorMessage);  //command failed
                   else
                       MessageBox.Show("connected!");
               }
           }
   ```
