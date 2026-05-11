---
title: Purchase Orders
url: https://developer.tekla.com/documentation/purchase-orders
slug: purchase-orders
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Purchase Orders
updated: 18 Feb 2025
---

# Purchase Orders

This section details the API calls available for managing purchase orders within Tekla PowerFab.

### **API Calls**

- `PurchaseOrder_Get`

  This API call retrieves purchase orders from Tekla PowerFab. You can filter the results by various criteria, such as purchase order number, vendor, or status.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <PurchaseOrder_Get>
      <PurchaseOrderNumber>PO-123</PurchaseOrderNumber>
    </PurchaseOrder_Get>
  </FabSuiteXMLRequest>
  ```

  **Code Example (C#)**

  ```
  // Create a request object.
  reqPowerFabAPI.fsreqFabSuiteXMLRequest request = new reqPowerFabAPI.fsreqFabSuiteXMLRequest();
  request.ConnectionGUID = connectionGUID;

  // Get Purchase Order PO-123.
  reqPowerFabAPI.fsreqPurchaseOrder_Get getPurchaseOrderCommand = new reqPowerFabAPI.fsreqPurchaseOrder_Get();
  getPurchaseOrderCommand.PurchaseOrderNumber = "PO-123";
  request.PurchaseOrder_Get = new List<reqPowerFabAPI.fsreqPurchaseOrder_Get>();
  request.PurchaseOrder_Get.Add(getPurchaseOrderCommand);

  // Execute the command.
  resPowerFabAPI.FabSuiteXMLResponse response = executeCommand(request);

  // Check for errors.
  if (response.XMLError!= null && response.XMLError.Count > 0)
      MessageBox.Show(response.XMLError.ToString());
  else
  {
      resPowerFabAPI.PurchaseOrder_Get purchaseOrderResponse = response.PurchaseOrder_Get.First();
      if (!purchaseOrderResponse.Successful)
          MessageBox.Show(purchaseOrderResponse.ErrorMessage);
      else
      {
          // Get the purchase order from the response.
          resPowerFabAPI.PurchaseOrder purchaseOrder = purchaseOrderResponse.PurchaseOrder;
          MessageBox.Show(purchaseOrder.PurchaseOrderNumber);
      }
  }
  ```
- `PurchaseOrderItem_Get`

  This API call retrieves details about specific items within a purchase order. You'll need to provide the purchase order ID and optionally filter by item details.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <PurchaseOrderItem_Get>
      <PurchaseOrderID>456</PurchaseOrderID>
    </PurchaseOrderItem_Get>
  </FabSuiteXMLRequest>
  ```
- `PurchaseOrderItemReceiveTransaction_Get`

  This API call retrieves the receive transactions associated with a specific purchase order item. You'll need to provide the purchase order item ID.

  **Request (XML)**

  ```
  <FabSuiteXMLRequest>
    <ConnectionGUID>your_connection_guid</ConnectionGUID>
    <PurchaseOrderItemReceiveTransaction_Get>
      <PurchaseOrderItemID>789</PurchaseOrderItemID>
    </PurchaseOrderItemReceiveTransaction_Get>
  </FabSuiteXMLRequest>
  ```
- `PurchaseOrderFOB_Get`
- `PurchaseOrderFOB_Delete`
- `PurchaseOrderFOB_Update`
- `PurchaseOrderFOB_Insert`
- `PurchaseOrderPaymentTerm_Get`
- `PurchaseOrderPaymentTerm_Delete`
- `PurchaseOrderPaymentTerm_Update`
- `PurchaseOrderPaymentTerm_Insert`
- `PurchaseOrderPOType_Get`
- `PurchaseOrderPOType_Delete`
- `PurchaseOrderPOType_Update`
- `PurchaseOrderPOType_Insert`
- `PurchaseOrderShippingMethod_Get`
- `PurchaseOrderShippingMethod_Delete`
- `PurchaseOrderShippingMethod_Update`
- `PurchaseOrderShippingMethod_Insert`

### **PurchaseOrderFOB\_Get**

**Description:** Retrieves a list of FOB (Free On Board) points.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderFOB_Get/>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the available FOB points for purchase orders.

### **PurchaseOrderFOB\_Delete**

**Description:** Deletes an FOB point.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderFOB_Delete>
    <PurchaseOrderFOBID>123</PurchaseOrderFOBID>
  </PurchaseOrderFOB_Delete>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove an FOB point from the system.

### **PurchaseOrderFOB\_Update**

