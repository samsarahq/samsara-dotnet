using Samsara.Net;

namespace Samsara.Net.RouteEvents;

public partial interface IRouteEventsClient
{
    /// <summary>
    /// Subscribes to a feed of immutable, append-only updates for routes. The initial request to this feed endpoint returns a cursor, which can be used in subsequent requests to fetch events on all routes that occurred after the last retrieved event. An initial request (with empty after and startTime parameters) will return events from the past 24 hours.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<RoutesGetRouteEventsStreamResponseBody> GetRouteEventsStreamAsync(
        GetRouteEventsStreamRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
