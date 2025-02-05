using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvBatteryCurrentMilliAmp
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Battery current for electric and hybrid vehicles in milli amps.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
