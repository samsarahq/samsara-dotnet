using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Idling;

public partial class IdlingClient
{
    private RawClient _client;

    internal IdlingClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all vehicle idling reports for the requested time duration.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 25 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example><code>
    /// await client.Idling.GetVehicleReportsAsync(
    ///     new IdlingGetVehicleReportsRequest { StartTime = "startTime", EndTime = "endTime" }
    /// );
    /// </code></example>
    public async Task<IdlingReportsGetVehicleIdlingReportsResponseBody> GetVehicleReportsAsync(
        IdlingGetVehicleReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["startTime"] = request.StartTime;
        _query["endTime"] = request.EndTime;
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.VehicleIds != null)
        {
            _query["vehicleIds"] = request.VehicleIds;
        }
        if (request.TagIds != null)
        {
            _query["tagIds"] = request.TagIds;
        }
        if (request.ParentTagIds != null)
        {
            _query["parentTagIds"] = request.ParentTagIds;
        }
        if (request.IsPtoActive != null)
        {
            _query["isPtoActive"] = JsonUtils.Serialize(request.IsPtoActive.Value);
        }
        if (request.MinIdlingDurationMinutes != null)
        {
            _query["minIdlingDurationMinutes"] = request.MinIdlingDurationMinutes.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/reports/vehicle/idling",
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
                return JsonUtils.Deserialize<IdlingReportsGetVehicleIdlingReportsResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
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
}
