using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A door monitor configuration for a vehicle
/// </summary>
[Serializable]
public record VehicleSensorConfigurationDoor : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Position of the door monitor on the vehicle
    /// </summary>
    [JsonPropertyName("position")]
    public VehicleSensorConfigurationDoorPosition? Position { get; set; }

    [JsonPropertyName("sensor")]
    public Sensor? Sensor { get; set; }

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
