using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1TemperatureResponseSensors : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Currently reported ambient temperature in millidegrees celsius.
    /// </summary>
    [JsonPropertyName("ambientTemperature")]
    public long? AmbientTemperature { get; set; }

    /// <summary>
    /// The timestamp of reported ambient temperature, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("ambientTemperatureTime")]
    public string? AmbientTemperatureTime { get; set; }

    /// <summary>
    /// ID of the sensor.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Name of the sensor.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Currently reported probe temperature in millidegrees celsius. If no probe is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("probeTemperature")]
    public long? ProbeTemperature { get; set; }

    /// <summary>
    /// The timestamp of reported probe temperature, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("probeTemperatureTime")]
    public string? ProbeTemperatureTime { get; set; }

    /// <summary>
    /// ID of the trailer associated with the sensor for the data point. If no trailer is connected, this parameter will not be reported.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public long? TrailerId { get; set; }

    /// <summary>
    /// ID of the vehicle associated with the sensor for the data point. If no vehicle is connected, this parameter will not be reported.
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
