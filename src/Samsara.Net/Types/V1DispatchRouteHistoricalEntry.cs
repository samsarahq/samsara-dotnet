using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchRouteHistoricalEntry
{
    /// <summary>
    /// Timestamp that the route was updated, represented as Unix milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("changed_at_ms")]
    public long? ChangedAtMs { get; set; }

    [JsonPropertyName("route")]
    public V1DispatchRoute? Route { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
