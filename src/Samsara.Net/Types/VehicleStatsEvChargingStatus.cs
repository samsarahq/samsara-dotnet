using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsEvChargingStatus
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Charging status for electric and hybrid vehicles. Statuses:
    ///  unknown - 0,
    ///  not charging - 1,
    ///  charging - 2.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
