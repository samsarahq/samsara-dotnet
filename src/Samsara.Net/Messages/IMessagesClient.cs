using Samsara.Net;

namespace Samsara.Net.Messages;

public partial interface IMessagesClient
{
    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Get all messages.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Messages** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<InlineResponse2005> V1GetMessagesAsync(
        V1GetMessagesRequest request,
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
    /// Send a message to a list of driver ids.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Messages** under the Driver Workflow category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<InlineResponse2006> V1CreateMessagesAsync(
        InlineObject2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
