using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// PartInventoryLocation object
/// </summary>
[Serializable]
public record EntityUpdatePartInventoryLocationTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Aisle within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("aisle")]
    public string? Aisle { get; set; }

    /// <summary>
    /// Quantity available to be consumed at this location (current minus reserved). Read-only; changes only via stock movements.
    /// </summary>
    [JsonPropertyName("availableQuantity")]
    public double? AvailableQuantity { get; set; }

    /// <summary>
    /// Bin within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("bin")]
    public string? Bin { get; set; }

    /// <summary>
    /// Time when the inventory level record was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Total physical quantity on hand at this location, equal to the available quantity plus the reserved quantity. Read-only; changes only via stock movements.
    /// </summary>
    [JsonPropertyName("currentQuantity")]
    public double? CurrentQuantity { get; set; }

    /// <summary>
    /// Unique identifier for the part inventory level record. The internal composite key is never exposed; identify the part and location via part ID and place ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether costing is tracked at this location. Defaults to false; once enabled it cannot be turned back off.
    /// </summary>
    [JsonPropertyName("isCostTracked")]
    public bool? IsCostTracked { get; set; }

    /// <summary>
    /// Whether the available quantity is greater than zero and at or below the reorder threshold.
    /// </summary>
    [JsonPropertyName("isLowStock")]
    public bool? IsLowStock { get; set; }

    /// <summary>
    /// Maximum quantity to keep in stock at this location.
    /// </summary>
    [JsonPropertyName("maxStockLevel")]
    public double? MaxStockLevel { get; set; }

    /// <summary>
    /// Minimum quantity to keep in stock at this location.
    /// </summary>
    [JsonPropertyName("minStockLevel")]
    public double? MinStockLevel { get; set; }

    [JsonPropertyName("partSamsara")]
    public EntityUpdatePartInventoryLocationPartDefinitionRefTypeResponseBody? PartSamsara { get; set; }

    [JsonPropertyName("place")]
    public EntityUpdatePartInventoryLocationPlaceRefTypeResponseBody? Place { get; set; }

    /// <summary>
    /// Quantity to reorder when stock reaches the reorder threshold.
    /// </summary>
    [JsonPropertyName("reorderQuantity")]
    public double? ReorderQuantity { get; set; }

    /// <summary>
    /// Available quantity at or below which the part should be reordered at this location.
    /// </summary>
    [JsonPropertyName("reorderThreshold")]
    public double? ReorderThreshold { get; set; }

    /// <summary>
    /// Quantity reserved against work orders at this location. Read-only; changes only via stock movements.
    /// </summary>
    [JsonPropertyName("reservedQuantity")]
    public double? ReservedQuantity { get; set; }

    /// <summary>
    /// Row within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("row")]
    public string? Row { get; set; }

    [JsonPropertyName("unitCost")]
    public UpdatePartInventoryLocationEntityPartInventoryLocationMoneyTypeResponseBody? UnitCost { get; set; }

    /// <summary>
    /// Unit of measure that the quantity fields on this record are expressed in. Surfaced here so the unit of all quantity fields is visible in-response.
    /// </summary>
    [JsonPropertyName("unitOfMeasureType")]
    public string? UnitOfMeasureType { get; set; }

    /// <summary>
    /// Time when the inventory level record was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

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
