using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderAirTemp
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Air (ambient) temperature in milli celsius reading from material spreader.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
