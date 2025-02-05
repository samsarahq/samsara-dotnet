using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

public partial class FuelAndEnergyClient
{
    private RawClient _client;

    internal FuelAndEnergyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get fuel and energy efficiency driver reports for the requested time range.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.FuelAndEnergy.GetFuelEnergyDriverReportsAsync(
    ///     new FuelAndEnergyGetFuelEnergyDriverReportsRequest
    ///     {
    ///         StartDate = "startDate",
    ///         EndDate = "endDate",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<FuelEnergyGetFuelEnergyDriverReportsResponseBody> GetFuelEnergyDriverReportsAsync(
        FuelAndEnergyGetFuelEnergyDriverReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startDate"] = request.StartDate;
        _query["endDate"] = request.EndDate;
        _query["driverIds"] = request.DriverIds;
        if (request.TagIds != null)
        {
            _query["tagIds"] = request.TagIds;
        }
        if (request.ParentTagIds != null)
        {
            _query["parentTagIds"] = request.ParentTagIds;
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "fleet/reports/drivers/fuel-energy",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FuelEnergyGetFuelEnergyDriverReportsResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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

    /// <summary>
    /// Get fuel and energy efficiency vehicle reports for the requested time range.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.FuelAndEnergy.GetFuelEnergyVehicleReportsAsync(
    ///     new FuelAndEnergyGetFuelEnergyVehicleReportsRequest
    ///     {
    ///         StartDate = "startDate",
    ///         EndDate = "endDate",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<FuelEnergyGetFuelEnergyVehicleReportsResponseBody> GetFuelEnergyVehicleReportsAsync(
        FuelAndEnergyGetFuelEnergyVehicleReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startDate"] = request.StartDate;
        _query["endDate"] = request.EndDate;
        if (request.VehicleIds != null)
        {
            _query["vehicleIds"] = request.VehicleIds;
        }
        if (request.EnergyType != null)
        {
            _query["energyType"] = request.EnergyType.Value.Stringify();
        }
        if (request.TagIds != null)
        {
            _query["tagIds"] = request.TagIds;
        }
        if (request.ParentTagIds != null)
        {
            _query["parentTagIds"] = request.ParentTagIds;
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "fleet/reports/vehicles/fuel-energy",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FuelEnergyGetFuelEnergyVehicleReportsResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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

    /// <summary>
    /// Create a fuel purchase transaction.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Fuel Purchase** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.FuelAndEnergy.PostFuelPurchaseAsync(
    ///     new FuelPurchasePostFuelPurchaseRequestBody
    ///     {
    ///         FuelQuantityLiters = "676.8",
    ///         TransactionLocation = "350 Rhode Island St, San Francisco, CA 94103",
    ///         TransactionPrice = new PostFuelPurchaseRequestBodyPriceRequestBody
    ///         {
    ///             Amount = "640.2",
    ///             Currency = PostFuelPurchaseRequestBodyPriceRequestBodyCurrency.Usd,
    ///         },
    ///         TransactionReference = "5454534",
    ///         TransactionTime = "2022-07-13T14:20:50.52-07:00",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<FuelPurchasePostFuelPurchaseResponseBody> PostFuelPurchaseAsync(
        FuelPurchasePostFuelPurchaseRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Post,
                    Path = "fuel-purchase",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FuelPurchasePostFuelPurchaseResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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
