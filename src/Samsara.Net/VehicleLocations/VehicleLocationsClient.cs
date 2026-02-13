using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleLocations;

public partial class VehicleLocationsClient : IVehicleLocationsClient
{
    private RawClient _client;

    internal VehicleLocationsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<VehicleLocationsResponse>> GetVehicleLocationsAsyncCore(
        GetVehicleLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("after", request.After)
            .Add("time", request.Time)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("tagIds", request.TagIds)
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
                    Path = "fleet/vehicles/locations",
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
                var responseData = JsonUtils.Deserialize<VehicleLocationsResponse>(responseBody)!;
                return new WithRawResponse<VehicleLocationsResponse>()
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
        WithRawResponse<VehicleLocationsListResponse>
    > GetVehicleLocationsFeedAsyncCore(
        GetVehicleLocationsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("after", request.After)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("tagIds", request.TagIds)
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
                    Path = "fleet/vehicles/locations/feed",
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
                var responseData = JsonUtils.Deserialize<VehicleLocationsListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<VehicleLocationsListResponse>()
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
        WithRawResponse<VehicleLocationsListResponse>
    > GetVehicleLocationsHistoryAsyncCore(
        GetVehicleLocationsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("after", request.After)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("tagIds", request.TagIds)
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
                    Path = "fleet/vehicles/locations/history",
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
                var responseData = JsonUtils.Deserialize<VehicleLocationsListResponse>(
                    responseBody
                )!;
                return new WithRawResponse<VehicleLocationsListResponse>()
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
    /// ***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestats) instead.***
    ///
    /// Returns the last known location of all vehicles at the given `time`. If no `time` is specified, the current time is used. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: [Vehicle Locations](/docs/vehicle-locations-1).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.GetVehicleLocationsAsync(new GetVehicleLocationsRequest());
    /// </code></example>
    public WithRawResponseTask<VehicleLocationsResponse> GetVehicleLocationsAsync(
        GetVehicleLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<VehicleLocationsResponse>(
            GetVehicleLocationsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// ***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatsfeed) instead.***
    ///
    /// Follow a continuous feed of all vehicle locations from Samsara Vehicle Gateways.
    ///
    /// Your first call to this endpoint will provide you with the most recent location for each vehicle and a `pagination` object that contains an `endCursor`.
    ///
    /// You can provide the `endCursor` to the `after` parameter of this endpoint to get location updates since that `endCursor`.
    ///
    /// If `hasNextPage` is `false`, no updates are readily available yet. We'd suggest waiting a minimum of 5 seconds before requesting updates.
    ///
    /// Related guide: [Vehicle Locations](/docs/vehicle-locations-1).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.GetVehicleLocationsFeedAsync(new GetVehicleLocationsFeedRequest());
    /// </code></example>
    public WithRawResponseTask<VehicleLocationsListResponse> GetVehicleLocationsFeedAsync(
        GetVehicleLocationsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<VehicleLocationsListResponse>(
            GetVehicleLocationsFeedAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// ***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatshistory) instead.***
    ///
    /// Returns all known vehicle locations during the given time range. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: [Vehicle Locations](/docs/vehicle-locations-1).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.GetVehicleLocationsHistoryAsync(
    ///     new GetVehicleLocationsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<VehicleLocationsListResponse> GetVehicleLocationsHistoryAsync(
        GetVehicleLocationsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<VehicleLocationsListResponse>(
            GetVehicleLocationsHistoryAsyncCore(request, options, cancellationToken)
        );
    }
}
