using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInput object
/// </summary>
[Serializable]
public record UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the core charge is active or removed or disabled.
    /// </summary>
    [JsonPropertyName("coreChargeStatus")]
    public required string CoreChargeStatus { get; set; }

    /// <summary>
    /// ID of the returnable core part.
    /// </summary>
    [JsonPropertyName("corePartSamsaraId")]
    public string? CorePartSamsaraId { get; set; }

    [JsonPropertyName("recoverabilityPolicy")]
    public UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBody? RecoverabilityPolicy { get; set; }

    /// <summary>
    /// ID of the vendor that receives returned cores.
    /// </summary>
    [JsonPropertyName("returnRecipientVendorId")]
    public string? ReturnRecipientVendorId { get; set; }

    [JsonPropertyName("unitCoreAmount")]
    public UpdatePurchaseOrderEntityPurchaseOrderMoneyInputTypeRequestBody? UnitCoreAmount { get; set; }

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
