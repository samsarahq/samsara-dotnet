using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

public partial class PreviewApIsClient : IPreviewApIsClient
{
    private RawClient _client;

    internal PreviewApIsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<DeviceRecoveryListDeviceRecoveryAssetsResponseBody>
    > ListDeviceRecoveryAssetsAsyncCore(
        ListDeviceRecoveryAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("statuses", request.Statuses)
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
                    Path = "preview/fleet/assets/device-recovery",
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
                    JsonUtils.Deserialize<DeviceRecoveryListDeviceRecoveryAssetsResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DeviceRecoveryListDeviceRecoveryAssetsResponseBody>()
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
        WithRawResponse<DeviceRecoveryMarkAssetMissingResponseBody>
    > MarkAssetMissingAsyncCore(
        DeviceRecoveryMarkAssetMissingRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "preview/fleet/assets/device-recovery/{0}/missing",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
                    Body = request,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<DeviceRecoveryMarkAssetMissingResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DeviceRecoveryMarkAssetMissingResponseBody>()
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
        WithRawResponse<DeviceRecoveryRecoverAssetResponseBody>
    > RecoverAssetAsyncCore(
        DeviceRecoveryRecoverAssetRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "preview/fleet/assets/device-recovery/{0}/recovered",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
                    Body = request,
                    Headers = _headers,
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
                var responseData = JsonUtils.Deserialize<DeviceRecoveryRecoverAssetResponseBody>(
                    responseBody
                )!;
                return new WithRawResponse<DeviceRecoveryRecoverAssetResponseBody>()
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
        WithRawResponse<DeviceRecoveryGetAssetRecoveryStateResponseBody>
    > GetAssetRecoveryStateAsyncCore(
        GetAssetRecoveryStateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Path = string.Format(
                        "preview/fleet/assets/device-recovery/{0}/recovery-state",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
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
                    JsonUtils.Deserialize<DeviceRecoveryGetAssetRecoveryStateResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DeviceRecoveryGetAssetRecoveryStateResponseBody>()
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
        WithRawResponse<DriversAuthTokenCreateDriverAuthTokenResponseBody>
    > CreateDriverAuthTokenAsyncCore(
        DriversAuthTokenCreateDriverAuthTokenRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Post,
                    Path = "preview/fleet/drivers/create-auth-token",
                    Body = request,
                    Headers = _headers,
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
                var responseData =
                    JsonUtils.Deserialize<DriversAuthTokenCreateDriverAuthTokenResponseBody>(
                        responseBody
                    )!;
                return new WithRawResponse<DriversAuthTokenCreateDriverAuthTokenResponseBody>()
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
    /// List all assets that have a device recovery state for the organization. Optionally filter by one or more statuses (UNKNOWN, MISSING, LOCATED, RECOVERED).
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.ListDeviceRecoveryAssetsAsync(new ListDeviceRecoveryAssetsRequest());
    /// </code></example>
    public WithRawResponseTask<DeviceRecoveryListDeviceRecoveryAssetsResponseBody> ListDeviceRecoveryAssetsAsync(
        ListDeviceRecoveryAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DeviceRecoveryListDeviceRecoveryAssetsResponseBody>(
            ListDeviceRecoveryAssetsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Mark an asset as missing. Optionally specify a note and notification recipients who will receive email updates.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.MarkAssetMissingAsync(
    ///     new DeviceRecoveryMarkAssetMissingRequestBody { Id = "id" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DeviceRecoveryMarkAssetMissingResponseBody> MarkAssetMissingAsync(
        DeviceRecoveryMarkAssetMissingRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DeviceRecoveryMarkAssetMissingResponseBody>(
            MarkAssetMissingAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Mark a missing asset as recovered. Provide the recovery status, reason for being missing, and optional additional details.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.RecoverAssetAsync(
    ///     new DeviceRecoveryRecoverAssetRequestBody
    ///     {
    ///         Id = "id",
    ///         MissingReason = DeviceRecoveryRecoverAssetRequestBodyMissingReason.Misplaced,
    ///         RecoveryStatus = DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus.Yes,
    ///         Status = DeviceRecoveryRecoverAssetRequestBodyStatus.Recovered,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<DeviceRecoveryRecoverAssetResponseBody> RecoverAssetAsync(
        DeviceRecoveryRecoverAssetRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DeviceRecoveryRecoverAssetResponseBody>(
            RecoverAssetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Get the current recovery state for a specific asset, including recovery photos and notification recipients.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.GetAssetRecoveryStateAsync(new GetAssetRecoveryStateRequest { Id = "id" });
    /// </code></example>
    public WithRawResponseTask<DeviceRecoveryGetAssetRecoveryStateResponseBody> GetAssetRecoveryStateAsync(
        GetAssetRecoveryStateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DeviceRecoveryGetAssetRecoveryStateResponseBody>(
            GetAssetRecoveryStateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Creates a short-lived auth token for a driver.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Driver Auth Token** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.CreateDriverAuthTokenAsync(
    ///     new DriversAuthTokenCreateDriverAuthTokenRequestBody { Code = "dp[gZc1wAigz4uGa0Hh" }
    /// );
    /// </code></example>
    public WithRawResponseTask<DriversAuthTokenCreateDriverAuthTokenResponseBody> CreateDriverAuthTokenAsync(
        DriversAuthTokenCreateDriverAuthTokenRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DriversAuthTokenCreateDriverAuthTokenResponseBody>(
            CreateDriverAuthTokenAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Lock a vehicle. This requires a vehicle gateway with locking capabilities.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.LockVehicleAsync(new LockVehicleRequest { Id = "id" });
    /// </code></example>
    public async Task LockVehicleAsync(
        LockVehicleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "preview/fleet/vehicles/{0}/lock",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
    /// Unlock a vehicle.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    /// <example><code>
    /// await client.PreviewApIs.UnlockVehicleAsync(new UnlockVehicleRequest { Id = "id" });
    /// </code></example>
    public async Task UnlockVehicleAsync(
        UnlockVehicleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "preview/fleet/vehicles/{0}/lock",
                        ValueConvert.ToPathParameterString(request.Id)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
