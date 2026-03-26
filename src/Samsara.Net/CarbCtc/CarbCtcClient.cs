using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.CarbCtc;

public partial class CarbCtcClient : ICarbCtcClient
{
    private RawClient _client;

    internal CarbCtcClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<CarbCtcListCarbCtcVehiclesResponseBody>
    > ListCarbCtcVehiclesAsyncCore(
        ListCarbCtcVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("tagIds", request.TagIds)
            .Add("parentTagIds", request.ParentTagIds)
            .Add("testStatus", request.TestStatus)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/carb-ctc/vehicles",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<CarbCtcListCarbCtcVehiclesResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<CarbCtcListCarbCtcVehiclesResponseBody>()
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

    private async Task<
        WithRawResponse<CarbCtcListCarbCtcVehicleHistoryResponseBody>
    > ListCarbCtcVehicleHistoryAsyncCore(
        ListCarbCtcVehicleHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("vehicleIds", request.VehicleIds)
            .Add("startTime", request.StartTime)
            .Add("endTime", request.EndTime)
            .Add("after", request.After)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Samsara.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/carb-ctc/vehicles/history",
                    QueryString = _queryString,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<CarbCtcListCarbCtcVehicleHistoryResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<CarbCtcListCarbCtcVehicleHistoryResponseBody>()
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
    /// Returns a paginated list of vehicles enrolled in the CARB CTC program with their latest compliance status. Results can be filtered by tag IDs and test status.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read CARB CTC Integration** under the CARB CTC Integration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.CarbCtc.ListCarbCtcVehiclesAsync(new ListCarbCtcVehiclesRequest());
    /// </code></example>
    public WithRawResponseTask<CarbCtcListCarbCtcVehiclesResponseBody> ListCarbCtcVehiclesAsync(
        ListCarbCtcVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CarbCtcListCarbCtcVehiclesResponseBody>(
            ListCarbCtcVehiclesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns paginated collection history for a batch of vehicles enrolled in the CARB CTC program. Use vehicle IDs from the list enrolled vehicles endpoint. Optionally filter by time range. Results are ordered by happenedAtTime descending, with vehicle ID as a tiebreaker.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read CARB CTC Integration** under the CARB CTC Integration category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.CarbCtc.ListCarbCtcVehicleHistoryAsync(
    ///     new ListCarbCtcVehicleHistoryRequest { VehicleIds = "vehicleIds" }
    /// );
    /// </code></example>
    public WithRawResponseTask<CarbCtcListCarbCtcVehicleHistoryResponseBody> ListCarbCtcVehicleHistoryAsync(
        ListCarbCtcVehicleHistoryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CarbCtcListCarbCtcVehicleHistoryResponseBody>(
            ListCarbCtcVehicleHistoryAsyncCore(request, options, cancellationToken)
        );
    }
}
