using Samsara.Net;

namespace Samsara.Net.TrainingCourses;

public partial interface ITrainingCoursesClient
{
    /// <summary>
    /// Returns all training courses data. Results are paginated.
    ///  Courses in the ‘draft’ status are excluded from the data returned by this endpoint.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Training Courses** under the Training Courses category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    WithRawResponseTask<TrainingCoursesGetTrainingCoursesResponseBody> GetTrainingCoursesAsync(
        GetTrainingCoursesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
