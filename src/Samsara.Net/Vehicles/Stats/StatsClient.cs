using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles.Stats;

public partial class StatsClient
{
    private RawClient _client;

    internal StatsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the last known stats of all vehicles at the given `time`. If no `time` is specified, the current time is used.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    private async Task<VehicleStatsResponse> ListInternalAsync(
        StatsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        _query["vehicleIds"] = request.VehicleIds;
        _query["types"] = request.Types.Select(_value => _value.Stringify()).ToList();
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
                    Path = "fleet/vehicles/stats",
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
                return JsonUtils.Deserialize<VehicleStatsResponse>(responseBody)!;
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
    /// Follow a feed of vehicle stats.
    ///
    /// Your first call to this endpoint will provide you with the most recent stats for each vehicle and an `endCursor`.
    ///
    /// You can the provide the `endCursor` value to the `after` query parameter to get all updates since the last call you made.
    ///
    /// If `hasNextPage` is `false`, no new data is immediately available. You should wait a minimum of 5 seconds making a subsequent request.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    private async Task<VehicleStatsListResponse> FeedInternalAsync(
        StatsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        _query["vehicleIds"] = request.VehicleIds;
        _query["types"] = request.Types.Select(_value => _value.Stringify()).ToList();
        _query["decorations"] = request.Decorations.Select(_value => _value.Stringify()).ToList();
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
                    Path = "fleet/vehicles/stats/feed",
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
                return JsonUtils.Deserialize<VehicleStatsListResponse>(responseBody)!;
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
    /// Returns vehicle stats during the given time range for all vehicles. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    private async Task<VehicleStatsListResponse> HistoryInternalAsync(
        StatsHistoryRequest request,
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
        _query["types"] = request.Types.Select(_value => _value.Stringify()).ToList();
        _query["decorations"] = request.Decorations.Select(_value => _value.Stringify()).ToList();
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
                    Path = "fleet/vehicles/stats/history",
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
                return JsonUtils.Deserialize<VehicleStatsListResponse>(responseBody)!;
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
    /// Returns the last known stats of all vehicles at the given `time`. If no `time` is specified, the current time is used.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Vehicles.Stats.ListAsync(new StatsListRequest());
    /// </code></example>
    public async Task<Pager<VehicleStatsResponseData>> ListAsync(
        StatsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            StatsListRequest,
            RequestOptions?,
            VehicleStatsResponse,
            string,
            VehicleStatsResponseData
        >
            .CreateInstanceAsync(
                request,
                options,
                ListInternalAsync,
                (request, cursor) =>
                {
                    request.After = cursor;
                },
                response => response?.Pagination?.EndCursor,
                response => response?.Data?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Follow a feed of vehicle stats.
    ///
    /// Your first call to this endpoint will provide you with the most recent stats for each vehicle and an `endCursor`.
    ///
    /// You can the provide the `endCursor` value to the `after` query parameter to get all updates since the last call you made.
    ///
    /// If `hasNextPage` is `false`, no new data is immediately available. You should wait a minimum of 5 seconds making a subsequent request.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Vehicles.Stats.FeedAsync(new StatsFeedRequest());
    /// </code></example>
    public async Task<Pager<VehicleStatsListResponseData>> FeedAsync(
        StatsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            StatsFeedRequest,
            RequestOptions?,
            VehicleStatsListResponse,
            string,
            VehicleStatsListResponseData
        >
            .CreateInstanceAsync(
                request,
                options,
                FeedInternalAsync,
                (request, cursor) =>
                {
                    request.After = cursor;
                },
                response => response?.Pagination?.EndCursor,
                response => response?.Data?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Returns vehicle stats during the given time range for all vehicles. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Vehicles.Stats.HistoryAsync(
    ///     new StatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public async Task<Pager<VehicleStatsListResponseData>> HistoryAsync(
        StatsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            StatsHistoryRequest,
            RequestOptions?,
            VehicleStatsListResponse,
            string,
            VehicleStatsListResponseData
        >
            .CreateInstanceAsync(
                request,
                options,
                HistoryInternalAsync,
                (request, cursor) =>
                {
                    request.After = cursor;
                },
                response => response?.Pagination?.EndCursor,
                response => response?.Data?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }
}
