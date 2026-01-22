using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.TrailerAssignments;

public partial class TrailerAssignmentsClient : ITrailerAssignmentsClient
{
    private RawClient _client;

    internal TrailerAssignmentsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<InlineResponse2007>> V1GetAllTrailerAssignmentsAsyncCore(
        V1GetAllTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.StartMs != null)
        {
            _query["startMs"] = request.StartMs.Value.ToString();
        }
        if (request.EndMs != null)
        {
            _query["endMs"] = request.EndMs.Value.ToString();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        if (request.EndingBefore != null)
        {
            _query["endingBefore"] = request.EndingBefore;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "v1/fleet/trailers/assignments",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                var responseData = JsonUtils.Deserialize<InlineResponse2007>(responseBody)!;
                return new WithRawResponse<InlineResponse2007>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<V1TrailerAssignmentsResponse>
    > V1GetFleetTrailerAssignmentsAsyncCore(
        V1GetFleetTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.StartMs != null)
        {
            _query["startMs"] = request.StartMs.Value.ToString();
        }
        if (request.EndMs != null)
        {
            _query["endMs"] = request.EndMs.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "v1/fleet/trailers/{0}/assignments",
                        ValueConvert.ToPathParameterString(request.TrailerId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                var responseData = JsonUtils.Deserialize<V1TrailerAssignmentsResponse>(
                    responseBody
                )!;
                return new WithRawResponse<V1TrailerAssignmentsResponse>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new SamsaraClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// &lt;i class="fa fa-exclamation-circle"&gt;&lt;/i&gt;
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for all trailers in your organization.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.TrailerAssignments.V1GetAllTrailerAssignmentsAsync(
    ///     new V1GetAllTrailerAssignmentsRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<InlineResponse2007> V1GetAllTrailerAssignmentsAsync(
        V1GetAllTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InlineResponse2007>(
            V1GetAllTrailerAssignmentsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// &lt;n class="warning"&gt;
    /// &lt;nh&gt;
    /// &lt;i class="fa fa-exclamation-circle"&gt;&lt;/i&gt;
    /// This endpoint is still on our legacy API.
    /// &lt;/nh&gt;
    /// &lt;/n&gt;
    ///
    /// Fetch trailer assignment data for a single trailer.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.TrailerAssignments.V1GetFleetTrailerAssignmentsAsync(
    ///     new V1GetFleetTrailerAssignmentsRequest { TrailerId = 1000000 }
    /// );
    /// </code></example>
    public WithRawResponseTask<V1TrailerAssignmentsResponse> V1GetFleetTrailerAssignmentsAsync(
        V1GetFleetTrailerAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<V1TrailerAssignmentsResponse>(
            V1GetFleetTrailerAssignmentsAsyncCore(request, options, cancellationToken)
        );
    }
}
