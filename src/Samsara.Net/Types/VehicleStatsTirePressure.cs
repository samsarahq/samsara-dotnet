using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsTirePressure
{
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("value")]
    public VehicleStatsTirePressures? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
