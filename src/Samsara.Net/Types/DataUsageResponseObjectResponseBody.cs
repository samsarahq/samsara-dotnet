using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataUsageResponseObjectResponseBody
{
    /// <summary>
    /// Celluar data usage in bytes.
    /// </summary>
    [JsonPropertyName("cellularDataUsageBytes")]
    public long? CellularDataUsageBytes { get; set; }

    /// <summary>
    /// Wifi hotspot data usage in bytes.
    /// </summary>
    [JsonPropertyName("hotspotUsageBytes")]
    public long? HotspotUsageBytes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
