using Samsara.Net;

namespace Samsara.Net.Idling;

public partial interface IIdlingClient
{
    /// <summary>
    /// Get idling events for the requested time duration.
    ///
    /// **Note:** The data from this endpoint comes from the new Advanced Idling Report, which provides additional data fields for each idling event such as air temperature, geofence, PTO state and minimum idle time. This endpoint includes data from January 1, 2024. If you require additional historical data, you can access it via the [vehicle idling reports API](/api-reference/legacy/legacy-apis/get-vehicle-idling-reports).
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Idling** under the Fuel & Energy category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<AdvancedIdlingGetIdlingEventsResponseBody> GetIdlingEventsAsync(
        GetIdlingEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
