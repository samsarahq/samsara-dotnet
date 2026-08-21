using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInput object
/// </summary>
[Serializable]
public record UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBody
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
    public UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderCoreChargeInputTypeRequestBody? CoreCharge { get; set; }

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

    [JsonPropertyName("tax")]
    public UpdatePurchaseOrderEntityPurchaseOrderTaxAdjustmentInputTypeRequestBody? Tax { get; set; }

    [JsonPropertyName("unitCost")]
    public UpdatePurchaseOrderEntityPurchaseOrderMoneyInputPublicVarianta34Bfd5A4152TypeRequestBody? UnitCost { get; set; }

    /// <summary>
    /// Unit of measure for quantities on this line.  Valid values: `Unknown`, `Each`, `Set`, `Pack`, `Box`, `Pound`, `Kilogram`, `Ounce`, `Liter`, `Milliliter`, `Gallon`, `Quart`, `FluidOunce`, `Inch`, `Foot`, `Meter`, `Yard`, `SquareFoot`, `SquareMeter`, `Pint`, `Hundred`, `Roll`
    /// </summary>
    [JsonPropertyName("unitOfMeasureType")]
    public required UpdatePurchaseOrderEntityPurchaseOrderPurchaseOrderPartInputPublicVariant1A94E81632EaTypeRequestBodyUnitOfMeasureType UnitOfMeasureType { get; set; }

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
