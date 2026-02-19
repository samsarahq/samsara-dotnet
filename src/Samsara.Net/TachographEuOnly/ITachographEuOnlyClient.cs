using Samsara.Net;

namespace Samsara.Net.TachographEuOnly;

public partial interface ITachographEuOnlyClient
{
    /// <summary>
    /// Returns all known tachograph activity for all specified drivers in the time range.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<DriverTachographActivityResponse> GetDriverTachographActivityAsync(
        GetDriverTachographActivityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns all known tachograph files for all specified drivers in the time range.
    ///
    ///  <b>Rate limit:</b> 50 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<TachographDriverFilesResponse> GetDriverTachographFilesAsync(
        GetDriverTachographFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns all known tachograph files for all specified vehicles in the time range.
    ///
    ///  <b>Rate limit:</b> 150 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Tachograph (EU)** under the Compliance category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<TachographVehicleFilesResponse> GetVehicleTachographFilesAsync(
        GetVehicleTachographFilesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
