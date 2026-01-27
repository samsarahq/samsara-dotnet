using Samsara.Net;

namespace Samsara.Net.RouteEvents;

public partial interface IRouteEventsClient
{
    /// <summary>
    /// Subscribes to a feed of immutable, append-only updates for routes. The initial request to this feed endpoint returns a cursor, which can be used in subsequent requests to fetch events on all routes that occurred after the last retrieved event. An initial request (with empty after and startTime parameters) will return events from the past 24 hours.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Routes** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    WithRawResponseTask<RoutesGetRouteEventsStreamResponseBody> GetRouteEventsStreamAsync(
        GetRouteEventsStreamRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
