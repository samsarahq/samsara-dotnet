using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

public partial interface IVehiclesClient
{
    /// <summary>
    /// Returns a list of all vehicles.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    Task<Pager<VehicleResponseObjectResponseBody>> ListAsync(
        ListVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get information about a specific vehicle.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<VehicleResponse> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the given Vehicle object.
    ///
    /// **Note:** Vehicle objects are automatically created when Samsara Vehicle Gateways are installed. You cannot create a Vehicle object via API.
    ///
    /// You are able to *update* many of the fields of a Vehicle.
    ///
    /// **Note**: There are no required fields in the request body, and you only need to provide the fields you wish to update.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Vehicles** under the Vehicles category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<VehicleResponse> UpdateAsync(
        string id,
        UpdateVehicleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
