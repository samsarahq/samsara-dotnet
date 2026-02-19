using Samsara.Net;

namespace Samsara.Net.TrailerAssignments;

public partial interface ITrailerAssignmentsClient
{
    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for all trailers in your organization.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<InlineResponse2007> V1GetAllTrailerAssignmentsAsync(
        V1GetAllTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for a single trailer.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<V1TrailerAssignmentsResponse> V1GetFleetTrailerAssignmentsAsync(
        long trailerId,
        V1GetFleetTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
