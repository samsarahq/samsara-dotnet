using Samsara.Net;

namespace Samsara.Net.Readings;

public partial interface IReadingsClient
{
    /// <summary>
    /// An introspection endpoint for discovering the set of readings including their name, description, data type, unit, and other metadata.
    ///
    /// Related guide: [Readings](https://developers.samsara.com/docs/readings).
    ///
    ///  <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Readings** under the Readings category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<ReadingsListReadingsDefinitionsResponseBody> ListReadingsDefinitionsAsync(
        ListReadingsDefinitionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the values of a reading for a set of entities within the specified time range. Returns a paginated response with data for the specified resource IDs where startTime &lt;= happenedAtTime &lt; endTime. If endTime is not set, the time of the request is used as the endTime.
    ///
    /// Related guide: [Readings](https://developers.samsara.com/docs/readings).
    ///
    ///  <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Readings** under the Readings category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<ReadingsGetReadingsHistoryResponseBody> GetReadingsHistoryAsync(
        GetReadingsHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// An endpoint to get the last value of a reading for a set of entities at the specified time.
    ///
    /// Related guide: [Readings](https://developers.samsara.com/docs/readings).
    ///
    ///  <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Readings** under the Readings category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<ReadingsGetReadingsSnapshotResponseBody> GetReadingsSnapshotAsync(
        GetReadingsSnapshotRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
