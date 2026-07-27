using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityPartInventoryLocationsServiceCreatePartInventoryLocationRequestBody
{
    /// <summary>
    /// Unique identifier for the part definition these inventory levels are tracked for.
    /// </summary>
    [JsonIgnore]
    public string? PartSamsaraId { get; set; }

    /// <summary>
    /// Unique identifier for the place linked to the maintenance site holding this inventory. The internal location identifier is never exposed.
    /// </summary>
    [JsonIgnore]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Aisle within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("aisle")]
    public string? Aisle { get; set; }

    /// <summary>
    /// Bin within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("bin")]
    public string? Bin { get; set; }

    /// <summary>
    /// Total physical quantity on hand at this location, equal to the available quantity plus the reserved quantity. Read-only; changes only via stock movements.
    /// </summary>
    [JsonPropertyName("currentQuantity")]
    public double? CurrentQuantity { get; set; }

    /// <summary>
    /// Whether costing is tracked at this location. Defaults to false; once enabled it cannot be turned back off.
    /// </summary>
    [JsonPropertyName("isCostTracked")]
    public bool? IsCostTracked { get; set; }

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
    /// Row within the location where the part is stored.
    /// </summary>
    [JsonPropertyName("row")]
    public string? Row { get; set; }

    [JsonPropertyName("unitCost")]
    public CreatePartInventoryLocationEntityPartInventoryLocationMoneyInputTypeRequestBody? UnitCost { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
