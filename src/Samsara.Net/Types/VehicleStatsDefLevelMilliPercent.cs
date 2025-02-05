using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsDefLevelMilliPercent
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The Diesel Exhaust Fluid (DEF) level in milli percentage points (e.g. `99001`, `49999`, etc).
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
