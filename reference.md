# Reference
## Addresses
<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">ListAsync</a>(AddressesListRequest { ... }) -> Pager<Address></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all addresses in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Addresses** under the Addresses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Addresses.ListAsync(new AddressesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AddressesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">CreateAsync</a>(CreateAddressRequest { ... }) -> AddressResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new address in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Addresses.CreateAsync(
    new CreateAddressRequest
    {
        FormattedAddress = "350 Rhode Island St, San Francisco, CA",
        Geofence = new CreateAddressRequestGeofence(),
        Name = "Samsara HQ",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAddressRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">GetAsync</a>(id) -> AddressResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Addresses** under the Addresses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Addresses.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Address. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">DeleteAsync</a>(id) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Addresses.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Address. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">UpdateAsync</a>(id, UpdateAddressRequest { ... }) -> AddressResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Addresses.UpdateAsync("id", new UpdateAddressRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Address. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateAddressRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Assets
<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">ListAsync</a>(AssetsListRequest { ... }) -> Pager<AssetResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all assets. Up to 300 assets will be returned per page.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.ListAsync(new AssetsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">CreateAsync</a>(AssetsCreateAssetRequestBody { ... }) -> AssetsCreateAssetResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.CreateAsync(new AssetsCreateAssetRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsCreateAssetRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">DeleteAsync</a>(AssetsDeleteRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an existing asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.DeleteAsync(new AssetsDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">UpdateAsync</a>(AssetsUpdateAssetRequestBody { ... }) -> AssetsUpdateAssetResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.UpdateAsync(new AssetsUpdateAssetRequestBody { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AssetsUpdateAssetRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Inputs
<details><summary><code>client.Inputs.<a href="/src/Samsara.Net/Inputs/InputsClient.cs">StreamAsync</a>(InputsStreamRequest { ... }) -> Pager<AssetsInputsResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return data collected from the inputs of your organization's assets based on the time parameters passed in. Results are paginated. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. The endpoint will only return data up until the endTime that has been processed by the server at the time of the original request. You will need to request the same [startTime, endTime) range again to receive data for assets processed after the original request time. This endpoint sorts data by time ascending.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Inputs.StreamAsync(
    new InputsStreamRequest { Type = InputsStreamRequestType.AuxInput1, StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InputsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Attributes
<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">ListAsync</a>(AttributesListRequest { ... }) -> Pager<Attribute></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch all attributes in an organization associated with either drivers or assets. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Attributes** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Attributes.ListAsync(
    new AttributesListRequest { EntityType = AttributesListRequestEntityType.Driver }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AttributesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">CreateAsync</a>(CreateAttributeRequest { ... }) -> AttributeExpandedResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new attribute in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Attributes.CreateAsync(
    new CreateAttributeRequest
    {
        AttributeType = CreateAttributeRequestAttributeType.String,
        AttributeValueQuantity = CreateAttributeRequestAttributeValueQuantity.Single,
        EntityType = CreateAttributeRequestEntityType.Driver,
        Name = "License Certifications",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAttributeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">GetAsync</a>(id, AttributesGetRequest { ... }) -> AttributeExpandedResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch an attribute by id, including all of its applications. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Attributes** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Attributes.GetAsync(
    "id",
    new AttributesGetRequest { EntityType = AttributesGetRequestEntityType.Driver }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Samsara-provided UUID of the attribute.
    
</dd>
</dl>

<dl>
<dd>

**request:** `AttributesGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">DeleteAsync</a>(id, AttributesDeleteRequest { ... }) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an attribute by id, including all of its applications. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Attributes.DeleteAsync(
    "id",
    new AttributesDeleteRequest { EntityType = AttributesDeleteRequestEntityType.Driver }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Samsara-provided UUID of the attribute.
    
</dd>
</dl>

<dl>
<dd>

**request:** `AttributesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">UpdateAsync</a>(id, UpdateAttributeRequest { ... }) -> AttributeExpandedResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an attribute in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Attributes.UpdateAsync(
    "id",
    new UpdateAttributeRequest { EntityType = UpdateAttributeRequestEntityType.Driver }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Samsara-provided UUID of the attribute.
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateAttributeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Contacts
<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">ListAsync</a>(ContactsListRequest { ... }) -> Pager<Contact></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all contacts in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Alert Contacts** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contacts.ListAsync(new ContactsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContactsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">CreateAsync</a>(CreateContactRequest { ... }) -> ContactResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a contact to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contacts.CreateAsync(new CreateContactRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateContactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">GetAsync</a>(id) -> ContactResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific contact's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Alert Contacts** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contacts.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the contact.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">DeleteAsync</a>(id) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the given contact. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contacts.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the contact.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">UpdateAsync</a>(id, UpdateContactRequest { ... }) -> ContactResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific contact's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contacts.UpdateAsync("id", new UpdateContactRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the contact.
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateContactRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## DefectTypes
<details><summary><code>client.DefectTypes.<a href="/src/Samsara.Net/DefectTypes/DefectTypesClient.cs">ListAsync</a>(DefectTypesListRequest { ... }) -> Pager<DefectTypesResponseDataResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get DVIR defect types.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Defect Types** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DefectTypes.ListAsync(new DefectTypesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DefectTypesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Defects
<details><summary><code>client.Defects.<a href="/src/Samsara.Net/Defects/DefectsClient.cs">StreamAsync</a>(DefectsStreamRequest { ... }) -> Pager<DefectsResponseDataResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stream DVIR defects.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Defects.StreamAsync(new DefectsStreamRequest { StartTime = "startTime" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DefectsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Defects.<a href="/src/Samsara.Net/Defects/DefectsClient.cs">GetAsync</a>(id, DefectsGetRequest { ... }) -> DvirDefectGetDefectResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a single DVIR defect by ID.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Defects.GetAsync("id", new DefectsGetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — The unique ID of the DVIR defect.
    
</dd>
</dl>

<dl>
<dd>

**request:** `DefectsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Defects.<a href="/src/Samsara.Net/Defects/DefectsClient.cs">HistoryAsync</a>(DefectsHistoryRequest { ... }) -> DefectsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/streamdefects) instead. The endpoint will continue to function as documented.** 

Returns a list of DVIR defects in an organization, filtered by creation time. The maximum time period you can query for is 30 days. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Defects.HistoryAsync(
    new DefectsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DefectsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Defects.<a href="/src/Samsara.Net/Defects/DefectsClient.cs">UpdateAsync</a>(id, DefectPatch { ... }) -> DefectResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a given defect. Can be used to resolve a defect by marking its `isResolved` field to `true`. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Defects** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Defects.UpdateAsync("id", new DefectPatch());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the defect.
    
</dd>
</dl>

<dl>
<dd>

**request:** `DefectPatch` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Devices
<details><summary><code>client.Devices.<a href="/src/Samsara.Net/Devices/DevicesClient.cs">ListAsync</a>(DevicesListRequest { ... }) -> Pager<DeviceResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all installed cameras (CM3x), vehicle gateways (VGs), and asset gateways (AGs) and their health information within an organization. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Devices API enabled for your organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Devices** under the Devices category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Devices.ListAsync(new DevicesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DevicesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## DriverTrailerAssignments
<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">ListAsync</a>(DriverTrailerAssignmentsListRequest { ... }) -> Pager<GetDriverTrailerAssignmentsResponseBodyResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get currently active driver-trailer assignments for driver.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverTrailerAssignments.ListAsync(new DriverTrailerAssignmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverTrailerAssignmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">CreateAsync</a>(TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody { ... }) -> TrailerAssignmentsCreateDriverTrailerAssignmentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new driver-trailer assignment

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverTrailerAssignments.CreateAsync(
    new TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody
    {
        DriverId = "494123",
        TrailerId = "12345",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">UpdateAsync</a>(TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody { ... }) -> TrailerAssignmentsUpdateDriverTrailerAssignmentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing driver-trailer assignment.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverTrailerAssignments.UpdateAsync(
    new TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody
    {
        Id = "id",
        EndTime = "2019-06-13T19:08:25Z",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Dvirs
<details><summary><code>client.Dvirs.<a href="/src/Samsara.Net/Dvirs/DvirsClient.cs">StreamAsync</a>(DvirsStreamRequest { ... }) -> Pager<DvirStreamResponseDataResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a history/feed of changed DVIRs by updatedAtTime between startTime and endTime parameters. In case of missing `endTime` parameter it will return a never ending stream of data.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Dvirs.StreamAsync(new DvirsStreamRequest { StartTime = "startTime" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DvirsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Dvirs.<a href="/src/Samsara.Net/Dvirs/DvirsClient.cs">GetAsync</a>(id, DvirsGetRequest { ... }) -> DvirGetDvirResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a single DVIR by ID.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Dvirs.GetAsync("id", new DvirsGetRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Id of the DVIR.
    
</dd>
</dl>

<dl>
<dd>

**request:** `DvirsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Dvirs.<a href="/src/Samsara.Net/Dvirs/DvirsClient.cs">CreateAsync</a>(CreateDvirRequest { ... }) -> DvirResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new mechanic DVIR in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Dvirs.CreateAsync(
    new CreateDvirRequest
    {
        AuthorId = "11",
        SafetyStatus = CreateDvirRequestSafetyStatus.Safe,
        Type = "mechanic",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateDvirRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Dvirs.<a href="/src/Samsara.Net/Dvirs/DvirsClient.cs">HistoryAsync</a>(DvirsHistoryRequest { ... }) -> DvirsListResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdvirs) instead. The endpoint will continue to function as documented.** 

 Returns a list of all DVIRs in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Dvirs.HistoryAsync(
    new DvirsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DvirsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Dvirs.<a href="/src/Samsara.Net/Dvirs/DvirsClient.cs">UpdateAsync</a>(id, UpdateDvirRequest { ... }) -> DvirResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Resolves a given DVIR by marking its `isResolved` field to `true`. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Dvirs.UpdateAsync("id", new UpdateDvirRequest { AuthorId = "11", IsResolved = true });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the DVIR.
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateDvirRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Carrier Proposed Assignments
<details><summary><code>client.CarrierProposedAssignments.<a href="/src/Samsara.Net/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">ListAsync</a>(CarrierProposedAssignmentsListRequest { ... }) -> Pager<CarrierProposedAssignment></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Show the assignments created by the POST fleet/carrier-proposed-assignments. This endpoint will only show the assignments that are active for drivers and currently visible to them in the driver app. Once a proposed assignment has been accepted, the endpoint will not return any data. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CarrierProposedAssignments.ListAsync(new CarrierProposedAssignmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CarrierProposedAssignmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CarrierProposedAssignments.<a href="/src/Samsara.Net/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">CreateAsync</a>(CreateCarrierProposedAssignmentRequest { ... }) -> CarrierProposedAssignmentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new assignment that a driver can later use. Each driver can only have one future assignment. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CarrierProposedAssignments.CreateAsync(
    new CreateCarrierProposedAssignmentRequest { DriverId = "42", VehicleId = "123" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateCarrierProposedAssignmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CarrierProposedAssignments.<a href="/src/Samsara.Net/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">DeleteAsync</a>(id) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete an assignment. You can only delete assignments that are not yet active. To override a currently active assignment, create a new empty one, instead. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CarrierProposedAssignments.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the assignment.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## DocumentTypes
<details><summary><code>client.DocumentTypes.<a href="/src/Samsara.Net/DocumentTypes/DocumentTypesClient.cs">ListAsync</a>(DocumentTypesListRequest { ... }) -> Pager<GetDocumentTypeResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of the organization document types. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentTypesByOrgId).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DocumentTypes.ListAsync(new DocumentTypesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentTypesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents
<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">ListAsync</a>(DocumentsListRequest { ... }) -> Pager<DocumentResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all documents for the given time range. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentsByOrgId).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.ListAsync(
    new DocumentsListRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">CreateAsync</a>(DocumentsPostDocumentRequestBody { ... }) -> DocumentsPostDocumentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/createDriverDocument).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.CreateAsync(
    new DocumentsPostDocumentRequestBody
    {
        DocumentTypeId = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
        DriverId = "45646",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsPostDocumentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GetAsync</a>(id) -> DocumentsGetDocumentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentByIdAndDriverId).

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the document
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/deleteDriverDocumentByIdAndDriverId).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the document to delete
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## DriverVehicleAssignments
<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">GetAsync</a>(DriverVehicleAssignmentsGetRequest { ... }) -> DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all driver-vehicle assignments for the requested drivers or vehicles in the requested time range. To fetch driver-vehicle assignments out of the vehicle trips' time ranges, assignmentType needs to be specified. Note: this endpoint replaces past endpoints to fetch assignments by driver or by vehicle. Visit [this migration guide](https://developers.samsara.com/docs/migrating-from-driver-vehicle-assignment-or-vehicle-driver-assignment-endpoints) for more information.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverVehicleAssignments.GetAsync(
    new DriverVehicleAssignmentsGetRequest
    {
        FilterBy = DriverVehicleAssignmentsGetRequestFilterBy.Drivers,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverVehicleAssignmentsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">CreateAsync</a>(DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody { ... }) -> DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Assign vehicle drive-time to a driver via API. For a step-by-step instruction on how to leverage this endpoint, see [this guide](https://developers.samsara.com/docs/creating-driver-vehicle-assignments)

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverVehicleAssignments.CreateAsync(
    new DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody
    {
        DriverId = "494123",
        VehicleId = "281474978683353",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">DeleteAsync</a>(DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete driver assignments that were created using the `POST fleet/driver-vehicle-assignments` endpoint for the requested vehicle in the requested time range.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverVehicleAssignments.DeleteAsync(
    new DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody
    {
        VehicleId = "281474978683353",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">UpdateAsync</a>(DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody { ... }) -> DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update driver assignments that were created using the `POST fleet/driver-vehicle-assignments`. Vehicle Id, Driver Id, and Start Time must match an existing assignment.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.DriverVehicleAssignments.UpdateAsync(
    new DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody
    {
        DriverId = "494123",
        StartTime = "2019-06-13T19:08:25Z",
        VehicleId = "281474978683353",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Drivers
<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">ListAsync</a>(DriversListRequest { ... }) -> Pager<Driver></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all drivers in organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.ListAsync(new DriversListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriversListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">CreateAsync</a>(CreateDriverRequest { ... }) -> DriverResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a driver to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.CreateAsync(
    new CreateDriverRequest
    {
        Name = "Susan Jones",
        Password = "aSecurePassword1234",
        Username = "SusanJones",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateDriverRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">SignOutAsync</a>(DriverRemoteSignoutPostDriverRemoteSignoutRequestBody { ... }) -> DriverRemoteSignoutPostDriverRemoteSignoutResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sign out a driver from the Samsara Driver App

To access this endpoint, your organization must have the Samsara Platform Premier license.

Note: Sign out requests made while a logged-in driver does not have internet connection will not log the driver out. A success response will still be provided and the driver will be logged out once they have internet connection.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Driver Remote Signout** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.SignOutAsync(
    new DriverRemoteSignoutPostDriverRemoteSignoutRequestBody { DriverId = "12434" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverRemoteSignoutPostDriverRemoteSignoutRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">GetAsync</a>(id) -> DriverResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a driver. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the driver. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">UpdateAsync</a>(id, UpdateDriverRequest { ... }) -> DriverResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific driver's information. This can also be used to activate or de-activate a given driver by setting the driverActivationStatus field. If the driverActivationStatus field is 'deactivated' then the user can also specify the deactivatedAtTime. The deactivatedAtTime cannot be more than 6 months in the past and must not come before the dirver's latest active HOS log. It will be considered an error if deactivatedAtTime is provided with a driverActivationStatus of active. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.UpdateAsync("id", new UpdateDriverRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the driver. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateDriverRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Equipment
<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">ListAsync</a>(EquipmentListRequest { ... }) -> Pager<EquipmentObject></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all equipment in an organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.ListAsync(new EquipmentListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EquipmentListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetAsync</a>(id) -> EquipmentResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the unit of equipment with the given Samsara ID. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Samsara ID of the Equipment.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Hos
<details><summary><code>client.Hos.<a href="/src/Samsara.Net/Hos/HosClient.cs">ClocksAsync</a>(HosClocksRequest { ... }) -> HosClocksResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the current HOS status for all drivers. Note that this includes inactive as well as active drivers. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getFleetHosLogsSummary). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hos.ClocksAsync(new HosClocksRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HosClocksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hos.<a href="/src/Samsara.Net/Hos/HosClient.cs">DailyLogsAsync</a>(HosDailyLogsRequest { ... }) -> Pager<HosDailyLogsObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get summarized daily Hours of Service charts for the specified drivers.

The time range for a log is defined by the `driver`'s `eldDayStartHour`. This value is configurable per driver.

The `startDate` and `endDate` parameters indicate the date range you'd like to retrieve daily logs for. A daily log will be returned if its `startTime` is on any of the days within in this date range (inclusive of `startDate` and `endDate`).

**Note:** If data is still being uploaded from the Samsara Driver App, it may not be completely reflected in the response from this endpoint. The best practice is to wait a couple of days before querying this endpoint to make sure that all data from the Samsara Driver App has been uploaded.

If you are using the legacy version of this endpoint and looking for its documentation, you can find it [here](https://www.samsara.com/api-legacy#operation/getFleetDriversHosDailyLogs).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hos.DailyLogsAsync(new HosDailyLogsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HosDailyLogsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hos.<a href="/src/Samsara.Net/Hos/HosClient.cs">LogsAsync</a>(HosLogsRequest { ... }) -> HosLogsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns HOS logs between a given `startTime` and `endTime`. The logs can be further filtered using tags or by providing a list of driver IDs (including external IDs). The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getFleetHosLogs).

**Note:** If data is still being uploaded from the Samsara Driver App, it may not be completely reflected in the response from this endpoint. The best practice is to wait a couple of days before querying this endpoint to make sure that all data from the Samsara Driver App has been uploaded. 

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hos.LogsAsync(new HosLogsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HosLogsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hos.<a href="/src/Samsara.Net/Hos/HosClient.cs">ViolationsAsync</a>(HosViolationsRequest { ... }) -> Pager<HosViolationsObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get active Hours of Service violations for the specified drivers.

The day object time range for a violation is defined by the `driver`'s `eldDayStartHour`. This value is configurable per driver.

The `startTime` and `endTime` parameters indicate the datetime range you'd like to retrieve violations for. A violation will be returned if its `violationStartTime` falls within this datetime range (inclusive of `startTime` and `endTime`) 

**Note:** The following are all the violation types with a short explanation about what each of them means: `californiaMealbreakMissed` (Missed California Meal Break), `cycleHoursOn` (Cycle Limit), `cycleOffHoursAfterOnDutyHours` (Cycle 2 Limit), `dailyDrivingHours` (Daily Driving Limit), `dailyOffDutyDeferralAddToDay2Consecutive` (Daily Off-Duty Deferral: Add To Day2 Consecutive), `dailyOffDutyDeferralNotPartMandatory` (Daily Off-Duty Deferral: Not Part Of Mandatory), `dailyOffDutyDeferralTwoDayDrivingLimit` (Daily Off-Duty Deferral: 2 Day Driving Limit), `dailyOffDutyDeferralTwoDayOffDuty` (Daily Off-Duty Deferral: 2 Day Off Duty), `dailyOffDutyNonResetHours` (Daily Off-Duty Time: Non-Reset), `dailyOffDutyTotalHours` (Daily Off-Duty Time), `dailyOnDutyHours` (Daily On-Duty Limit), `mandatory24HoursOffDuty` (24 Hours of Off Duty required), `restbreakMissed` (Missed Rest Break), `shiftDrivingHours` (Shift Driving Limit), `shiftHours` (Shift Duty Limit), `shiftOnDutyHours` (Shift On-Duty Limit), `unsubmittedLogs` (Missing Driver Certification)

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Hos.ViolationsAsync(new HosViolationsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HosViolationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Routes
<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">ListAsync</a>(RoutesListRequest { ... }) -> Pager<BaseRouteResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns multiple routes. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/fetchAllDispatchRoutes).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.ListAsync(
    new RoutesListRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoutesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">CreateAsync</a>(RoutesCreateRouteRequestBody { ... }) -> RoutesCreateRouteResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a route. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/createDispatchRoute).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.CreateAsync(
    new RoutesCreateRouteRequestBody
    {
        Name = "Bid 123",
        Stops = new List<CreateRoutesStopRequestObjectRequestBody>()
        {
            new CreateRoutesStopRequestObjectRequestBody(),
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RoutesCreateRouteRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">GetAsync</a>(id) -> RoutesFetchRouteResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single route. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDispatchRouteById).

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a dispatch route and its associated stops.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">UpdateAsync</a>(id, RoutesPatchRouteRequestBody { ... }) -> RoutesPatchRouteResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a route.  **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard.
 This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource.
 For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array.

The legacy version of this endpoint (which uses PUT instead of PATCH) can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/updateDispatchRouteById).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.UpdateAsync("id", new RoutesPatchRouteRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>

<dl>
<dd>

**request:** `RoutesPatchRouteRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SafetyEvents
<details><summary><code>client.SafetyEvents.<a href="/src/Samsara.Net/SafetyEvents/SafetyEventsClient.cs">ListAsync</a>(SafetyEventsListRequest { ... }) -> Pager<SafetyEvent></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch safety events for the organization in a given time period. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SafetyEvents.ListAsync(
    new SafetyEventsListRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SafetyEventsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Trailers
<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">ListAsync</a>(TrailersListRequest { ... }) -> Pager<TrailerResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all trailers.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trailers.ListAsync(new TrailersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrailersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">CreateAsync</a>(TrailersCreateTrailerRequestBody { ... }) -> TrailersCreateTrailerResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new trailer asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trailers.CreateAsync(new TrailersCreateTrailerRequestBody { Name = "Trailer-123" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrailersCreateTrailerRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">GetAsync</a>(id) -> TrailersGetTrailerResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a trailer with given ID.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trailers.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the trailer. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: "key:value". For example, "maintenanceId:250020".
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a trailer with the given ID.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trailers.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the trailer to delete.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">UpdateAsync</a>(id, TrailersUpdateTrailerRequestBody { ... }) -> TrailersUpdateTrailerResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a trailer.  **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard.
 This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource.
 For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trailers.UpdateAsync("id", new TrailersUpdateTrailerRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the trailer. Can be either unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the trailer.
    
</dd>
</dl>

<dl>
<dd>

**request:** `TrailersUpdateTrailerRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Vehicles
<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">ListAsync</a>(VehiclesListRequest { ... }) -> Pager<VehicleResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all vehicles.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.ListAsync(new VehiclesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">GetAsync</a>(id) -> VehicleResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific vehicle. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the vehicle. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource, or automatically populated by fields on the vehicle. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `maintenanceId:250020`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.vin:1HGBH41JXMN109186`.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">UpdateAsync</a>(id, UpdateVehicleRequest { ... }) -> VehicleResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the given Vehicle object.

**Note:** Vehicle objects are automatically created when Samsara Vehicle Gateways are installed. You cannot create a Vehicle object via API.

You are able to *update* many of the fields of a Vehicle.

**Note**: There are no required fields in the request body, and you only need to provide the fields you wish to update. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Vehicles** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.UpdateAsync("id", new UpdateVehicleRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the vehicle. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource, or automatically populated by fields on the vehicle. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `maintenanceId:250020`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.vin:1HGBH41JXMN109186`.
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateVehicleRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Legacy
<details><summary><code>client.Legacy.<a href="/src/Samsara.Net/Legacy/LegacyClient.cs">GetVehiclesDriverAssignmentsAsync</a>(LegacyGetVehiclesDriverAssignmentsRequest { ... }) -> VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdrivervehicleassignments) instead. The endpoint will continue to function as documented.** Get all driver assignments for the requested vehicles in the requested time range. The only type of assignment supported right now are assignments created through the driver app.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Legacy.GetVehiclesDriverAssignmentsAsync(
    new LegacyGetVehiclesDriverAssignmentsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LegacyGetVehiclesDriverAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FormSubmissions
<details><summary><code>client.FormSubmissions.<a href="/src/Samsara.Net/FormSubmissions/FormSubmissionsClient.cs">ListAsync</a>(FormSubmissionsListRequest { ... }) -> FormSubmissionsGetFormSubmissionsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all form submissions data for the specified list of IDs.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.ListAsync(new FormSubmissionsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FormSubmissionsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FormSubmissions.<a href="/src/Samsara.Net/FormSubmissions/FormSubmissionsClient.cs">CreateAsync</a>(FormSubmissionsPostFormSubmissionRequestBody { ... }) -> FormSubmissionsPostFormSubmissionResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a form submission and assigns it to an individual worker. This endpoint can be used to create an empty or partially complete form submission and assign it to a worker.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.CreateAsync(
    new FormSubmissionsPostFormSubmissionRequestBody
    {
        FormTemplate = new FormTemplateRequestObjectRequestBody
        {
            Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
            RevisionId = "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7",
        },
        Status = "notStarted",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FormSubmissionsPostFormSubmissionRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FormSubmissions.<a href="/src/Samsara.Net/FormSubmissions/FormSubmissionsClient.cs">UpdateAsync</a>(FormSubmissionsPatchFormSubmissionRequestBody { ... }) -> FormSubmissionsPatchFormSubmissionResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an instance of a form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.UpdateAsync(
    new FormSubmissionsPatchFormSubmissionRequestBody
    {
        Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac8",
        Status = FormSubmissionsPatchFormSubmissionRequestBodyStatus.NotStarted,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FormSubmissionsPatchFormSubmissionRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FormSubmissions.<a href="/src/Samsara.Net/FormSubmissions/FormSubmissionsClient.cs">StreamAsync</a>(FormSubmissionsStreamRequest { ... }) -> Pager<FormSubmissionResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all form submissions data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.StreamAsync(
    new FormSubmissionsStreamRequest { StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FormSubmissionsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Forms
<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">GetFormTemplatesAsync</a>(GetFormTemplatesRequest { ... }) -> FormTemplatesGetFormTemplatesResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of the organization's form templates for the specified list of IDs. If no IDs are provided, all form templates for the organization will be returned.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Forms.GetFormTemplatesAsync(new GetFormTemplatesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetFormTemplatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FuelPurchases
<details><summary><code>client.FuelPurchases.<a href="/src/Samsara.Net/FuelPurchases/FuelPurchasesClient.cs">CreateAsync</a>(FuelPurchasePostFuelPurchaseRequestBody { ... }) -> FuelPurchasePostFuelPurchaseResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a fuel purchase transaction.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Fuel Purchase** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FuelPurchases.CreateAsync(
    new FuelPurchasePostFuelPurchaseRequestBody
    {
        FuelQuantityLiters = "676.8",
        TransactionLocation = "350 Rhode Island St, San Francisco, CA 94103",
        TransactionPrice = new PostFuelPurchaseRequestBodyPriceRequestBody
        {
            Amount = "640.2",
            Currency = PostFuelPurchaseRequestBodyPriceRequestBodyCurrency.Usd,
        },
        TransactionReference = "5454534",
        TransactionTime = "2022-07-13T14:20:50.52-07:00",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FuelPurchasePostFuelPurchaseRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Gateways
<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">ListAsync</a>(GatewaysListRequest { ... }) -> Pager<GatewayResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all gateways

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Gateways** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Gateways.ListAsync(new GatewaysListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GatewaysListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">CreateAsync</a>(GatewaysPostGatewayRequestBody { ... }) -> GatewaysPostGatewayResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Activate a new gateway. To activate a device and associate it with your organization, enter its serial number. Each device's serial number can also be found on its label or packaging, or from your order confirmation email. A Not Found error could mean that the serial was not found or it has already been activated

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Gateways** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Gateways.CreateAsync(new GatewaysPostGatewayRequestBody { Serial = "GFRV-43N-VGX" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GatewaysPostGatewayRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deactivate a gateway

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Gateways** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Gateways.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Gateway serial number
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Idling
<details><summary><code>client.Idling.<a href="/src/Samsara.Net/Idling/IdlingClient.cs">ListAsync</a>(IdlingListRequest { ... }) -> Pager<IdlingEventObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get idling events for the requested time duration.

**Note:** The data from this endpoint comes from the new Advanced Idling Report, which provides additional data fields for each idling event such as air temperature, geofence, PTO state and minimum idle time. This endpoint will initially include data from August 1, 2024. Approx. two weeks later, this will be further back dated to January 1, 2024. If you require additional historical data, you can access it via the [vehicle idling reports API](https://developers.samsara.com/reference/getvehicleidlingreports).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Idling** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Idling.ListAsync(
    new IdlingListRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IdlingListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Issues
<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">ListAsync</a>(IssuesListRequest { ... }) -> IssuesGetIssuesResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all issues data for the specified IDs.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Issues** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Issues.ListAsync(new IssuesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">UpdateAsync</a>(IssuesPatchIssueRequestBody { ... }) -> IssuesPatchIssueResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an instance of an issue.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Issues** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Issues.UpdateAsync(
    new IssuesPatchIssueRequestBody { Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesPatchIssueRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">StreamAsync</a>(IssuesStreamRequest { ... }) -> Pager<IssueResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all issues data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Issues** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Issues.StreamAsync(new IssuesStreamRequest { StartTime = "startTime" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssuesStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## LiveShares
<details><summary><code>client.LiveShares.<a href="/src/Samsara.Net/LiveShares/LiveSharesClient.cs">ListAsync</a>(LiveSharesListRequest { ... }) -> Pager<LiveSharingLinkFullResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all non-expired Live Sharing Links.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Live Sharing Links** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LiveShares.ListAsync(new LiveSharesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiveSharesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LiveShares.<a href="/src/Samsara.Net/LiveShares/LiveSharesClient.cs">CreateAsync</a>(LiveSharingLinksCreateLiveSharingLinkRequestBody { ... }) -> LiveSharingLinksCreateLiveSharingLinkResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LiveShares.CreateAsync(
    new LiveSharingLinksCreateLiveSharingLinkRequestBody
    {
        Name = "Example Live Sharing Link name",
        Type = LiveSharingLinksCreateLiveSharingLinkRequestBodyType.AssetsLocation,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiveSharingLinksCreateLiveSharingLinkRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LiveShares.<a href="/src/Samsara.Net/LiveShares/LiveSharesClient.cs">DeleteAsync</a>(LiveSharesDeleteRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LiveShares.DeleteAsync(new LiveSharesDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiveSharesDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LiveShares.<a href="/src/Samsara.Net/LiveShares/LiveSharesClient.cs">UpdateAsync</a>(LiveSharingLinksUpdateLiveSharingLinkRequestBody { ... }) -> LiveSharingLinksUpdateLiveSharingLinkResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.LiveShares.UpdateAsync(
    new LiveSharingLinksUpdateLiveSharingLinkRequestBody
    {
        Id = "id",
        Name = "Example Live Sharing Link name",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LiveSharingLinksUpdateLiveSharingLinkRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Me
<details><summary><code>client.Me.<a href="/src/Samsara.Net/Me/MeClient.cs">GetAsync</a>() -> OrganizationInfoResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about your organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Org Information** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Me.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Readings
<details><summary><code>client.Readings.<a href="/src/Samsara.Net/Readings/ReadingsClient.cs">DefinitionsAsync</a>(ReadingsDefinitionsRequest { ... }) -> Pager<ReadingDefinitionResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

An introspection endpoint for discovering the set of readings including their name, description, data type, unit, and other metadata.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Readings.DefinitionsAsync(new ReadingsDefinitionsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReadingsDefinitionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Readings.<a href="/src/Samsara.Net/Readings/ReadingsClient.cs">HistoryAsync</a>(ReadingsHistoryRequest { ... }) -> Pager<ReadingHistoryResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the values of a reading for a set of entities within the specified time range. Returns a paginated response with data for the specified resource IDs where startTime <= happenedAtTime < endTime. End time of null implies endTime is infinite and all known readings are returned.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Readings.HistoryAsync(
    new ReadingsHistoryRequest { ReadingId = "readingId", EntityType = "entityType" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReadingsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Readings.<a href="/src/Samsara.Net/Readings/ReadingsClient.cs">LatestAsync</a>(ReadingsLatestRequest { ... }) -> Pager<ReadingSnapshotResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

An endpoint to get the last value of a reading for a set of entities at the specified time.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Readings.LatestAsync(
    new ReadingsLatestRequest { ReadingIds = "readingIds", EntityType = "entityType" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReadingsLatestRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SpeedingIntervals
<details><summary><code>client.SpeedingIntervals.<a href="/src/Samsara.Net/SpeedingIntervals/SpeedingIntervalsClient.cs">StreamAsync</a>(SpeedingIntervalsStreamRequest { ... }) -> Pager<TripSpeedingIntervalsResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return all speeding intervals associated with all trips that have been collected for your organization based on the time parameters passed in. Only completed trips are included. Trips with no speeding intervals detected will be returned with an empty list of intervals. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Speeding Intervals** under the Speeding Intervals category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SpeedingIntervals.StreamAsync(
    new SpeedingIntervalsStreamRequest { StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SpeedingIntervalsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tags
<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">ListAsync</a>(TagsListRequest { ... }) -> Pager<Tag></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return all of the tags for an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.ListAsync(new TagsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TagsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">CreateAsync</a>(CreateTagRequest { ... }) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new tag for the organization. This may include up to 20,000 tagged entities. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.CreateAsync(new CreateTagRequest { Name = "California" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateTagRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">GetAsync</a>(id) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch a tag by id. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Tag. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.name:ELD-exempt`.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">ReplaceAsync</a>(id, ReplaceTagRequest { ... }) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a tag with a new name and new members. This API call would replace all old members of a tag with new members specified in the request body. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.ReplaceAsync("id", new ReplaceTagRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Tag. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.name:ELD-exempt`.
    
</dd>
</dl>

<dl>
<dd>

**request:** `ReplaceTagRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">DeleteAsync</a>(id) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently deletes a tag. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Tag. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.name:ELD-exempt`.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">PatchAsync</a>(id, PatchTagRequest { ... }) -> TagResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing tag. **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard. 

 This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource. 

 For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tags.PatchAsync("id", new PatchTagRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the Tag. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.name:ELD-exempt`.
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatchTagRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## TrainingAssignments
<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">CreateAsync</a>(TrainingAssignmentsCreateRequest { ... }) -> TrainingAssignmentsPostTrainingAssignmentsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create training assignments. Existing assignments will remain unchanged. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Training APIs enabled for your organization.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TrainingAssignments.CreateAsync(
    new TrainingAssignmentsCreateRequest { CourseId = "courseId", DueAtTime = "dueAtTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrainingAssignmentsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">DeleteAsync</a>(TrainingAssignmentsDeleteRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint supports batch deletion operations. The response does not indicate which specific deletions, if any, have failed. On a successful deletion or partial failure, a ‘204 No Content’ status is returned. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Training APIs enabled for your organization.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TrainingAssignments.DeleteAsync(new TrainingAssignmentsDeleteRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrainingAssignmentsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">UpdateAsync</a>(TrainingAssignmentsUpdateRequest { ... }) -> TrainingAssignmentsPatchTrainingAssignmentsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update training assignments. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Training APIs enabled for your organization.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TrainingAssignments.UpdateAsync(
    new TrainingAssignmentsUpdateRequest { DueAtTime = "dueAtTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrainingAssignmentsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">StreamAsync</a>(TrainingAssignmentsStreamRequest { ... }) -> TrainingAssignmentsGetTrainingAssignmentsStreamResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all training assignments data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don't include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Training APIs enabled for your organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Training Assignments** under the Training Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TrainingAssignments.StreamAsync(
    new TrainingAssignmentsStreamRequest { StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrainingAssignmentsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## TrainingCourses
<details><summary><code>client.TrainingCourses.<a href="/src/Samsara.Net/TrainingCourses/TrainingCoursesClient.cs">ListAsync</a>(TrainingCoursesListRequest { ... }) -> Pager<TrainingCourseResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all training courses data. Results are paginated. 
 Courses in the ‘draft’ status are excluded from the data returned by this endpoint.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Training Courses** under the Training Courses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.TrainingCourses.ListAsync(new TrainingCoursesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TrainingCoursesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Trips
<details><summary><code>client.Trips.<a href="/src/Samsara.Net/Trips/TripsClient.cs">StreamAsync</a>(TripsStreamRequest { ... }) -> Pager<TripResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return trips that have been collected for your organization based on the time parameters passed in. Results are paginated. Reach out to your Samsara Representative to have this API enabled for your organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Trips** under the Trips category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Trips.StreamAsync(new TripsStreamRequest { StartTime = "startTime" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TripsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## UserRoles
<details><summary><code>client.UserRoles.<a href="/src/Samsara.Net/UserRoles/UserRolesClient.cs">ListAsync</a>(UserRolesListRequest { ... }) -> Pager<UserRole></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all user roles in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.UserRoles.ListAsync(new UserRolesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UserRolesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Users
<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">ListAsync</a>(UsersListRequest { ... }) -> Pager<User></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all users in an organization. Users that have expired access will not be returned. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.ListAsync(new UsersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">CreateAsync</a>(CreateUserRequest { ... }) -> UserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a user to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.CreateAsync(
    new CreateUserRequest
    {
        AuthType = CreateUserRequestAuthType.Default,
        Email = "user@company.com",
        Name = "Bob Smith",
        Roles = new List<CreateUserRequestRoles>()
        {
            new CreateUserRequestRoles { RoleId = "8a9371af-82d1-4158-bf91-4ecc8d3a114c" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateUserRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">GetAsync</a>(id) -> UserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific user's information. Users that have expired access will not be returned. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the user.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">DeleteAsync</a>(id) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the given user. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the user.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">UpdateAsync</a>(id, UpdateUserRequest { ... }) -> UserResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific user's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Users.UpdateAsync("id", new UpdateUserRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the user.
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateUserRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## V1Messages
<details><summary><code>client.V1Messages.<a href="/src/Samsara.Net/V1Messages/V1MessagesClient.cs">ListAsync</a>(V1MessagesListRequest { ... }) -> InlineResponse2005</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

<n class="warning">
<nh>
<i class="fa fa-exclamation-circle"></i>
This endpoint is still on our legacy API.
</nh>
</n>

Get all messages. 

 <b>Rate limit:</b> 75 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Messages** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.V1Messages.ListAsync(new V1MessagesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `V1MessagesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.V1Messages.<a href="/src/Samsara.Net/V1Messages/V1MessagesClient.cs">CreateAsync</a>(InlineObject2 { ... }) -> InlineResponse2006</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

<n class="warning">
<nh>
<i class="fa fa-exclamation-circle"></i>
This endpoint is still on our legacy API.
</nh>
</n>

Send a message to a list of driver ids. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Messages** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.V1Messages.CreateAsync(
    new InlineObject2
    {
        DriverIds = new List<long>() { 111, 222, 333 },
        Text = "This is a message.",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InlineObject2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">ListAsync</a>(WebhooksListRequest { ... }) -> Pager<WebhookResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all webhooks belonging to a specific org.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Webhooks** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.ListAsync(new WebhooksListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WebhooksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">CreateAsync</a>(WebhooksPostWebhooksRequestBody { ... }) -> WebhooksPostWebhooksResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a webhook

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.CreateAsync(
    new WebhooksPostWebhooksRequestBody
    {
        Name = "Webhook-123",
        Url = "https://www.Webhook-123.com/webhook/listener",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WebhooksPostWebhooksRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">GetAsync</a>(id) -> WebhooksGetWebhookResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a webhook with given ID.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Webhooks** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the webhook. This is the Samsara-specified ID.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a webhook with the given ID.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.DeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the webhook to delete.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">PatchAsync</a>(id, WebhooksPatchWebhookRequestBody { ... }) -> WebhooksPatchWebhookResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific webhook's information.  **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard.
 This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource.
 For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Webhooks.PatchAsync("id", new WebhooksPatchWebhookRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — Unique identifier for the webhook to update.
    
</dd>
</dl>

<dl>
<dd>

**request:** `WebhooksPatchWebhookRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Alerts Configurations
<details><summary><code>client.Alerts.Configurations.<a href="/src/Samsara.Net/Alerts/Configurations/ConfigurationsClient.cs">ListAsync</a>(ConfigurationsListRequest { ... }) -> Pager<GetResponseWorkflowConfigurationObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get specified Alert Configurations.

The following trigger types are API enabled and will show up in the results:
Vehicle Speed
Ambient Temperature
Fuel Level (Percentage)
Vehicle DEF Level (Percentage)
Vehicle Battery
Gateway Unplugged
Dashcam Disconnected
Camera Connector Disconnected
Asset starts moving
Inside Geofence
Outside Geofence
Unassigned Driving
Driver HOS Violation
Vehicle Engine Idle
Asset Engine On
Asset Engine Off
Harsh Event
Scheduled Maintenance
Scheduled Maintenance by Odometer
Scheduled Maintenance by Engine Hours
Out of Route
GPS Signal Loss
Cell Signal Loss
Fault Code
Tire Faults
Gateway Disconnected
Panic Button
Tampering Detected
Asset Reading
If vehicle is severely speeding (as defined by your organization)
DVIR Submitted for Asset
Driver Document Submitted
Driver App Sign In
Driver App Sign Out
Geofence Entry
Geofence Exit
Route Stop ETA Alert
Driver Recorded
Sudden Fuel Level Rise
Sudden Fuel Level Drop
Scheduled Date And Time
Training Assignment Due Soon
Training Assignment Past Due

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Alerts** under the Alerts category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Alerts.Configurations.ListAsync(new ConfigurationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConfigurationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Alerts.Configurations.<a href="/src/Samsara.Net/Alerts/Configurations/ConfigurationsClient.cs">CreateAsync</a>(AlertsPostConfigurationsRequestBody { ... }) -> AlertsPostConfigurationsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Alerts.Configurations.CreateAsync(
    new AlertsPostConfigurationsRequestBody
    {
        Actions = new List<ActionObjectRequestBody>()
        {
            new ActionObjectRequestBody { ActionTypeId = 1 },
        },
        IsEnabled = true,
        Name = "My Harsh Event Alert",
        Scope = new ScopeObjectRequestBody { All = true },
        Triggers = new List<WorkflowTriggerObjectRequestBody>()
        {
            new WorkflowTriggerObjectRequestBody { TriggerTypeId = 1000 },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AlertsPostConfigurationsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Alerts.Configurations.<a href="/src/Samsara.Net/Alerts/Configurations/ConfigurationsClient.cs">DeleteAsync</a>(ConfigurationsDeleteRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Alerts.Configurations.DeleteAsync(new ConfigurationsDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ConfigurationsDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Alerts.Configurations.<a href="/src/Samsara.Net/Alerts/Configurations/ConfigurationsClient.cs">UpdateAsync</a>(AlertsPatchConfigurationsRequestBody { ... }) -> AlertsPatchConfigurationsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Alerts.Configurations.UpdateAsync(
    new AlertsPatchConfigurationsRequestBody { Id = "e1c5dffc-c7b7-47b0-a778-6a65de638abf" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AlertsPatchConfigurationsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Alerts Incidents
<details><summary><code>client.Alerts.Incidents.<a href="/src/Samsara.Net/Alerts/Incidents/IncidentsClient.cs">StreamAsync</a>(IncidentsStreamRequest { ... }) -> Pager<GetWorkflowIncidentResponseObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get Alert Incidents for specific Alert Configurations over a specified period of time.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Alerts** under the Alerts category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Alerts.Incidents.StreamAsync(new IncidentsStreamRequest { StartTime = "startTime" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IncidentsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Assets LocationAndSpeed
<details><summary><code>client.Assets.LocationAndSpeed.<a href="/src/Samsara.Net/Assets/LocationAndSpeed/LocationAndSpeedClient.cs">StreamAsync</a>(LocationAndSpeedStreamRequest { ... }) -> Pager<LocationAndSpeedResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return asset locations and speed data that has been collected for your organization based on the time parameters passed in. Results are paginated. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. The endpoint will only return data up until the endTime that has been processed by the server at the time of the original request. You will need to request the same [startTime, endTime) range again to receive data for assets processed after the original request time. This endpoint sorts the time-series data by device.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.LocationAndSpeed.StreamAsync(new LocationAndSpeedStreamRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationAndSpeedStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Auth Tokens
<details><summary><code>client.Auth.Tokens.<a href="/src/Samsara.Net/Auth/Tokens/TokensClient.cs">CreateAsync</a>(TokensCreateRequest { ... }) -> CreateTokensResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exchange an authorization code for access and refresh tokens.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.Tokens.CreateAsync(new TokensCreateRequest { GrantType = "authorization_code" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TokensCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Auth.Tokens.<a href="/src/Samsara.Net/Auth/Tokens/TokensClient.cs">RevokeAsync</a>(TokensRevokeRequest { ... }) -> CreateTokensResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Invalidates access tokens and refresh tokens for that organization
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.Tokens.RevokeAsync(new TokensRevokeRequest { Token = "token" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TokensRevokeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Cameras Media
<details><summary><code>client.Cameras.Media.<a href="/src/Samsara.Net/Cameras/Media/MediaClient.cs">ListAsync</a>(MediaListRequest { ... }) -> MediaRetrievalListUploadedMediaResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns a list of all uploaded media (video and still images) matching query parameters, with a maximum query range of one day. Additional media can be retrieved with the [Create a media retrieval request](https://developers.samsara.com/reference/postmediaretrieval) endpoint, and they will be included in the list after they are uploaded. Urls provided by this endpoint expire in 8 hours.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Media Retrieval** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cameras.Media.ListAsync(
    new MediaListRequest
    {
        VehicleIds = "vehicleIds",
        StartTime = "startTime",
        EndTime = "endTime",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MediaListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Cameras Media Retrieval
<details><summary><code>client.Cameras.Media.Retrieval.<a href="/src/Samsara.Net/Cameras/Media/Retrieval/RetrievalClient.cs">GetAsync</a>(RetrievalGetRequest { ... }) -> MediaRetrievalGetMediaRetrievalResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns media information corresponding to a retrieval ID. Retrieval IDs are associated to prior [media retrieval requests](https://developers.samsara.com/reference/postmediaretrieval). Urls provided by this endpoint expire in 8 hours.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Media Retrieval** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cameras.Media.Retrieval.GetAsync(
    new RetrievalGetRequest { RetrievalId = "retrievalId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RetrievalGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Cameras.Media.Retrieval.<a href="/src/Samsara.Net/Cameras/Media/Retrieval/RetrievalClient.cs">CreateAsync</a>(MediaRetrievalPostMediaRetrievalRequestBody { ... }) -> MediaRetrievalPostMediaRetrievalResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint creates an asynchronous request to upload certain media from a device. The closest available media to the requested timestamp is returned. Images and high-res videos are supported; other types of media (e.g. hyperlapse, low-res) are planned to be supported in the future. Currently, only unblurred media is supported. If a device is offline, the requested media will be uploaded once it comes back online. Quota limits are enforced for media retrievals made through the API. The Create a media retrieval request response includes information about the media retrieval quota remaining for the organization. The media retrieval quota for the organization is reset at the beginning of each month.The quota is expressed using seconds of High Resolution video. 10 still images are equivalent to a 1 second of High Resolution footage.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Media Retrieval** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Cameras.Media.Retrieval.CreateAsync(
    new MediaRetrievalPostMediaRetrievalRequestBody
    {
        EndTime = "2019-06-13T19:08:55Z",
        Inputs = new List<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>()
        {
            MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
            MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
        },
        MediaType = MediaRetrievalPostMediaRetrievalRequestBodyMediaType.Image,
        StartTime = "2019-06-13T19:08:25Z",
        VehicleId = "1234",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MediaRetrievalPostMediaRetrievalRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Coaching DriverCoachAssignments
<details><summary><code>client.Coaching.DriverCoachAssignments.<a href="/src/Samsara.Net/Coaching/DriverCoachAssignments/DriverCoachAssignmentsClient.cs">ListAsync</a>(DriverCoachAssignmentsListRequest { ... }) -> Pager<CoachAssignmentWithDriverExternalIdsResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return coach assignments for your organization based on the parameters passed in. Results are paginated.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Coaching.DriverCoachAssignments.ListAsync(new DriverCoachAssignmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverCoachAssignmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Coaching.DriverCoachAssignments.<a href="/src/Samsara.Net/Coaching/DriverCoachAssignments/DriverCoachAssignmentsClient.cs">UpdateAsync</a>(DriverCoachAssignmentsUpdateRequest { ... }) -> DriverCoachAssignmentsPutDriverCoachAssignmentResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will update an existing or create a new coach-to-driver assignment for your organization based on the parameters passed in. This endpoint should only be used for existing Coach to Driver assignments. In order to remove a driver-coach-assignment for a given driver, set coachId to null

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Coaching** under the Coaching category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Coaching.DriverCoachAssignments.UpdateAsync(
    new DriverCoachAssignmentsUpdateRequest { DriverId = "driverId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverCoachAssignmentsUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Coaching Sessions
<details><summary><code>client.Coaching.Sessions.<a href="/src/Samsara.Net/Coaching/Sessions/SessionsClient.cs">StreamAsync</a>(SessionsStreamRequest { ... }) -> Pager<CoachingSessionsResponseResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return coaching sessions for your organization based on the time parameters passed in. Results are paginated by sessions. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Coaching.Sessions.StreamAsync(
    new SessionsStreamRequest { StartTime = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SessionsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents Pdfs
<details><summary><code>client.Documents.Pdfs.<a href="/src/Samsara.Net/Documents/Pdfs/PdfsClient.cs">CreateAsync</a>(DocumentPdfGenerationRequest { ... }) -> DocumentPdfGenerationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Request creation of a document PDF. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.Pdfs.CreateAsync(
    new DocumentPdfGenerationRequest { DocumentId = "6c8c0c01-206a-41a4-9d21-15b9978d04cb" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentPdfGenerationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.Pdfs.<a href="/src/Samsara.Net/Documents/Pdfs/PdfsClient.cs">GetAsync</a>(id) -> DocumentPdfQueryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns generation job status and download URL for a PDF. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.Pdfs.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the pdf.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Drivers QrCodes
<details><summary><code>client.Drivers.QrCodes.<a href="/src/Samsara.Net/Drivers/QrCodes/QrCodesClient.cs">ListAsync</a>(QrCodesListRequest { ... }) -> DriverQrCodesGetDriversQrCodesResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details for requested driver(s) QR code, used for driver trip assignment.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.QrCodes.ListAsync(new QrCodesListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `QrCodesListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.QrCodes.<a href="/src/Samsara.Net/Drivers/QrCodes/QrCodesClient.cs">CreateAsync</a>(DriverQrCodesCreateDriverQrCodeRequestBody { ... }) -> DriverQrCodesCreateDriverQrCodeResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Assign a new QR code for the requested driver. Return error if an active QR code already exists.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.QrCodes.CreateAsync(
    new DriverQrCodesCreateDriverQrCodeRequestBody { DriverId = 494123 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverQrCodesCreateDriverQrCodeRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.QrCodes.<a href="/src/Samsara.Net/Drivers/QrCodes/QrCodesClient.cs">DeleteAsync</a>(DriverQrCodesDeleteDriverQrCodeRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Revoke requested driver's currently active QR code.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.QrCodes.DeleteAsync(
    new DriverQrCodesDeleteDriverQrCodeRequestBody { DriverId = 494123 }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverQrCodesDeleteDriverQrCodeRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Drivers VehicleAssignments
<details><summary><code>client.Drivers.VehicleAssignments.<a href="/src/Samsara.Net/Drivers/VehicleAssignments/VehicleAssignmentsClient.cs">ListAsync</a>(VehicleAssignmentsListRequest { ... }) -> DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdrivervehicleassignments) instead. The endpoint will continue to function as documented.** Get all vehicle assignments for the requested drivers in the requested time range. The only type of assignment supported right now are assignments created through the driver app.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.VehicleAssignments.ListAsync(new VehicleAssignmentsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehicleAssignmentsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Equipment Locations
<details><summary><code>client.Equipment.Locations.<a href="/src/Samsara.Net/Equipment/Locations/LocationsClient.cs">ListAsync</a>(LocationsListRequest { ... }) -> Pager<EquipmentLocationsResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns last known locations for all equipment. This can be optionally filtered by tags or specific equipment IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Locations.ListAsync(new LocationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.Locations.<a href="/src/Samsara.Net/Equipment/Locations/LocationsClient.cs">FeedAsync</a>(LocationsFeedRequest { ... }) -> Pager<EquipmentLocationsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Follow a continuous feed of all equipment locations.

Your first call to this endpoint will provide you with the most recent location for each unit of equipment and a `pagination` object that contains an `endCursor`.

You can provide the `endCursor` to subsequent calls via the `after` parameter. The response will contain any equipment location updates since that `endCursor`.

If `hasNextPage` is `false`, no updates are readily available yet. We'd suggest waiting a minimum of 5 seconds before requesting updates. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Locations.FeedAsync(new LocationsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.Locations.<a href="/src/Samsara.Net/Equipment/Locations/LocationsClient.cs">HistoryAsync</a>(LocationsHistoryRequest { ... }) -> Pager<EquipmentLocationsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns historical equipment locations during the given time range. This can be optionally filtered by tags or specific equipment IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Locations.HistoryAsync(
    new LocationsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Equipment Stats
<details><summary><code>client.Equipment.Stats.<a href="/src/Samsara.Net/Equipment/Stats/StatsClient.cs">ListAsync</a>(StatsListRequest { ... }) -> Pager<EquipmentStatsResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the last known stats for all equipment. This can be optionally filtered by tags or specific equipment IDs. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Stats.ListAsync(new StatsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.Stats.<a href="/src/Samsara.Net/Equipment/Stats/StatsClient.cs">FeedAsync</a>(StatsFeedRequest { ... }) -> Pager<EquipmentStatsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Follow a continuous feed of all equipment stats.

Your first call to this endpoint will provide you with the most recent stats for each unit of equipment and a `pagination` object that contains an `endCursor`.

You can provide the `endCursor` to subsequent calls via the `after` parameter. The response will contain any equipment stats updates since that `endCursor`.

If `hasNextPage` is `false`, no updates are readily available yet. Each stat type has a different refresh rate, but in general we'd suggest waiting a minimum of 5 seconds before requesting updates. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Stats.FeedAsync(new StatsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.Stats.<a href="/src/Samsara.Net/Equipment/Stats/StatsClient.cs">HistoryAsync</a>(StatsHistoryRequest { ... }) -> Pager<EquipmentStatsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns historical equipment status during the given time range. This can be optionally filtered by tags or specific equipment IDs. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Equipment.Stats.HistoryAsync(
    new StatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FormSubmissions PdfExports
<details><summary><code>client.FormSubmissions.PdfExports.<a href="/src/Samsara.Net/FormSubmissions/PdfExports/PdfExportsClient.cs">GetAsync</a>(PdfExportsGetRequest { ... }) -> FormSubmissionsGetFormSubmissionsPdfExportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a PDF export that has already been generated for a form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.PdfExports.GetAsync(new PdfExportsGetRequest { PdfId = "pdfId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PdfExportsGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FormSubmissions.PdfExports.<a href="/src/Samsara.Net/FormSubmissions/PdfExports/PdfExportsClient.cs">CreateAsync</a>(PdfExportsCreateRequest { ... }) -> FormSubmissionsPostFormSubmissionsPdfExportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a PDF export for an existing form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FormSubmissions.PdfExports.CreateAsync(new PdfExportsCreateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PdfExportsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ifta Csv
<details><summary><code>client.Ifta.Csv.<a href="/src/Samsara.Net/Ifta/Csv/CsvClient.cs">CreateAsync</a>(IftaCreateIftaDetailJobRequestBody { ... }) -> IftaCreateIftaDetailJobResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a job to generate csv files of IFTA mileage segments.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write IFTA (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ifta.Csv.CreateAsync(
    new IftaCreateIftaDetailJobRequestBody
    {
        EndHour = "2019-06-13T19:00:00Z",
        StartHour = "2019-06-13T19:00:00Z",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IftaCreateIftaDetailJobRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ifta.Csv.<a href="/src/Samsara.Net/Ifta/Csv/CsvClient.cs">GetAsync</a>(id) -> IftaGetIftaDetailJobResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about an existing IFTA detail job.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Ifta.Csv.GetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` — ID of the requested job.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Maintenance ServiceTasks
<details><summary><code>client.Maintenance.ServiceTasks.<a href="/src/Samsara.Net/Maintenance/ServiceTasks/ServiceTasksClient.cs">ListAsync</a>(ServiceTasksListRequest { ... }) -> Pager<ServiceTaskDefinitionObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets service tasks.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.ServiceTasks.ListAsync(new ServiceTasksListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ServiceTasksListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.ServiceTasks.<a href="/src/Samsara.Net/Maintenance/ServiceTasks/ServiceTasksClient.cs">CreateAsync</a>()</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.ServiceTasks.CreateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.ServiceTasks.<a href="/src/Samsara.Net/Maintenance/ServiceTasks/ServiceTasksClient.cs">DeleteAsync</a>()</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.ServiceTasks.DeleteAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.ServiceTasks.<a href="/src/Samsara.Net/Maintenance/ServiceTasks/ServiceTasksClient.cs">UpdateAsync</a>()</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.ServiceTasks.UpdateAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Maintenance WorkOrders
<details><summary><code>client.Maintenance.WorkOrders.<a href="/src/Samsara.Net/Maintenance/WorkOrders/WorkOrdersClient.cs">ListAsync</a>(WorkOrdersListRequest { ... }) -> Pager<WorkOrderObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets work orders.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.WorkOrders.ListAsync(new WorkOrdersListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkOrdersListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.WorkOrders.<a href="/src/Samsara.Net/Maintenance/WorkOrders/WorkOrdersClient.cs">CreateAsync</a>(WorkOrdersPostWorkOrdersRequestBody { ... }) -> WorkOrdersPostWorkOrdersResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.WorkOrders.CreateAsync(
    new WorkOrdersPostWorkOrdersRequestBody { AssetId = "12443" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkOrdersPostWorkOrdersRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.WorkOrders.<a href="/src/Samsara.Net/Maintenance/WorkOrders/WorkOrdersClient.cs">DeleteAsync</a>(WorkOrdersDeleteRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.WorkOrders.DeleteAsync(new WorkOrdersDeleteRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkOrdersDeleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.WorkOrders.<a href="/src/Samsara.Net/Maintenance/WorkOrders/WorkOrdersClient.cs">UpdateAsync</a>(WorkOrdersPatchWorkOrdersRequestBody { ... }) -> WorkOrdersPatchWorkOrdersResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.WorkOrders.UpdateAsync(
    new WorkOrdersPatchWorkOrdersRequestBody { Id = "5" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkOrdersPatchWorkOrdersRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.WorkOrders.<a href="/src/Samsara.Net/Maintenance/WorkOrders/WorkOrdersClient.cs">StreamAsync</a>(WorkOrdersStreamRequest { ... }) -> Pager<WorkOrderObjectResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stream work orders.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Work Orders** under the Closed Beta category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Maintenance.WorkOrders.StreamAsync(
    new WorkOrdersStreamRequest { StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `WorkOrdersStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports Drivers FuelEnergy
<details><summary><code>client.Reports.Drivers.FuelEnergy.<a href="/src/Samsara.Net/Reports/Drivers/FuelEnergy/FuelEnergyClient.cs">ListAsync</a>(FuelEnergyListRequest { ... }) -> FuelEnergyGetFuelEnergyDriverReportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get fuel and energy efficiency driver reports for the requested time range.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.Drivers.FuelEnergy.ListAsync(
    new FuelEnergyListRequest { StartDate = "startDate", EndDate = "endDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FuelEnergyListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports Ifta Jurisdiction
<details><summary><code>client.Reports.Ifta.Jurisdiction.<a href="/src/Samsara.Net/Reports/Ifta/Jurisdiction/JurisdictionClient.cs">GetAsync</a>(JurisdictionGetRequest { ... }) -> IftaGetIftaJurisdictionReportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all jurisdiction IFTA reports for the requested time duration. Data is returned in your organization's defined timezone.

**Note:** The most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.Ifta.Jurisdiction.GetAsync(new JurisdictionGetRequest { Year = 1 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `JurisdictionGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports Ifta Vehicle
<details><summary><code>client.Reports.Ifta.Vehicle.<a href="/src/Samsara.Net/Reports/Ifta/Vehicle/VehicleClient.cs">ListAsync</a>(VehicleListRequest { ... }) -> IftaGetIftaVehicleReportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all vehicle IFTA reports for the requested time duration. Data is returned in your organization's defined timezone.

**Note:** The most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.Ifta.Vehicle.ListAsync(new VehicleListRequest { Year = 1 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehicleListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports Vehicles Idling
<details><summary><code>client.Reports.Vehicles.Idling.<a href="/src/Samsara.Net/Reports/Vehicles/Idling/IdlingClient.cs">ListAsync</a>(IdlingListRequest { ... }) -> Pager<IdlingReportEventResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all vehicle idling reports for the requested time duration.

**Note:** We are gradually releasing the new Advanced Idling Report, which provides additional data fields for each idling event such as air temperature, geofence, PTO state and minimum idle time. We have released the associated API in Beta to gather valuable feedback. You can access the Beta API [here](https://developers.samsara.com/reference/getidlingevents).

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.Vehicles.Idling.ListAsync(
    new IdlingListRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IdlingListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Reports Vehicles FuelEnergy
<details><summary><code>client.Reports.Vehicles.FuelEnergy.<a href="/src/Samsara.Net/Reports/Vehicles/FuelEnergy/FuelEnergyClient.cs">ListAsync</a>(FuelEnergyListRequest { ... }) -> FuelEnergyGetFuelEnergyVehicleReportsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get fuel and energy efficiency vehicle reports for the requested time range.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Reports.Vehicles.FuelEnergy.ListAsync(
    new FuelEnergyListRequest { StartDate = "startDate", EndDate = "endDate" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FuelEnergyListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Routes AuditLogs
<details><summary><code>client.Routes.AuditLogs.<a href="/src/Samsara.Net/Routes/AuditLogs/AuditLogsClient.cs">FeedAsync</a>(AuditLogsFeedRequest { ... }) -> RoutesGetRoutesFeedResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Subscribes to a feed of immutable, append-only updates for routes. The initial request to this feed endpoint returns a cursor, which can be used on the next request to fetch updated routes that have had state changes since that request.

The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/fetchAllRouteJobUpdates).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Routes.AuditLogs.FeedAsync(new AuditLogsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuditLogsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SafetyEvents AuditLogs
<details><summary><code>client.SafetyEvents.AuditLogs.<a href="/src/Samsara.Net/SafetyEvents/AuditLogs/AuditLogsClient.cs">FeedAsync</a>(AuditLogsFeedRequest { ... }) -> Pager<SafetyEventActivityFeedItemResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get continuous safety events. The safety activity event feed offers a change-log for safety events. Use this endpoint to subscribe to safety event changes. See documentation below for all supported change-log types.

| ActivityType      | Description |
| ----------- | ----------- |
| CreateSafetyEventActivityType | a new safety event is processed by Samsara      |
| BehaviorLabelActivityType     | a label is added or removed from a safety event |
| CoachingStateActivityType     | a safety event coaching state is updated        |

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.SafetyEvents.AuditLogs.FeedAsync(new AuditLogsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuditLogsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Settings Compliance
<details><summary><code>client.Settings.Compliance.<a href="/src/Samsara.Net/Settings/Compliance/ComplianceClient.cs">GetAsync</a>() -> SettingsGetComplianceSettingsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get organization's compliance settings, including carrier name, office address, and DOT number

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Settings.Compliance.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Settings.Compliance.<a href="/src/Samsara.Net/Settings/Compliance/ComplianceClient.cs">UpdateAsync</a>(SettingsPatchComplianceSettingsRequestBody { ... }) -> SettingsPatchComplianceSettingsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update organization's compliance settings, including carrier name, office address, and DOT number

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Settings.Compliance.UpdateAsync(new SettingsPatchComplianceSettingsRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsPatchComplianceSettingsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Settings DriverApp
<details><summary><code>client.Settings.DriverApp.<a href="/src/Samsara.Net/Settings/DriverApp/DriverAppClient.cs">GetAsync</a>() -> SettingsGetDriverAppSettingsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get driver app settings.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Driver App Settings** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Settings.DriverApp.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Settings.DriverApp.<a href="/src/Samsara.Net/Settings/DriverApp/DriverAppClient.cs">UpdateAsync</a>(SettingsPatchDriverAppSettingsRequestBody { ... }) -> SettingsPatchDriverAppSettingsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update driver app settings.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Write Driver App Settings** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Settings.DriverApp.UpdateAsync(new SettingsPatchDriverAppSettingsRequestBody());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SettingsPatchDriverAppSettingsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Settings Safety
<details><summary><code>client.Settings.Safety.<a href="/src/Samsara.Net/Settings/Safety/SafetyClient.cs">GetAsync</a>() -> SafetySettingsGetSafetySettingsResponseBody</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get safety settings

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Settings.Safety.GetAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tachograph Driver
<details><summary><code>client.Tachograph.Driver.<a href="/src/Samsara.Net/Tachograph/Driver/DriverClient.cs">ActivityAsync</a>(DriverActivityRequest { ... }) -> DriverTachographActivityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph activity for all specified drivers in the time range. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tachograph.Driver.ActivityAsync(
    new DriverActivityRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverActivityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tachograph.Driver.<a href="/src/Samsara.Net/Tachograph/Driver/DriverClient.cs">FilesAsync</a>(DriverFilesRequest { ... }) -> TachographDriverFilesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph files for all specified drivers in the time range. 

 <b>Rate limit:</b> 50 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tachograph.Driver.FilesAsync(
    new DriverFilesRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DriverFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tachograph Vehicles
<details><summary><code>client.Tachograph.Vehicles.<a href="/src/Samsara.Net/Tachograph/Vehicles/VehiclesClient.cs">FilesAsync</a>(VehiclesFilesRequest { ... }) -> TachographVehicleFilesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph files for all specified vehicles in the time range. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tachograph.Vehicles.FilesAsync(
    new VehiclesFilesRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `VehiclesFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Vehicles Immobilizer
<details><summary><code>client.Vehicles.Immobilizer.<a href="/src/Samsara.Net/Vehicles/Immobilizer/ImmobilizerClient.cs">StreamAsync</a>(ImmobilizerStreamRequest { ... }) -> Pager<EngineImmobilizerStateResponseBody></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the engine immobilizer states of the queried vehicles. If a vehicle has never had an engine immobilizer connected, there won't be any state returned for that vehicle.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).

To use this endpoint, select **Read Vehicle Immobilization** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Immobilizer.StreamAsync(
    new ImmobilizerStreamRequest { VehicleIds = "vehicleIds", StartTime = "startTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ImmobilizerStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Vehicles Locations
<details><summary><code>client.Vehicles.Locations.<a href="/src/Samsara.Net/Vehicles/Locations/LocationsClient.cs">ListAsync</a>(LocationsListRequest { ... }) -> Pager<VehicleLocationsResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestats) instead.***

Returns the last known location of all vehicles at the given `time`. If no `time` is specified, the current time is used. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: <a href="/docs/vehicle-locations-1" target="_blank">Vehicle Locations</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Locations.ListAsync(new LocationsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.Locations.<a href="/src/Samsara.Net/Vehicles/Locations/LocationsClient.cs">FeedAsync</a>(LocationsFeedRequest { ... }) -> Pager<VehicleLocationsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatsfeed) instead.***

Follow a continuous feed of all vehicle locations from Samsara Vehicle Gateways.

Your first call to this endpoint will provide you with the most recent location for each vehicle and a `pagination` object that contains an `endCursor`.

You can provide the `endCursor` to the `after` parameter of this endpoint to get location updates since that `endCursor`. 

If `hasNextPage` is `false`, no updates are readily available yet. We'd suggest waiting a minimum of 5 seconds before requesting updates.

Related guide: <a href="/docs/vehicle-locations-1" target="_blank">Vehicle Locations</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Locations.FeedAsync(new LocationsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.Locations.<a href="/src/Samsara.Net/Vehicles/Locations/LocationsClient.cs">HistoryAsync</a>(LocationsHistoryRequest { ... }) -> Pager<VehicleLocationsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatshistory) instead.***

Returns all known vehicle locations during the given time range. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: <a href="/docs/vehicle-locations-1" target="_blank">Vehicle Locations</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Locations.HistoryAsync(
    new LocationsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `LocationsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Vehicles Stats
<details><summary><code>client.Vehicles.Stats.<a href="/src/Samsara.Net/Vehicles/Stats/StatsClient.cs">ListAsync</a>(StatsListRequest { ... }) -> Pager<VehicleStatsResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the last known stats of all vehicles at the given `time`. If no `time` is specified, the current time is used.

Related guide: <a href="/docs/telematics" target="_blank">Telematics</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Stats.ListAsync(new StatsListRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.Stats.<a href="/src/Samsara.Net/Vehicles/Stats/StatsClient.cs">FeedAsync</a>(StatsFeedRequest { ... }) -> Pager<VehicleStatsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Follow a feed of vehicle stats. 

Your first call to this endpoint will provide you with the most recent stats for each vehicle and an `endCursor`.

You can the provide the `endCursor` value to the `after` query parameter to get all updates since the last call you made.

If `hasNextPage` is `false`, no new data is immediately available. You should wait a minimum of 5 seconds making a subsequent request.

Related guide: <a href="/docs/telematics" target="_blank">Telematics</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Stats.FeedAsync(new StatsFeedRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.Stats.<a href="/src/Samsara.Net/Vehicles/Stats/StatsClient.cs">HistoryAsync</a>(StatsHistoryRequest { ... }) -> Pager<VehicleStatsListResponseData></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns vehicle stats during the given time range for all vehicles. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: <a href="/docs/telematics" target="_blank">Telematics</a>. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Vehicles.Stats.HistoryAsync(
    new StatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StatsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
