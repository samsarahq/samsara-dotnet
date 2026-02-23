using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.CarrierProposedAssignments;

public partial class CarrierProposedAssignmentsClient : ICarrierProposedAssignmentsClient
{
    private RawClient _client;

    internal CarrierProposedAssignmentsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<ListCarrierProposedAssignmentResponse>
    > ListCarrierProposedAssignmentsAsyncCore(
        ListCarrierProposedAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Samsara.Net.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("limit", request.Limit)
            .Add("after", request.After)
            .Add("driverIds", request.DriverIds)
            .Add("activeTime", request.ActiveTime)
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
                    Path = "fleet/carrier-proposed-assignments",
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
                var responseData = JsonUtils.Deserialize<ListCarrierProposedAssignmentResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ListCarrierProposedAssignmentResponse>()
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
        WithRawResponse<CarrierProposedAssignmentResponse>
    > CreateCarrierProposedAssignmentAsyncCore(
        CreateCarrierProposedAssignmentRequest request,
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
                    Path = "fleet/carrier-proposed-assignments",
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
                var responseData = JsonUtils.Deserialize<CarrierProposedAssignmentResponse>(
                    responseBody
                )!;
                return new WithRawResponse<CarrierProposedAssignmentResponse>()
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
    /// Show the assignments created by the POST fleet/carrier-proposed-assignments. This endpoint will only show the assignments that are active for drivers and currently visible to them in the driver app. Once a proposed assignment has been accepted, the endpoint will not return any data.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Read Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    /// <example><code>
    /// await client.CarrierProposedAssignments.ListCarrierProposedAssignmentsAsync(
    ///     new ListCarrierProposedAssignmentsRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<ListCarrierProposedAssignmentResponse> ListCarrierProposedAssignmentsAsync(
        ListCarrierProposedAssignmentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ListCarrierProposedAssignmentResponse>(
            ListCarrierProposedAssignmentsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Creates a new assignment that a driver can later use. Each driver can only have one future assignment.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    /// </summary>
    /// <example><code>
    /// await client.CarrierProposedAssignments.CreateCarrierProposedAssignmentAsync(
    ///     new CreateCarrierProposedAssignmentRequest { DriverId = "42", VehicleId = "123" }
    /// );
    /// </code></example>
    public WithRawResponseTask<CarrierProposedAssignmentResponse> CreateCarrierProposedAssignmentAsync(
        CreateCarrierProposedAssignmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CarrierProposedAssignmentResponse>(
            CreateCarrierProposedAssignmentAsyncCore(request, options, cancellationToken)
        );
    }
}
