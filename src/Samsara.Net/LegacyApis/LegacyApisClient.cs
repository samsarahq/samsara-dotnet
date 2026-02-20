using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.LegacyApis;

public partial class LegacyApisClient : ILegacyApisClient
{
    private RawClient _client;

    internal LegacyApisClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<DefectsResponse>> GetDvirDefectsAsyncCore(
        GetDvirDefectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("limit", request.Limit)
            .Add("after", request.After)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("isResolved", request.IsResolved)
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
                    Path = "fleet/defects/history",
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
                var responseData = JsonUtils.Deserialize<DefectsResponse>(responseBody)!;
                return new WithRawResponse<DefectsResponse>()
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
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody>
    > GetDriversVehicleAssignmentsAsyncCore(
        GetDriversVehicleAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("driverIds", request.DriverIds)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("driverActivationStatus", request.DriverActivationStatus)
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
                    Path = "fleet/drivers/vehicle-assignments",
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
                    JsonUtils.Deserialize<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody>()
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

    private async Task<WithRawResponse<DvirsListResponse>> GetDvirHistoryAsyncCore(
        GetDvirHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("limit", request.Limit)
            .Add("after", request.After)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("tagIds", request.TagIds)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
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
                    Path = "fleet/dvirs/history",
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
                var responseData = JsonUtils.Deserialize<DvirsListResponse>(responseBody)!;
                return new WithRawResponse<DvirsListResponse>()
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
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<IdlingReportsGetVehicleIdlingReportsResponseBody>
    > GetVehicleIdlingReportsAsyncCore(
        GetVehicleIdlingReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 9)
            .Add("after", request.After)
            .Add("limit", request.Limit)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("vehicleIds", request.VehicleIds)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("isPtoActive", request.IsPtoActive)
            .Add("minIdlingDurationMinutes", request.MinIdlingDurationMinutes)
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
                    Path = "fleet/reports/vehicle/idling",
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
                    JsonUtils.Deserialize<IdlingReportsGetVehicleIdlingReportsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<IdlingReportsGetVehicleIdlingReportsResponseBody>()
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

    private async Task<WithRawResponse<SafetyEventsListResponse>> GetSafetyEventsAsyncCore(
        GetSafetyEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("after", request.After)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("vehicleIds", request.VehicleIds)
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
                    Path = "fleet/safety-events",
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
                var responseData = JsonUtils.Deserialize<SafetyEventsListResponse>(responseBody)!;
                return new WithRawResponse<SafetyEventsListResponse>()
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
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<SafetyEventsGetSafetyActivityEventFeedResponseBody>
    > GetSafetyActivityEventFeedAsyncCore(
        GetSafetyActivityEventFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("after", request.After)
            .Add("startTime", request.StartTime)
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
                    Path = "fleet/safety-events/audit-logs/feed",
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
                    JsonUtils.Deserialize<SafetyEventsGetSafetyActivityEventFeedResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<SafetyEventsGetSafetyActivityEventFeedResponseBody>()
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
        WithRawResponse<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody>
    > GetVehiclesDriverAssignmentsAsyncCore(
        GetVehiclesDriverAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("vehicleIds", request.VehicleIds)
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
                    Path = "fleet/vehicles/driver-assignments",
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
                    JsonUtils.Deserialize<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody>()
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

    private async Task<WithRawResponse<InlineResponse2001>> V1GetAllAssetsAsyncCore(
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
                    Method = HttpMethod.Get,
                    Path = "v1/fleet/assets",
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
                var responseData = JsonUtils.Deserialize<InlineResponse2001>(responseBody)!;
                return new WithRawResponse<InlineResponse2001>()
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
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<V1VehicleHarshEventResponse>
    > V1GetVehicleHarshEventAsyncCore(
        long vehicleId,
        V1GetVehicleHarshEventRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("timestamp", request.Timestamp)
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
                    Path = string.Format(
                        "v1/fleet/vehicles/{0}/safety/harsh_event",
                        ValueConvert.ToPathParameterString(vehicleId)
                    ),
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
                var responseData = JsonUtils.Deserialize<V1VehicleHarshEventResponse>(
                    responseBody
                )!;
                return new WithRawResponse<V1VehicleHarshEventResponse>()
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
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Stream DVIR defects](/api-reference/maintenance/maintenance/stream-defects) instead. The endpoint will continue to function as documented.**
    ///
    /// Returns a list of DVIR defects in an organization, filtered by creation time. The maximum time period you can query for is 30 days.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetDvirDefectsAsync(
    ///     new GetDvirDefectsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DefectsResponse> GetDvirDefectsAsync(
        GetDvirDefectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DefectsResponse>(
            GetDvirDefectsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get all driver-vehicle assignments](/api-reference/drivers/driver-vehicle-assignments/get-driver-vehicle-assignments) instead. The endpoint will continue to function as documented.** Get all vehicle assignments for the requested drivers in the requested time range. The only type of assignment supported right now are assignments created through the driver app.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetDriversVehicleAssignmentsAsync(
    ///     new GetDriversVehicleAssignmentsRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody> GetDriversVehicleAssignmentsAsync(
        GetDriversVehicleAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody>(
            GetDriversVehicleAssignmentsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Stream DVIRs](/api-reference/maintenance/maintenance/get-dvirs) instead. The endpoint will continue to function as documented.**
    ///
    ///  Returns a list of all DVIRs in an organization.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetDvirHistoryAsync(
    ///     new GetDvirHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DvirsListResponse> GetDvirHistoryAsync(
        GetDvirHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DvirsListResponse>(
            GetDvirHistoryAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get idling events](/api-reference/fuel-and-efficiency/idling/get-idling-events) instead. The endpoint will continue to function as documented.** Get all vehicle idling reports for the requested time duration.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetVehicleIdlingReportsAsync(
    ///     new GetVehicleIdlingReportsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<IdlingReportsGetVehicleIdlingReportsResponseBody> GetVehicleIdlingReportsAsync(
        GetVehicleIdlingReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IdlingReportsGetVehicleIdlingReportsResponseBody>(
            GetVehicleIdlingReportsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get Safety Events Stream](/api-reference/safety/safety/get-safety-events-v-2-stream) instead. The endpoint will continue to function as documented.**
    ///
    ///  Fetch safety events for the organization in a given time period.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetSafetyEventsAsync(
    ///     new GetSafetyEventsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<SafetyEventsListResponse> GetSafetyEventsAsync(
        GetSafetyEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SafetyEventsListResponse>(
            GetSafetyEventsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get Safety Events Stream](/api-reference/safety/safety/get-safety-events-v-2-stream) instead. The endpoint will continue to function as documented.**
    ///
    /// Get continuous safety events. The safety activity event feed offers a change-log for safety events. Use this endpoint to subscribe to safety event changes. See documentation below for all supported change-log types.
    ///
    /// | ActivityType      | Description |
    /// | ----------- | ----------- |
    /// | CreateSafetyEventActivityType | a new safety event is processed by Samsara      |
    /// | BehaviorLabelActivityType     | a label is added or removed from a safety event |
    /// | CoachingStateActivityType     | a safety event coaching state is updated        |
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetSafetyActivityEventFeedAsync(new GetSafetyActivityEventFeedRequest());
    /// </code></example>
    public WithRawResponseTask<SafetyEventsGetSafetyActivityEventFeedResponseBody> GetSafetyActivityEventFeedAsync(
        GetSafetyActivityEventFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SafetyEventsGetSafetyActivityEventFeedResponseBody>(
            GetSafetyActivityEventFeedAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get all driver-vehicle assignments](/api-reference/drivers/driver-vehicle-assignments/get-driver-vehicle-assignments) instead. The endpoint will continue to function as documented.** Get all driver assignments for the requested vehicles in the requested time range. The only type of assignment supported right now are assignments created through the driver app.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.GetVehiclesDriverAssignmentsAsync(
    ///     new GetVehiclesDriverAssignmentsRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody> GetVehiclesDriverAssignmentsAsync(
        GetVehiclesDriverAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody>(
            GetVehiclesDriverAssignmentsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [List all assets](/api-reference/assets-vehicles-trailers-equipment/assets/list) instead. The endpoint will continue to function as documented.**
    ///
    ///  Fetch all powered and unpowered equipment.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.V1GetAllAssetsAsync();
    /// </code></example>
    public WithRawResponseTask<InlineResponse2001> V1GetAllAssetsAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InlineResponse2001>(
            V1GetAllAssetsAsyncCore(options, cancellationToken)
        );
    }

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [Get Safety Events](/api-reference/safety/safety/get-safety-events-v-2) instead. The endpoint will continue to function as documented.** &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch harsh event details for a vehicle.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.LegacyApis.V1GetVehicleHarshEventAsync(
    ///     1000000,
    ///     new V1GetVehicleHarshEventRequest { Timestamp = 1000000 }
    /// );
    /// </code></example>
    public WithRawResponseTask<V1VehicleHarshEventResponse> V1GetVehicleHarshEventAsync(
        long vehicleId,
        V1GetVehicleHarshEventRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<V1VehicleHarshEventResponse>(
            V1GetVehicleHarshEventAsyncCore(vehicleId, request, options, cancellationToken)
        );
    }
}
