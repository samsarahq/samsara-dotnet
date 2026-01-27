using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A door monitor configuration on a vehicle
/// </summary>
[Serializable]
public record VehicleSensorConfigurationDoorResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Position of the door monitor on the vehicle  Valid values: `back`, `left`, `right`
    /// </summary>
    [JsonPropertyName("position")]
    public required VehicleSensorConfigurationDoorResponseBodyPosition Position { get; set; }

    [JsonPropertyName("sensor")]
    public required SensorResponseBody Sensor { get; set; }

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
