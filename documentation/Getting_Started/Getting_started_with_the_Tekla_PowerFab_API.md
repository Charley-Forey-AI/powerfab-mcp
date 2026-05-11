---
title: Getting started with the Tekla PowerFab API
url: https://developer.tekla.com/documentation/getting-started-tekla-powerfab-api
slug: getting-started-tekla-powerfab-api
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Getting started with the Tekla PowerFab API
updated: 23 Oct 2025
---

# Getting started with the Tekla PowerFab API

In this guide you will go through how to get started with the Tekla PowerFab Open API.

Follow this guide to get started with Tekla PowerFab Open API.

## What’s possible with the Tekla PowerFab Open API

Watch the short video below to learn how to use the Tekla PowerFab Open API on both the Tekla PowerFab Go web product and the Tekla PowerFab Office desktop product.

You will see how to code an application that uses the drawing management functionality and how the changes get updated to both web and desktop products.

## How the Tekla PowerFab Open API works

The Tekla PowerFab Open API provides a data-access layer to the Tekla PowerFab database. The .NET classes model the XSD [request](http://api.teklapowerfab.net/xml-schema/fabsuite-xml-request-v0108.xsd) and [response](https://api.teklapowerfab.net/xml-schema/fabsuite-xml-response-v0108.xsd) schemas' structure and content. As a developer it is easiest to code directly with the .NET classes and data types described in the [API Reference](https://developer.tekla.com/tekla-epm/api/8/16984).

## Prerequisites

In order to develop on top of the Tekla PowerFab Open API you need to purchase a Tekla PowerFab license, or join the Tekla Partners Program.

By joining the Tekla Partners Program you will be able to purchase Tekla Partners Program Suite containing the Tekla PowerFab product, along with other Tekla products.

#### Not a member of the Tekla Partners Program yet?

Get familiar with the benefits and apply to the Tekla Partners Program.

[Read more](https://developer.tekla.com/Tekla-Partners-Program)

## Prepare your setup

1. To get started you will need to create an empty .NET application project in Microsoft Visual Studio. Follow the steps in this guide: [Create a new project in Microsoft Visual Studio](https://developer.tekla.com/documentation/create-new-project-microsoft-visual-studio).
2. Next, add reference to the Tekla PowerFab Open API dll package. The package file is called Tekla.PowerFab.API.dll and can be added from NuGet.

   1. From the **Project** menu in Microsoft Visual Studio select **Manage NuGet packages**.
   2. Select **Browse** and search for PowerFab.
   3. Select Tekla.PowerFab.API then click **Install**.
3. Then, download and add fabsuite-xml-request-v0108.cs source file to your Microsoft Visual Studio project.

   1. Download the source file [here](https://developer.tekla.com/sites/default/files/files/inline-files/fabsuite-xml-request-v0108_0.zip).
   2. On the **Project** menu of Microsoft Visual Studio, click **Add existing item**.
   3. Browse to fabsuite-xml-request-v0108.Designer.cs and click **Add**.
4. Then, download and add fabsuite-xml-response-v0108.cs source file to your Microsoft Visual Studio project.

   1. Download the source file [here](https://developer.tekla.com/sites/default/files/files/inline-files/fabsuite-xml-response-v0108.zip).
   2. On the **Project** menu of Microsoft Visual Studio, click **Add existing item**.
   3. Browse to fabsuite-xml-response-v0108.cs and click **Add**.
5. **Obtain API credentials.** To access the Tekla PowerFab XML API, you'll need valid API credentials, typically an External username and password. Contact your Tekla PowerFab administrator or IT department to obtain these credentials.
6. **Make your first API request.** Once your development environment is set up and you have your API credentials, you can make your first API request. Here's a general outline of the process:
7. **Construct the XML Request:** Create an XML document that conforms to the Tekla PowerFab XML API schema. This document will contain the command you want to execute and any necessary parameters.
8. **Send the Request:** Use your chosen programming language and libraries to send an HTTP POST request to the Tekla PowerFab API endpoint. Include your API credentials for authentication and the XML request document in the request body.
9. **Handle the Response:** Parse the XML response received from the API. This response will contain the requested data or a status message indicating the success or failure of the request.
10. The Tekla PowerFab XML API offers a wide range of commands for different functionalities. Refer to the **API Endpoints** section of this documentation for a detailed explanation of each command and its parameters.

---

*The Tekla PowerFab API schema is updated often. Updated Request and Response xsd files are installed with Tekla PowerFab in the Docs folder of the program installation directory.*

## Continue coding by editing an existing code example

Here's a simple [Tekla PowerFab API code example](https://developer.tekla.com/sites/default/files/files/inline-files/ReadProductionJobs-Direct_0.zip).

The code example will show, for example:

- how to connect and disconnect the Tekla PowerFab database
- how to read the Production Control jobs
- how to show each job in a list box

### Convert Objects to and from XML or JSON for sending/receiving

The example programs in this folder converts objects to XML.  Here’s a code snippet

Code Snippet of executeCommand function

You will also want to include a Namespace Override.  This makes sure that the name of the schema in the response file you get will be altered to match what you expect.  As we update our API, a name change in the schema would break your extension without a Namespace Override.

Code snipped of NameSpace Override

## Troubleshoot with the API Log

Inside PowerFab, we provide an API Log to help you and the user troubleshoot what’s going on with the commands you send.  To use the it, set APILog to “all” in the command you send.  This shows a code snipped to do it in C#.  

Code snipped to use the API Log

In PowerFab, the user can go to Maintenance->Integration Settings->API Log and see both the requests and results that were logged using this setting.

Screenshot of API Log

# See available requests and responses in the .xsd schema files

The PowerFab API schemas contain 251 commands.   They are included in related articles or in your PowerFab install directory. Have a look and give it a try!
