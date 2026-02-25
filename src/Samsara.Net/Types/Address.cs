using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An Address object.
/// </summary>
[Serializable]
public record Address : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Reporting location type associated with the address (used for ELD reporting purposes). Valid values: `yard`, `shortHaul`, `workforceSite`, `riskZone`, `industrialSite`, `alertsOnly`, `agricultureSource`, `avoidanceZone`, `knownGPSJammingZone`, `authorizedZone`, `unauthorizedZone`, `vendor`, `inventory`.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<AddressAddressTypesItem>? AddressTypes { get; set; }

    /// <summary>
    /// An array Contact mini-objects that are associated the Address.
    /// </summary>
    [JsonPropertyName("contacts")]
    public IEnumerable<ContactTinyResponse>? Contacts { get; set; }

    /// <summary>
    /// The date and time this address was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public DateTime? CreatedAtTime { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public AddressExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// The full street address for this address/geofence, as it might be recognized by Google Maps.
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public required string FormattedAddress { get; set; }

    [JsonPropertyName("geofence")]
    public required AddressGeofence Geofence { get; set; }

    /// <summary>
    /// ID of the Address.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Latitude of the address. Will be geocoded from `formattedAddress` if not provided.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the address. Will be geocoded from `formattedAddress` if not provided.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Name of the address.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes about the address.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// An array of all tag mini-objects that are associated with the given address entry.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<TagTinyResponse>? Tags { get; set; }

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
