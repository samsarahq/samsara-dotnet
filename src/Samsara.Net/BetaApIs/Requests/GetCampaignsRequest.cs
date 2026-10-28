using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetCampaignsRequest
{
    /// <summary>
    /// Comma-separated list of campaign IDs to filter by. Up to 100 ids. Returns all campaigns, paginated, when omitted. Returns 404 Not Found when none of the requested ids resolve to a campaign; ids that do not resolve (e.g. deleted) are otherwise omitted from the response.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

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
