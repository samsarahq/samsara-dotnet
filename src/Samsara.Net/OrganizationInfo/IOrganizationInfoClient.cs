using Samsara.Net;

namespace Samsara.Net.OrganizationInfo;

public partial interface IOrganizationInfoClient
{
    /// <summary>
    /// Get information about your organization.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Org Information** under the Setup & Administration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    WithRawResponseTask<OrganizationInfoResponse> GetOrganizationInfoAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
