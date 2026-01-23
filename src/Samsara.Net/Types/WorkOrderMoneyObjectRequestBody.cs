using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A specified amount of money.
/// </summary>
[Serializable]
public record WorkOrderMoneyObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Amount of the currency.
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    /// <summary>
    /// Type of the currency. We currently only support usd.  Valid values: `usd`
    /// </summary>
    [JsonPropertyName("currency")]
    public required WorkOrderMoneyObjectRequestBodyCurrency Currency { get; set; }

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
