using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Price per quantity unit in the organization's currency. Rates can include fractional cents; round the extended line amount once to cents.
/// </summary>
[Serializable]
public record MaintenanceEstimateUnitRateResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Nonnegative decimal unit price, with up to six fractional digits. Signs, exponents and grouping separators are not accepted.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    /// <summary>
    /// Three-letter ISO 4217 currency code. Must match the organization's current currency and the line amount.  Valid values: `usd`, `gbp`, `cad`, `eur`, `chf`, `mxn`
    /// </summary>
    [JsonPropertyName("currency")]
    public required MaintenanceEstimateUnitRateResponseBodyCurrency Currency { get; set; }

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
