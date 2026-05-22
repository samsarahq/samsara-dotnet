using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PreferredStationsPostPreferredStationRequestBody
{
    [JsonPropertyName("address")]
    public required PreferredStationAddressRequestBody Address { get; set; }

    /// <summary>
    /// Array of discount overrides per fuel type. Max 14 items.
    /// </summary>
    [JsonPropertyName("discounts")]
    public IEnumerable<PreferredStationDiscountInputRequestBody>? Discounts { get; set; }

    /// <summary>
    /// Map of source-system key to customer-provided station ID.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string> ExternalIds { get; set; } = new Dictionary<string, string>();

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
    /// Array of per-fuel-type prices. Max 14 items.
    /// </summary>
    [JsonPropertyName("prices")]
    public IEnumerable<PreferredStationPriceInputRequestBody>? Prices { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
