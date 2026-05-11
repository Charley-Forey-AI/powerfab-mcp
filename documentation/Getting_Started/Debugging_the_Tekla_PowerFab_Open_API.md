---
title: Debugging the Tekla PowerFab Open API
url: https://developer.tekla.com/documentation/debugging-tekla-powerfab-open-api
slug: debugging-tekla-powerfab-open-api
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Debugging the Tekla PowerFab Open API
updated: 12 Apr 2026
---

# Debugging the Tekla PowerFab Open API

# See commands and responses with API Log

Inside PowerFab, we provide an API Log to help you and the user troubleshoot what’s going on with the commands you send.  To use the it, set APILog to “all” in the command you send.  This shows a code snipped to do it in C#.  

Code Snipped to use API log in .CS code

In PowerFab, the user can go to Maintenance->Integration Settings->API Log and see both the requests and results that were logged using this setting.

Code Snipped showing result of Saved Nest to a Future Remnant

# Tekla PowerFab Interface Test

The Tekla PowerFab Interface Test program is installed with Tekla PowerFab (C:\Program Files (x86)\Tekla\Tekla PowerFab\Tekla.PowerFab.Interface.Test.exe) and is a useful tool for testing and debugging API commands.

## Elements of the XML request

The root element of the XML request is **FabSuiteXMLRequest**.

The element under **FabSuiteXMLRequest** indicates the command that should be executed.

When you open the Interface Test Program, this Connect request will be displayed:

```
<FabSuiteXMLRequest>
	<Connect>
		<IPAddress>localhost</IPAddress>
		<PortNumber>3306</PortNumber>
		<Username></Username>
		<Password></Password>
	</Connect>
</FabSuiteXMLRequest>
```

Add a Username and Password and click the Submit Request button to test the connection to PowerFab. This example uses defaults from the default database included with the PowerFab installation:

        <Username>admin</Username>  
        <Password>fab</Password>

## Elements of the XML response

The root element of the XML response is **FabSuiteXMLResponse**.

Under **FabSuiteXMLResponse** there may be **XMLError** or **XMLWarning** elements.

### XMLError

Here is an **XMLError** example where the end tag missing:

```
<FabSuiteXMLRequest>
	<Connect>
		<IPAddress>localhost</IPAddress>
		<PortNumber>3306</PortNumber>
		<Username>admin</Username>
		<Password>fab</Password>
	</Connect>
```

Missing end tag would produce the following response:

```
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <Lang>en</Lang>

  <XMLError>Fatal Error (7, 12): input ended before all started tags were ended; last tag started is 'FabSuiteXMLRequest'</XMLError>

</FabSuiteXMLResponse>
```

If there is an **XMLError** the request will not be processed.

### XMLWarning

In the following **XMLWarning** example the password is misspelled:

```
<FabSuiteXMLRequest>
	<Connect>
		<IPAddress>localhost</IPAddress>
		<PortNumber>3306</PortNumber>
		<Username>admin</Username>
		<Pass>fab</Pass> --Password element mispelled
	</Connect>
</FabSuiteXMLRequest>
```

The unknown password would cause a response like this:

```
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <Lang>en</Lang>

  <XMLWarning>Element FabSuiteXMLRequest-&gt;Connect-&gt;Pass-&gt;Pass (fab) is unknown.</XMLWarning>

  <Connect>
    <ErrorMessage>MySQL error: 1045 - Access denied for user 'admin'@'localhost' (using password: NO)</ErrorMessage>
    <Successful>0</Successful>
  </Connect>

</FabSuiteXMLResponse>
```

An**XMLWarning** will not prevent the request from being processed.  In this case, the connection is attempted with a blank password and the login fails.

### Successful

The command response always contains the **Successful** element:

- 1 = successful
- 0 = unsuccessful

If the request was unsuccessful then there is also an **ErrorMessage** element to give further information.

### Returned data

In addition, if the command returns any data it will also be listed under the response element.  For example, the **Version** command returns the version number of the Tekla PowerFab Open API:

```
<FabSuiteXMLRequest>
	<Version/>
</FabSuiteXMLRequest>
```

```
<FabSuiteXMLResponse xmlns="http://www.fabsuite.com/xml/fabsuite-xml-response-v0108.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <Lang>en</Lang>

  <Version>
    <Successful>1</Successful>
    <MajorVersion>2023</MajorVersion>
    <MinorVersion>B3</MinorVersion>
    <InterfaceVersionNumber>2023.0.0</InterfaceVersionNumber>
  </Version>

</FabSuiteXMLResponse>
```
