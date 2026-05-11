---
title: Firm Contacts
url: https://developer.tekla.com/documentation/firm-contacts
slug: firm-contacts
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Firm Contacts
updated: 13 Feb 2025
---

# Firm Contacts

### **FirmContact\_Get**

**Description:** Retrieves a specific firm contact from Tekla PowerFab. [cite: 139]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmContact_Get>
    <FirmContactID>123</FirmContactID>
  </FirmContact_Get>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmContact_Get>
    <Successful>true</Successful>
    <FirmContact>
      <FirmContactID>123</FirmContactID>
      <FirmID>456</FirmID>
      <ContactFirstName>John</ContactFirstName>
      <ContactLastName>Doe</ContactLastName>
      <ContactTitle>Sales Manager</ContactTitle>
      <ContactPhone>123-456-7890</ContactPhone>
      <ContactEmail>john.doe@example.com</ContactEmail>
    </FirmContact>
  </FirmContact_Get>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmContactID` element is required. [cite: 140]

### **FirmContact\_Insert**

**Description:** Inserts a new firm contact into Tekla PowerFab. [cite: 141]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmContact_Insert>
    <FirmContact>
      <FirmID>456</FirmID>
      <ContactFirstName>John</ContactFirstName>
      <ContactLastName>Doe</ContactLastName>
      <ContactTitle>Sales Manager</ContactTitle>
      <ContactPhone>123-456-7890</ContactPhone>
      <ContactEmail>john.doe@example.com</ContactEmail>
    </FirmContact>
  </FirmContact_Insert>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmContact_Insert>
    <Successful>true</Successful>
    <FirmContact>
      <FirmContactID>123</FirmContactID>
      <FirmID>456</FirmID>
      <ContactFirstName>John</ContactFirstName>
      <ContactLastName>Doe</ContactLastName>
      <ContactTitle>Sales Manager</ContactTitle>
      <ContactPhone>123-456-7890</ContactPhone>
      <ContactEmail>john.doe@example.com</ContactEmail>
    </FirmContact>
  </FirmContact_Insert>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmID`, `ContactFirstName`, `ContactLastName`, `ContactTitle`, `ContactPhone`, and `ContactEmail` elements are required. [cite: 142, 143, 144]

### **FirmContact\_Update**

**Description:** Updates an existing firm contact in Tekla PowerFab. [cite: 145]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmContact_Update>
    <FirmContact>
      <FirmContactID>123</FirmContactID>
      <FirmID>456</FirmID>
      <ContactFirstName>John</ContactFirstName>
      <ContactLastName>Doe</ContactLastName>
      <ContactTitle>Sales Manager</ContactTitle>
      <ContactPhone>123-456-7890</ContactPhone>
      <ContactEmail>john.doe@example.com</ContactEmail>
    </FirmContact>
  </FirmContact_Update>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmContact_Update>
    <Successful>true</Successful>
    <FirmContact>
      <FirmContactID>123</FirmContactID>
      <FirmID>456</FirmID>
      <ContactFirstName>John</ContactFirstName>
      <ContactLastName>Doe</ContactLastName>
      <ContactTitle>Sales Manager</ContactTitle>
      <ContactPhone>123-456-7890</ContactPhone>
      <ContactEmail>john.doe@example.com</ContactEmail>
    </FirmContact>
  </FirmContact_Update>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- The `FirmContactID`, `FirmID`, `ContactFirstName`, `ContactLastName`, `ContactTitle`, `ContactPhone`, and `ContactEmail` elements are required.

### **FirmContact\_Delete**

**Description:** Deletes one or more firm contacts from Tekla PowerFab. [cite: 149]

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <FirmContact_Delete>
    <FirmContactID>123</FirmContactID>
    <FirmContactID>456</FirmContactID>
  </FirmContact_Delete>
</FabSuiteXMLRequest>
```

**Response:**

```
<FabSuiteXMLResponse>
  <FirmContact_Delete>
    <Successful>true</Successful>
  </FirmContact_Delete>
</FabSuiteXMLResponse>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- At least one `FirmContactID` element is required. [cite: 150]

**End of Section: Firm Contacts**
