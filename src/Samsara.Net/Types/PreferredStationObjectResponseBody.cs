using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A preferred fuel station.
/// </summary>
[Serializable]
public record PreferredStationObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("address")]
    public PreferredStationAddressResponseResponseBody? Address { get; set; }

    /// <summary>
    /// Discount overrides per fuel type.
    /// </summary>
    [JsonPropertyName("discounts")]
    public IEnumerable<PreferredStationDiscountResponseResponseBody>? Discounts { get; set; }

    /// <summary>
    /// External IDs for this station.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Samsara-assigned station ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Latitude in WGS84 degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude in WGS84 degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Display name of the station.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Per-fuel-type prices.
    /// </summary>
    [JsonPropertyName("prices")]
    public IEnumerable<PreferredStationPriceResponseResponseBody>? Prices { get; set; }

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
