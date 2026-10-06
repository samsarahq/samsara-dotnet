using Samsara.Net;

namespace Samsara.Net.PreventiveMaintenance;

public partial interface IPreventiveMaintenanceClient
{
    /// <summary>
    /// Resolves the current open preventive maintenance instance for a schedule and asset, and automatically creates the next due record based on the schedule's intervals.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Preventive Maintenance Resolve** under the Preventive Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<ResolvePreventiveMaintenanceActionServiceResolvePreventiveMaintenanceResponseBody> ResolvePreventiveMaintenanceAsync(
        ResolvePreventiveMaintenanceActionServiceResolvePreventiveMaintenanceRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of preventive maintenance schedules for the organization.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Preventive Maintenance Schedules** under the Preventive Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<EntityPreventativeMaintenanceSchedulesServiceListPreventiveMaintenanceSchedulesResponseBody> ListPreventiveMaintenanceSchedulesAsync(
        ListPreventiveMaintenanceSchedulesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of upcoming preventive maintenance schedules for the organization's assets, enriched with live telemetry (current odometer, engine hours) and due-date projections.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Upcoming Preventive Maintenance** under the Preventive Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<EntityUpcomingPreventativeMaintenancesServiceListUpcomingPreventiveMaintenanceResponseBody> ListUpcomingPreventiveMaintenanceAsync(
        ListUpcomingPreventiveMaintenanceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Patches the due-target and last-resolved values on the open preventive maintenance instance for a schedule and asset. Only fields provided in the request are updated.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Upcoming Preventive Maintenance** under the Preventive Maintenance category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<EntityUpcomingPreventativeMaintenancesServiceUpdateUpcomingPreventiveMaintenanceResponseBody> UpdateUpcomingPreventiveMaintenanceAsync(
        EntityUpcomingPreventativeMaintenancesServiceUpdateUpcomingPreventiveMaintenanceRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
