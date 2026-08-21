using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreatePurchaseOrderEntityPurchaseOrderTaxAdjustmentInput object
/// </summary>
[Serializable]
public record CreatePurchaseOrderEntityPurchaseOrderTaxAdjustmentInputTypeRequestBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Tax rate in basis points. Set exactly one of money or basisPoints.
    /// </summary>
    [JsonPropertyName("basisPoints")]
    public long? BasisPoints { get; set; }

    [JsonPropertyName("money")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyInputTypeRequestBody? Money { get; set; }

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
