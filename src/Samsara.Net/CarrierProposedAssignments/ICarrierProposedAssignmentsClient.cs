using Samsara.Net;

namespace Samsara.Net.CarrierProposedAssignments;

public partial interface ICarrierProposedAssignmentsClient
{
    /// <summary>
    /// Show the assignments created by the POST fleet/carrier-proposed-assignments. This endpoint will only show the assignments that are active for drivers and currently visible to them in the driver app. Once a proposed assignment has been accepted, the endpoint will not return any data.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<ListCarrierProposedAssignmentResponse> ListCarrierProposedAssignmentsAsync(
        ListCarrierProposedAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new assignment that a driver can later use. Each driver can only have one future assignment.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<CarrierProposedAssignmentResponse> CreateCarrierProposedAssignmentAsync(
        CreateCarrierProposedAssignmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Permanently delete an assignment. You can only delete assignments that are not yet active. To override a currently active assignment, create a new empty one, instead.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    WithRawResponseTask<string> DeleteCarrierProposedAssignmentAsync(
        DeleteCarrierProposedAssignmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
