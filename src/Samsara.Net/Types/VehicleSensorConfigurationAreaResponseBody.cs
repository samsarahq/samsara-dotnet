using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A configured sensor area on the vehicle with its associated sensors
/// </summary>
[Serializable]
public record VehicleSensorConfigurationAreaResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cargoSensors")]
    public IEnumerable<SensorResponseBody>? CargoSensors { get; set; }

    [JsonPropertyName("humiditySensors")]
    public IEnumerable<SensorResponseBody>? HumiditySensors { get; set; }

    /// <summary>
    /// Position of the area on vehicle  Valid values: `back`, `front`, `middle`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationAreaResponseBodyPosition Position { get; set; }

    [JsonPropertyName("temperatureSensors")]
    public IEnumerable<SensorResponseBody>? TemperatureSensors { get; set; }

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
