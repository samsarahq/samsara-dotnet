using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreCharge object
/// </summary>
[Serializable]
public record ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the core charge is active or removed or disabled.  Valid values: `Unknown`, `Active`, `RemovedOrDisabled`
    /// </summary>
    [JsonPropertyName("coreChargeStatus")]
    public ListPurchaseOrdersEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBodyCoreChargeStatus? CoreChargeStatus { get; set; }

    [JsonPropertyName("corePartSamsara")]
    public EntityListPurchaseOrdersPartDefinitionRefTypeResponseBody? CorePartSamsara { get; set; }

    [JsonPropertyName("recoverabilityPolicy")]
    public ListPurchaseOrdersEntityPurchaseOrderCoreRecoverabilityPolicyTypeResponseBody? RecoverabilityPolicy { get; set; }

    [JsonPropertyName("returnRecipientVendor")]
    public EntityListPurchaseOrdersVendorRefTypeResponseBody? ReturnRecipientVendor { get; set; }

    [JsonPropertyName("unitCoreAmount")]
    public ListPurchaseOrdersEntityPurchaseOrderMoneyTypeResponseBody? UnitCoreAmount { get; set; }

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
