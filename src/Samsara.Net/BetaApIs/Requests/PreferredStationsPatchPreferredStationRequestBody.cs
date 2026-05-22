using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PreferredStationsPatchPreferredStationRequestBody
{
    /// <summary>
    /// Samsara ID of the preferred station to update.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Replaces all discount overrides. Pass empty array to remove all. Max 14 items.
    /// </summary>
    [JsonPropertyName("discounts")]
    public IEnumerable<PreferredStationDiscountInputRequestBody>? Discounts { get; set; }

    /// <summary>
    /// Replaces all per-fuel-type prices. Pass empty array to remove all. Max 14 items.
    /// </summary>
    [JsonPropertyName("prices")]
    public IEnumerable<PreferredStationPriceInputRequestBody>? Prices { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
