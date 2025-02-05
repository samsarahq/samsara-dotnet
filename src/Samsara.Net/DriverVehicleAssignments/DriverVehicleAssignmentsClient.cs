using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

public partial class DriverVehicleAssignmentsClient
{
    private RawClient _client;

    internal DriverVehicleAssignmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all driver-vehicle assignments for the requested drivers or vehicles in the requested time range. To fetch driver-vehicle assignments out of the vehicle trips' time ranges, assignmentType needs to be specified. Note: this endpoint replaces past endpoints to fetch assignments by driver or by vehicle. Visit [this migration guide](https://developers.samsara.com/docs/migrating-from-driver-vehicle-assignment-or-vehicle-driver-assignment-endpoints) for more information.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 5 requests/sec (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Read Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.DriverVehicleAssignments.GetDriverVehicleAssignmentsAsync(
    ///     new DriverVehicleAssignmentsGetDriverVehicleAssignmentsRequest
    ///     {
    ///         FilterBy = DriverVehicleAssignmentsGetDriverVehicleAssignmentsRequestFilterBy.Drivers,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody> GetDriverVehicleAssignmentsAsync(
        DriverVehicleAssignmentsGetDriverVehicleAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["filterBy"] = request.FilterBy.Stringify();
        _query["driverIds"] = request.DriverIds;
        _query["vehicleIds"] = request.VehicleIds;
        if (request.StartTime != null)
        {
            _query["startTime"] = request.StartTime;
        }
        if (request.EndTime != null)
        {
            _query["endTime"] = request.EndTime;
        }
        if (request.DriverTagIds != null)
        {
            _query["driverTagIds"] = request.DriverTagIds;
        }
        if (request.VehicleTagIds != null)
        {
            _query["vehicleTagIds"] = request.VehicleTagIds;
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        if (request.AssignmentType != null)
        {
            _query["assignmentType"] = request.AssignmentType.Value.Stringify();
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "fleet/driver-vehicle-assignments",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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

    /// <summary>
    /// Assign vehicle drive-time to a driver via API. For a step-by-step instruction on how to leverage this endpoint, see [this guide](https://developers.samsara.com/docs/creating-driver-vehicle-assignments)
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.DriverVehicleAssignments.CreateDriverVehicleAssignmentAsync(
    ///     new DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody
    ///     {
    ///         DriverId = "494123",
    ///         VehicleId = "281474978683353",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody> CreateDriverVehicleAssignmentAsync(
        DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Post,
                    Path = "fleet/driver-vehicle-assignments",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<DriverVehicleAssignmentsV2CreateDriverVehicleAssignmentResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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

    /// <summary>
    /// Delete driver assignments that were created using the `POST fleet/driver-vehicle-assignments` endpoint for the requested vehicle in the requested time range.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.DriverVehicleAssignments.DeleteDriverVehicleAssignmentsAsync(
    ///     new DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody
    ///     {
    ///         VehicleId = "281474978683353",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task DeleteDriverVehicleAssignmentsAsync(
        DriverVehicleAssignmentsV2DeleteDriverVehicleAssignmentsRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Delete,
                    Path = "fleet/driver-vehicle-assignments",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
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
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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

    /// <summary>
    /// Update driver assignments that were created using the `POST fleet/driver-vehicle-assignments`. Vehicle Id, Driver Id, and Start Time must match an existing assignment.
    ///
    ///  &lt;b&gt;Rate limit:&lt;/b&gt; 100 requests/min (learn more about rate limits &lt;a href="https://developers.samsara.com/docs/rate-limits" target="_blank"&gt;here&lt;/a&gt;).
    ///
    /// To use this endpoint, select **Write Assignments** under the Assignments category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.DriverVehicleAssignments.UpdateDriverVehicleAssignmentAsync(
    ///     new DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody
    ///     {
    ///         DriverId = "494123",
    ///         StartTime = "2019-06-13T19:08:25Z",
    ///         VehicleId = "281474978683353",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody> UpdateDriverVehicleAssignmentAsync(
        DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethodExtensions.Patch,
                    Path = "fleet/driver-vehicle-assignments",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<DriverVehicleAssignmentsV2UpdateDriverVehicleAssignmentResponseBody>(
                    responseBody
                )!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 401:
                    throw new UnauthorizedError(JsonUtils.Deserialize<object>(responseBody));
                case 404:
                    throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                case 405:
                    throw new MethodNotAllowedError(JsonUtils.Deserialize<object>(responseBody));
                case 429:
                    throw new TooManyRequestsError(JsonUtils.Deserialize<object>(responseBody));
                case 500:
                    throw new InternalServerError(JsonUtils.Deserialize<object>(responseBody));
                case 501:
                    throw new NotImplementedError(JsonUtils.Deserialize<object>(responseBody));
                case 502:
                    throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                case 503:
                    throw new ServiceUnavailableError(JsonUtils.Deserialize<object>(responseBody));
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
