using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Hubs;

public partial class HubsClient : IHubsClient
{
    private RawClient _client;

    internal HubsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<HubCapacitiesListHubCapacitiesResponseBody>
    > ListHubCapacitiesAsyncCore(
        ListHubCapacitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["hubId"] = request.HubId;
        if (request.CapacityIds != null)
        {
            _query["capacityIds"] = request.CapacityIds;
        }
        if (request.CapacityNames != null)
        {
            _query["capacityNames"] = request.CapacityNames;
        }
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hub/capacities",
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
                var responseData =
                    JsonUtils.Deserialize<HubCapacitiesListHubCapacitiesResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<HubCapacitiesListHubCapacitiesResponseBody>()
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
        WithRawResponse<HubLocationsUpdateHubLocationResponseBody>
    > UpdateHubLocationAsyncCore(
        HubLocationsUpdateHubLocationRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "hub/location/{0}",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
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
                var responseData = JsonUtils.Deserialize<HubLocationsUpdateHubLocationResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<HubLocationsUpdateHubLocationResponseBody>()
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
        WithRawResponse<HubLocationsListHubLocationsResponseBody>
    > ListHubLocationsAsyncCore(
        ListHubLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["hubId"] = request.HubId;
        if (request.LocationIds != null)
        {
            _query["locationIds"] = request.LocationIds;
        }
        if (request.CustomerLocationIds != null)
        {
            _query["customerLocationIds"] = request.CustomerLocationIds;
        }
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hub/locations",
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
                var responseData = JsonUtils.Deserialize<HubLocationsListHubLocationsResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<HubLocationsListHubLocationsResponseBody>()
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
        WithRawResponse<HubLocationsCreateHubLocationsResponseBody>
    > CreateHubLocationsAsyncCore(
        HubLocationsCreateHubLocationsRequestBody request,
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
                    Path = "hub/locations",
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
                var responseData =
                    JsonUtils.Deserialize<HubLocationsCreateHubLocationsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<HubLocationsCreateHubLocationsResponseBody>()
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

    private async Task<WithRawResponse<HubSkillsListHubSkillsResponseBody>> ListHubSkillsAsyncCore(
        ListHubSkillsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["hubId"] = request.HubId;
        if (request.SkillIds != null)
        {
            _query["skillIds"] = request.SkillIds;
        }
        if (request.SkillNames != null)
        {
            _query["skillNames"] = request.SkillNames;
        }
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hub/skills",
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
                var responseData = JsonUtils.Deserialize<HubSkillsListHubSkillsResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<HubSkillsListHubSkillsResponseBody>()
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

    private async Task<WithRawResponse<HubsListHubsResponseBody>> ListHubsAsyncCore(
        ListHubsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.HubIds != null)
        {
            _query["hubIds"] = request.HubIds;
        }
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hubs",
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
                var responseData = JsonUtils.Deserialize<HubsListHubsResponseBody>(responseBody)!;
                return new WithRawResponse<HubsListHubsResponseBody>()
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
    /// Retrieve capacity types for a specific hub.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.ListHubCapacitiesAsync(new ListHubCapacitiesRequest { HubId = "hubId" });
    /// </code></example>
    public WithRawResponseTask<HubCapacitiesListHubCapacitiesResponseBody> ListHubCapacitiesAsync(
        ListHubCapacitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubCapacitiesListHubCapacitiesResponseBody>(
            ListHubCapacitiesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update existing location by ID.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.UpdateHubLocationAsync(
    ///     new HubLocationsUpdateHubLocationRequestBody
    ///     {
    ///         Id = "id",
    ///         Data = new UpdateHubLocationRequestBodyRequestBody
    ///         {
    ///             Address = "123 Industrial Blvd, Los Angeles, CA 90210, US",
    ///             CustomerLocationId = "LOC-123",
    ///             DriverInstructions = "sample instructions",
    ///             IsDepot = false,
    ///             Latitude = 34.0522,
    ///             Longitude = -118.2437,
    ///             Name = "Customer ABC Warehouse",
    ///             PlannerNotes = "sample note",
    ///             ServiceTimeSeconds = 1800,
    ///             ServiceWindows = new List&lt;HubLocationServiceWindowInputRequestBody&gt;()
    ///             {
    ///                 new HubLocationServiceWindowInputRequestBody
    ///                 {
    ///                     DaysOfWeek = new List&lt;string&gt;()
    ///                     {
    ///                         "monday",
    ///                         "tuesday",
    ///                         "wednesday",
    ///                         "thursday",
    ///                         "friday",
    ///                     },
    ///                     EndTime = "17:00:00",
    ///                     StartTime = "08:00:00",
    ///                 },
    ///             },
    ///             SkillsRequired = new List&lt;string&gt;() { "650e8400-e29b-41d4-a716-446655440001" },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<HubLocationsUpdateHubLocationResponseBody> UpdateHubLocationAsync(
        HubLocationsUpdateHubLocationRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubLocationsUpdateHubLocationResponseBody>(
            UpdateHubLocationAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve locations for a specific hub.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.ListHubLocationsAsync(new ListHubLocationsRequest { HubId = "hubId" });
    /// </code></example>
    public WithRawResponseTask<HubLocationsListHubLocationsResponseBody> ListHubLocationsAsync(
        ListHubLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubLocationsListHubLocationsResponseBody>(
            ListHubLocationsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create new locations.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.CreateHubLocationsAsync(
    ///     new HubLocationsCreateHubLocationsRequestBody
    ///     {
    ///         Data = new List&lt;HubLocationInputObjectRequestBody&gt;()
    ///         {
    ///             new HubLocationInputObjectRequestBody
    ///             {
    ///                 Address = "123 Industrial Blvd, Los Angeles, CA 90210, US",
    ///                 CustomerLocationId = "LOC-123",
    ///                 DriverInstructions = "sample instructions",
    ///                 HubId = "550e8400-e29b-41d4-a716-446655440000",
    ///                 IsDepot = false,
    ///                 Latitude = 34.0522,
    ///                 Longitude = -118.2437,
    ///                 Name = "Customer ABC Warehouse",
    ///                 PlannerNotes = "sample note",
    ///                 ServiceTimeSeconds = 1800,
    ///                 ServiceWindows = new List&lt;HubLocationServiceWindowInputRequestBody&gt;()
    ///                 {
    ///                     new HubLocationServiceWindowInputRequestBody
    ///                     {
    ///                         DaysOfWeek = new List&lt;string&gt;()
    ///                         {
    ///                             "monday",
    ///                             "tuesday",
    ///                             "wednesday",
    ///                             "thursday",
    ///                             "friday",
    ///                         },
    ///                         EndTime = "17:00:00",
    ///                         StartTime = "08:00:00",
    ///                     },
    ///                 },
    ///                 SkillsRequired = new List&lt;string&gt;() { "650e8400-e29b-41d4-a716-446655440001" },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<HubLocationsCreateHubLocationsResponseBody> CreateHubLocationsAsync(
        HubLocationsCreateHubLocationsRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubLocationsCreateHubLocationsResponseBody>(
            CreateHubLocationsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve skills for a specific hub.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.ListHubSkillsAsync(new ListHubSkillsRequest { HubId = "hubId" });
    /// </code></example>
    public WithRawResponseTask<HubSkillsListHubSkillsResponseBody> ListHubSkillsAsync(
        ListHubSkillsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubSkillsListHubSkillsResponseBody>(
            ListHubSkillsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve all hubs (planners) in the organization. This endpoint supports pagination and filtering based on hub IDs and update times.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Hubs.ListHubsAsync(new ListHubsRequest());
    /// </code></example>
    public WithRawResponseTask<HubsListHubsResponseBody> ListHubsAsync(
        ListHubsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HubsListHubsResponseBody>(
            ListHubsAsyncCore(request, options, cancellationToken)
        );
    }
}
