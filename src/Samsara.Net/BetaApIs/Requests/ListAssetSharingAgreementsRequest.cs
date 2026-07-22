using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListAssetSharingAgreementsRequest
{
    /// <summary>
    /// Comma-separated list of agreement IDs to filter by.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Comma-separated list of statuses to filter by. Valid values: pending, accepted, rejected, canceled.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> StatusIn { get; set; } = new List<string>();

    /// <summary>
    /// Comma-separated list of roles to filter by. Valid values: provider, recipient.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> RoleIn { get; set; } = new List<string>();

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
