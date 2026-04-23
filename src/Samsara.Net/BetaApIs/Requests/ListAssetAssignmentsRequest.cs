using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListAssetAssignmentsRequest
{
    /// <summary>
    /// Optional boolean indicating whether to return external IDs for the referenced asset and assignee objects. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Optional comma-separated list of asset IDs to filter on. IDs may be Samsara asset IDs or external IDs in the format key:value. The response contains the union of matching assets.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional comma-separated list of assignee IDs to filter on. IDs may be Samsara assignee IDs or external IDs in the format key:value. The response contains the union of matching assignees.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssigneeIds { get; set; } = new List<string>();

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
