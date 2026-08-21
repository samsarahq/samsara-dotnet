using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreCharge object
/// </summary>
[Serializable]
public record UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the core charge is active or removed or disabled.  Valid values: `Unknown`, `Active`, `RemovedOrDisabled`
    /// </summary>
    [JsonPropertyName("coreChargeStatus")]
    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus? CoreChargeStatus { get; set; }

    [JsonPropertyName("corePartSamsara")]
    public EntityUpdatePurchaseOrderPartDefinitionRefTypeResponseBody? CorePartSamsara { get; set; }

    [JsonPropertyName("recoverabilityPolicy")]
    public UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBody? RecoverabilityPolicy { get; set; }

    [JsonPropertyName("returnRecipientVendor")]
    public EntityUpdatePurchaseOrderVendorRefTypeResponseBody? ReturnRecipientVendor { get; set; }

    [JsonPropertyName("unitCoreAmount")]
    public UpdatePurchaseOrderEntityPurchaseOrderMoneyTypeResponseBody? UnitCoreAmount { get; set; }

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
