using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record ListReadingsDefinitionsRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A String of comma separated reading IDs. Include up to 50 readings IDs. If not set, all readings are returned.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// A list of entity type to return readings for. (Examples: asset, sensor)
    /// </summary>
    [JsonIgnore]
    public string? EntityTypes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
