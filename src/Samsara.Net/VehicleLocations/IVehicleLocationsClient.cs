using Samsara.Net;

namespace Samsara.Net.VehicleLocations;

public partial interface IVehicleLocationsClient
{
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
    WithRawResponseTask<VehicleLocationsResponse> GetVehicleLocationsAsync(
        GetVehicleLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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
    WithRawResponseTask<VehicleLocationsListResponse> GetVehicleLocationsFeedAsync(
        GetVehicleLocationsFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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
    WithRawResponseTask<VehicleLocationsListResponse> GetVehicleLocationsHistoryAsync(
        GetVehicleLocationsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
