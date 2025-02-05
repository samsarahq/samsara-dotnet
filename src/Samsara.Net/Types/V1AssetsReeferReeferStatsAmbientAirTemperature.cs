using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1AssetsReeferReeferStatsAmbientAirTemperature
{
    /// <summary>
    /// Timestamp in Unix milliseconds since epoch.
    /// </summary>
    [JsonPropertyName("changedAtMs")]
    public long? ChangedAtMs { get; set; }

    /// <summary>
    /// Ambient temperature in millidegree Celsius.
    /// </summary>
    [JsonPropertyName("tempInMilliC")]
    public long? TempInMilliC { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
