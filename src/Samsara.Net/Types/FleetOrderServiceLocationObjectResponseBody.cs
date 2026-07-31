using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A saved, one-time, or unknown task service location.
/// </summary>
[Serializable]
public record FleetOrderServiceLocationObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Saved address ID.
    /// </summary>
    [JsonPropertyName("addressId")]
    public string? AddressId { get; set; }

    [JsonPropertyName("customAddress")]
    public FleetOrderCustomAddressObjectResponseBody? CustomAddress { get; set; }

    /// <summary>
    /// Location discriminator. Returns unknown when the backend location variant is not recognized.  Valid values: `unknown`, `savedAddress`, `customAddress`
    /// </summary>
    [JsonPropertyName("serviceLocationType")]
    public required FleetOrderServiceLocationObjectResponseBodyServiceLocationType ServiceLocationType { get; set; }

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
