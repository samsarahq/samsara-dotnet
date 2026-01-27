using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of harsh events
/// </summary>
[Serializable]
public record V1SafetyReportHarshEvent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Sensor generated harsh event type.
    /// </summary>
    [JsonPropertyName("harshEventType")]
    public string? HarshEventType { get; set; }

    /// <summary>
    /// Timestamp that the harsh event occurred in Unix milliseconds since epoch
    /// </summary>
    [JsonPropertyName("timestampMs")]
    public long? TimestampMs { get; set; }

    /// <summary>
    /// Vehicle associated with the harsh event
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public long? VehicleId { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
