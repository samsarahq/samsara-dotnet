using Samsara.Net;

namespace Samsara.Net.Fleet;

public partial interface IFleetClient
{
    public Samsara.Net.Fleet.CarrierProposedAssignments.ICarrierProposedAssignmentsClient CarrierProposedAssignments { get; }
    public Samsara.Net.Fleet.Attributes.IAttributesClient Attributes { get; }

    /// <summary>
    /// Get current location of vehicles.
    ///
    ///  <b>Rate limit:</b> 50 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Vehicle Statistics** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<FleetLocationsGetFleetLocationsResponseBody> GetFleetLocationsAsync(
        GetFleetLocationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
