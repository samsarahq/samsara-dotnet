using Samsara.Net;

namespace Samsara.Net.TrainingCourses;

public partial interface ITrainingCoursesClient
{
    /// <summary>
    /// Returns all training courses data. Results are paginated.
    ///  Courses in the ‘draft’ status are excluded from the data returned by this endpoint.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Training Courses** under the Training Courses category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<TrainingCoursesGetTrainingCoursesResponseBody> GetTrainingCoursesAsync(
        GetTrainingCoursesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
