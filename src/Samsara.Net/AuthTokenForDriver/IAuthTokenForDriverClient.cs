using Samsara.Net;

namespace Samsara.Net.AuthTokenForDriver;

public partial interface IAuthTokenForDriverClient
{
    /// <summary>
    /// Creates a short-lived auth token a driver can use to login.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Write Driver Auth Token** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<AuthTokenAuthTokenResponseBody> AuthTokenAsync(
        AuthTokenAuthTokenRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
