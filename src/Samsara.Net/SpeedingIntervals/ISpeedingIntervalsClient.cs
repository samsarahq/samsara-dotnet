using Samsara.Net;

namespace Samsara.Net.SpeedingIntervals;

public partial interface ISpeedingIntervalsClient
{
    /// <summary>
    /// This endpoint will return all speeding intervals associated with all trips that have been collected for your organization based on the time parameters passed in. Only completed trips are included. Trips with no speeding intervals detected will be returned with an empty list of intervals. Results are paginated.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Speeding Intervals** under the Speeding Intervals category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<SpeedingIntervalsGetSpeedingIntervalsResponseBody> GetSpeedingIntervalsAsync(
        GetSpeedingIntervalsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
