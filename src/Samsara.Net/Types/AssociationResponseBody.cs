using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An association between a vehicle (central device) and a peripheral device.
/// </summary>
[Serializable]
public record AssociationResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The time when this association ended, in RFC 3339 format. Null if the association is still active.
    /// </summary>
    [JsonPropertyName("associationEndTime")]
    public string? AssociationEndTime { get; set; }

    /// <summary>
    /// The time when this association started, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("associationStartTime")]
    public required string AssociationStartTime { get; set; }

    /// <summary>
    /// The Samsara ID of the peripheral device in this association.
    /// </summary>
    [JsonPropertyName("peripheralId")]
    public required string PeripheralId { get; set; }

    /// <summary>
    /// The human-readable name of the peripheral device, if available.
    /// </summary>
    [JsonPropertyName("peripheralName")]
    public string? PeripheralName { get; set; }

    /// <summary>
    /// The Samsara ID of the vehicle (central device) in this association.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

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
