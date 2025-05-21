using System.Net.Http;
using System.Text.Json;
using System.Threading;
using global::System.Threading.Tasks;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Fleet;

public partial class FleetClient
{
    private RawClient _client;

    internal FleetClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all driver and associated vehicle efficiency data.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 50 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.GetDriverEfficiencyAsync(new FleetGetDriverEfficiencyRequest());
    /// </code></example>
    public async Task<DriverEfficienciesResponse> GetDriverEfficiencyAsync(
        FleetGetDriverEfficiencyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["driverIds"] = request.DriverIds;
        _query["driverTagIds"] = request.DriverTagIds;
        _query["driverParentTagIds"] = request.DriverParentTagIds;
        if (request.DriverActivationStatus != null)
        {
            _query["driverActivationStatus"] = request.DriverActivationStatus.Value.Stringify();
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime.Value.ToString(Constants.DateTimeFormat);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "beta/fleet/drivers/efficiency",
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
                return JsonUtils.Deserialize<DriverEfficienciesResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
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
    /// Update an equipment.  **Note** this implementation of patch uses [the JSON merge patch](https://tools.ietf.org/html/rfc7396) proposed standard.
    ///  This means that any fields included in the patch request will _overwrite_ fields which exist on the target resource.
    ///  For arrays, this means any array included in the request will _replace_ the array that exists at the specified path, it will not _add_ to the existing array
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Equipment** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.UpdateEquipmentAsync("id", new EquipmentPatchEquipmentRequestBody());
    /// </code></example>
    public async Task<EquipmentPatchEquipmentResponseBody> UpdateEquipmentAsync(
        string id,
        EquipmentPatchEquipmentRequestBody request,
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
                        "beta/fleet/equipment/{0}",
                        ValueConvert.ToPathParameterString(id)
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
                return JsonUtils.Deserialize<EquipmentPatchEquipmentResponseBody>(responseBody)!;
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
    /// Get all HOS ELD events in a time range, grouped by driver. Attributes will be populated depending on which ELD Event Type is being returned.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read ELD Compliance Settings (US)** under the Compliance category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.GetHosEldEventsAsync(
    ///     new FleetGetHosEldEventsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public async Task<HosEldEventsGetHosEldEventsResponseBody> GetHosEldEventsAsync(
        FleetGetHosEldEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startTime"] = request.StartTime;
        _query["endTime"] = request.EndTime;
        _query["driverIds"] = request.DriverIds;
        if (request.TagIds != null)
        {
            _query["tagIds"] = request.TagIds;
        }
        if (request.ParentTagIds != null)
        {
            _query["parentTagIds"] = request.ParentTagIds;
        }
        if (request.DriverActivationStatus != null)
        {
            _query["driverActivationStatus"] = request.DriverActivationStatus.Value.Stringify();
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
                    Path = "beta/fleet/hos/drivers/eld-events",
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
                return JsonUtils.Deserialize<HosEldEventsGetHosEldEventsResponseBody>(
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
    /// Returns the last known stats of all trailers at the given `time`. If no `time` is specified, the current time is used.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.GetTrailerStatsSnapshotAsync(
    ///     new FleetGetTrailerStatsSnapshotRequest { Types = "types" }
    /// );
    /// </code></example>
    public async Task<TrailerStatsGetTrailerStatsSnapshotResponseBody> GetTrailerStatsSnapshotAsync(
        FleetGetTrailerStatsSnapshotRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["types"] = request.Types;
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
        if (request.TrailerIds != null)
        {
            _query["trailerIds"] = request.TrailerIds;
        }
        if (request.Time != null)
        {
            _query["time"] = request.Time;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "beta/fleet/trailers/stats",
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
                return JsonUtils.Deserialize<TrailerStatsGetTrailerStatsSnapshotResponseBody>(
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
    /// Follow a feed of trailer stats.
    ///
    /// The first call to this endpoint will provide the most recent stats for each trailer and an `endCursor`.
    ///
    /// Providing the `endCursor` value to the `after` query parameter will fetch all updates since the previous API call.
    ///
    /// If `hasNextPage` is false, no new data is immediately available. Please wait a minimum of 5 seconds before making a subsequent request.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.GetTrailerStatsFeedAsync(
    ///     new FleetGetTrailerStatsFeedRequest { Types = "types" }
    /// );
    /// </code></example>
    public async Task<TrailerStatsGetTrailerStatsFeedResponseBody> GetTrailerStatsFeedAsync(
        FleetGetTrailerStatsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["types"] = request.Types;
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
        if (request.TrailerIds != null)
        {
            _query["trailerIds"] = request.TrailerIds;
        }
        if (request.Decorations != null)
        {
            _query["decorations"] = request.Decorations;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "beta/fleet/trailers/stats/feed",
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
                return JsonUtils.Deserialize<TrailerStatsGetTrailerStatsFeedResponseBody>(
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
    /// Returns trailer stats during the given time range for all trailers. This can be optionally filtered by tags or specific trailer IDs.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Trailer Statistics** under the Trailers category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.GetTrailerStatsHistoryAsync(
    ///     new FleetGetTrailerStatsHistoryRequest
    ///     {
    ///         StartTime = "startTime",
    ///         EndTime = "endTime",
    ///         Types = "types",
    ///     }
    /// );
    /// </code></example>
    public async Task<TrailerStatsGetTrailerStatsHistoryResponseBody> GetTrailerStatsHistoryAsync(
        FleetGetTrailerStatsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startTime"] = request.StartTime;
        _query["endTime"] = request.EndTime;
        _query["types"] = request.Types;
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
        if (request.TrailerIds != null)
        {
            _query["trailerIds"] = request.TrailerIds;
        }
        if (request.Decorations != null)
        {
            _query["decorations"] = request.Decorations;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "beta/fleet/trailers/stats/history",
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
                return JsonUtils.Deserialize<TrailerStatsGetTrailerStatsHistoryResponseBody>(
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
    /// Update the engine immobilizer state of a vehicle. This requires an engine immobilizer to be installed on the vehicle gateway.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Vehicle Immobilization** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Beta.Fleet.UpdateEngineImmobilizerStateAsync(
    ///     1000000,
    ///     new EngineImmobilizerUpdateEngineImmobilizerStateRequestBody
    ///     {
    ///         RelayStates = new List&lt;UpdateEngineImmobilizerRelayStateRequestBodyRequestBody&gt;()
    ///         {
    ///             new UpdateEngineImmobilizerRelayStateRequestBodyRequestBody
    ///             {
    ///                 Id = UpdateEngineImmobilizerRelayStateRequestBodyRequestBodyId.Relay1,
    ///                 IsOpen = false,
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task UpdateEngineImmobilizerStateAsync(
        long id,
        EngineImmobilizerUpdateEngineImmobilizerStateRequestBody request,
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
                        "beta/fleet/vehicles/{0}/immobilizer",
                        ValueConvert.ToPathParameterString(id)
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
