using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

public partial class FuelAndEnergyClient : IFuelAndEnergyClient
{
    private RawClient _client;

    internal FuelAndEnergyClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody>
    > GetDriverEfficiencyByDriversAsyncCore(
        GetDriverEfficiencyByDriversRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("driverIds", request.DriverIds)
            .Add("dataFormats", request.DataFormats)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "driver-efficiency/drivers",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
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

    private async Task<
        WithRawResponse<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody>
    > GetDriverEfficiencyByVehiclesAsyncCore(
        GetDriverEfficiencyByVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("vehicleIds", request.VehicleIds)
            .Add("dataFormats", request.DataFormats)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "driver-efficiency/vehicles",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
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

    private async Task<
        WithRawResponse<FuelEnergyGetFuelEnergyDriverReportsResponseBody>
    > GetFuelEnergyDriverReportsAsyncCore(
        GetFuelEnergyDriverReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("startDate", request.StartDate)
            .Add("endDate", request.EndDate)
            .Add("driverIds", request.DriverIds)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/reports/drivers/fuel-energy",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<FuelEnergyGetFuelEnergyDriverReportsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<FuelEnergyGetFuelEnergyDriverReportsResponseBody>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
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

    private async Task<
        WithRawResponse<FuelEnergyGetFuelEnergyVehicleReportsResponseBody>
    > GetFuelEnergyVehicleReportsAsyncCore(
        GetFuelEnergyVehicleReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("startDate", request.StartDate)
            .Add("endDate", request.EndDate)
            .Add("vehicleIds", request.VehicleIds)
            .Add("energyType", request.EnergyType)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/reports/vehicles/fuel-energy",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<FuelEnergyGetFuelEnergyVehicleReportsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<FuelEnergyGetFuelEnergyVehicleReportsResponseBody>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
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

    private async Task<
        WithRawResponse<FuelPurchasePostFuelPurchaseResponseBody>
    > PostFuelPurchaseAsyncCore(
        FuelPurchasePostFuelPurchaseRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "fuel-purchase",
                    Body = request,
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<FuelPurchasePostFuelPurchaseResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<FuelPurchasePostFuelPurchaseResponseBody>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
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
    /// This endpoint will return driver efficiency data that has been collected for your organization and grouped by drivers based on the time parameters passed in. Results are paginated.
    ///
    /// **Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](/api-reference/future/beta-apis/get-driver-efficiency) endpoint has now been moved to Legacy.
    ///
    ///  <b>Rate limit:</b> 10 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.FuelAndEnergy.GetDriverEfficiencyByDriversAsync(
    ///     new GetDriverEfficiencyByDriversRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody> GetDriverEfficiencyByDriversAsync(
        GetDriverEfficiencyByDriversRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody>(
            GetDriverEfficiencyByDriversAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// This endpoint will return driver efficiency data that has been collected for your organization and grouped by vehicle drivers used based on the time parameters passed in. Results are paginated.
    ///
    /// **Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](/api-reference/future/beta-apis/get-driver-efficiency) endpoint has now been moved to Legacy.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.FuelAndEnergy.GetDriverEfficiencyByVehiclesAsync(
    ///     new GetDriverEfficiencyByVehiclesRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody> GetDriverEfficiencyByVehiclesAsync(
        GetDriverEfficiencyByVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody>(
            GetDriverEfficiencyByVehiclesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get fuel and energy efficiency driver reports for the requested time range.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.FuelAndEnergy.GetFuelEnergyDriverReportsAsync(
    ///     new GetFuelEnergyDriverReportsRequest { StartDate = "startDate", EndDate = "endDate" }
    /// );
    /// </code></example>
    public WithRawResponseTask<FuelEnergyGetFuelEnergyDriverReportsResponseBody> GetFuelEnergyDriverReportsAsync(
        GetFuelEnergyDriverReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<FuelEnergyGetFuelEnergyDriverReportsResponseBody>(
            GetFuelEnergyDriverReportsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get fuel and energy efficiency vehicle reports for the requested time range.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.FuelAndEnergy.GetFuelEnergyVehicleReportsAsync(
    ///     new GetFuelEnergyVehicleReportsRequest { StartDate = "startDate", EndDate = "endDate" }
    /// );
    /// </code></example>
    public WithRawResponseTask<FuelEnergyGetFuelEnergyVehicleReportsResponseBody> GetFuelEnergyVehicleReportsAsync(
        GetFuelEnergyVehicleReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<FuelEnergyGetFuelEnergyVehicleReportsResponseBody>(
            GetFuelEnergyVehicleReportsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create a fuel purchase transaction.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Write Fuel Purchase** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
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
    /// </code></example>
    public WithRawResponseTask<FuelPurchasePostFuelPurchaseResponseBody> PostFuelPurchaseAsync(
        FuelPurchasePostFuelPurchaseRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<FuelPurchasePostFuelPurchaseResponseBody>(
            PostFuelPurchaseAsyncCore(request, options, cancellationToken)
        );
    }
}
