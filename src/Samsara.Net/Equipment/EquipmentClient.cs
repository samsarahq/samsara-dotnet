using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Equipment.Locations;
using Samsara.Net.Equipment.Stats;

namespace Samsara.Net.Equipment;

public partial class EquipmentClient
{
    private RawClient _client;

    internal EquipmentClient(RawClient client)
    {
        _client = client;
        Locations = new LocationsClient(_client);
        Stats = new StatsClient(_client);
    }

    public LocationsClient Locations { get; }

    public StatsClient Stats { get; }

    /// <summary>
    /// Returns a list of all equipment in an organization.
    /// </summary>
    private async Task<EquipmentListResponse> ListInternalAsync(
        EquipmentListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["parentTagIds"] = request.ParentTagIds;
        _query["tagIds"] = request.TagIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.After != null)
        {
            _query["after"] = request.After;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "fleet/equipment",
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
                return JsonUtils.Deserialize<EquipmentListResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
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
    /// Returns a list of all equipment in an organization.
    /// </summary>
    /// <example><code>
    /// await client.Equipment.ListAsync(new EquipmentListRequest());
    /// </code></example>
    public async Task<Pager<EquipmentObject>> ListAsync(
        EquipmentListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            EquipmentListRequest,
            RequestOptions?,
            EquipmentListResponse,
            string,
            EquipmentObject
        >
            .CreateInstanceAsync(
                request,
                options,
                ListInternalAsync,
                (request, cursor) =>
                {
                    request.After = cursor;
                },
                response => response?.Pagination?.EndCursor,
                response => response?.Data?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Retrieves the unit of equipment with the given Samsara ID.
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our &lt;a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank"&gt;API feedback form&lt;/a&gt;. If you encountered an issue or noticed inaccuracies in the API documentation, please &lt;a href="https://www.samsara.com/help" target="_blank"&gt;submit a case&lt;/a&gt; to our support team.
    ///
    /// To use this endpoint, select **Read Equipment** under the Equipment category when creating or editing an API token. &lt;a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank"&gt;Learn More.&lt;/a&gt;
    /// </summary>
    /// <example><code>
    /// await client.Equipment.GetAsync("id");
    /// </code></example>
    public async Task<EquipmentResponse> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "fleet/equipment/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
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
                return JsonUtils.Deserialize<EquipmentResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SamsaraClientException("Failed to deserialize response", e);
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
}
