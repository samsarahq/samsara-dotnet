using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInput object
/// </summary>
[Serializable]
public record CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputTypeRequestBody
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
    public CreatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBody? CoreCharge { get; set; }

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

    /// <summary>
    /// ID of the part definition ordered on this line.
    /// </summary>
    [JsonPropertyName("partSamsaraId")]
    public required string PartSamsaraId { get; set; }

    /// <summary>
    /// Place linked to the maintenance site holding this line's inventory. The internal location identifier is never exposed.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Quantity ordered on this line.
    /// </summary>
    [JsonPropertyName("quantityOrdered")]
    public required double QuantityOrdered { get; set; }

    /// <summary>
    /// Quantity received on this line.
    /// </summary>
    [JsonPropertyName("quantityReceived")]
    public required double QuantityReceived { get; set; }

    [JsonPropertyName("unitCost")]
    public CreatePurchaseOrderEntityPurchaseOrderMoneyInputTypeRequestBody? UnitCost { get; set; }

    /// <summary>
    /// Unit of measure for quantities on this line.
    /// </summary>
    [JsonPropertyName("unitOfMeasureType")]
    public required string UnitOfMeasureType { get; set; }

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
