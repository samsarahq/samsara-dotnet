using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetQualificationTypesRequest
{
    /// <summary>
    /// String of entity type.  Valid values: `worker`, `asset`
    /// </summary>
    [JsonIgnore]
    public required GetQualificationTypesRequestEntityType EntityType { get; set; }

    /// <summary>
    /// Optional comma-separated list containing up to 100 qualification type IDs to filter on. If no IDs are provided, all qualification types will be returned.
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
