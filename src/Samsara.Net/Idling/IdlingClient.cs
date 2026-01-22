using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Idling;

public partial class IdlingClient : IIdlingClient
{
    private RawClient _client;

    internal IdlingClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<AdvancedIdlingGetIdlingEventsResponseBody>
    > GetIdlingEventsAsyncCore(
        GetIdlingEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startTime"] = request.StartTime;
        _query["endTime"] = request.EndTime;
        _query["assetIds"] = request.AssetIds;
        _query["operatorIds"] = request.OperatorIds;
        _query["tagIds"] = request.TagIds;
        _query["parentTagIds"] = request.ParentTagIds;
        if (request.PtoState != null)
        {
            _query["ptoState"] = request.PtoState.Value.Stringify();
        }
        if (request.MinAirTemperatureMillicelsius != null)
        {
            _query["minAirTemperatureMillicelsius"] =
                request.MinAirTemperatureMillicelsius.Value.ToString();
        }
        if (request.MaxAirTemperatureMillicelsius != null)
        {
            _query["maxAirTemperatureMillicelsius"] =
                request.MaxAirTemperatureMillicelsius.Value.ToString();
        }
        if (request.ExcludeEventsWithUnknownAirTemperature != null)
        {
            _query["excludeEventsWithUnknownAirTemperature"] = JsonUtils.Serialize(
                request.ExcludeEventsWithUnknownAirTemperature.Value
            );
        }
        if (request.MinDurationMilliseconds != null)
        {
            _query["minDurationMilliseconds"] = request.MinDurationMilliseconds.Value.ToString();
        }
        if (request.MaxDurationMilliseconds != null)
        {
            _query["maxDurationMilliseconds"] = request.MaxDurationMilliseconds.Value.ToString();
        }
        if (request.IncludeExternalIds != null)
        {
            _query["includeExternalIds"] = JsonUtils.Serialize(request.IncludeExternalIds.Value);
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "idling/events",
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
                var responseData = JsonUtils.Deserialize<AdvancedIdlingGetIdlingEventsResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<AdvancedIdlingGetIdlingEventsResponseBody>()
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
            try
            {
                switch (response.StatusCode)
                {
                    case 401:
                        throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 405:
                        throw new MethodNotAllowedError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                    case 500:
                        throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                    case 501:
                        throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new SamsaraClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get idling events for the requested time duration.
    ///
    /// **Note:** The data from this endpoint comes from the new Advanced Idling Report, which provides additional data fields for each idling event such as air temperature, geofence, PTO state and minimum idle time. This endpoint includes data from January 1, 2024. If you require additional historical data, you can access it via the [vehicle idling reports API](https://developers.samsara.com/reference/getvehicleidlingreports).
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Idling** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Idling.GetIdlingEventsAsync(
    ///     new GetIdlingEventsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public WithRawResponseTask<AdvancedIdlingGetIdlingEventsResponseBody> GetIdlingEventsAsync(
        GetIdlingEventsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<AdvancedIdlingGetIdlingEventsResponseBody>(
            GetIdlingEventsAsyncCore(request, options, cancellationToken)
        );
    }
}
