using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1CargoResponseSensors : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Flag indicating whether the current cargo is empty or loaded.
    /// </summary>
    [JsonPropertyName("cargoEmpty")]
    public bool? CargoEmpty { get; set; }

    /// <summary>
    /// The timestamp of reported cargo status, specified in RFC 3339 time.
    /// </summary>
    [JsonPropertyName("cargoStatusTime")]
    public string? CargoStatusTime { get; set; }

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
    /// The distance between red eye detector and the closest object in cm.
    /// </summary>
    [JsonPropertyName("redEyeDistance")]
    public long? RedEyeDistance { get; set; }

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
