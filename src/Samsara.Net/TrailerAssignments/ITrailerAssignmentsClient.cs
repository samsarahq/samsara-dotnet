using Samsara.Net;

namespace Samsara.Net.TrailerAssignments;

public partial interface ITrailerAssignmentsClient
{
    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// &lt;i class="fa fa-exclamation-circle"&gt;&lt;/i&gt;
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for all trailers in your organization.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<InlineResponse2007> V1GetAllTrailerAssignmentsAsync(
        V1GetAllTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// &lt;i class="fa fa-exclamation-circle"&gt;&lt;/i&gt;
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for a single trailer.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<V1TrailerAssignmentsResponse> V1GetFleetTrailerAssignmentsAsync(
        V1GetFleetTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
