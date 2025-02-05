using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsEngineHours
{
    /// <summary>
    /// Timestamp in Unix milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

    /// <summary>
    /// Engine hours of the reefer.
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
