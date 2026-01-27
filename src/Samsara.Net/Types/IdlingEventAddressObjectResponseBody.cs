using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The geofence address associated with the idling event, if applicable.
/// </summary>
[Serializable]
public record IdlingEventAddressObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The types of the geofence address of the idling location. An address can have multiple types.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<IdlingEventAddressObjectResponseBodyAddressTypesItem>? AddressTypes { get; set; }

    /// <summary>
    /// A map of external ids for the address.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The ID of the geofence address of the idling location. It will be the address at the time of idling.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
