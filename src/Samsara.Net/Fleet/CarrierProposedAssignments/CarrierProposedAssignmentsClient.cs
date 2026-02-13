using System.Text.Json;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Fleet.CarrierProposedAssignments;

public partial class CarrierProposedAssignmentsClient : ICarrierProposedAssignmentsClient
{
    private RawClient _client;

    internal CarrierProposedAssignmentsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<WithRawResponse<string>> DeleteAsyncCore(
        string id,
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
                        "fleet/carrier-proposed-assignments/{0}",
                        ValueConvert.ToPathParameterString(id)
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
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
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
    /// Permanently delete an assignment. You can only delete assignments that are not yet active. To override a currently active assignment, create a new empty one, instead.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    ///
    /// To use this endpoint, select **Write Carrier-Proposed Assignments** under the Assignments category when creating or editing an API token. [Learn More.](/docs/authentication#scopes-for-api-tokens)
    /// </summary>
    /// <example><code>
    /// await client.Fleet.CarrierProposedAssignments.DeleteAsync("id");
    /// </code></example>
    public WithRawResponseTask<string> DeleteAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(DeleteAsyncCore(id, options, cancellationToken));
    }
}
