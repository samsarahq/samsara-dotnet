using Samsara.Net;

namespace Samsara.Net.CarbCtc;

public partial interface ICarbCtcClient
{
    /// <summary>
    /// Returns a paginated list of vehicles enrolled in the CARB CTC program with their latest compliance status. Results can be filtered by tag IDs and test status.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read CARB CTC Integration** under the CARB CTC Integration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<CarbCtcListCarbCtcVehiclesResponseBody> ListCarbCtcVehiclesAsync(
        ListCarbCtcVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns paginated collection history for a batch of vehicles enrolled in the CARB CTC program. Use vehicle IDs from the list enrolled vehicles endpoint. Optionally filter by time range. Results are ordered by happenedAtTime descending, with vehicle ID as a tiebreaker.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read CARB CTC Integration** under the CARB CTC Integration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<CarbCtcListCarbCtcVehicleHistoryResponseBody> ListCarbCtcVehicleHistoryAsync(
        ListCarbCtcVehicleHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
