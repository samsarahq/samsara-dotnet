# Samsara C# Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-Built%20with%20Fern-brightgreen)](https://buildwithfern.com?utm_source=github&utm_medium=github&utm_campaign=readme&utm_source=https%3A%2F%2Fgithub.com%2Fsamsarahq%2Fsamsara-dotnet)
[![nuget shield](https://img.shields.io/nuget/v/Samsara.Net)](https://nuget.org/packages/Samsara.Net)

The Samsara C# library provides convenient access to the Samsara API from C#.

## Installation

```sh
dotnet add package Samsara.Net
```

## Usage

Instantiate and use the client with the following:

```csharp
using Samsara.Net.Addresses;
using Samsara.Net;

var client = new SamsaraClient();
await client.Addresses.CreateAsync(
    new CreateAddressRequest
    {
        FormattedAddress = "350 Rhode Island St, San Francisco, CA",
        Geofence = new CreateAddressRequestGeofence(),
        Name = "Samsara HQ",
    }
);
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), a subclass of the following error
will be thrown.

```csharp
using Samsara.Net;

try {
    var response = await client.Addresses.CreateAsync(...);
} catch (SamsaraClientApiException e) {
    System.Console.WriteLine(e.Body);
    System.Console.WriteLine(e.StatusCode);
}
```

## Auto Pagination

Paginated requests will return a `Pager`, which can be used to automatically iterate over items.

```csharp
var pager = await client.Assets.ListCurrentLocationsAsync(
    new AssetsListCurrentLocationsRequest());

await foreach (var item in pager)
{
    Console.WriteLine(item);
}
```

Alternatively, you can iterate page-by-page:

```csharp
await foreach (var page in pager.AsPagesAsync())
{
    foreach (var item in page.Items)
    {
        Console.WriteLine(item);
    }
}
```

## Pagination

List endpoints are paginated. The SDK provides an async enumerable so that you can simply loop over the items:

```csharp
using Samsara.Net.Addresses;
using Samsara.Net;

var client = new SamsaraClient();
var pager = await client.Addresses.ListAsync(new AddressesListRequest());

await foreach (var item in pager)
{
    // do something with item
}
```

## Webhook Signature Verification

The SDK provides utility methods that allow you to verify webhook signatures and ensure
that all webhook events originate from Samsara. The `WebhooksHelper.verifySignature` method
can be used to verify the signature like so:

```csharp
using Microsoft.AspNetCore.Http;
using Samsara;

public static async Task CheckWebhooksEvent(
    HttpRequest request,
    string signatureKey,
    string notificationUrl
)
{
    var signature = request.Headers["x-samsara-hmacsha256-signature"].ToString();
    using var reader = new StreamReader(request.Body, System.Text.Encoding.UTF8);
    var requestBody = await reader.ReadToEndAsync();
    if (!WebhooksHelper.VerifySignature(requestBody, signature, signatureKey, notificationUrl))
    {
        throw new Exception("A webhook event was received that was not from Samsara.");
    }
}
```

In .NET 6 and above, there are also overloads using spans for allocation free webhook verification.

## Advanced

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retryable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retryable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `MaxRetries` request option to configure this behavior.

```csharp
var response = await client.Addresses.CreateAsync(
    ...,
    new RequestOptions {
        MaxRetries: 0 // Override MaxRetries at the request level
    }
);
```

### Timeouts

The SDK defaults to a 30 second timeout. Use the `Timeout` option to configure this behavior.

```csharp
var response = await client.Addresses.CreateAsync(
    ...,
    new RequestOptions {
        Timeout: TimeSpan.FromSeconds(3) // Override timeout to 3s
    }
);
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
