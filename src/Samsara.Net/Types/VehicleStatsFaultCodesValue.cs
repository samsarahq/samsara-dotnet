using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Fault codes for the vehicle
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The CAN bus type of the vehicle.
    /// </summary>
    [JsonPropertyName("canBusType")]
    public string? CanBusType { get; set; }

    [JsonPropertyName("j1939")]
    public VehicleStatsFaultCodesValueJ1939? J1939 { get; set; }

    [JsonPropertyName("obdii")]
    public VehicleStatsFaultCodesValueObdii? Obdii { get; set; }

    [JsonPropertyName("oem")]
    public VehicleStatsFaultCodesValueOem? Oem { get; set; }

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
