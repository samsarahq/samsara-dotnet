using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvDistanceDrivenMeters
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Electric distance driven for electric and hybrid vehicles in meters.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
