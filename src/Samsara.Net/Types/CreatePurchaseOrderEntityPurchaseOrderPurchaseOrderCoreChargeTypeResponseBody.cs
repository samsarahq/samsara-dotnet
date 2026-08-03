using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreCharge object
/// </summary>
[Serializable]
public record CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the core charge is active or removed or disabled.
    /// </summary>
    [JsonPropertyName("coreChargeStatus")]
    public string? CoreChargeStatus { get; set; }

    [JsonPropertyName("corePartSamsara")]
    public EntityCreatePurchaseOrderPartDefinitionRefTypeResponseBody? CorePartSamsara { get; set; }

    [JsonPropertyName("recoverabilityPolicy")]
    public CreatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBody? RecoverabilityPolicy { get; set; }

    [JsonPropertyName("returnRecipientVendor")]
    public EntityCreatePurchaseOrderVendorRefTypeResponseBody? ReturnRecipientVendor { get; set; }

    [JsonPropertyName("unitCoreAmount")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyTypeResponseBody? UnitCoreAmount { get; set; }

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
