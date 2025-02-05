using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsAlarms1
{
    [JsonPropertyName("alarms")]
    public IEnumerable<V1AssetReeferResponseReeferStatsAlarms>? Alarms { get; set; }

    /// <summary>
    /// Timestamp when the alarms were reported, in Unix milliseconds since epoch
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
