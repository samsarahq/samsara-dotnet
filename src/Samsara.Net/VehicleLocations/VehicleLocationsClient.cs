using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.VehicleLocations;

public partial class VehicleLocationsClient
{
    private RawClient _client;

    internal VehicleLocationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// ***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestats) instead.***
    ///
    /// Returns the last known location of all vehicles at the given `time`. If no `time` is specified, the current time is used. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: &lt;a href="/docs/vehicle-locations-1" target="_blank"&gt;Vehicle Locations&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.ListAsync(new VehicleLocationsListRequest());
    /// </code></example>
    public async Task<VehicleLocationsResponse> ListAsync(
        VehicleLocationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        _query["vehicleIds"] = request.VehicleIds;
        if (request.After != null)
        {
            _query["after"] = request.After;
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
                    Path = "fleet/vehicles/locations",
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
                return JsonUtils.Deserialize<VehicleLocationsResponse>(responseBody)!;
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
    /// Related guide: &lt;a href="/docs/vehicle-locations-1" target="_blank"&gt;Vehicle Locations&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.GetFeedAsync(new VehicleLocationsGetFeedRequest());
    /// </code></example>
    public async Task<VehicleLocationsListResponse> GetFeedAsync(
        VehicleLocationsGetFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        _query["vehicleIds"] = request.VehicleIds;
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/vehicles/locations/feed",
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
                return JsonUtils.Deserialize<VehicleLocationsListResponse>(responseBody)!;
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
    /// ***NOTE: The Vehicle Locations API is an older API that does not combine GPS data with onboard diagnostics. Try our new [Vehicle Stats API](ref:getvehiclestatshistory) instead.***
    ///
    /// Returns all known vehicle locations during the given time range. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: &lt;a href="/docs/vehicle-locations-1" target="_blank"&gt;Vehicle Locations&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicle category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.VehicleLocations.GetHistoryAsync(
    ///     new VehicleLocationsGetHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public async Task<VehicleLocationsListResponse> GetHistoryAsync(
        VehicleLocationsGetHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startTime"] = request.StartTime;
        _query["endTime"] = request.EndTime;
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        _query["vehicleIds"] = request.VehicleIds;
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/vehicles/locations/history",
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
                return JsonUtils.Deserialize<VehicleLocationsListResponse>(responseBody)!;
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
}
