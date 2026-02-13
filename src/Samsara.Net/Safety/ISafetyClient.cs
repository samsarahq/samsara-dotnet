using Samsara.Net;

namespace Samsara.Net.Safety;

public partial interface ISafetyClient
{
    /// <summary>
    /// This endpoint will return details for the specified safety events based on the parameters passed in. Results are paginated.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<SafetyEventsV2GetSafetyEventsV2ResponseBody> GetSafetyEventsV2Async(
        GetSafetyEventsV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This endpoint will return all safety events associated with your organization based on the parameters passed in. To get core endpoint data, select Read Safety Events & Scores under the Safety & Cameras category when creating or editing an API token. Read Camera Media permissions required to get Safety Event video media via this endpoint. If you include an endTime, the endpoint will return data up until that point. If you do not include an endTime, you can continue to poll the API real-time with the pagination cursor that gets returned on every call. Results are paginated.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<SafetyEventsV2GetSafetyEventsV2StreamResponseBody> GetSafetyEventsV2StreamAsync(
        GetSafetyEventsV2StreamRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch the safety score for the driver.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<V1DriverSafetyScoreResponse> V1GetDriverSafetyScoreAsync(
        long driverId,
        V1GetDriverSafetyScoreRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// <i class="fa fa-exclamation-circle"></i>
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch the safety score for the vehicle.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits [here](/docs/rate-limits)).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Safety Events & Scores** under the Safety & Cameras category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    WithRawResponseTask<V1VehicleSafetyScoreResponse> V1GetVehicleSafetyScoreAsync(
        long vehicleId,
        V1GetVehicleSafetyScoreRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
