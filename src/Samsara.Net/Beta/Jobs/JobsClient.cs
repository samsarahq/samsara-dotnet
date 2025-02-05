using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Jobs;

public partial class JobsClient
{
    private RawClient _client;

    internal JobsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Fetches jobs based on id/uuid or provided filters.
    ///
    /// To use this endpoint, select **Read Jobs** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Beta.Jobs.GetAsync(new JobsGetRequest());
    /// </code>
    /// </example>
    public async Task<JobsGetJobsResponseBody> GetAsync(
        JobsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["industrialAssetIds"] = request.IndustrialAssetIds;
        _query["fleetDeviceIds"] = request
            .FleetDeviceIds.Select(_value => _value.ToString())
            .ToList();
        if (request.Id != null)
        {
            _query["id"] = request.Id;
        }
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate;
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status.Value.Stringify();
        }
        if (request.CustomerName != null)
        {
            _query["customerName"] = request.CustomerName;
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "beta/industrial/jobs",
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
                return JsonUtils.Deserialize<JobsGetJobsResponseBody>(responseBody)!;
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
    /// Creates a new job and returns it.
    ///
    /// To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Beta.Jobs.CreateAsync(
    ///     new JobsCreateJobRequestBody
    ///     {
    ///         Job = new PostJobObjectRequestBody
    ///         {
    ///             EndDate = "2019-06-13T19:08:25Z",
    ///             Id = "8d218e6c-7a16-4f9f-90f7-cc1d93b9e596",
    ///             Name = "My Job Name",
    ///             StartDate = "2019-06-13T19:08:25Z",
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<JobsCreateJobResponseBody> CreateAsync(
        JobsCreateJobRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "beta/industrial/jobs",
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
                return JsonUtils.Deserialize<JobsCreateJobResponseBody>(responseBody)!;
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
    /// Deletes an existing job.
    ///
    /// To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Beta.Jobs.DeleteAsync(new JobsDeleteRequest { Id = "id" });
    /// </code>
    /// </example>
    public async Task<JobsDeleteJobResponseBody> DeleteAsync(
        JobsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["id"] = request.Id;
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = "beta/industrial/jobs",
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
                return JsonUtils.Deserialize<JobsDeleteJobResponseBody>(responseBody)!;
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
    /// Patches an existing job and returns it.
    ///
    /// To use this endpoint, select **Write Jobs** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Beta.Jobs.UpdateAsync(
    ///     new JobsPatchJobRequestBody { Id = "id", Job = new PatchJobObjectRequestBody() }
    /// );
    /// </code>
    /// </example>
    public async Task<JobsPatchJobResponseBody> UpdateAsync(
        JobsPatchJobRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["id"] = request.Id;
        var requestBody = new Dictionary<string, object>()
        {
            { "job", request.Job },
            { "keepHistory", request.KeepHistory },
        };
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethodExtensions.Patch,
                    Path = "beta/industrial/jobs",
                    Body = requestBody,
                    Query = _query,
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
                return JsonUtils.Deserialize<JobsPatchJobResponseBody>(responseBody)!;
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
