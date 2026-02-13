using Samsara.Net;

namespace Samsara.Net.LegacyApIs;

public partial interface ILegacyApIsClient
{
    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/streamdefects) instead. The endpoint will continue to function as documented.**
    ///
    /// Returns a list of DVIR defects in an organization, filtered by creation time. The maximum time period you can query for is 30 days.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Defects** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    WithRawResponseTask<DefectsResponse> GetDvirDefectsAsync(
        GetDvirDefectsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdrivervehicleassignments) instead. The endpoint will continue to function as documented.** Get all vehicle assignments for the requested drivers in the requested time range. The only type of assignment supported right now are assignments created through the driver app.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody> GetDriversVehicleAssignmentsAsync(
        GetDriversVehicleAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdvirs) instead. The endpoint will continue to function as documented.**
    ///
    ///  Returns a list of all DVIRs in an organization.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read DVIRs** under the Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    WithRawResponseTask<DvirsListResponse> GetDvirHistoryAsync(
        GetDvirHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getidlingevents) instead. The endpoint will continue to function as documented.** Get all vehicle idling reports for the requested time duration.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<IdlingReportsGetVehicleIdlingReportsResponseBody> GetVehicleIdlingReportsAsync(
        GetVehicleIdlingReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getsafetyeventsv2stream) instead. The endpoint will continue to function as documented.**
    ///
    ///  Fetch safety events for the organization in a given time period.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    WithRawResponseTask<SafetyEventsListResponse> GetSafetyEventsAsync(
        GetSafetyEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getsafetyeventsv2stream) instead. The endpoint will continue to function as documented.**
    ///
    /// Get continuous safety events. The safety activity event feed offers a change-log for safety events. Use this endpoint to subscribe to safety event changes. See documentation below for all supported change-log types.
    ///
    /// | ActivityType      | Description |
    /// | ----------- | ----------- |
    /// | CreateSafetyEventActivityType | a new safety event is processed by Samsara      |
    /// | BehaviorLabelActivityType     | a label is added or removed from a safety event |
    /// | CoachingStateActivityType     | a safety event coaching state is updated        |
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<SafetyEventsGetSafetyActivityEventFeedResponseBody> GetSafetyActivityEventFeedAsync(
        GetSafetyActivityEventFeedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getdrivervehicleassignments) instead. The endpoint will continue to function as documented.** Get all driver assignments for the requested vehicles in the requested time range. The only type of assignment supported right now are assignments created through the driver app.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody> GetVehiclesDriverAssignmentsAsync(
        GetVehiclesDriverAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// **Note: This is a legacy endpoint, consider using [this endpoint](https://developers.samsara.com/reference/getsafetyeventsv2stream) instead. The endpoint will continue to function as documented.** &lt;n class="warning"&gt;
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
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    WithRawResponseTask<V1VehicleHarshEventResponse> V1GetVehicleHarshEventAsync(
        long vehicleId,
        V1GetVehicleHarshEventRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
