using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A one-time structured service address. Coordinate ranges are validated per batch item.
/// </summary>
[Serializable]
public record FleetOrderBatchCustomAddressInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// First address line.
    /// </summary>
    [JsonPropertyName("addressLine1")]
    public string? AddressLine1 { get; set; }

    /// <summary>
    /// Second address line.
    /// </summary>
    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Human-readable formatted address.
    /// </summary>
    [JsonPropertyName("formattedAddress")]
    public string? FormattedAddress { get; set; }

    /// <summary>
    /// Latitude in decimal degrees. Must be between -90 and 90.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude in decimal degrees. Must be between -180 and 180.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// State, province, or region.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

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
