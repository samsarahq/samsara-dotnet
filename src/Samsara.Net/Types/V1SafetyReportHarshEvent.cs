using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of harsh events
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