**Description:** Updates an FOB point.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderFOB_Update>
    <PurchaseOrderFOB>
      <PurchaseOrderFOBID>123</PurchaseOrderFOBID>
      <FOBName>Updated FOB Name</FOBName>
    </PurchaseOrderFOB>
  </PurchaseOrderFOB_Update>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to modify the details of an existing FOB point.

### **PurchaseOrderFOB\_Insert**

**Description:** Inserts a new FOB point.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderFOB_Insert>
    <PurchaseOrderFOB>
      <FOBName>New FOB Name</FOBName>
    </PurchaseOrderFOB>
  </PurchaseOrderFOB_Insert>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new FOB point to the system.

### **PurchaseOrderPaymentTerm\_Get**

**Description:** Retrieves a list of payment terms.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPaymentTerm_Get/>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the available payment terms for purchase orders.

### **PurchaseOrderPaymentTerm\_Delete**

**Description:** Deletes a payment term.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPaymentTerm_Delete>
    <PurchaseOrderPaymentTermID>123</PurchaseOrderPaymentTermID>
  </PurchaseOrderPaymentTerm_Delete>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove a payment term from the system.

### **PurchaseOrderPaymentTerm\_Update**

**Description:** Updates a payment term.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPaymentTerm_Update>
    <PurchaseOrderPaymentTerm>
      <PurchaseOrderPaymentTermID>123</PurchaseOrderPaymentTermID>
      <PaymentTermName>Updated Payment Term Name</PaymentTermName>
    </PurchaseOrderPaymentTerm>
  </PurchaseOrderPaymentTerm_Update>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to modify the details of an existing payment term.

### **PurchaseOrderPaymentTerm\_Insert**

**Description:** Inserts a new payment term.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPaymentTerm_Insert>
    <PurchaseOrderPaymentTerm>
      <PaymentTermName>New Payment Term Name</PaymentTermName>
    </PurchaseOrderPaymentTerm>
  </PurchaseOrderPaymentTerm_Insert>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new payment term to the system.

### **PurchaseOrderPOType\_Get**

**Description:** Retrieves a list of purchase order types.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPOType_Get/>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the available purchase order types.

### **PurchaseOrderPOType\_Delete**

**Description:** Deletes a purchase order type.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPOType_Delete>
    <PurchaseOrderPOTypeID>123</PurchaseOrderPOTypeID>
  </PurchaseOrderPOType_Delete>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove a purchase order type from the system.

### **PurchaseOrderPOType\_Update**

**Description:** Updates a purchase order type.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPOType_Update>
    <PurchaseOrderPOType>
      <PurchaseOrderPOTypeID>123</PurchaseOrderPOTypeID>
      <POTypeName>Updated Purchase Order Type Name</POTypeName>
    </PurchaseOrderPOType>
  </PurchaseOrderPOType_Update>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to modify the details of an existing purchase order type.

### **PurchaseOrderPOType\_Insert**

**Description:** Inserts a new purchase order type.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderPOType_Insert>
    <PurchaseOrderPOType>
      <POTypeName>New Purchase Order Type Name</POTypeName>
    </PurchaseOrderPOType>
  </PurchaseOrderPOType_Insert>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new purchase order type to the system.

### **PurchaseOrderShippingMethod\_Get**

**Description:** Retrieves a list of shipping methods.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderShippingMethod_Get/>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to get the available shipping methods for purchase orders.

### **PurchaseOrderShippingMethod\_Delete**

**Description:** Deletes a shipping method.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderShippingMethod_Delete>
    <PurchaseOrderShippingMethodID>123</PurchaseOrderShippingMethodID>
  </PurchaseOrderShippingMethod_Delete>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to remove a shipping method from the system.

### **PurchaseOrderShippingMethod\_Update**

**Description:** Updates a shipping method.

**Request:**

```
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderShippingMethod_Update>
    <PurchaseOrderShippingMethod>
      <PurchaseOrderShippingMethodID>123</PurchaseOrderShippingMethodID>
      <ShippingMethodName>Updated Shipping Method Name</ShippingMethodName>
    </PurchaseOrderShippingMethod>

### PurchaseOrderShippingMethod_Insert

**Description:** Inserts a new shipping method.

**Request:**

```xml
<FabSuiteXMLRequest>
  <ConnectionGUID>your_connection_guid</ConnectionGUID>
  <PurchaseOrderShippingMethod_Insert>
    <PurchaseOrderShippingMethod>
      <ShippingMethodName>New Shipping Method Name</ShippingMethodName>
    </PurchaseOrderShippingMethod>
  </PurchaseOrderShippingMethod_Insert>
</FabSuiteXMLRequest>
```

**Code Example:**

```
// Not available in the provided code examples.
```

**Notes:**

- This API call is used to add a new shipping method to the system.

**End of Section: Purchase Orders**
