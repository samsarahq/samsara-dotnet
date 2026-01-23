using Samsara.Net;

namespace Samsara.Net.Coaching;

public partial interface ICoachingClient
{
    /// <summary>
    /// This endpoint will return coach assignments for your organization based on the parameters passed in. Results are paginated.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    WithRawResponseTask<DriverCoachAssignmentsGetDriverCoachAssignmentResponseBody> GetDriverCoachAssignmentAsync(
        GetDriverCoachAssignmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This endpoint will update an existing or create a new coach-to-driver assignment for your organization based on the parameters passed in. This endpoint should only be used for existing Coach to Driver assignments. In order to remove a driver-coach-assignment for a given driver, set coachId to null
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 10 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Coaching** under the Coaching category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    WithRawResponseTask<DriverCoachAssignmentsPutDriverCoachAssignmentResponseBody> PutDriverCoachAssignmentAsync(
        PutDriverCoachAssignmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This endpoint will return coaching sessions for your organization based on the time parameters passed in. Results are paginated by sessions. If you include an endTime, the endpoint will return data up until that point. If you don’t include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Coaching** under the Coaching category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    WithRawResponseTask<CoachingSessionsGetCoachingSessionsResponseBody> GetCoachingSessionsAsync(
        GetCoachingSessionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
