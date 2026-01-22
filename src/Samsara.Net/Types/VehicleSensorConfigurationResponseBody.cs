using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The sensors configured on a vehicle
/// </summary>
[Serializable]
public record VehicleSensorConfigurationResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Configured sensor areas on the vehicle with its associated sensors
    /// </summary>
    [JsonPropertyName("areas")]
    public IEnumerable<VehicleSensorConfigurationAreaResponseBody>? Areas { get; set; }

    /// <summary>
    /// Configured door monitors on the vehicle
    /// </summary>
    [JsonPropertyName("doors")]
    public IEnumerable<VehicleSensorConfigurationDoorResponseBody>? Doors { get; set; }

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
