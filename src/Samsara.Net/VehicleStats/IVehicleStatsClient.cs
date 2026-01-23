using Samsara.Net;

namespace Samsara.Net.VehicleStats;

public partial interface IVehicleStatsClient
{
    /// <summary>
    /// Returns the last known stats of all vehicles at the given `time`. If no `time` is specified, the current time is used.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<VehicleStatsResponse> GetVehicleStatsAsync(
        GetVehicleStatsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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
    WithRawResponseTask<VehicleStatsListResponse> GetVehicleStatsFeedAsync(
        GetVehicleStatsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns vehicle stats during the given time range for all vehicles. This can be optionally filtered by tags or specific vehicle IDs.
    ///
    /// Related guide: &lt;a href="/docs/telematics" target="_blank"&gt;Telematics&lt;/a&gt;.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<VehicleStatsListResponse> GetVehicleStatsHistoryAsync(
        GetVehicleStatsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
