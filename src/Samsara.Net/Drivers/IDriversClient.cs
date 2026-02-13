using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

public partial interface IDriversClient
{
    /// <summary>
    /// Get all drivers in organization.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    Task<Pager<Driver>> ListAsync(
        ListDriversRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Add a driver to the organization.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<DriverResponse> CreateAsync(
        CreateDriverRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sign out a driver from the Samsara Driver App
    ///
    /// To access this endpoint, your organization must have the Samsara Platform Premier license.
    ///
    /// Note: Sign out requests made while a logged-in driver does not have internet connection will not log the driver out. A success response will still be provided and the driver will be logged out once they have internet connection.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Write Driver Remote Signout** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DriverRemoteSignoutPostDriverRemoteSignoutResponseBody> PostDriverRemoteSignoutAsync(
        DriverRemoteSignoutPostDriverRemoteSignoutRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a driver.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<DriverResponse> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    Task DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a specific driver's information. This can also be used to activate or de-activate a given driver by setting the driverActivationStatus field. If the driverActivationStatus field is 'deactivated' then the user can also specify the deactivatedAtTime. The deactivatedAtTime cannot be more than 6 months in the past and must not come before the dirver's latest active HOS log. It will be considered an error if deactivatedAtTime is provided with a driverActivationStatus of active.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Drivers** under the Drivers category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<DriverResponse> UpdateAsync(
        string id,
        UpdateDriverRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
