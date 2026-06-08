using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains information about a sensor.
/// </summary>
[Serializable]
public record V1Sensor : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Sensor activation time in Unix milliseconds. Null if the sensor has no monitor.
    /// </summary>
    [JsonPropertyName("activatedAtMs")]
    public long? ActivatedAtMs { get; set; }

    /// <summary>
    /// Current sensor health status.
    /// </summary>
    [JsonPropertyName("healthStatus")]
    public string? HealthStatus { get; set; }

    /// <summary>
    /// ID of the sensor.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Last sensor transmission time in Unix milliseconds. Null when the sensor is connected or has never connected.
    /// </summary>
    [JsonPropertyName("lastTransmissionAtMs")]
    public long? LastTransmissionAtMs { get; set; }

    /// <summary>
    /// MAC address of the sensor.
    /// </summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>
    /// Name of the sensor.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Product type of the sensor.
    /// </summary>
    [JsonPropertyName("sensorType")]
    public string? SensorType { get; set; }

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
