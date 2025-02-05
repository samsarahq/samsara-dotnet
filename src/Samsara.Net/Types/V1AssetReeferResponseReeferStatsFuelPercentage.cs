using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetReeferResponseReeferStatsFuelPercentage
{
    /// <summary>
    /// Timestamp in Unix milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

    /// <summary>
    /// Fuel percentage of the reefer.
    /// </summary>
    [JsonPropertyName("fuelPercentage")]
    public long? FuelPercentage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
