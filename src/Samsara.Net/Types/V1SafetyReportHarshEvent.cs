using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1SafetyReportHarshEvent
{
    /// <summary>
    /// Sensor generated harsh event type.
    /// </summary>
    [JsonPropertyName("harshEventType")]
    public string? HarshEventType { get; set; }

    /// <summary>
    /// Timestamp that the harsh event occurred in Unix milliseconds since epoch
    /// </summary>
    [JsonPropertyName("timestampMs")]
    public int? TimestampMs { get; set; }

    /// <summary>
    /// Vehicle associated with the harsh event
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public int? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
