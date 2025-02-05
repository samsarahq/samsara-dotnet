using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentGpsOdometerMeters
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// An approximation of odometer reading based on GPS calculations since the AG26 was activated, and a manual odometer offset provided in the Samsara cloud dashboard.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
