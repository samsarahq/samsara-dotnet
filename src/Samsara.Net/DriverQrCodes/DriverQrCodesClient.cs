using System.Net.Http;
using System.Text.Json;
using System.Threading;
using global::System.Threading.Tasks;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.DriverQrCodes;

public partial class DriverQrCodesClient
{
    private RawClient _client;

    internal DriverQrCodesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get details for requested driver(s) QR code, used for driver trip assignment.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.DriverQrCodes.GetAsync(new DriverQrCodesGetRequest());
    /// </code></example>
    public async Task<DriverQrCodesGetDriversQrCodesResponseBody> GetAsync(
        DriverQrCodesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["driverIds"] = request.DriverIds;
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "drivers/qr-codes",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<DriverQrCodesGetDriversQrCodesResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                switch (response.StatusCode)
                {
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 405:
                        throw new MethodNotAllowedError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                    case 501:
                        throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Assign a new QR code for the requested driver. Return error if an active QR code already exists.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.DriverQrCodes.CreateAsync(
    ///     new DriverQrCodesCreateDriverQrCodeRequestBody { DriverId = 494123 }
    /// );
    /// </code></example>
    public async Task<DriverQrCodesCreateDriverQrCodeResponseBody> CreateAsync(
        DriverQrCodesCreateDriverQrCodeRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "drivers/qr-codes",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<DriverQrCodesCreateDriverQrCodeResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                switch (response.StatusCode)
                {
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 405:
                        throw new MethodNotAllowedError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                    case 501:
                        throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Revoke requested driver's currently active QR code.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.DriverQrCodes.DeleteAsync(
    ///     new DriverQrCodesDeleteDriverQrCodeRequestBody { DriverId = 494123 }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        DriverQrCodesDeleteDriverQrCodeRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = "drivers/qr-codes",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                switch (response.StatusCode)
                {
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 405:
                        throw new MethodNotAllowedError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                    case 501:
                        throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
