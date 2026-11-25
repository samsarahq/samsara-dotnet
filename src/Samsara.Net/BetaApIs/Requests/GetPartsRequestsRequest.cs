using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetPartsRequestsRequest
{
    /// <summary>
    /// Comma-separated list of parts request IDs to filter by. Maximum number of IDs: 1. Returns all lines of the requested parts request on one page, including closed and cancelled lines. Returns 404 Not Found when the parts request does not exist.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Comma-separated list of work order IDs to filter by. Maximum number of IDs: 100. Returns only lines linked to these work orders. Cannot be combined with `ids`; supplying both returns 400 Bad Request.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> WorkOrderIds { get; set; } = new List<string>();

    /// <summary>
    /// Comma-separated list of maintenance site IDs, as returned by GET /maintenance/sites. Returns only lines requested by these maintenance sites. When omitted or empty, returns lines from all maintenance sites you have permission to access.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> MaintenanceSiteIds { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
