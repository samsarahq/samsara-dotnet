using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvConsumedEnergyMicroWhWithDecoration
{
    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Consumed energy (including regenerated) for electric and hybrid vehicles in microwatt hours.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
