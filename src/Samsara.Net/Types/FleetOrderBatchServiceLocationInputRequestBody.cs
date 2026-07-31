using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Saved or one-time service location for an order task. The discriminator and matching branch are validated per batch item.
/// </summary>
[Serializable]
public record FleetOrderBatchServiceLocationInputRequestBody : IJsonOnDeserialized
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
    public FleetOrderBatchCustomAddressInputRequestBody? CustomAddress { get; set; }

    /// <summary>
    /// Location discriminator. Required; must be savedAddress or customAddress.
    /// </summary>
    [JsonPropertyName("serviceLocationType")]
    public string? ServiceLocationType { get; set; }

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
