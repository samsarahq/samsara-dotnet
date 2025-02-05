using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvAverageBatteryTemperatureMilliCelsiusWithDecoration
{
    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Battery temperature for electric and hybrid vehicles in milli celsius.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
