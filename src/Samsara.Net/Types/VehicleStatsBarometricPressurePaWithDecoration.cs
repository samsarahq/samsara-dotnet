using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsBarometricPressurePaWithDecoration
{
    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The barometric pressure reading in pascals.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
