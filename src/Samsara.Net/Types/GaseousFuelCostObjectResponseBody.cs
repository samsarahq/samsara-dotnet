using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The cost incurred based on the gaseous fuel consumed during the idling event.
/// </summary>
[Serializable]
public record GaseousFuelCostObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The money amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    /// <summary>
    /// The currency of money. This is a 3-letter ISO 4217 currency code.  Valid values: `usd`, `gbp`, `cad`, `eur`, `chf`, `mxn`
    /// </summary>
    [JsonPropertyName("currency")]
    public required GaseousFuelCostObjectResponseBodyCurrency Currency { get; set; }

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
