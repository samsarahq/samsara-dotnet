using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEngineLoadPercent
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The engine load in percentage points (e.g. `99`, `50`, etc).
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
