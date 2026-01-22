using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Messages;

public partial class MessagesClient : IMessagesClient
{
    private RawClient _client;

    internal MessagesClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<InlineResponse2005>> V1GetMessagesAsyncCore(
        V1GetMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.EndMs != null)
        {
            _query["endMs"] = request.EndMs.Value.ToString();
        }
        if (request.DurationMs != null)
        {
            _query["durationMs"] = request.DurationMs.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "v1/fleet/messages",
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
                var responseData = JsonUtils.Deserialize<InlineResponse2005>(responseBody)!;
                return new WithRawResponse<InlineResponse2005>()
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

    private async Task<WithRawResponse<InlineResponse2006>> V1CreateMessagesAsyncCore(
        InlineObject2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "v1/fleet/messages",
                    Body = request,
                    ContentType = "application/json",
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
                var responseData = JsonUtils.Deserialize<InlineResponse2006>(responseBody)!;
                return new WithRawResponse<InlineResponse2006>()
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
    /// Get all messages.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Messages** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Messages.V1GetMessagesAsync(new V1GetMessagesRequest());
    /// </code></example>
    public WithRawResponseTask<InlineResponse2005> V1GetMessagesAsync(
        V1GetMessagesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InlineResponse2005>(
            V1GetMessagesAsyncCore(request, options, cancellationToken)
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
    /// Send a message to a list of driver ids.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Write Messages** under the Driver Workflow category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Messages.V1CreateMessagesAsync(
    ///     new InlineObject2
    ///     {
    ///         DriverIds = new List&lt;long&gt;() { 111, 222, 333 },
    ///         Text = "This is a message.",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<InlineResponse2006> V1CreateMessagesAsync(
        InlineObject2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<InlineResponse2006>(
            V1CreateMessagesAsyncCore(request, options, cancellationToken)
        );
    }
}
