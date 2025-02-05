using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEngineState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    [JsonPropertyName("value")]
    public required VehicleStatsEngineStateSetting Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
