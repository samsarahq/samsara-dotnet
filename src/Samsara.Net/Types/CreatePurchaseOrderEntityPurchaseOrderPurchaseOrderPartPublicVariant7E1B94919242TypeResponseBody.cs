using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPart object
/// </summary>
[Serializable]
public record CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartPublicVariant7E1B94919242TypeResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Batch or lot number for the ordered part.
    /// </summary>
    [JsonPropertyName("batchNumber")]
    public string? BatchNumber { get; set; }

    [JsonPropertyName("coreCharge")]
    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeTypeResponseBody? CoreCharge { get; set; }

    /// <summary>
    /// Description of the ordered part.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Stable identifier for the purchase order line.
    /// </summary>
    [JsonPropertyName("lineItemId")]
    public string? LineItemId { get; set; }

    [JsonPropertyName("partSamsara")]
    public EntityCreatePurchaseOrderPartDefinitionRefTypeResponseBody? PartSamsara { get; set; }

    [JsonPropertyName("place")]
    public EntityCreatePurchaseOrderPlaceRefTypeResponseBody? Place { get; set; }

    /// <summary>
    /// Quantity ordered on this line.
    /// </summary>
    [JsonPropertyName("quantityOrdered")]
    public double? QuantityOrdered { get; set; }

    /// <summary>
    /// Quantity received on this line.
    /// </summary>
    [JsonPropertyName("quantityReceived")]
    public double? QuantityReceived { get; set; }

    [JsonPropertyName("unitCost")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyPublicVariant8749B9E1F4AfTypeResponseBody? UnitCost { get; set; }

    /// <summary>
    /// Unit of measure for quantities on this line.
    /// </summary>
    [JsonPropertyName("unitOfMeasureType")]
    public string? UnitOfMeasureType { get; set; }

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
