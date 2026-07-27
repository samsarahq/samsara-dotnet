using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record CreateStockMovementActionServiceCreateStockMovementRequestBody
{
    /// <summary>
    /// Batch or lot identifier the movement applies to, if the part is batch-tracked.
    /// </summary>
    [JsonPropertyName("batch")]
    public string? Batch { get; set; }

    /// <summary>
    /// Unique identifier of the place linked to the maintenance site the inventory is transferred out of. Transfer only.
    /// </summary>
    [JsonPropertyName("fromPlaceId")]
    public string? FromPlaceId { get; set; }

    /// <summary>
    /// Time when the movement occurred. Defaults to the current time if not provided.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public string? HappenedAtTime { get; set; }

    /// <summary>
    /// Type of stock movement to record. Must be one of Receive, Transfer, Scrap, or Adjust; Unknown is rejected.
    /// </summary>
    [JsonPropertyName("movementType")]
    public required string MovementType { get; set; }

    /// <summary>
    /// Notes explaining the movement. Scrap and adjust only.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Unique identifier of the part definition the movement applies to.
    /// </summary>
    [JsonPropertyName("partSamsaraId")]
    public required string PartSamsaraId { get; set; }

    /// <summary>
    /// Unique identifier of the place linked to the maintenance site the movement targets. Required for receive, scrap, and adjust; rejected for transfer (use fromPlaceId and toPlaceId).
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Purchase order reference for the received inventory. Receive only.
    /// </summary>
    [JsonPropertyName("purchaseOrder")]
    public string? PurchaseOrder { get; set; }

    /// <summary>
    /// Quantity moved, in the part's unit of measure. Positive magnitude for receive, transfer, and scrap; signed delta for adjust.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; set; }

    /// <summary>
    /// Unique identifier of the place linked to the maintenance site the inventory is transferred into. Transfer only.
    /// </summary>
    [JsonPropertyName("toPlaceId")]
    public string? ToPlaceId { get; set; }

    [JsonPropertyName("unitCost")]
    public EntityCreateStockMovementMoneyInputTypeRequestBody? UnitCost { get; set; }

    /// <summary>
    /// Unique identifier of the vendor the inventory was received from. Receive only.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
