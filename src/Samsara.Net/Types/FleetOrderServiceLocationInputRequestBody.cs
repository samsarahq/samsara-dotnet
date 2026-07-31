using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Saved or one-time service location for an order task.
/// </summary>
[Serializable]
public record FleetOrderServiceLocationInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Saved address ID. Required for savedAddress locations.
    /// </summary>
    [JsonPropertyName("addressId")]
    public string? AddressId { get; set; }

    [JsonPropertyName("customAddress")]
    public FleetOrderCustomAddressInputRequestBody? CustomAddress { get; set; }

    /// <summary>
    /// Location discriminator.  Valid values: `savedAddress`, `customAddress`
    /// </summary>
    [JsonPropertyName("serviceLocationType")]
    public required FleetOrderServiceLocationInputRequestBodyServiceLocationType ServiceLocationType { get; set; }

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
