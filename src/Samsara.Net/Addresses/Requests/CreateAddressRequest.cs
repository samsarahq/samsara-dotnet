using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Addresses;

public record CreateAddressRequest
{
    /// <summary>
    /// Reporting location type associated with the address (used for ELD reporting purposes). Valid values: `yard`, `shortHaul`, `workforceSite`, `riskZone`, `industrialSite`, `alertsOnly`, `agricultureSource`.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<CreateAddressRequestAddressTypesItem>? AddressTypes { get; set; }

    /// <summary>
    /// An array of Contact IDs associated with this Address.
    /// </summary>
    [JsonPropertyName("contactIds")]
    public IEnumerable<string>? ContactIds { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The full street address for this address/geofence, as it might be recognized by Google Maps.
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public required string FormattedAddress { get; set; }

    [JsonPropertyName("geofence")]
    public required CreateAddressRequestGeofence Geofence { get; set; }

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
    /// An array of IDs of tags to associate with this address.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
