# Reference
## Addresses
<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">ListAsync</a>(ListAddressesRequest { ... }) -> Pager&lt;Address&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all addresses in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Addresses** under the Addresses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Addresses.ListAsync(new ListAddressesRequest());
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

**request:** `ListAddressesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">CreateAsync</a>(CreateAddressRequest { ... }) -> WithRawResponseTask&lt;AddressResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new address in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;AddressResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Addresses** under the Addresses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Addresses.<a href="/src/Samsara.Net/Addresses/AddressesClient.cs">UpdateAsync</a>(id, UpdateAddressRequest { ... }) -> WithRawResponseTask&lt;AddressResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific address. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Addresses** under the Addresses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

## Alerts
<details><summary><code>client.Alerts.<a href="/src/Samsara.Net/Alerts/AlertsClient.cs">GetConfigurationsAsync</a>(GetConfigurationsRequest { ... }) -> WithRawResponseTask&lt;AlertsGetConfigurationsResponseBody&gt;</code></summary>
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
A safety event occurred with a driver assigned
A safety event occurred
Sudden Fuel Level Rise
Sudden Fuel Level Drop
Scheduled Date And Time
Training Assignment Due Soon
Training Assignment Past Due

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Alerts** under the Alerts category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Alerts.GetConfigurationsAsync(new GetConfigurationsRequest());
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

**request:** `GetConfigurationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Alerts.<a href="/src/Samsara.Net/Alerts/AlertsClient.cs">PostConfigurationsAsync</a>(AlertsPostConfigurationsRequestBody { ... }) -> WithRawResponseTask&lt;AlertsPostConfigurationsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Alerts.PostConfigurationsAsync(
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

<details><summary><code>client.Alerts.<a href="/src/Samsara.Net/Alerts/AlertsClient.cs">DeleteConfigurationsAsync</a>(DeleteConfigurationsRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Alerts.DeleteConfigurationsAsync(new DeleteConfigurationsRequest { Id = "id" });
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

**request:** `DeleteConfigurationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Alerts.<a href="/src/Samsara.Net/Alerts/AlertsClient.cs">PatchConfigurationsAsync</a>(AlertsPatchConfigurationsRequestBody { ... }) -> WithRawResponseTask&lt;AlertsPatchConfigurationsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an alert configuration.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Alerts** under the Alerts category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Alerts.PatchConfigurationsAsync(
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

<details><summary><code>client.Alerts.<a href="/src/Samsara.Net/Alerts/AlertsClient.cs">GetIncidentsAsync</a>(GetIncidentsRequest { ... }) -> WithRawResponseTask&lt;AlertsGetIncidentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get Alert Incidents for specific Alert Configurations over a specified period of time.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Alerts** under the Alerts category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Alerts.GetIncidentsAsync(new GetIncidentsRequest { StartTime = "startTime" });
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

**request:** `GetIncidentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Assets
<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">ListAsync</a>(ListAssetsRequest { ... }) -> Pager&lt;AssetResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all assets. Up to 300 assets will be returned per page.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Assets.ListAsync(new ListAssetsRequest());
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

**request:** `ListAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">CreateAssetAsync</a>(AssetsCreateAssetRequestBody { ... }) -> WithRawResponseTask&lt;AssetsCreateAssetResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Assets.CreateAssetAsync(new AssetsCreateAssetRequestBody());
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

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">DeleteAssetAsync</a>(DeleteAssetRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an existing asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Assets.DeleteAssetAsync(new DeleteAssetRequest { Id = "id" });
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

**request:** `DeleteAssetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">UpdateAssetAsync</a>(AssetsUpdateAssetRequestBody { ... }) -> WithRawResponseTask&lt;AssetsUpdateAssetResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Assets.UpdateAssetAsync(new AssetsUpdateAssetRequestBody { Id = "id" });
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

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">V1GetAllAssetCurrentLocationsAsync</a>(V1GetAllAssetCurrentLocationsRequest { ... }) -> WithRawResponseTask&lt;InlineResponse2002&gt;</code></summary>
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

Fetch current locations of all assets. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Assets.V1GetAllAssetCurrentLocationsAsync(new V1GetAllAssetCurrentLocationsRequest());
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

**request:** `V1GetAllAssetCurrentLocationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">V1GetAssetsReefersAsync</a>(V1GetAssetsReefersRequest { ... }) -> WithRawResponseTask&lt;InlineResponse2003&gt;</code></summary>
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

Fetches all reefers and reefer-specific stats. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Assets.V1GetAssetsReefersAsync(
    new V1GetAssetsReefersRequest { StartMs = 1000000, EndMs = 1000000 }
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

**request:** `V1GetAssetsReefersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">V1GetAssetLocationAsync</a>(assetId, V1GetAssetLocationRequest { ... }) -> WithRawResponseTask&lt;IEnumerable&lt;V1AssetLocationResponseItem&gt;&gt;</code></summary>
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

List historical locations for a given asset. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Assets.V1GetAssetLocationAsync(
    1000000,
    new V1GetAssetLocationRequest { StartMs = 1000000, EndMs = 1000000 }
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

**assetId:** `long` — ID of the asset. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetAssetLocationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">V1GetAssetReeferAsync</a>(assetId, V1GetAssetReeferRequest { ... }) -> WithRawResponseTask&lt;V1AssetReeferResponse&gt;</code></summary>
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

Fetch the reefer-specific stats of an asset. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Assets.V1GetAssetReeferAsync(
    1000000,
    new V1GetAssetReeferRequest { StartMs = 1000000, EndMs = 1000000 }
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

**assetId:** `long` — ID of the asset. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetAssetReeferRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">GetAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.GetAsync("id");
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

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Assets.<a href="/src/Samsara.Net/Assets/AssetsClient.cs">UpdateAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Assets.UpdateAsync("id");
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

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## beta-apis
<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDepreciationTransactionsAsync</a>(GetDepreciationTransactionsRequest { ... }) -> WithRawResponseTask&lt;DepreciationGetDepreciationTransactionsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns depreciation and adjustment transactions for assets. Transactions are returned ordered by updatedAt in ascending order (oldest to newest). Use startTime parameter for incremental sync.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDepreciationTransactionsAsync(new GetDepreciationTransactionsRequest());
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

**request:** `GetDepreciationTransactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetAssetsInputsAsync</a>(GetAssetsInputsRequest { ... }) -> WithRawResponseTask&lt;AssetsInputsGetAssetsInputsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return data collected from the inputs of your organization's assets based on the time parameters passed in. Results are paginated. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. The endpoint will only return data up until the endTime that has been processed by the server at the time of the original request. You will need to request the same [startTime, endTime) range again to receive data for assets processed after the original request time. This endpoint sorts data by time ascending.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetAssetsInputsAsync(
    new GetAssetsInputsRequest
    {
        Type = GetAssetsInputsRequestType.AuxInput1,
        StartTime = "startTime",
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

**request:** `GetAssetsInputsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetAempEquipmentListAsync</a>(pageNumber) -> WithRawResponseTask&lt;AempEquipmentGetAempEquipmentListResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a list of equipment following the AEMP ISO 15143-3 standard.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read AEMP** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetAempEquipmentListAsync("pageNumber");
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

**pageNumber:** `string` — The number corresponding to a specific page of paginated results, defaulting to the first page if not provided. The default page size is 100 records.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDriverEfficiencyAsync</a>(GetDriverEfficiencyRequest { ... }) -> WithRawResponseTask&lt;DriverEfficienciesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all driver and associated vehicle efficiency data. 

 This is a legacy endpoint, consider using this endpoint [/driver-efficiency/drivers](/api-reference/fuel-and-efficiency/fuel-and-energy/get-driver-efficiency-by-drivers) instead. The endpoint will continue to function as documented. 

 <b>Rate limit:</b> 50 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.BetaApis.GetDriverEfficiencyAsync(new GetDriverEfficiencyRequest());
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

**request:** `GetDriverEfficiencyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">PatchEquipmentAsync</a>(id, EquipmentPatchEquipmentRequestBody { ... }) -> WithRawResponseTask&lt;EquipmentPatchEquipmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an equipment.  **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard.
 This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource.
 For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.PatchEquipmentAsync("id", new EquipmentPatchEquipmentRequestBody());
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

**id:** `string` — The unique Samsara ID of the Equipment. This is automatically generated when the Equipment object is created. It cannot be changed.
    
</dd>
</dl>

<dl>
<dd>

**request:** `EquipmentPatchEquipmentRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetHosEldEventsAsync</a>(GetHosEldEventsRequest { ... }) -> WithRawResponseTask&lt;HosEldEventsGetHosEldEventsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all HOS ELD events in a time range, grouped by driver. Attributes will be populated depending on which ELD Event Type is being returned.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetHosEldEventsAsync(
    new GetHosEldEventsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetHosEldEventsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetTrailerStatsSnapshotAsync</a>(GetTrailerStatsSnapshotRequest { ... }) -> WithRawResponseTask&lt;TrailerStatsGetTrailerStatsSnapshotResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the last known stats of all trailers at the given `time`. If no `time` is specified, the current time is used.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetTrailerStatsSnapshotAsync(
    new GetTrailerStatsSnapshotRequest { Types = "types" }
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

**request:** `GetTrailerStatsSnapshotRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetTrailerStatsFeedAsync</a>(GetTrailerStatsFeedRequest { ... }) -> WithRawResponseTask&lt;TrailerStatsGetTrailerStatsFeedResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Follow a feed of trailer stats.

The first call to this endpoint will provide the most recent stats for each trailer and an `endCursor`.

Providing the `endCursor` value to the `after` query parameter will fetch all updates since the previous API call.

If `hasNextPage` is false, no new data is immediately available. Please wait a minimum of 5 seconds before making a subsequent request.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetTrailerStatsFeedAsync(new GetTrailerStatsFeedRequest { Types = "types" });
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

**request:** `GetTrailerStatsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetTrailerStatsHistoryAsync</a>(GetTrailerStatsHistoryRequest { ... }) -> WithRawResponseTask&lt;TrailerStatsGetTrailerStatsHistoryResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns trailer stats during the given time range for all trailers. This can be optionally filtered by tags or specific trailer IDs.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetTrailerStatsHistoryAsync(
    new GetTrailerStatsHistoryRequest
    {
        StartTime = "startTime",
        EndTime = "endTime",
        Types = "types",
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

**request:** `GetTrailerStatsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">UpdateEngineImmobilizerStateAsync</a>(id, EngineImmobilizerUpdateEngineImmobilizerStateRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the engine immobilizer state of a vehicle. This requires an engine immobilizer to be installed on the vehicle gateway.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Vehicle Immobilization** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.UpdateEngineImmobilizerStateAsync(
    1000000,
    new EngineImmobilizerUpdateEngineImmobilizerStateRequestBody
    {
        RelayStates = new List<UpdateEngineImmobilizerRelayStateRequestBodyRequestBody>()
        {
            new UpdateEngineImmobilizerRelayStateRequestBodyRequestBody
            {
                Id = UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId.Relay1,
                IsOpen = true,
            },
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

**id:** `long` — Vehicle ID
    
</dd>
</dl>

<dl>
<dd>

**request:** `EngineImmobilizerUpdateEngineImmobilizerStateRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetJobsAsync</a>(GetJobsRequest { ... }) -> WithRawResponseTask&lt;JobsGetJobsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetches jobs based on id/uuid or provided filters.

To use this endpoint, select **Read Jobs** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetJobsAsync(new GetJobsRequest());
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

**request:** `GetJobsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">CreateJobAsync</a>(JobsCreateJobRequestBody { ... }) -> WithRawResponseTask&lt;JobsCreateJobResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new job and returns it.

To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.CreateJobAsync(
    new JobsCreateJobRequestBody
    {
        Job = new PostJobObjectRequestBody
        {
            EndDate = "2019-06-13T19:08:25Z",
            Id = "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596",
            Name = "My Job Name",
            StartDate = "2019-06-13T19:08:25Z",
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

**request:** `JobsCreateJobRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">DeleteJobAsync</a>(DeleteJobRequest { ... }) -> WithRawResponseTask&lt;JobsDeleteJobResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes an existing job.

To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.DeleteJobAsync(new DeleteJobRequest { Id = "id" });
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

**request:** `DeleteJobRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">PatchJobAsync</a>(JobsPatchJobRequestBody { ... }) -> WithRawResponseTask&lt;JobsPatchJobResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Patches an existing job and returns it.

To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.PatchJobAsync(
    new JobsPatchJobRequestBody { Id = "id", Job = new PatchJobObjectRequestBody() }
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

**request:** `JobsPatchJobRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDetectionsAsync</a>(GetDetectionsRequest { ... }) -> WithRawResponseTask&lt;DetectionLogGetDetectionsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return all detections detected by in-vehicle assets and associated metadata. To get core endpoint data, select View Safety Detection Log under the Safety & Cameras category when creating or editing an API token.

If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Detection Log** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDetectionsAsync(new GetDetectionsRequest { StartTime = "startTime" });
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

**request:** `GetDetectionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDevicesAsync</a>(GetDevicesRequest { ... }) -> WithRawResponseTask&lt;DevicesGetDevicesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all installed cameras (CM3x), vehicle gateways (VGs), and asset gateways (AGs) and their health information within an organization. 

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have Devices API enabled for your organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Devices** under the Devices category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDevicesAsync(new GetDevicesRequest());
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

**request:** `GetDevicesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetEngineImmobilizerStatesAsync</a>(GetEngineImmobilizerStatesRequest { ... }) -> WithRawResponseTask&lt;EngineImmobilizerGetEngineImmobilizerStatesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the engine immobilizer states of the queried vehicles. If a vehicle has never had an engine immobilizer connected, there won't be any state returned for that vehicle.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Vehicle Immobilization** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetEngineImmobilizerStatesAsync(
    new GetEngineImmobilizerStatesRequest { VehicleIds = "vehicleIds", StartTime = "startTime" }
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

**request:** `GetEngineImmobilizerStatesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">StartFunctionRunAsync</a>(name, FunctionsStartFunctionRunRequestBody { ... }) -> WithRawResponseTask&lt;FunctionsStartFunctionRunResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Start an asynchronous run for the specified Function. This endpoint allows you to override parameters available at runtime.

 <b>Rate limit:</b> 2 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Functions** under the Closed Beta category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.StartFunctionRunAsync(
    "name",
    new FunctionsStartFunctionRunRequestBody
    {
        ParamsOverride = new FunctionsStartFunctionRunRequestBodyParamsOverride(),
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

**name:** `string` — The name of the Function to run.
    
</dd>
</dl>

<dl>
<dd>

**request:** `FunctionsStartFunctionRunRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">UpdateShippingDocsAsync</a>(HosDailyLogsUpdateShippingDocsRequestBody { ... }) -> WithRawResponseTask&lt;HosDailyLogsUpdateShippingDocsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the shippingDocs field of an existing assignment.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write ELD Hours of Service (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.UpdateShippingDocsAsync(
    new HosDailyLogsUpdateShippingDocsRequestBody
    {
        HosDate = "hosDate",
        DriverId = "driverID",
        ShippingDocs = "ShippingID1, ShippingID2",
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

**request:** `HosDailyLogsUpdateShippingDocsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">ListHubCustomPropertiesAsync</a>(ListHubCustomPropertiesRequest { ... }) -> WithRawResponseTask&lt;HubCustomPropertiesListHubCustomPropertiesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve custom properties for a specific hub.

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have RoutePlanning APIs enabled for your organization.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.ListHubCustomPropertiesAsync(
    new ListHubCustomPropertiesRequest { HubId = "hubId" }
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

**request:** `ListHubCustomPropertiesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">CreatePlanOrdersAsync</a>(PlanOrdersCreatePlanOrdersRequestBody { ... }) -> WithRawResponseTask&lt;PlanOrdersCreatePlanOrdersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create one or more orders (bulk upsert). Pass an array of order objects; any object whose customerOrderId already exists will be updated, otherwise a new order is created. Functions can return JSON arrays in this Order POST format. Orders are initially created at the plan level but will migrate to hub-level entities, with planId becoming optional in future versions.

**Beta:** This endpoint is in beta and is likely to change before being broadly available. Reach out to your Samsara Representative to have RoutePlanning APIs enabled for your organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.CreatePlanOrdersAsync(
    new PlanOrdersCreatePlanOrdersRequestBody
    {
        Data = new List<OrderInputObjectRequestBody>()
        {
            new OrderInputObjectRequestBody
            {
                CustomerOrderId = "ORDER-2024-001",
                HubId = "550e8400-e29b-41d4-a716-446655440000",
                PlanId = "650e8400-e29b-41d4-a716-446655440023",
            },
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

**request:** `PlanOrdersCreatePlanOrdersRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetQualificationRecordsAsync</a>(GetQualificationRecordsRequest { ... }) -> WithRawResponseTask&lt;QualificationsGetQualificationRecordsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns qualification records for the specified list of IDs.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetQualificationRecordsAsync(new GetQualificationRecordsRequest());
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

**request:** `GetQualificationRecordsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">PostQualificationRecordAsync</a>(QualificationsPostQualificationRecordRequestBody { ... }) -> WithRawResponseTask&lt;QualificationsPostQualificationRecordResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new qualification record.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.PostQualificationRecordAsync(
    new QualificationsPostQualificationRecordRequestBody
    {
        Fields = new List<QualificationRecordRequestFieldInputObjectRequestBody>()
        {
            new QualificationRecordRequestFieldInputObjectRequestBody
            {
                Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                Type = QualificationRecordRequestFieldInputObjectRequestBodyType.Number,
            },
        },
        IssueDate = new DateTime(2025, 08, 27, 10, 20, 30, 000),
        Owner = new QualificationOwnerRequestObjectRequestBody
        {
            EntityType = QualificationOwnerRequestObjectRequestBodyEntityType.Worker,
            Id = "281474",
        },
        QualificationType = new QualificationTypeRequestObjectRequestBody
        {
            Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
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

**request:** `QualificationsPostQualificationRecordRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">DeleteQualificationRecordAsync</a>(QualificationsDeleteQualificationRecordRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes an existing qualification record.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.DeleteQualificationRecordAsync(
    new QualificationsDeleteQualificationRecordRequestBody
    {
        Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
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

**request:** `QualificationsDeleteQualificationRecordRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">PatchQualificationRecordAsync</a>(QualificationsPatchQualificationRecordRequestBody { ... }) -> WithRawResponseTask&lt;QualificationsPatchQualificationRecordResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an existing qualification record.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.PatchQualificationRecordAsync(
    new QualificationsPatchQualificationRecordRequestBody
    {
        Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
        IssueDate = new DateTime(2025, 08, 27, 10, 20, 30, 000),
        Owner = new QualificationOwnerRequestObjectRequestBody
        {
            EntityType = QualificationOwnerRequestObjectRequestBodyEntityType.Worker,
            Id = "281474",
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

**request:** `QualificationsPatchQualificationRecordRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">ArchiveQualificationRecordAsync</a>(QualificationsArchiveQualificationRecordRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Archives an existing qualification record.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.ArchiveQualificationRecordAsync(
    new QualificationsArchiveQualificationRecordRequestBody
    {
        Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
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

**request:** `QualificationsArchiveQualificationRecordRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetQualificationRecordsStreamAsync</a>(GetQualificationRecordsStreamRequest { ... }) -> WithRawResponseTask&lt;QualificationsGetQualificationRecordsStreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all qualification records that have been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don't include an endTime, the API will continue to poll with the pagination cursor that gets returned on every call. The hasNextPage response value will be true if there is no endTime specified and endCursor is nonempty.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetQualificationRecordsStreamAsync(
    new GetQualificationRecordsStreamRequest
    {
        EntityType = GetQualificationRecordsStreamRequestEntityType.Worker,
        StartTime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
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

**request:** `GetQualificationRecordsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">UnarchiveQualificationRecordAsync</a>(QualificationsUnarchiveQualificationRecordRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unarchives an existing qualification record.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.UnarchiveQualificationRecordAsync(
    new QualificationsUnarchiveQualificationRecordRequestBody
    {
        Id = "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
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

**request:** `QualificationsUnarchiveQualificationRecordRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetQualificationTypesAsync</a>(GetQualificationTypesRequest { ... }) -> WithRawResponseTask&lt;QualificationsGetQualificationTypesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of qualification types for the specified list of IDs. If no IDs are provided, all qualification types will be returned.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Qualification Records** under the Qualification Records category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetQualificationTypesAsync(
    new GetQualificationTypesRequest { EntityType = GetQualificationTypesRequestEntityType.Worker }
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

**request:** `GetQualificationTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">PostReadingsAsync</a>(ReadingsPostReadingsRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Ingest new readings. This endpoint allows the ingestion of batches of readings.

Ingesting readings is only supported for assets created using the POST /assets API endpoint with readingsIngestionEnabled set to true. To see a full list of readings available for ingestion use the GET readings definitions API. When ingesting location data, the readingID 'location' must be used and the value object must contain at least the following fields: 'speed', 'latitude', 'longitude'.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Readings** under the Closed Beta category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.PostReadingsAsync(
    new ReadingsPostReadingsRequestBody
    {
        Data = new List<ReadingDatapointRequestBody>()
        {
            new ReadingDatapointRequestBody
            {
                EntityId = "123451234512345",
                EntityType = "asset",
                HappenedAtTime = "2023-10-27T10:00:00Z",
                ReadingId = "airInletPressure",
                Value = new Dictionary<string, object?>() { { "key", "value" } },
            },
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

**request:** `ReadingsPostReadingsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">ListReadingsDefinitionsAsync</a>(ListReadingsDefinitionsRequest { ... }) -> WithRawResponseTask&lt;ReadingsListReadingsDefinitionsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

An introspection endpoint for discovering the set of readings including their name, description, data type, unit, and other metadata.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.ListReadingsDefinitionsAsync(new ListReadingsDefinitionsRequest());
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

**request:** `ListReadingsDefinitionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetReadingsHistoryAsync</a>(GetReadingsHistoryRequest { ... }) -> WithRawResponseTask&lt;ReadingsGetReadingsHistoryResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the values of a reading for a set of entities within the specified time range. Returns a paginated response with data for the specified resource IDs where startTime <= happenedAtTime < endTime. End time of null implies endTime is infinite and all known readings are returned.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetReadingsHistoryAsync(
    new GetReadingsHistoryRequest { ReadingId = "readingId", EntityType = "entityType" }
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

**request:** `GetReadingsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetReadingsSnapshotAsync</a>(GetReadingsSnapshotRequest { ... }) -> WithRawResponseTask&lt;ReadingsGetReadingsSnapshotResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

An endpoint to get the last value of a reading for a set of entities at the specified time.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Readings** under the Closed Beta category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetReadingsSnapshotAsync(
    new GetReadingsSnapshotRequest { ReadingIds = "readingIds", EntityType = "entityType" }
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

**request:** `GetReadingsSnapshotRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetReportConfigsAsync</a>(GetReportConfigsRequest { ... }) -> WithRawResponseTask&lt;ReportsGetReportConfigsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get report configs created in the organization.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Custom Reports** under the Custom Reports category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetReportConfigsAsync(new GetReportConfigsRequest());
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

**request:** `GetReportConfigsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDatasetsAsync</a>(GetDatasetsRequest { ... }) -> WithRawResponseTask&lt;ReportsGetDatasetsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get datasets for custom reports.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Custom Reports** under the Custom Reports category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDatasetsAsync(new GetDatasetsRequest());
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

**request:** `GetDatasetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetReportRunsAsync</a>(GetReportRunsRequest { ... }) -> WithRawResponseTask&lt;ReportsGetReportRunsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get custom report runs created by the user.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Custom Reports** under the Custom Reports category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetReportRunsAsync(new GetReportRunsRequest());
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

**request:** `GetReportRunsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">CreateReportRunAsync</a>(ReportsCreateReportRunRequestBody { ... }) -> WithRawResponseTask&lt;ReportsCreateReportRunResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Triggers a new custom report run based on the provided configuration.

 <b>Rate limit:</b> 50 requests/hour (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Custom Reports** under the Custom Reports category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.CreateReportRunAsync(
    new ReportsCreateReportRunRequestBody
    {
        ReportConfig = new CreateReportConfigObjectRequestBody(),
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

**request:** `ReportsCreateReportRunRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetReportRunDataAsync</a>(GetReportRunDataRequest { ... }) -> WithRawResponseTask&lt;ReportsGetReportRunDataResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get data for the given custom report run.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Custom Reports** under the Custom Reports category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetReportRunDataAsync(new GetReportRunDataRequest { Id = "id" });
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

**request:** `GetReportRunDataRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDriverSafetyScoresAsync</a>(GetDriverSafetyScoresRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetDriverSafetyScoresResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get safety scores and overall risk factors for drivers.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDriverSafetyScoresAsync(
    new GetDriverSafetyScoresRequest { EndTime = "endTime", StartTime = "startTime" }
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

**request:** `GetDriverSafetyScoresRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetDriverSafetyScoreTripsAsync</a>(GetDriverSafetyScoreTripsRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetDriverSafetyScoreTripsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get trips contributing to a driver's safety score, and risk factors in each trip.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetDriverSafetyScoreTripsAsync(
    new GetDriverSafetyScoreTripsRequest { EndTime = "endTime", StartTime = "startTime" }
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

**request:** `GetDriverSafetyScoreTripsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetTagGroupSafetyScoresAsync</a>(GetTagGroupSafetyScoresRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetTagGroupSafetyScoresResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a combined safety score and risk factors for a set of tags.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetTagGroupSafetyScoresAsync(
    new GetTagGroupSafetyScoresRequest
    {
        EndTime = "endTime",
        StartTime = "startTime",
        ScoreType = GetTagGroupSafetyScoresRequestScoreType.Driver,
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

**request:** `GetTagGroupSafetyScoresRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetTagSafetyScoresAsync</a>(GetTagSafetyScoresRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetTagSafetyScoresResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get safety scores and overall risk factors for tags.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetTagSafetyScoresAsync(
    new GetTagSafetyScoresRequest
    {
        EndTime = "endTime",
        StartTime = "startTime",
        ScoreType = GetTagSafetyScoresRequestScoreType.Driver,
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

**request:** `GetTagSafetyScoresRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetVehicleSafetyScoresAsync</a>(GetVehicleSafetyScoresRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetVehicleSafetyScoresResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get safety scores and overall risk factors for vehicles.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetVehicleSafetyScoresAsync(
    new GetVehicleSafetyScoresRequest { EndTime = "endTime", StartTime = "startTime" }
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

**request:** `GetVehicleSafetyScoresRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BetaApis.<a href="/src/Samsara.Net/BetaApis/BetaApisClient.cs">GetVehicleSafetyScoreTripsAsync</a>(GetVehicleSafetyScoreTripsRequest { ... }) -> WithRawResponseTask&lt;SafetyScoresGetVehicleSafetyScoreTripsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get trips contributing to a vehicle's safety score, and risk factors in each trip.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.BetaApis.GetVehicleSafetyScoreTripsAsync(
    new GetVehicleSafetyScoreTripsRequest { EndTime = "endTime", StartTime = "startTime" }
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

**request:** `GetVehicleSafetyScoreTripsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## LocationAndSpeed
<details><summary><code>client.LocationAndSpeed.<a href="/src/Samsara.Net/LocationAndSpeed/LocationAndSpeedClient.cs">GetLocationAndSpeedAsync</a>(GetLocationAndSpeedRequest { ... }) -> WithRawResponseTask&lt;LocationAndSpeedGetLocationAndSpeedResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return asset locations and speed data that has been collected for your organization based on the time parameters passed in. Results are paginated. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. The endpoint will only return data up until the endTime that has been processed by the server at the time of the original request. You will need to request the same [startTime, endTime) range again to receive data for assets processed after the original request time. This endpoint sorts the time-series data by device.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LocationAndSpeed.GetLocationAndSpeedAsync(new GetLocationAndSpeedRequest());
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

**request:** `GetLocationAndSpeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Attributes
<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">GetAttributesByEntityTypeAsync</a>(GetAttributesByEntityTypeRequest { ... }) -> WithRawResponseTask&lt;GetAttributesByEntityTypeResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch all attributes in an organization associated with either drivers or assets. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Attributes** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Attributes.GetAttributesByEntityTypeAsync(
    new GetAttributesByEntityTypeRequest
    {
        EntityType = GetAttributesByEntityTypeRequestEntityType.Driver,
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

**request:** `GetAttributesByEntityTypeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">CreateAttributeAsync</a>(CreateAttributeRequest { ... }) -> WithRawResponseTask&lt;AttributeExpandedResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new attribute in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Attributes.CreateAttributeAsync(
    new CreateAttributeRequest
    {
        AttributeType = CreateAttributeRequestAttributeType.SingleSelect,
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

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">GetAttributeAsync</a>(id, GetAttributeRequest { ... }) -> WithRawResponseTask&lt;AttributeExpandedResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch an attribute by id, including all of its applications. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Attributes** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Attributes.GetAttributeAsync(
    "id",
    new GetAttributeRequest { EntityType = GetAttributeRequestEntityType.Driver }
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

**request:** `GetAttributeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">DeleteAsync</a>(id, DeleteAttributesRequest { ... }) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete an attribute by id, including all of its applications. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
    new DeleteAttributesRequest { EntityType = DeleteAttributesRequestEntityType.Driver }
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

**request:** `DeleteAttributesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Attributes.<a href="/src/Samsara.Net/Attributes/AttributesClient.cs">UpdateAttributeAsync</a>(id, UpdateAttributeRequest { ... }) -> WithRawResponseTask&lt;AttributeExpandedResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an attribute in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Attributes** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Attributes.UpdateAttributeAsync(
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

## Media
<details><summary><code>client.Media.<a href="/src/Samsara.Net/Media/MediaClient.cs">ListUploadedMediaAsync</a>(ListUploadedMediaRequest { ... }) -> WithRawResponseTask&lt;MediaRetrievalListUploadedMediaResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns a list of all uploaded media (video and still images) matching query parameters, with a maximum query range of one day. Additional media can be retrieved with the [Create a media retrieval request](/api-reference/safety/media/post-media-retrieval) endpoint, and they will be included in the list after they are uploaded. Urls provided by this endpoint expire in 8 hours.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Media Retrieval** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Media.ListUploadedMediaAsync(
    new ListUploadedMediaRequest
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

**request:** `ListUploadedMediaRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Media.<a href="/src/Samsara.Net/Media/MediaClient.cs">GetMediaRetrievalAsync</a>(GetMediaRetrievalRequest { ... }) -> WithRawResponseTask&lt;MediaRetrievalGetMediaRetrievalResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint returns media information corresponding to a retrieval ID. Retrieval IDs are associated to prior [media retrieval requests](/api-reference/safety/media/post-media-retrieval). Urls provided by this endpoint expire in 8 hours.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Media Retrieval** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Media.GetMediaRetrievalAsync(
    new GetMediaRetrievalRequest { RetrievalId = "retrievalId" }
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

**request:** `GetMediaRetrievalRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Media.<a href="/src/Samsara.Net/Media/MediaClient.cs">PostMediaRetrievalAsync</a>(MediaRetrievalPostMediaRetrievalRequestBody { ... }) -> WithRawResponseTask&lt;MediaRetrievalPostMediaRetrievalResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint creates an asynchronous request to upload certain media from a device. The closest available media to the requested timestamp is returned. Images, videos(both high resolution and low resolution) and hyperlapses are supported.Currently, only unblurred media is supported. If a device is offline, the requested media will be uploaded once it comes back online. Quota limits are enforced for media retrievals made through the API. The Create a media retrieval request response includes information about the media retrieval quota remaining for the organization. The media retrieval quota for the organization is reset at the beginning of each month.The quota is expressed using seconds of High Resolution video. 10 still images are equivalent to a 1 second of High Resolution footage.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Media Retrieval** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Media.PostMediaRetrievalAsync(
    new MediaRetrievalPostMediaRetrievalRequestBody
    {
        EndTime = "2019-06-13T19:08:55Z",
        Inputs = new List<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>()
        {
            MediaRetrievalPostMediaRetrievalRequestBodyInputsItem.DashcamRoadFacing,
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

## Coaching
<details><summary><code>client.Coaching.<a href="/src/Samsara.Net/Coaching/CoachingClient.cs">GetDriverCoachAssignmentAsync</a>(GetDriverCoachAssignmentRequest { ... }) -> WithRawResponseTask&lt;DriverCoachAssignmentsGetDriverCoachAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return coach assignments for your organization based on the parameters passed in. Results are paginated.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Coaching.GetDriverCoachAssignmentAsync(new GetDriverCoachAssignmentRequest());
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

**request:** `GetDriverCoachAssignmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Coaching.<a href="/src/Samsara.Net/Coaching/CoachingClient.cs">PutDriverCoachAssignmentAsync</a>(PutDriverCoachAssignmentRequest { ... }) -> WithRawResponseTask&lt;DriverCoachAssignmentsPutDriverCoachAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will update an existing or create a new coach-to-driver assignment for your organization based on the parameters passed in. This endpoint should only be used for existing Coach to Driver assignments. In order to remove a driver-coach-assignment for a given driver, set coachId to null

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Coaching** under the Coaching category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Coaching.PutDriverCoachAssignmentAsync(
    new PutDriverCoachAssignmentRequest { DriverId = "driverId" }
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

**request:** `PutDriverCoachAssignmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Coaching.<a href="/src/Samsara.Net/Coaching/CoachingClient.cs">GetCoachingSessionsAsync</a>(GetCoachingSessionsRequest { ... }) -> WithRawResponseTask&lt;CoachingSessionsGetCoachingSessionsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return coaching sessions for your organization based on the time parameters passed in. Results are paginated by sessions. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Coaching.GetCoachingSessionsAsync(
    new GetCoachingSessionsRequest { StartTime = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
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

**request:** `GetCoachingSessionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Contacts
<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">ListContactsAsync</a>(ListContactsRequest { ... }) -> WithRawResponseTask&lt;ListContactsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all contacts in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Alert Contacts** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Contacts.ListContactsAsync(new ListContactsRequest());
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

**request:** `ListContactsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">CreateContactAsync</a>(CreateContactRequest { ... }) -> WithRawResponseTask&lt;ContactResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a contact to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Contacts.CreateContactAsync(new CreateContactRequest());
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

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">GetContactAsync</a>(id) -> WithRawResponseTask&lt;ContactResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific contact's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Alert Contacts** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Contacts.GetContactAsync("id");
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

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the given contact. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Contacts.<a href="/src/Samsara.Net/Contacts/ContactsClient.cs">UpdateContactAsync</a>(id, UpdateContactRequest { ... }) -> WithRawResponseTask&lt;ContactResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific contact's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Alert Contacts** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Contacts.UpdateContactAsync("id", new UpdateContactRequest());
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

## Maintenance
<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">GetDefectTypesAsync</a>(GetDefectTypesRequest { ... }) -> WithRawResponseTask&lt;DvirDefectTypeGetDefectTypesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get DVIR defect types.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Defect Types** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Maintenance.GetDefectTypesAsync(new GetDefectTypesRequest());
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

**request:** `GetDefectTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">StreamDefectsAsync</a>(StreamDefectsRequest { ... }) -> WithRawResponseTask&lt;DvirDefectStreamDefectsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stream DVIR defects.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Maintenance.StreamDefectsAsync(new StreamDefectsRequest { StartTime = "startTime" });
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

**request:** `StreamDefectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">GetDefectAsync</a>(id, GetDefectRequest { ... }) -> WithRawResponseTask&lt;DvirDefectGetDefectResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a single DVIR defect by ID.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Maintenance.GetDefectAsync("id", new GetDefectRequest());
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

**request:** `GetDefectRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">GetDvirsAsync</a>(GetDvirsRequest { ... }) -> WithRawResponseTask&lt;DvirGetDvirsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a history/feed of changed DVIRs by updatedAtTime between startTime and endTime parameters. In case of missing `endTime` parameter it will return a never ending stream of data.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Maintenance.GetDvirsAsync(new GetDvirsRequest { StartTime = "startTime" });
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

**request:** `GetDvirsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">GetDvirAsync</a>(id, GetDvirRequest { ... }) -> WithRawResponseTask&lt;DvirGetDvirResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a single DVIR by ID.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Maintenance.GetDvirAsync("id", new GetDvirRequest());
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

**request:** `GetDvirRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">UpdateDvirDefectAsync</a>(id, DefectPatch { ... }) -> WithRawResponseTask&lt;DefectResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a given defect. Can be used to resolve a defect by marking its `isResolved` field to `true`. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Defects** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Maintenance.UpdateDvirDefectAsync("id", new DefectPatch());
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

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">CreateDvirAsync</a>(CreateDvirRequest { ... }) -> WithRawResponseTask&lt;DvirResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new mechanic DVIR in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Maintenance.CreateDvirAsync(
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

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">UpdateDvirAsync</a>(id, UpdateDvirRequest { ... }) -> WithRawResponseTask&lt;DvirResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Resolves a given DVIR by marking its `isResolved` field to `true`. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Maintenance.UpdateDvirAsync(
    "id",
    new UpdateDvirRequest { AuthorId = "11", IsResolved = true }
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

<details><summary><code>client.Maintenance.<a href="/src/Samsara.Net/Maintenance/MaintenanceClient.cs">V1GetFleetMaintenanceListAsync</a>() -> WithRawResponseTask&lt;InlineResponse2004&gt;</code></summary>
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

Get list of the vehicles with any engine faults or check light data. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Maintenance.V1GetFleetMaintenanceListAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FuelAndEnergy
<details><summary><code>client.FuelAndEnergy.<a href="/src/Samsara.Net/FuelAndEnergy/FuelAndEnergyClient.cs">GetDriverEfficiencyByDriversAsync</a>(GetDriverEfficiencyByDriversRequest { ... }) -> WithRawResponseTask&lt;DriverEfficiencyGetDriverEfficiencyByDriversResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return driver efficiency data that has been collected for your organization and grouped by drivers based on the time parameters passed in. Results are paginated. 

**Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](/api-reference/future/beta-apis/get-driver-efficiency) endpoint has now been moved to Legacy.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.FuelAndEnergy.GetDriverEfficiencyByDriversAsync(
    new GetDriverEfficiencyByDriversRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDriverEfficiencyByDriversRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FuelAndEnergy.<a href="/src/Samsara.Net/FuelAndEnergy/FuelAndEnergyClient.cs">GetDriverEfficiencyByVehiclesAsync</a>(GetDriverEfficiencyByVehiclesRequest { ... }) -> WithRawResponseTask&lt;DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return driver efficiency data that has been collected for your organization and grouped by vehicle drivers used based on the time parameters passed in. Results are paginated. 

**Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](/api-reference/future/beta-apis/get-driver-efficiency) endpoint has now been moved to Legacy.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.FuelAndEnergy.GetDriverEfficiencyByVehiclesAsync(
    new GetDriverEfficiencyByVehiclesRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDriverEfficiencyByVehiclesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FuelAndEnergy.<a href="/src/Samsara.Net/FuelAndEnergy/FuelAndEnergyClient.cs">GetFuelEnergyDriverReportsAsync</a>(GetFuelEnergyDriverReportsRequest { ... }) -> WithRawResponseTask&lt;FuelEnergyGetFuelEnergyDriverReportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get fuel and energy efficiency driver reports for the requested time range.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.FuelAndEnergy.GetFuelEnergyDriverReportsAsync(
    new GetFuelEnergyDriverReportsRequest { StartDate = "startDate", EndDate = "endDate" }
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

**request:** `GetFuelEnergyDriverReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FuelAndEnergy.<a href="/src/Samsara.Net/FuelAndEnergy/FuelAndEnergyClient.cs">GetFuelEnergyVehicleReportsAsync</a>(GetFuelEnergyVehicleReportsRequest { ... }) -> WithRawResponseTask&lt;FuelEnergyGetFuelEnergyVehicleReportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get fuel and energy efficiency vehicle reports for the requested time range.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.FuelAndEnergy.GetFuelEnergyVehicleReportsAsync(
    new GetFuelEnergyVehicleReportsRequest { StartDate = "startDate", EndDate = "endDate" }
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

**request:** `GetFuelEnergyVehicleReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FuelAndEnergy.<a href="/src/Samsara.Net/FuelAndEnergy/FuelAndEnergyClient.cs">PostFuelPurchaseAsync</a>(FuelPurchasePostFuelPurchaseRequestBody { ... }) -> WithRawResponseTask&lt;FuelPurchasePostFuelPurchaseResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a fuel purchase transaction.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Fuel Purchase** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.FuelAndEnergy.PostFuelPurchaseAsync(
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

## DriverTrailerAssignments
<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">GetDriverTrailerAssignmentsAsync</a>(GetDriverTrailerAssignmentsRequest { ... }) -> WithRawResponseTask&lt;TrailerAssignmentsGetDriverTrailerAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get currently active driver-trailer assignments for driver.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverTrailerAssignments.GetDriverTrailerAssignmentsAsync(
    new GetDriverTrailerAssignmentsRequest()
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

**request:** `GetDriverTrailerAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">CreateDriverTrailerAssignmentAsync</a>(TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody { ... }) -> WithRawResponseTask&lt;TrailerAssignmentsCreateDriverTrailerAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new driver-trailer assignment

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverTrailerAssignments.CreateDriverTrailerAssignmentAsync(
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

<details><summary><code>client.DriverTrailerAssignments.<a href="/src/Samsara.Net/DriverTrailerAssignments/DriverTrailerAssignmentsClient.cs">UpdateDriverTrailerAssignmentAsync</a>(TrailerAssignmentsUpdateDriverTrailerAssignmentRequestBody { ... }) -> WithRawResponseTask&lt;TrailerAssignmentsUpdateDriverTrailerAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing driver-trailer assignment.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverTrailerAssignments.UpdateDriverTrailerAssignmentAsync(
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

## DriverQrCodes
<details><summary><code>client.DriverQrCodes.<a href="/src/Samsara.Net/DriverQrCodes/DriverQrCodesClient.cs">GetDriversQrCodesAsync</a>(GetDriversQrCodesRequest { ... }) -> WithRawResponseTask&lt;DriverQrCodesGetDriversQrCodesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get details for requested driver(s) QR code, used for driver trip assignment.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverQrCodes.GetDriversQrCodesAsync(new GetDriversQrCodesRequest());
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

**request:** `GetDriversQrCodesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverQrCodes.<a href="/src/Samsara.Net/DriverQrCodes/DriverQrCodesClient.cs">CreateDriverQrCodeAsync</a>(DriverQrCodesCreateDriverQrCodeRequestBody { ... }) -> WithRawResponseTask&lt;DriverQrCodesCreateDriverQrCodeResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Assign a new QR code for the requested driver. Return error if an active QR code already exists.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverQrCodes.CreateDriverQrCodeAsync(
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

<details><summary><code>client.DriverQrCodes.<a href="/src/Samsara.Net/DriverQrCodes/DriverQrCodesClient.cs">DeleteDriverQrCodeAsync</a>(DriverQrCodesDeleteDriverQrCodeRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Revoke requested driver's currently active QR code.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverQrCodes.DeleteDriverQrCodeAsync(
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

## Carrier Proposed Assignments
<details><summary><code>client.CarrierProposedAssignments.<a href="/src/Samsara.Net/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">ListCarrierProposedAssignmentsAsync</a>(ListCarrierProposedAssignmentsRequest { ... }) -> WithRawResponseTask&lt;ListCarrierProposedAssignmentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Show the assignments created by the POST fleet/carrier-proposed-assignments. This endpoint will only show the assignments that are active for drivers and currently visible to them in the driver app. Once a proposed assignment has been accepted, the endpoint will not return any data. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.CarrierProposedAssignments.ListCarrierProposedAssignmentsAsync(
    new ListCarrierProposedAssignmentsRequest()
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

**request:** `ListCarrierProposedAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CarrierProposedAssignments.<a href="/src/Samsara.Net/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">CreateCarrierProposedAssignmentAsync</a>(CreateCarrierProposedAssignmentRequest { ... }) -> WithRawResponseTask&lt;CarrierProposedAssignmentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new assignment that a driver can later use. Each driver can only have one future assignment. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.CarrierProposedAssignments.CreateCarrierProposedAssignmentAsync(
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

## legacy-apis
<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetDvirDefectsAsync</a>(GetDvirDefectsRequest { ... }) -> WithRawResponseTask&lt;DefectsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Stream DVIR defects](/api-reference/maintenance/maintenance/stream-defects) instead. The endpoint will continue to function as documented.** 

Returns a list of DVIR defects in an organization, filtered by creation time. The maximum time period you can query for is 30 days. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.LegacyApis.GetDvirDefectsAsync(
    new GetDvirDefectsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDvirDefectsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetDriversVehicleAssignmentsAsync</a>(GetDriversVehicleAssignmentsRequest { ... }) -> WithRawResponseTask&lt;DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get all driver-vehicle assignments](/api-reference/drivers/driver-vehicle-assignments/get-driver-vehicle-assignments) instead. The endpoint will continue to function as documented.** Get all vehicle assignments for the requested drivers in the requested time range. The only type of assignment supported right now are assignments created through the driver app.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LegacyApis.GetDriversVehicleAssignmentsAsync(
    new GetDriversVehicleAssignmentsRequest()
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

**request:** `GetDriversVehicleAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetDvirHistoryAsync</a>(GetDvirHistoryRequest { ... }) -> WithRawResponseTask&lt;DvirsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Stream DVIRs](/api-reference/maintenance/maintenance/get-dvirs) instead. The endpoint will continue to function as documented.** 

 Returns a list of all DVIRs in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.LegacyApis.GetDvirHistoryAsync(
    new GetDvirHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDvirHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetVehicleIdlingReportsAsync</a>(GetVehicleIdlingReportsRequest { ... }) -> WithRawResponseTask&lt;IdlingReportsGetVehicleIdlingReportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get idling events](/api-reference/fuel-and-efficiency/idling/get-idling-events) instead. The endpoint will continue to function as documented.** Get all vehicle idling reports for the requested time duration.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LegacyApis.GetVehicleIdlingReportsAsync(
    new GetVehicleIdlingReportsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetVehicleIdlingReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetSafetyEventsAsync</a>(GetSafetyEventsRequest { ... }) -> WithRawResponseTask&lt;SafetyEventsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get Safety Events Stream](/api-reference/safety/safety/get-safety-events-v-2-stream) instead. The endpoint will continue to function as documented.** 

 Fetch safety events for the organization in a given time period. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.LegacyApis.GetSafetyEventsAsync(
    new GetSafetyEventsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetSafetyEventsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetSafetyActivityEventFeedAsync</a>(GetSafetyActivityEventFeedRequest { ... }) -> WithRawResponseTask&lt;SafetyEventsGetSafetyActivityEventFeedResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get Safety Events Stream](/api-reference/safety/safety/get-safety-events-v-2-stream) instead. The endpoint will continue to function as documented.**

Get continuous safety events. The safety activity event feed offers a change-log for safety events. Use this endpoint to subscribe to safety event changes. See documentation below for all supported change-log types.

| ActivityType      | Description |
| ----------- | ----------- |
| CreateSafetyEventActivityType | a new safety event is processed by Samsara      |
| BehaviorLabelActivityType     | a label is added or removed from a safety event |
| CoachingStateActivityType     | a safety event coaching state is updated        |

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LegacyApis.GetSafetyActivityEventFeedAsync(new GetSafetyActivityEventFeedRequest());
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

**request:** `GetSafetyActivityEventFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">GetVehiclesDriverAssignmentsAsync</a>(GetVehiclesDriverAssignmentsRequest { ... }) -> WithRawResponseTask&lt;VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get all driver-vehicle assignments](/api-reference/drivers/driver-vehicle-assignments/get-driver-vehicle-assignments) instead. The endpoint will continue to function as documented.** Get all driver assignments for the requested vehicles in the requested time range. The only type of assignment supported right now are assignments created through the driver app.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LegacyApis.GetVehiclesDriverAssignmentsAsync(
    new GetVehiclesDriverAssignmentsRequest()
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

**request:** `GetVehiclesDriverAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">V1GetAllAssetsAsync</a>() -> WithRawResponseTask&lt;InlineResponse2001&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [List all assets](/api-reference/assets-vehicles-trailers-equipment/assets/list) instead. The endpoint will continue to function as documented.** 

 Fetch all powered and unpowered equipment. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.LegacyApis.V1GetAllAssetsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LegacyApis.<a href="/src/Samsara.Net/LegacyApis/LegacyApisClient.cs">V1GetVehicleHarshEventAsync</a>(vehicleId, V1GetVehicleHarshEventRequest { ... }) -> WithRawResponseTask&lt;V1VehicleHarshEventResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Note: This is a legacy endpoint, consider using [Get Safety Events](/api-reference/safety/safety/get-safety-events-v-2) instead. The endpoint will continue to function as documented.** <n class="warning">
<nh>
<i class="fa fa-exclamation-circle"></i>
This endpoint is still on our legacy API.
</nh>
</n>

Fetch harsh event details for a vehicle. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.LegacyApis.V1GetVehicleHarshEventAsync(
    1000000,
    new V1GetVehicleHarshEventRequest { Timestamp = 1000000 }
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

**vehicleId:** `long` — ID of the vehicle. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetVehicleHarshEventRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents
<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GetDocumentTypesAsync</a>(GetDocumentTypesRequest { ... }) -> WithRawResponseTask&lt;DocumentTypesGetDocumentTypesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of the organization document types. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentTypesByOrgId).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Documents.GetDocumentTypesAsync(new GetDocumentTypesRequest());
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

**request:** `GetDocumentTypesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GetDocumentsAsync</a>(GetDocumentsRequest { ... }) -> WithRawResponseTask&lt;DocumentsGetDocumentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all documents for the given time range. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentsByOrgId).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Documents.GetDocumentsAsync(
    new GetDocumentsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">PostDocumentAsync</a>(DocumentsPostDocumentRequestBody { ... }) -> WithRawResponseTask&lt;DocumentsPostDocumentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/createDriverDocument).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Documents.PostDocumentAsync(
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

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GenerateDocumentPdfAsync</a>(DocumentPdfGenerationRequest { ... }) -> WithRawResponseTask&lt;DocumentPdfGenerationResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Request creation of a document PDF. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Documents.GenerateDocumentPdfAsync(
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

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GetDocumentPdfAsync</a>(id) -> WithRawResponseTask&lt;DocumentPdfQueryResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns generation job status and download URL for a PDF. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Documents.GetDocumentPdfAsync("id");
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

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">GetDocumentAsync</a>(id) -> WithRawResponseTask&lt;DocumentsGetDocumentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDriverDocumentByIdAndDriverId).

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Documents.GetDocumentAsync("id");
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

<details><summary><code>client.Documents.<a href="/src/Samsara.Net/Documents/DocumentsClient.cs">DeleteDocumentAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a single document. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/deleteDriverDocumentByIdAndDriverId).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Documents** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Documents.DeleteDocumentAsync("id");
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
<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">GetDriverVehicleAssignmentsAsync</a>(GetDriverVehicleAssignmentsRequest { ... }) -> WithRawResponseTask&lt;DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all driver-vehicle assignments for the requested drivers or vehicles in the requested time range. To fetch driver-vehicle assignments out of the vehicle trips' time ranges, assignmentType needs to be specified. Note: this endpoint replaces past endpoints to fetch assignments by driver or by vehicle. Visit [this migration guide](/docs/migrating-from-driver-vehicle-assignment-or-vehicle-driver-assignment-endpoints) for more information.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverVehicleAssignments.GetDriverVehicleAssignmentsAsync(
    new GetDriverVehicleAssignmentsRequest
    {
        FilterBy = GetDriverVehicleAssignmentsRequestFilterBy.Drivers,
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

**request:** `GetDriverVehicleAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">CreateDriverVehicleAssignmentAsync</a>(DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody { ... }) -> WithRawResponseTask&lt;DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Assign vehicle drive-time to a driver via API. For a step-by-step instruction on how to leverage this endpoint, see [this guide](/docs/creating-driver-vehicle-assignments)

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverVehicleAssignments.CreateDriverVehicleAssignmentAsync(
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

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">DeleteDriverVehicleAssignmentsAsync</a>(DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete driver assignments that were created using the `POST fleet/driver-vehicle-assignments` endpoint for the requested vehicle in the requested time range.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverVehicleAssignments.DeleteDriverVehicleAssignmentsAsync(
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

<details><summary><code>client.DriverVehicleAssignments.<a href="/src/Samsara.Net/DriverVehicleAssignments/DriverVehicleAssignmentsClient.cs">UpdateDriverVehicleAssignmentAsync</a>(DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody { ... }) -> WithRawResponseTask&lt;DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update driver assignments that were created using the `POST fleet/driver-vehicle-assignments`. Vehicle Id, Driver Id, and Start Time must match an existing assignment.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.DriverVehicleAssignments.UpdateDriverVehicleAssignmentAsync(
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
<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">ListAsync</a>(ListDriversRequest { ... }) -> Pager&lt;Driver&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all drivers in organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Drivers.ListAsync(new ListDriversRequest());
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

**request:** `ListDriversRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">CreateAsync</a>(CreateDriverRequest { ... }) -> WithRawResponseTask&lt;DriverResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a driver to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">PostDriverRemoteSignoutAsync</a>(DriverRemoteSignoutPostDriverRemoteSignoutRequestBody { ... }) -> WithRawResponseTask&lt;DriverRemoteSignoutPostDriverRemoteSignoutResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Driver Remote Signout** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Drivers.PostDriverRemoteSignoutAsync(
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

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;DriverResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a driver. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">DeleteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Drivers.DeleteAsync("id");
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

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Drivers.<a href="/src/Samsara.Net/Drivers/DriversClient.cs">UpdateAsync</a>(id, UpdateDriverRequest { ... }) -> WithRawResponseTask&lt;DriverResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific driver's information. This can also be used to activate or de-activate a given driver by setting the driverActivationStatus field. If the driverActivationStatus field is 'deactivated' then the user can also specify the deactivatedAtTime. The deactivatedAtTime cannot be more than 6 months in the past and must not come before the dirver's latest active HOS log. It will be considered an error if deactivatedAtTime is provided with a driverActivationStatus of active. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

## AuthTokenForDriver
<details><summary><code>client.AuthTokenForDriver.<a href="/src/Samsara.Net/AuthTokenForDriver/AuthTokenForDriverClient.cs">AuthTokenAsync</a>(AuthTokenAuthTokenRequestBody { ... }) -> WithRawResponseTask&lt;AuthTokenAuthTokenResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a short-lived auth token a driver can use to login.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Driver Auth Token** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.AuthTokenForDriver.AuthTokenAsync(
    new AuthTokenAuthTokenRequestBody { Code = "dp[gZc1wAigz4uGa0Hh" }
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

**request:** `AuthTokenAuthTokenRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tachograph (EU Only)
<details><summary><code>client.TachographEuOnly.<a href="/src/Samsara.Net/TachographEuOnly/TachographEuOnlyClient.cs">GetDriverTachographActivityAsync</a>(GetDriverTachographActivityRequest { ... }) -> WithRawResponseTask&lt;DriverTachographActivityResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph activity for all specified drivers in the time range. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.TachographEuOnly.GetDriverTachographActivityAsync(
    new GetDriverTachographActivityRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDriverTachographActivityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TachographEuOnly.<a href="/src/Samsara.Net/TachographEuOnly/TachographEuOnlyClient.cs">GetDriverTachographFilesAsync</a>(GetDriverTachographFilesRequest { ... }) -> WithRawResponseTask&lt;TachographDriverFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph files for all specified drivers in the time range. 

 <b>Rate limit:</b> 50 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.TachographEuOnly.GetDriverTachographFilesAsync(
    new GetDriverTachographFilesRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDriverTachographFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TachographEuOnly.<a href="/src/Samsara.Net/TachographEuOnly/TachographEuOnlyClient.cs">GetVehicleTachographFilesAsync</a>(GetVehicleTachographFilesRequest { ... }) -> WithRawResponseTask&lt;TachographVehicleFilesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known tachograph files for all specified vehicles in the time range. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.TachographEuOnly.GetVehicleTachographFilesAsync(
    new GetVehicleTachographFilesRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetVehicleTachographFilesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Equipment
<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">ListEquipmentAsync</a>(ListEquipmentRequest { ... }) -> WithRawResponseTask&lt;EquipmentListResponse&gt;</code></summary>
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
await client.Equipment.ListEquipmentAsync(new ListEquipmentRequest());
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

**request:** `ListEquipmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentLocationsAsync</a>(GetEquipmentLocationsRequest { ... }) -> WithRawResponseTask&lt;EquipmentLocationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns last known locations for all equipment. This can be optionally filtered by tags or specific equipment IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentLocationsAsync(new GetEquipmentLocationsRequest());
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

**request:** `GetEquipmentLocationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentLocationsFeedAsync</a>(GetEquipmentLocationsFeedRequest { ... }) -> WithRawResponseTask&lt;EquipmentLocationsListResponse&gt;</code></summary>
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

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentLocationsFeedAsync(new GetEquipmentLocationsFeedRequest());
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

**request:** `GetEquipmentLocationsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentLocationsHistoryAsync</a>(GetEquipmentLocationsHistoryRequest { ... }) -> WithRawResponseTask&lt;EquipmentLocationsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns historical equipment locations during the given time range. This can be optionally filtered by tags or specific equipment IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentLocationsHistoryAsync(
    new GetEquipmentLocationsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetEquipmentLocationsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentStatsAsync</a>(GetEquipmentStatsRequest { ... }) -> WithRawResponseTask&lt;EquipmentStatsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the last known stats for all equipment. This can be optionally filtered by tags or specific equipment IDs. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentStatsAsync(new GetEquipmentStatsRequest());
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

**request:** `GetEquipmentStatsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentStatsFeedAsync</a>(GetEquipmentStatsFeedRequest { ... }) -> WithRawResponseTask&lt;EquipmentStatsListResponse&gt;</code></summary>
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

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentStatsFeedAsync(new GetEquipmentStatsFeedRequest());
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

**request:** `GetEquipmentStatsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentStatsHistoryAsync</a>(GetEquipmentStatsHistoryRequest { ... }) -> WithRawResponseTask&lt;EquipmentStatsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns historical equipment status during the given time range. This can be optionally filtered by tags or specific equipment IDs. 

 <b>Rate limit:</b> 150 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentStatsHistoryAsync(
    new GetEquipmentStatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetEquipmentStatsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Equipment.<a href="/src/Samsara.Net/Equipment/EquipmentClient.cs">GetEquipmentAsync</a>(id) -> WithRawResponseTask&lt;EquipmentResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves the unit of equipment with the given Samsara ID. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Equipment.GetEquipmentAsync("id");
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

## Hours of Service
<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">GetHosClocksAsync</a>(GetHosClocksRequest { ... }) -> WithRawResponseTask&lt;HosClocksResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the current HOS status for all drivers. Note that this includes inactive as well as active drivers. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getFleetHosLogsSummary). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.HoursOfService.GetHosClocksAsync(new GetHosClocksRequest());
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

**request:** `GetHosClocksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">GetHosDailyLogsAsync</a>(GetHosDailyLogsRequest { ... }) -> WithRawResponseTask&lt;HosDailyLogsGetHosDailyLogsResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.HoursOfService.GetHosDailyLogsAsync(new GetHosDailyLogsRequest());
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

**request:** `GetHosDailyLogsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">GetHosLogsAsync</a>(GetHosLogsRequest { ... }) -> WithRawResponseTask&lt;HosLogsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns HOS logs between a given `startTime` and `endTime`. The logs can be further filtered using tags or by providing a list of driver IDs (including external IDs). The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getFleetHosLogs).

**Note:** If data is still being uploaded from the Samsara Driver App, it may not be completely reflected in the response from this endpoint. The best practice is to wait a couple of days before querying this endpoint to make sure that all data from the Samsara Driver App has been uploaded. 

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.HoursOfService.GetHosLogsAsync(new GetHosLogsRequest());
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

**request:** `GetHosLogsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">GetHosViolationsAsync</a>(GetHosViolationsRequest { ... }) -> WithRawResponseTask&lt;HosViolationsGetHosViolationsResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.HoursOfService.GetHosViolationsAsync(new GetHosViolationsRequest());
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

**request:** `GetHosViolationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">SetCurrentDutyStatusAsync</a>(driverId, InlineObject1 { ... })</code></summary>
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

Set an individual driver’s current duty status to 'On Duty' or 'Off Duty'.

 To ensure compliance with the ELD Mandate, only  authenticated drivers can make direct duty status changes on their own logbook. Any system external to the Samsara Driver App using this endpoint to trigger duty status changes must ensure that such changes are only triggered directly by the driver in question and that the driver has been properly authenticated. This endpoint should not be used to algorithmically trigger duty status changes nor should it be used by personnel besides the driver to trigger duty status changes on the driver’s behalf. Carriers and their drivers are ultimately responsible for maintaining accurate logs and should confirm that their use of the endpoint is compliant with the ELD Mandate. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write ELD Hours of Service (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.HoursOfService.SetCurrentDutyStatusAsync(
    1000000,
    new InlineObject1 { DutyStatus = "ON_DUTY" }
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

**driverId:** `long` — ID of the driver for whom the duty status is being set.
    
</dd>
</dl>

<dl>
<dd>

**request:** `InlineObject1` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HoursOfService.<a href="/src/Samsara.Net/HoursOfService/HoursOfServiceClient.cs">V1GetFleetHosAuthenticationLogsAsync</a>(V1GetFleetHosAuthenticationLogsRequest { ... }) -> WithRawResponseTask&lt;V1HosAuthenticationLogsResponse&gt;</code></summary>
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

Get the HOS (hours of service) signin and signout logs for the specified driver. The response includes 4 fields that are now deprecated.

**Note:** If data is still being uploaded from the Samsara Driver App, it may not be completely reflected in the response from this endpoint. The best practice is to wait a couple of days before querying this endpoint to make sure that all data from the Samsara Driver App has been uploaded. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read ELD Hours of Service (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.HoursOfService.V1GetFleetHosAuthenticationLogsAsync(
    new V1GetFleetHosAuthenticationLogsRequest
    {
        DriverId = 1000000,
        StartMs = 1000000,
        EndMs = 1000000,
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

**request:** `V1GetFleetHosAuthenticationLogsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Ifta
<details><summary><code>client.Ifta.<a href="/src/Samsara.Net/Ifta/IftaClient.cs">GetIftaJurisdictionReportsAsync</a>(GetIftaJurisdictionReportsRequest { ... }) -> WithRawResponseTask&lt;IftaGetIftaJurisdictionReportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all jurisdiction IFTA reports for the requested time duration. Data is returned in your organization's defined timezone.

**Note:** The most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Ifta.GetIftaJurisdictionReportsAsync(
    new GetIftaJurisdictionReportsRequest { Year = 1000000 }
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

**request:** `GetIftaJurisdictionReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ifta.<a href="/src/Samsara.Net/Ifta/IftaClient.cs">GetIftaVehicleReportsAsync</a>(GetIftaVehicleReportsRequest { ... }) -> WithRawResponseTask&lt;IftaGetIftaVehicleReportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get all vehicle IFTA reports for the requested time duration. Data is returned in your organization's defined timezone.

**Note:** The most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Ifta.GetIftaVehicleReportsAsync(new GetIftaVehicleReportsRequest { Year = 1000000 });
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

**request:** `GetIftaVehicleReportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Ifta.<a href="/src/Samsara.Net/Ifta/IftaClient.cs">CreateIftaDetailJobAsync</a>(IftaCreateIftaDetailJobRequestBody { ... }) -> WithRawResponseTask&lt;IftaCreateIftaDetailJobResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a job to generate csv files of IFTA mileage segments.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write IFTA (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Ifta.CreateIftaDetailJobAsync(
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

<details><summary><code>client.Ifta.<a href="/src/Samsara.Net/Ifta/IftaClient.cs">GetIftaDetailJobAsync</a>(id) -> WithRawResponseTask&lt;IftaGetIftaDetailJobResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about an existing IFTA detail job.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read IFTA (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Ifta.GetIftaDetailJobAsync("id");
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

## Routes
<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">FetchRoutesAsync</a>(FetchRoutesRequest { ... }) -> WithRawResponseTask&lt;RoutesFetchRoutesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns multiple routes. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/fetchAllDispatchRoutes).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.FetchRoutesAsync(
    new FetchRoutesRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `FetchRoutesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">CreateRouteAsync</a>(RoutesCreateRouteRequestBody { ... }) -> WithRawResponseTask&lt;RoutesCreateRouteResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a route. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/createDispatchRoute).

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.CreateRouteAsync(
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

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">GetRoutesFeedAsync</a>(GetRoutesFeedRequest { ... }) -> WithRawResponseTask&lt;RoutesGetRoutesFeedResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Subscribes to a feed of immutable, append-only updates for routes. The initial request to this feed endpoint returns a cursor, which can be used on the next request to fetch updated routes that have had state changes since that request.

The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/fetchAllRouteJobUpdates).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.GetRoutesFeedAsync(new GetRoutesFeedRequest());
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

**request:** `GetRoutesFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">FetchRouteAsync</a>(id, FetchRouteRequest { ... }) -> WithRawResponseTask&lt;RoutesFetchRouteResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a single route. The legacy version of this endpoint can be found at [samsara.com/api-legacy](https://www.samsara.com/api-legacy#operation/getDispatchRouteById).

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.FetchRouteAsync("id", new FetchRouteRequest());
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

**request:** `FetchRouteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">DeleteRouteAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a dispatch route and its associated stops.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.DeleteRouteAsync("id");
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

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">PatchRouteAsync</a>(id, RoutesPatchRouteRequestBody { ... }) -> WithRawResponseTask&lt;RoutesPatchRouteResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.PatchRouteAsync("id", new RoutesPatchRouteRequestBody());
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

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">ListHubPlanRoutesAsync</a>(ListHubPlanRoutesRequest { ... }) -> WithRawResponseTask&lt;HubPlanRoutesListHubPlanRoutesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve routes for a specific plan.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Routes.ListHubPlanRoutesAsync(new ListHubPlanRoutesRequest { PlanId = "planId" });
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

**request:** `ListHubPlanRoutesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Routes.<a href="/src/Samsara.Net/Routes/RoutesClient.cs">V1DeleteDispatchRouteByIdAsync</a>(routeIdOrExternalId, InlineObject { ... })</code></summary>
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

Delete a dispatch route and its associated jobs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Routes.V1DeleteDispatchRouteByIdAsync("route_id_or_external_id", new InlineObject());
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

**routeIdOrExternalId:** `string` — ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    
</dd>
</dl>

<dl>
<dd>

**request:** `InlineObject` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Settings
<details><summary><code>client.Settings.<a href="/src/Samsara.Net/Settings/SettingsClient.cs">GetComplianceSettingsAsync</a>() -> WithRawResponseTask&lt;SettingsGetComplianceSettingsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get organization's compliance settings, including carrier name, office address, and DOT number

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Settings.GetComplianceSettingsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Settings.<a href="/src/Samsara.Net/Settings/SettingsClient.cs">PatchComplianceSettingsAsync</a>(SettingsPatchComplianceSettingsRequestBody { ... }) -> WithRawResponseTask&lt;SettingsPatchComplianceSettingsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update organization's compliance settings, including carrier name, office address, and DOT number

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Settings.PatchComplianceSettingsAsync(
    new SettingsPatchComplianceSettingsRequestBody()
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

**request:** `SettingsPatchComplianceSettingsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Settings.<a href="/src/Samsara.Net/Settings/SettingsClient.cs">GetDriverAppSettingsAsync</a>() -> WithRawResponseTask&lt;SettingsGetDriverAppSettingsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get driver app settings.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Driver App Settings** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Settings.GetDriverAppSettingsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Settings.<a href="/src/Samsara.Net/Settings/SettingsClient.cs">PatchDriverAppSettingsAsync</a>(SettingsPatchDriverAppSettingsRequestBody { ... }) -> WithRawResponseTask&lt;SettingsPatchDriverAppSettingsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update driver app settings.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Driver App Settings** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Settings.PatchDriverAppSettingsAsync(new SettingsPatchDriverAppSettingsRequestBody());
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

<details><summary><code>client.Settings.<a href="/src/Samsara.Net/Settings/SettingsClient.cs">GetSafetySettingsAsync</a>() -> WithRawResponseTask&lt;SafetySettingsGetSafetySettingsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get safety settings

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Settings.GetSafetySettingsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Trailers
<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">ListTrailersAsync</a>(ListTrailersRequest { ... }) -> WithRawResponseTask&lt;TrailersListTrailersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all trailers.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trailers.ListTrailersAsync(new ListTrailersRequest());
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

**request:** `ListTrailersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">CreateTrailerAsync</a>(TrailersCreateTrailerRequestBody { ... }) -> WithRawResponseTask&lt;TrailersCreateTrailerResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new trailer asset.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trailers.CreateTrailerAsync(
    new TrailersCreateTrailerRequestBody { Name = "Trailer-123" }
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

**request:** `TrailersCreateTrailerRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">GetTrailerAsync</a>(id) -> WithRawResponseTask&lt;TrailersGetTrailerResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a trailer with given ID.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trailers.GetTrailerAsync("id");
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

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">DeleteTrailerAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a trailer with the given ID.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trailers.DeleteTrailerAsync("id");
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

<details><summary><code>client.Trailers.<a href="/src/Samsara.Net/Trailers/TrailersClient.cs">UpdateTrailerAsync</a>(id, TrailersUpdateTrailerRequestBody { ... }) -> WithRawResponseTask&lt;TrailersUpdateTrailerResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Trailers** under the Trailers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trailers.UpdateTrailerAsync("id", new TrailersUpdateTrailerRequestBody());
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

**id:** `string` — ID of the trailer. Can be either unique Samsara ID or an [external ID](/docs/external-ids) for the trailer.
    
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
<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">ListAsync</a>(ListVehiclesRequest { ... }) -> Pager&lt;VehicleResponseObjectResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all vehicles.

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Vehicles.ListAsync(new ListVehiclesRequest());
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

**request:** `ListVehiclesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">GetAsync</a>(id) -> WithRawResponseTask&lt;VehicleResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about a specific vehicle. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Vehicles.<a href="/src/Samsara.Net/Vehicles/VehiclesClient.cs">UpdateAsync</a>(id, UpdateVehicleRequest { ... }) -> WithRawResponseTask&lt;VehicleResponse&gt;</code></summary>
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

To use this endpoint, select **Write Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

## Vehicle Locations
<details><summary><code>client.VehicleLocations.<a href="/src/Samsara.Net/VehicleLocations/VehicleLocationsClient.cs">GetVehicleLocationsAsync</a>(GetVehicleLocationsRequest { ... }) -> WithRawResponseTask&lt;VehicleLocationsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestats) instead.***

Returns the last known location of all vehicles at the given `time`. If no `time` is specified, the current time is used. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: [Vehicle Locations](/docs/vehicle-locations-1). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleLocations.GetVehicleLocationsAsync(new GetVehicleLocationsRequest());
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

**request:** `GetVehicleLocationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VehicleLocations.<a href="/src/Samsara.Net/VehicleLocations/VehicleLocationsClient.cs">GetVehicleLocationsFeedAsync</a>(GetVehicleLocationsFeedRequest { ... }) -> WithRawResponseTask&lt;VehicleLocationsListResponse&gt;</code></summary>
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

Related guide: [Vehicle Locations](/docs/vehicle-locations-1). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleLocations.GetVehicleLocationsFeedAsync(new GetVehicleLocationsFeedRequest());
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

**request:** `GetVehicleLocationsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VehicleLocations.<a href="/src/Samsara.Net/VehicleLocations/VehicleLocationsClient.cs">GetVehicleLocationsHistoryAsync</a>(GetVehicleLocationsHistoryRequest { ... }) -> WithRawResponseTask&lt;VehicleLocationsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatshistory) instead.***

Returns all known vehicle locations during the given time range. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: [Vehicle Locations](/docs/vehicle-locations-1). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleLocations.GetVehicleLocationsHistoryAsync(
    new GetVehicleLocationsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetVehicleLocationsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Vehicle Stats
<details><summary><code>client.VehicleStats.<a href="/src/Samsara.Net/VehicleStats/VehicleStatsClient.cs">GetVehicleStatsAsync</a>(GetVehicleStatsRequest { ... }) -> WithRawResponseTask&lt;VehicleStatsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns the last known stats of all vehicles at the given `time`. If no `time` is specified, the current time is used.

Related guide: [Telematics](/docs/telematics). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleStats.GetVehicleStatsAsync(new GetVehicleStatsRequest());
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

**request:** `GetVehicleStatsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VehicleStats.<a href="/src/Samsara.Net/VehicleStats/VehicleStatsClient.cs">GetVehicleStatsFeedAsync</a>(GetVehicleStatsFeedRequest { ... }) -> WithRawResponseTask&lt;VehicleStatsListResponse&gt;</code></summary>
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

Related guide: [Telematics](/docs/telematics). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleStats.GetVehicleStatsFeedAsync(new GetVehicleStatsFeedRequest());
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

**request:** `GetVehicleStatsFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.VehicleStats.<a href="/src/Samsara.Net/VehicleStats/VehicleStatsClient.cs">GetVehicleStatsHistoryAsync</a>(GetVehicleStatsHistoryRequest { ... }) -> WithRawResponseTask&lt;VehicleStatsListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns vehicle stats during the given time range for all vehicles. This can be optionally filtered by tags or specific vehicle IDs.

Related guide: [Telematics](/docs/telematics). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.VehicleStats.GetVehicleStatsHistoryAsync(
    new GetVehicleStatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetVehicleStatsHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Forms
<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">GetFormSubmissionsAsync</a>(GetFormSubmissionsRequest { ... }) -> WithRawResponseTask&lt;FormSubmissionsGetFormSubmissionsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all form submissions data for the specified list of IDs.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.GetFormSubmissionsAsync(new GetFormSubmissionsRequest());
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

**request:** `GetFormSubmissionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">PostFormSubmissionAsync</a>(FormSubmissionsPostFormSubmissionRequestBody { ... }) -> WithRawResponseTask&lt;FormSubmissionsPostFormSubmissionResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a form submission and assigns it to an individual worker. This endpoint can be used to create an empty or partially complete form submission and assign it to a worker.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.PostFormSubmissionAsync(
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

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">PatchFormSubmissionAsync</a>(FormSubmissionsPatchFormSubmissionRequestBody { ... }) -> WithRawResponseTask&lt;FormSubmissionsPatchFormSubmissionResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an instance of a form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.PatchFormSubmissionAsync(
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

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">GetFormSubmissionsPdfExportsAsync</a>(GetFormSubmissionsPdfExportsRequest { ... }) -> WithRawResponseTask&lt;FormSubmissionsGetFormSubmissionsPdfExportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a PDF export that has already been generated for a form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.GetFormSubmissionsPdfExportsAsync(
    new GetFormSubmissionsPdfExportsRequest { PdfId = "pdfId" }
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

**request:** `GetFormSubmissionsPdfExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">PostFormSubmissionsPdfExportsAsync</a>(PostFormSubmissionsPdfExportsRequest { ... }) -> WithRawResponseTask&lt;FormSubmissionsPostFormSubmissionsPdfExportsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a PDF export for an existing form submission.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.PostFormSubmissionsPdfExportsAsync(
    new PostFormSubmissionsPdfExportsRequest { Id = "id" }
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

**request:** `PostFormSubmissionsPdfExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">GetFormSubmissionsStreamAsync</a>(GetFormSubmissionsStreamRequest { ... }) -> WithRawResponseTask&lt;FormSubmissionsGetFormSubmissionsStreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all form submissions data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Forms.GetFormSubmissionsStreamAsync(
    new GetFormSubmissionsStreamRequest { StartTime = "startTime" }
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

**request:** `GetFormSubmissionsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Forms.<a href="/src/Samsara.Net/Forms/FormsClient.cs">GetFormTemplatesAsync</a>(GetFormTemplatesRequest { ... }) -> WithRawResponseTask&lt;FormTemplatesGetFormTemplatesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of the organization's form templates for the specified list of IDs. If no IDs are provided, all form templates for the organization will be returned.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Form Submissions** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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

## Gateways
<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">GetGatewaysAsync</a>(GetGatewaysRequest { ... }) -> WithRawResponseTask&lt;GatewaysGetGatewaysResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all gateways

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Gateways** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Gateways.GetGatewaysAsync(new GetGatewaysRequest());
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

**request:** `GetGatewaysRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">PostGatewayAsync</a>(GatewaysPostGatewayRequestBody { ... }) -> WithRawResponseTask&lt;GatewaysPostGatewayResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Activate a new gateway. To activate a device and associate it with your organization, enter its serial number. Each device's serial number can also be found on its label or packaging, or from your order confirmation email. A Not Found error could mean that the serial was not found or it has already been activated

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Gateways** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Gateways.PostGatewayAsync(
    new GatewaysPostGatewayRequestBody { Serial = "GFRV-43N-VGX" }
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

**request:** `GatewaysPostGatewayRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Gateways.<a href="/src/Samsara.Net/Gateways/GatewaysClient.cs">DeleteGatewayAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deactivate a gateway

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Gateways** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Gateways.DeleteGatewayAsync("id");
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

## Hubs
<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">ListHubCapacitiesAsync</a>(ListHubCapacitiesRequest { ... }) -> WithRawResponseTask&lt;HubCapacitiesListHubCapacitiesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve capacity types for a specific hub.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.ListHubCapacitiesAsync(new ListHubCapacitiesRequest { HubId = "hubId" });
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

**request:** `ListHubCapacitiesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">UpdateHubLocationAsync</a>(id, HubLocationsUpdateHubLocationRequestBody { ... }) -> WithRawResponseTask&lt;HubLocationsUpdateHubLocationResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update existing location by ID.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.UpdateHubLocationAsync(
    "id",
    new HubLocationsUpdateHubLocationRequestBody
    {
        Data = new UpdateHubLocationRequestBodyRequestBody
        {
            Address = "123 Industrial Blvd, Los Angeles, CA 90210, US",
            CustomerLocationId = "LOC-123",
            DriverInstructions = "sample instructions",
            IsDepot = false,
            Latitude = 34.0522,
            Longitude = -118.2437,
            Name = "Customer ABC Warehouse",
            PlannerNotes = "sample note",
            ServiceTimeSeconds = 1800,
            ServiceWindows = new List<HubLocationServiceWindowInputRequestBody>()
            {
                new HubLocationServiceWindowInputRequestBody
                {
                    DaysOfWeek = new List<string>()
                    {
                        "monday",
                        "tuesday",
                        "wednesday",
                        "thursday",
                        "friday",
                    },
                    EndTime = "17:00:00",
                    StartTime = "08:00:00",
                },
            },
            SkillsRequired = new List<string>() { "650e8400-e29b-41d4-a716-446655440001" },
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

**id:** `string` — The unique Samsara ID of the hub location to update
    
</dd>
</dl>

<dl>
<dd>

**request:** `HubLocationsUpdateHubLocationRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">ListHubLocationsAsync</a>(ListHubLocationsRequest { ... }) -> WithRawResponseTask&lt;HubLocationsListHubLocationsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve locations for a specific hub.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.ListHubLocationsAsync(new ListHubLocationsRequest { HubId = "hubId" });
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

**request:** `ListHubLocationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">CreateHubLocationsAsync</a>(HubLocationsCreateHubLocationsRequestBody { ... }) -> WithRawResponseTask&lt;HubLocationsCreateHubLocationsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create new locations.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.CreateHubLocationsAsync(
    new HubLocationsCreateHubLocationsRequestBody
    {
        Data = new List<HubLocationInputObjectRequestBody>()
        {
            new HubLocationInputObjectRequestBody
            {
                Address = "123 Industrial Blvd, Los Angeles, CA 90210, US",
                CustomerLocationId = "LOC-123",
                DriverInstructions = "sample instructions",
                HubId = "550e8400-e29b-41d4-a716-446655440000",
                IsDepot = false,
                Latitude = 34.0522,
                Longitude = -118.2437,
                Name = "Customer ABC Warehouse",
                PlannerNotes = "sample note",
                ServiceTimeSeconds = 1800,
                ServiceWindows = new List<HubLocationServiceWindowInputRequestBody>()
                {
                    new HubLocationServiceWindowInputRequestBody
                    {
                        DaysOfWeek = new List<string>()
                        {
                            "monday",
                            "tuesday",
                            "wednesday",
                            "thursday",
                            "friday",
                        },
                        EndTime = "17:00:00",
                        StartTime = "08:00:00",
                    },
                },
                SkillsRequired = new List<string>() { "650e8400-e29b-41d4-a716-446655440001" },
            },
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

**request:** `HubLocationsCreateHubLocationsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">ListHubSkillsAsync</a>(ListHubSkillsRequest { ... }) -> WithRawResponseTask&lt;HubSkillsListHubSkillsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve skills for a specific hub.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.ListHubSkillsAsync(new ListHubSkillsRequest { HubId = "hubId" });
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

**request:** `ListHubSkillsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Hubs.<a href="/src/Samsara.Net/Hubs/HubsClient.cs">ListHubsAsync</a>(ListHubsRequest { ... }) -> WithRawResponseTask&lt;HubsListHubsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all hubs (planners) in the organization. This endpoint supports pagination and filtering based on hub IDs and update times.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Hubs.ListHubsAsync(new ListHubsRequest());
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

**request:** `ListHubsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Plans
<details><summary><code>client.Plans.<a href="/src/Samsara.Net/Plans/PlansClient.cs">CreateHubPlanAsync</a>(HubPlansCreateHubPlanRequestBody { ... }) -> WithRawResponseTask&lt;HubPlansCreateHubPlanResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new plan.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Plans.CreateHubPlanAsync(
    new HubPlansCreateHubPlanRequestBody
    {
        HubId = "550e8400-e29b-41d4-a716-446655440000",
        Name = "Weekly Plan - Week 15",
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

**request:** `HubPlansCreateHubPlanRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Plans.<a href="/src/Samsara.Net/Plans/PlansClient.cs">ListHubPlansAsync</a>(ListHubPlansRequest { ... }) -> WithRawResponseTask&lt;HubPlansListHubPlansResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve all plans for a specific hub.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Plans.ListHubPlansAsync(new ListHubPlansRequest { HubId = "hubId" });
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

**request:** `ListHubPlansRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Idling
<details><summary><code>client.Idling.<a href="/src/Samsara.Net/Idling/IdlingClient.cs">GetIdlingEventsAsync</a>(GetIdlingEventsRequest { ... }) -> WithRawResponseTask&lt;AdvancedIdlingGetIdlingEventsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get idling events for the requested time duration.

**Note:** The data from this endpoint comes from the new Advanced Idling Report, which provides additional data fields for each idling event such as air temperature, geofence, PTO state and minimum idle time. This endpoint includes data from January 1, 2024. If you require additional historical data, you can access it via the [vehicle idling reports API](/api-reference/legacy/legacy-apis/get-vehicle-idling-reports).

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Idling** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Idling.GetIdlingEventsAsync(
    new GetIdlingEventsRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetIdlingEventsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Industrial
<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetIndustrialAssetsAsync</a>(GetIndustrialAssetsRequest { ... }) -> WithRawResponseTask&lt;ListIndustrialAssetsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all assets in the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetIndustrialAssetsAsync(new GetIndustrialAssetsRequest());
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

**request:** `GetIndustrialAssetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">CreateIndustrialAssetAsync</a>(AssetCreate { ... }) -> WithRawResponseTask&lt;InlineResponse200&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an asset with optional configuration parameters. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.CreateIndustrialAssetAsync(new AssetCreate { Name = "name" });
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

**request:** `AssetCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">PatchIndustrialAssetAsync</a>(id, AssetPatch { ... }) -> WithRawResponseTask&lt;InlineResponse200&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an existing asset. Only the provided fields will be updated. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.PatchIndustrialAssetAsync("id", new AssetPatch());
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

**id:** `string` — Id of the asset to be updated
    
</dd>
</dl>

<dl>
<dd>

**request:** `AssetPatch` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">PatchAssetDataOutputsAsync</a>(id, AssetDataOutputsPatchAssetDataOutputsRequestBody { ... }) -> WithRawResponseTask&lt;AssetDataOutputsPatchAssetDataOutputsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Writes values to multiple data outputs on an asset simultaneously. Only the provided data outputs will be updated.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Industrial.PatchAssetDataOutputsAsync(
    "id",
    new AssetDataOutputsPatchAssetDataOutputsRequestBody
    {
        Values = new Dictionary<string, object?>() { { "key", "value" } },
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

**id:** `string` — Asset ID
    
</dd>
</dl>

<dl>
<dd>

**request:** `AssetDataOutputsPatchAssetDataOutputsRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetDataInputsAsync</a>(GetDataInputsRequest { ... }) -> WithRawResponseTask&lt;DataInputsTinyResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all data inputs, optionally filtered by tags or asset ids. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetDataInputsAsync(new GetDataInputsRequest());
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

**request:** `GetDataInputsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetDataInputDataSnapshotAsync</a>(GetDataInputDataSnapshotRequest { ... }) -> WithRawResponseTask&lt;DataInputSnapshotResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns last known data points for all data inputs. This can be filtered by optional tags, specific data input IDs or asset IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetDataInputDataSnapshotAsync(new GetDataInputDataSnapshotRequest());
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

**request:** `GetDataInputDataSnapshotRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetDataInputDataFeedAsync</a>(GetDataInputDataFeedRequest { ... }) -> WithRawResponseTask&lt;DataInputListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Follow a continuous feed of all data input data points.

Your first call to this endpoint will provide you with the most recent data points for each data input and a `pagination` object that contains an `endCursor`.

You can provide the `endCursor` to the `after` parameter of this endpoint to get data point updates since that `endCursor`.

If `hasNextPage` is `false`, no updates are readily available yet. We suggest waiting a minimum of 5 seconds before requesting updates. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetDataInputDataFeedAsync(new GetDataInputDataFeedRequest());
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

**request:** `GetDataInputDataFeedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetDataInputDataHistoryAsync</a>(GetDataInputDataHistoryRequest { ... }) -> WithRawResponseTask&lt;DataInputListResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all known data points during the given time range for all data inputs. This can be filtered by optional tags, specific data input IDs or asset IDs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Equipment Statistics** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetDataInputDataHistoryAsync(
    new GetDataInputDataHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
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

**request:** `GetDataInputDataHistoryRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetCamerasAsync</a>() -> WithRawResponseTask&lt;IEnumerable&lt;V1VisionCamerasResponseItem&gt;&gt;</code></summary>
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

Fetch all cameras. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetCamerasAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetVisionProgramsByCameraAsync</a>(cameraId) -> WithRawResponseTask&lt;IEnumerable&lt;V1ProgramsForTheCameraResponseItem&gt;&gt;</code></summary>
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

Fetch configured programs on the camera. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetVisionProgramsByCameraAsync(1000000);
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

**cameraId:** `long` — The camera_id should be valid for the given accessToken.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetVisionLatestRunCameraAsync</a>(cameraId, V1GetVisionLatestRunCameraRequest { ... }) -> WithRawResponseTask&lt;V1VisionRunByCameraResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch the latest run for a camera or program by default. If startedAtMs is supplied, fetch the specific run that corresponds to that start time. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetVisionLatestRunCameraAsync(
    1000000,
    new V1GetVisionLatestRunCameraRequest()
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

**cameraId:** `long` — The camera_id should be valid for the given accessToken.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetVisionLatestRunCameraRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetVisionRunsAsync</a>(V1GetVisionRunsRequest { ... }) -> WithRawResponseTask&lt;V1VisionRunsResponse&gt;</code></summary>
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

Fetch runs. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetVisionRunsAsync(new V1GetVisionRunsRequest { DurationMs = 1000000 });
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

**request:** `V1GetVisionRunsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">GetVisionRunsByCameraAsync</a>(cameraId, GetVisionRunsByCameraRequest { ... }) -> WithRawResponseTask&lt;IEnumerable&lt;V1VisionRunsByCameraResponseItem&gt;&gt;</code></summary>
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

Fetch runs by camera. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.GetVisionRunsByCameraAsync(
    1000000,
    new GetVisionRunsByCameraRequest { DurationMs = 1000000 }
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

**cameraId:** `long` — The camera_id should be valid for the given accessToken.
    
</dd>
</dl>

<dl>
<dd>

**request:** `GetVisionRunsByCameraRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetVisionRunsByCameraAndProgramAsync</a>(cameraId, programId, startedAtMs, V1GetVisionRunsByCameraAndProgramRequest { ... }) -> WithRawResponseTask&lt;V1VisionRunsByCameraAndProgramResponse&gt;</code></summary>
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

Fetch runs by camera and program. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetVisionRunsByCameraAndProgramAsync(
    1000000,
    1000000,
    1000000,
    new V1GetVisionRunsByCameraAndProgramRequest()
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

**cameraId:** `long` — The camera_id should be valid for the given accessToken.
    
</dd>
</dl>

<dl>
<dd>

**programId:** `long` — The configured program's ID on the camera.
    
</dd>
</dl>

<dl>
<dd>

**startedAtMs:** `long` — Started_at_ms is a required param. Indicates the start time of the run to be fetched.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetVisionRunsByCameraAndProgramRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetMachinesHistoryAsync</a>(InlineObject3 { ... }) -> WithRawResponseTask&lt;V1MachineHistoryResponse&gt;</code></summary>
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

Get historical data for machine objects. This method returns a set of historical data for all machines. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetMachinesHistoryAsync(
    new InlineObject3 { EndMs = 1462881998034, StartMs = 1462878398034 }
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

**request:** `InlineObject3` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Industrial.<a href="/src/Samsara.Net/Industrial/IndustrialClient.cs">V1GetMachinesAsync</a>() -> WithRawResponseTask&lt;InlineResponse2008&gt;</code></summary>
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

Get machine objects. This method returns a list of the machine objects in the Samsara Cloud and information about them. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Industrial** under the Industrial category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.V1GetMachinesAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Issues
<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">GetIssuesAsync</a>(GetIssuesRequest { ... }) -> WithRawResponseTask&lt;IssuesGetIssuesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all issues data for the specified IDs.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Issues** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Issues.GetIssuesAsync(new GetIssuesRequest());
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

**request:** `GetIssuesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">PatchIssueAsync</a>(IssuesPatchIssueRequestBody { ... }) -> WithRawResponseTask&lt;IssuesPatchIssueResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an instance of an issue.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Issues** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Issues.PatchIssueAsync(
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

<details><summary><code>client.Issues.<a href="/src/Samsara.Net/Issues/IssuesClient.cs">GetIssuesStreamAsync</a>(GetIssuesStreamRequest { ... }) -> WithRawResponseTask&lt;IssuesGetIssuesStreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all issues data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Issues** under the Forms category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Issues.GetIssuesStreamAsync(new GetIssuesStreamRequest { StartTime = "startTime" });
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

**request:** `GetIssuesStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## LiveSharingLinks
<details><summary><code>client.LiveSharingLinks.<a href="/src/Samsara.Net/LiveSharingLinks/LiveSharingLinksClient.cs">GetLiveSharingLinksAsync</a>(GetLiveSharingLinksRequest { ... }) -> WithRawResponseTask&lt;LiveSharingLinksGetLiveSharingLinksResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all non-expired Live Sharing Links.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Live Sharing Links** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LiveSharingLinks.GetLiveSharingLinksAsync(new GetLiveSharingLinksRequest());
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

**request:** `GetLiveSharingLinksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LiveSharingLinks.<a href="/src/Samsara.Net/LiveSharingLinks/LiveSharingLinksClient.cs">CreateLiveSharingLinkAsync</a>(LiveSharingLinksCreateLiveSharingLinkRequestBody { ... }) -> WithRawResponseTask&lt;LiveSharingLinksCreateLiveSharingLinkResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LiveSharingLinks.CreateLiveSharingLinkAsync(
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

<details><summary><code>client.LiveSharingLinks.<a href="/src/Samsara.Net/LiveSharingLinks/LiveSharingLinksClient.cs">DeleteLiveSharingLinkAsync</a>(DeleteLiveSharingLinkRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LiveSharingLinks.DeleteLiveSharingLinkAsync(
    new DeleteLiveSharingLinkRequest { Id = "id" }
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

**request:** `DeleteLiveSharingLinkRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.LiveSharingLinks.<a href="/src/Samsara.Net/LiveSharingLinks/LiveSharingLinksClient.cs">UpdateLiveSharingLinkAsync</a>(LiveSharingLinksUpdateLiveSharingLinkRequestBody { ... }) -> WithRawResponseTask&lt;LiveSharingLinksUpdateLiveSharingLinkResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update Live Sharing Link.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Live Sharing Links** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.LiveSharingLinks.UpdateLiveSharingLinkAsync(
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

## WorkOrders
<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">PostInvoiceScanAsync</a>(WorkOrdersPostInvoiceScanRequestBody { ... }) -> WithRawResponseTask&lt;WorkOrdersPostInvoiceScanResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Process an invoice scan to create or update a work order with AI-extracted data. Accepts base64 encoded invoice files (PDF, JPEG, PNG) up to 10MB.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.PostInvoiceScanAsync(
    new WorkOrdersPostInvoiceScanRequestBody
    {
        File = new InvoiceScanFileRequestBody
        {
            Base64Content = "JVBERi0xLjQKJeLjz9MKMyAwIG9iago8P...",
            ContentType = "application/pdf",
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

**request:** `WorkOrdersPostInvoiceScanRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">GetServiceTasksAsync</a>(GetServiceTasksRequest { ... }) -> WithRawResponseTask&lt;WorkOrdersGetServiceTasksResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets service tasks.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.GetServiceTasksAsync(new GetServiceTasksRequest());
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

**request:** `GetServiceTasksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">GetWorkOrdersAsync</a>(GetWorkOrdersRequest { ... }) -> WithRawResponseTask&lt;WorkOrdersGetWorkOrdersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets work orders.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.GetWorkOrdersAsync(new GetWorkOrdersRequest());
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

**request:** `GetWorkOrdersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">PostWorkOrdersAsync</a>(WorkOrdersPostWorkOrdersRequestBody { ... }) -> WithRawResponseTask&lt;WorkOrdersPostWorkOrdersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.PostWorkOrdersAsync(
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

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">DeleteWorkOrdersAsync</a>(DeleteWorkOrdersRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.DeleteWorkOrdersAsync(new DeleteWorkOrdersRequest { Id = "id" });
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

**request:** `DeleteWorkOrdersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">PatchWorkOrdersAsync</a>(WorkOrdersPatchWorkOrdersRequestBody { ... }) -> WithRawResponseTask&lt;WorkOrdersPatchWorkOrdersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a work order.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.PatchWorkOrdersAsync(new WorkOrdersPatchWorkOrdersRequestBody { Id = "5" });
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

<details><summary><code>client.WorkOrders.<a href="/src/Samsara.Net/WorkOrders/WorkOrdersClient.cs">StreamWorkOrdersAsync</a>(StreamWorkOrdersRequest { ... }) -> WithRawResponseTask&lt;WorkOrdersStreamWorkOrdersResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Stream work orders.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Work Orders** under the Work Orders category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.WorkOrders.StreamWorkOrdersAsync(
    new StreamWorkOrdersRequest { StartTime = "startTime" }
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

**request:** `StreamWorkOrdersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Organization Info
<details><summary><code>client.OrganizationInfo.<a href="/src/Samsara.Net/OrganizationInfo/OrganizationInfoClient.cs">GetOrganizationInfoAsync</a>() -> WithRawResponseTask&lt;OrganizationInfoResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get information about your organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Org Information** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.OrganizationInfo.GetOrganizationInfoAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## preview-apis
<details><summary><code>client.PreviewApis.<a href="/src/Samsara.Net/PreviewApis/PreviewApisClient.cs">CreateDriverAuthTokenAsync</a>(DriversAuthTokenCreateDriverAuthTokenRequestBody { ... }) -> WithRawResponseTask&lt;DriversAuthTokenCreateDriverAuthTokenResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a short-lived auth token for a driver.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Driver Auth Token** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)

Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications

- Samsara may change the structure of a preview API's interface without versioning or any notice to API users.

- When an endpoint becomes generally available, it will be announced in the API [changelog](/docs/subscribe-to-api-updates).
 

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
await client.PreviewApis.CreateDriverAuthTokenAsync(
    new DriversAuthTokenCreateDriverAuthTokenRequestBody { Code = "dp[gZc1wAigz4uGa0Hh" }
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

**request:** `DriversAuthTokenCreateDriverAuthTokenRequestBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreviewApis.<a href="/src/Samsara.Net/PreviewApis/PreviewApisClient.cs">LockVehicleAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Lock a vehicle. This requires a vehicle gateway with locking capabilities.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)

Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications

- Samsara may change the structure of a preview API's interface without versioning or any notice to API users.

- When an endpoint becomes generally available, it will be announced in the API [changelog](/docs/subscribe-to-api-updates).
 

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
await client.PreviewApis.LockVehicleAsync("id");
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

**id:** `string` — The ID of the vehicle to lock or unlock. This can be a Samsara internal ID or an external ID in the format `samsara.vin:{VIN}`.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreviewApis.<a href="/src/Samsara.Net/PreviewApis/PreviewApisClient.cs">UnlockVehicleAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unlock a vehicle.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)

Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications

- Samsara may change the structure of a preview API's interface without versioning or any notice to API users.

- When an endpoint becomes generally available, it will be announced in the API [changelog](/docs/subscribe-to-api-updates).
 

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
await client.PreviewApis.UnlockVehicleAsync("id");
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

**id:** `string` — The ID of the vehicle to lock or unlock. This can be a Samsara internal ID or an external ID in the format `samsara.vin:{VIN}`.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## RouteEvents
<details><summary><code>client.RouteEvents.<a href="/src/Samsara.Net/RouteEvents/RouteEventsClient.cs">GetRouteEventsStreamAsync</a>(GetRouteEventsStreamRequest { ... }) -> WithRawResponseTask&lt;RoutesGetRouteEventsStreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Subscribes to a feed of immutable, append-only updates for routes. The initial request to this feed endpoint returns a cursor, which can be used in subsequent requests to fetch events on all routes that occurred after the last retrieved event. An initial request (with empty after and startTime parameters) will return events from the past 24 hours.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.RouteEvents.GetRouteEventsStreamAsync(new GetRouteEventsStreamRequest());
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

**request:** `GetRouteEventsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Safety
<details><summary><code>client.Safety.<a href="/src/Samsara.Net/Safety/SafetyClient.cs">GetSafetyEventsV2Async</a>(GetSafetyEventsV2Request { ... }) -> WithRawResponseTask&lt;SafetyEventsV2GetSafetyEventsV2ResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return details for the specified safety events based on the parameters passed in. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Safety.GetSafetyEventsV2Async(new GetSafetyEventsV2Request());
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

**request:** `GetSafetyEventsV2Request` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Safety.<a href="/src/Samsara.Net/Safety/SafetyClient.cs">GetSafetyEventsV2StreamAsync</a>(GetSafetyEventsV2StreamRequest { ... }) -> WithRawResponseTask&lt;SafetyEventsV2GetSafetyEventsV2StreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return all safety events associated with your organization based on the parameters passed in. To get core endpoint data, select Read Safety Events & Scores under the Safety & Cameras category when creating or editing an API token. Read Camera Media permissions required to get Safety Event video media via this endpoint. If you include an endTime, the endpoint will return data up until that point. If you do not include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Safety.GetSafetyEventsV2StreamAsync(
    new GetSafetyEventsV2StreamRequest { StartTime = "startTime" }
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

**request:** `GetSafetyEventsV2StreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Safety.<a href="/src/Samsara.Net/Safety/SafetyClient.cs">V1GetDriverSafetyScoreAsync</a>(driverId, V1GetDriverSafetyScoreRequest { ... }) -> WithRawResponseTask&lt;V1DriverSafetyScoreResponse&gt;</code></summary>
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

Fetch the safety score for the driver.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Safety.V1GetDriverSafetyScoreAsync(
    1000000,
    new V1GetDriverSafetyScoreRequest { StartMs = 1000000, EndMs = 1000000 }
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

**driverId:** `long` — ID of the driver. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetDriverSafetyScoreRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Safety.<a href="/src/Samsara.Net/Safety/SafetyClient.cs">V1GetVehicleSafetyScoreAsync</a>(vehicleId, V1GetVehicleSafetyScoreRequest { ... }) -> WithRawResponseTask&lt;V1VehicleSafetyScoreResponse&gt;</code></summary>
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

Fetch the safety score for the vehicle. 

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Safety.V1GetVehicleSafetyScoreAsync(
    1000000,
    new V1GetVehicleSafetyScoreRequest { StartMs = 1000000, EndMs = 1000000 }
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

**vehicleId:** `long` — ID of the vehicle. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetVehicleSafetyScoreRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## SpeedingIntervals
<details><summary><code>client.SpeedingIntervals.<a href="/src/Samsara.Net/SpeedingIntervals/SpeedingIntervalsClient.cs">GetSpeedingIntervalsAsync</a>(GetSpeedingIntervalsRequest { ... }) -> WithRawResponseTask&lt;SpeedingIntervalsGetSpeedingIntervalsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return all speeding intervals associated with all trips that have been collected for your organization based on the time parameters passed in. Only completed trips are included. Trips with no speeding intervals detected will be returned with an empty list of intervals. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Speeding Intervals** under the Speeding Intervals category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.SpeedingIntervals.GetSpeedingIntervalsAsync(
    new GetSpeedingIntervalsRequest { StartTime = "startTime" }
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

**request:** `GetSpeedingIntervalsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tags
<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">ListTagsAsync</a>(ListTagsRequest { ... }) -> WithRawResponseTask&lt;ListTagsResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return all of the tags for an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Tags.ListTagsAsync(new ListTagsRequest());
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

**request:** `ListTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">CreateTagAsync</a>(CreateTagRequest { ... }) -> WithRawResponseTask&lt;TagResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new tag for the organization. This may include up to 20,000 tagged entities. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Tags.CreateTagAsync(new CreateTagRequest { Name = "California" });
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

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">GetTagAsync</a>(id) -> WithRawResponseTask&lt;TagResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Fetch a tag by id. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Tags.GetTagAsync("id");
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

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">ReplaceTagAsync</a>(id, ReplaceTagRequest { ... }) -> WithRawResponseTask&lt;TagResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a tag with a new name and new members. This API call would replace all old members of a tag with new members specified in the request body. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Tags.ReplaceTagAsync("id", new ReplaceTagRequest());
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

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently deletes a tag. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Tags.<a href="/src/Samsara.Net/Tags/TagsClient.cs">PatchTagAsync</a>(id, PatchTagRequest { ... }) -> WithRawResponseTask&lt;TagResponse&gt;</code></summary>
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

To use this endpoint, select **Write Tags** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Tags.PatchTagAsync("id", new PatchTagRequest());
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
<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">PostTrainingAssignmentsAsync</a>(PostTrainingAssignmentsRequest { ... }) -> WithRawResponseTask&lt;TrainingAssignmentsPostTrainingAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create training assignments. Existing assignments will remain unchanged.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.TrainingAssignments.PostTrainingAssignmentsAsync(
    new PostTrainingAssignmentsRequest { CourseId = "courseId", DueAtTime = "dueAtTime" }
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

**request:** `PostTrainingAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">DeleteTrainingAssignmentsAsync</a>(DeleteTrainingAssignmentsRequest { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint supports batch deletion operations. The response does not indicate which specific deletions, if any, have failed. On a successful deletion or partial failure, a ‘204 No Content’ status is returned.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.TrainingAssignments.DeleteTrainingAssignmentsAsync(
    new DeleteTrainingAssignmentsRequest()
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

**request:** `DeleteTrainingAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">PatchTrainingAssignmentsAsync</a>(PatchTrainingAssignmentsRequest { ... }) -> WithRawResponseTask&lt;TrainingAssignmentsPatchTrainingAssignmentsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update training assignments.

 <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Training Assignments** under the Training Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.TrainingAssignments.PatchTrainingAssignmentsAsync(
    new PatchTrainingAssignmentsRequest { DueAtTime = "dueAtTime" }
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

**request:** `PatchTrainingAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrainingAssignments.<a href="/src/Samsara.Net/TrainingAssignments/TrainingAssignmentsClient.cs">GetTrainingAssignmentsStreamAsync</a>(GetTrainingAssignmentsStreamRequest { ... }) -> WithRawResponseTask&lt;TrainingAssignmentsGetTrainingAssignmentsStreamResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all training assignments data that has been created or modified for your organization based on the time parameters passed in. Results are paginated and are sorted by last modified date. If you include an endTime, the endpoint will return data up until that point (exclusive). If you don't include an endTime, the API will continue to poll with the pagination cursor that gets returned on every call. The hasNextPage response value will be true if there is no endTime specified and endCursor is nonempty.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Training Assignments** under the Training Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.TrainingAssignments.GetTrainingAssignmentsStreamAsync(
    new GetTrainingAssignmentsStreamRequest { StartTime = "startTime" }
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

**request:** `GetTrainingAssignmentsStreamRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## TrainingCourses
<details><summary><code>client.TrainingCourses.<a href="/src/Samsara.Net/TrainingCourses/TrainingCoursesClient.cs">GetTrainingCoursesAsync</a>(GetTrainingCoursesRequest { ... }) -> WithRawResponseTask&lt;TrainingCoursesGetTrainingCoursesResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all training courses data. Results are paginated. 
 Courses in the ‘draft’ status are excluded from the data returned by this endpoint.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Training Courses** under the Training Courses category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.TrainingCourses.GetTrainingCoursesAsync(new GetTrainingCoursesRequest());
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

**request:** `GetTrainingCoursesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Trips
<details><summary><code>client.Trips.<a href="/src/Samsara.Net/Trips/TripsClient.cs">GetTripsAsync</a>(GetTripsRequest { ... }) -> WithRawResponseTask&lt;TripsGetTripsResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This endpoint will return trips that have been collected for your organization based on the time parameters passed in. Results are paginated.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Trips** under the Trips category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Trips.GetTripsAsync(new GetTripsRequest { StartTime = "startTime" });
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

**request:** `GetTripsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Trips.<a href="/src/Samsara.Net/Trips/TripsClient.cs">V1GetFleetTripsAsync</a>(V1GetFleetTripsRequest { ... }) -> WithRawResponseTask&lt;V1TripResponse&gt;</code></summary>
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

Get historical trips data for specified vehicle. This method returns a set of historical trips data for the specified vehicle in the specified time range. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Vehicle Trips** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Trips.V1GetFleetTripsAsync(
    new V1GetFleetTripsRequest
    {
        VehicleId = 1000000,
        StartMs = 1000000,
        EndMs = 1000000,
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

**request:** `V1GetFleetTripsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Users
<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">ListUserRolesAsync</a>(ListUserRolesRequest { ... }) -> WithRawResponseTask&lt;ListUserRolesResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all user roles in an organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Users.ListUserRolesAsync(new ListUserRolesRequest());
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

**request:** `ListUserRolesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">ListUsersAsync</a>(ListUsersRequest { ... }) -> WithRawResponseTask&lt;ListUsersResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of all users in an organization. Users that have expired access will not be returned. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Users.ListUsersAsync(new ListUsersRequest());
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

**request:** `ListUsersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">CreateUserAsync</a>(CreateUserRequest { ... }) -> WithRawResponseTask&lt;UserResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add a user to the organization. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Users.CreateUserAsync(
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

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">GetUserAsync</a>(id) -> WithRawResponseTask&lt;UserResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a specific user's information. Users that have expired access will not be returned. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Users.GetUserAsync("id");
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

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete the given user. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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

<details><summary><code>client.Users.<a href="/src/Samsara.Net/Users/UsersClient.cs">UpdateUserAsync</a>(id, UpdateUserRequest { ... }) -> WithRawResponseTask&lt;UserResponse&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update a specific user's information. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Users** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Users.UpdateUserAsync("id", new UpdateUserRequest());
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

## Messages
<details><summary><code>client.Messages.<a href="/src/Samsara.Net/Messages/MessagesClient.cs">V1GetMessagesAsync</a>(V1GetMessagesRequest { ... }) -> WithRawResponseTask&lt;InlineResponse2005&gt;</code></summary>
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

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Messages** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Messages.V1GetMessagesAsync(new V1GetMessagesRequest());
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

**request:** `V1GetMessagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Messages.<a href="/src/Samsara.Net/Messages/MessagesClient.cs">V1CreateMessagesAsync</a>(InlineObject2 { ... }) -> WithRawResponseTask&lt;InlineResponse2006&gt;</code></summary>
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

To use this endpoint, select **Write Messages** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Messages.V1CreateMessagesAsync(
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

## Trailer Assignments
<details><summary><code>client.TrailerAssignments.<a href="/src/Samsara.Net/TrailerAssignments/TrailerAssignmentsClient.cs">V1GetAllTrailerAssignmentsAsync</a>(V1GetAllTrailerAssignmentsRequest { ... }) -> WithRawResponseTask&lt;InlineResponse2007&gt;</code></summary>
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

Fetch trailer assignment data for all trailers in your organization. 

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.TrailerAssignments.V1GetAllTrailerAssignmentsAsync(
    new V1GetAllTrailerAssignmentsRequest()
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

**request:** `V1GetAllTrailerAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.TrailerAssignments.<a href="/src/Samsara.Net/TrailerAssignments/TrailerAssignmentsClient.cs">V1GetFleetTrailerAssignmentsAsync</a>(trailerId, V1GetFleetTrailerAssignmentsRequest { ... }) -> WithRawResponseTask&lt;V1TrailerAssignmentsResponse&gt;</code></summary>
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

Fetch trailer assignment data for a single trailer. 

 <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.TrailerAssignments.V1GetFleetTrailerAssignmentsAsync(
    1000000,
    new V1GetFleetTrailerAssignmentsRequest()
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

**trailerId:** `long` — ID of trailer. Must contain only digits 0-9.
    
</dd>
</dl>

<dl>
<dd>

**request:** `V1GetFleetTrailerAssignmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Sensors
<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsCargoAsync</a>(InlineObject4 { ... }) -> WithRawResponseTask&lt;V1CargoResponse&gt;</code></summary>
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

Get cargo monitor status (empty / full) for requested sensors. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsCargoAsync(
    new InlineObject4 { Sensors = new List<long>() { 122 } }
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

**request:** `InlineObject4` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsDoorAsync</a>(InlineObject5 { ... }) -> WithRawResponseTask&lt;V1DoorResponse&gt;</code></summary>
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

Get door monitor status (closed / open) for requested sensors. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsDoorAsync(
    new InlineObject5 { Sensors = new List<long>() { 122 } }
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

**request:** `InlineObject5` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsHistoryAsync</a>(InlineObject6 { ... }) -> WithRawResponseTask&lt;V1SensorHistoryResponse&gt;</code></summary>
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

Get historical data for specified sensors. This method returns a set of historical data for the specified sensors in the specified time range and at the specified time resolution. 

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)). 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsHistoryAsync(
    new InlineObject6
    {
        EndMs = 1462881998034,
        Series = new List<V1SensorsHistorySeries>()
        {
            new V1SensorsHistorySeries
            {
                Field = V1SensorsHistorySeriesField.AmbientTemperature,
                WidgetId = 1,
            },
        },
        StartMs = 1462878398034,
        StepMs = 3600000,
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

**request:** `InlineObject6` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsHumidityAsync</a>(InlineObject7 { ... }) -> WithRawResponseTask&lt;V1HumidityResponse&gt;</code></summary>
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

Get humidity for requested sensors. This method returns the current relative humidity for the requested sensors. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsHumidityAsync(
    new InlineObject7 { Sensors = new List<long>() { 122 } }
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

**request:** `InlineObject7` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsAsync</a>() -> WithRawResponseTask&lt;InlineResponse2009&gt;</code></summary>
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

Get sensor objects. This method returns a list of the sensor objects in the Samsara Cloud and information about them. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Sensors.<a href="/src/Samsara.Net/Sensors/SensorsClient.cs">V1GetSensorsTemperatureAsync</a>(InlineObject8 { ... }) -> WithRawResponseTask&lt;V1TemperatureResponse&gt;</code></summary>
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

Get temperature for requested sensors. This method returns the current ambient temperature (and probe temperature if applicable) for the requested sensors. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Sensors** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Sensors.V1GetSensorsTemperatureAsync(
    new InlineObject8 { Sensors = new List<long>() { 122 } }
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

**request:** `InlineObject8` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Webhooks
<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">ListWebhooksAsync</a>(ListWebhooksRequest { ... }) -> WithRawResponseTask&lt;WebhooksListWebhooksResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

List all webhooks belonging to a specific org.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Webhooks** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Webhooks.ListWebhooksAsync(new ListWebhooksRequest());
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

**request:** `ListWebhooksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">PostWebhooksAsync</a>(WebhooksPostWebhooksRequestBody { ... }) -> WithRawResponseTask&lt;WebhooksPostWebhooksResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a webhook

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Webhooks.PostWebhooksAsync(
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

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">GetWebhookAsync</a>(id) -> WithRawResponseTask&lt;WebhooksGetWebhookResponseBody&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a webhook with given ID.

 <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Read Webhooks** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Webhooks.GetWebhookAsync("id");
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

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">DeleteWebhookAsync</a>(id)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a webhook with the given ID.

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Webhooks.DeleteWebhookAsync("id");
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

<details><summary><code>client.Webhooks.<a href="/src/Samsara.Net/Webhooks/WebhooksClient.cs">PatchWebhookAsync</a>(id, WebhooksPatchWebhookRequestBody { ... }) -> WithRawResponseTask&lt;WebhooksPatchWebhookResponseBody&gt;</code></summary>
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

 <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).

To use this endpoint, select **Write Webhooks** under the Setup & Administration category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
 

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
await client.Webhooks.PatchWebhookAsync("id", new WebhooksPatchWebhookRequestBody());
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

## Fleet CarrierProposedAssignments
<details><summary><code>client.Fleet.CarrierProposedAssignments.<a href="/src/Samsara.Net/Fleet/CarrierProposedAssignments/CarrierProposedAssignmentsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Permanently delete an assignment. You can only delete assignments that are not yet active. To override a currently active assignment, create a new empty one, instead. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Fleet.CarrierProposedAssignments.DeleteAsync("id");
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

## Fleet Attributes
<details><summary><code>client.Fleet.Attributes.<a href="/src/Samsara.Net/Fleet/Attributes/AttributesClient.cs">UpdateAsync</a>(id)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Fleet.Attributes.UpdateAsync("id");
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

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Industrial Assets
<details><summary><code>client.Industrial.Assets.<a href="/src/Samsara.Net/Industrial/Assets/AssetsClient.cs">DeleteAsync</a>(id) -> WithRawResponseTask&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete asset. 

 **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.

To use this endpoint, select **Write Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
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
await client.Industrial.Assets.DeleteAsync("id");
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

**id:** `string` — Id of the asset to be deleted.
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
