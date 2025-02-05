using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvBatteryVoltageMilliVolt
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Battery voltage for electric and hybrid vehicles in milli volts.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
