using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvStateOfChargeMilliPercent
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Milli percent State of Charge for electric and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
