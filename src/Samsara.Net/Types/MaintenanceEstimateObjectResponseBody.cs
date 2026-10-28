using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A priced vendor recommendation or quote for one work order.
/// </summary>
[Serializable]
public record MaintenanceEstimateObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Authority for the current approval state. Defaults to none.  Valid values: `unknown`, `none`, `policy`, `samsara`
    /// </summary>
    [JsonPropertyName("approvalSource")]
    public required MaintenanceEstimateObjectResponseBodyApprovalSource ApprovalSource { get; set; }

    /// <summary>
    /// Approval state. Vendor quotes default to unapproved; expectedCost recommendations report unknown until conversion, or cancelled after cancellation. Approval and award are separate operations.  Valid values: `unknown`, `unapproved`, `pending`, `approved`, `denied`, `cancelled`
    /// </summary>
    [JsonPropertyName("approvalStatus")]
    public required MaintenanceEstimateObjectResponseBodyApprovalStatus ApprovalStatus { get; set; }

    /// <summary>
    /// Quote documents. API additions enforce a 50-file WO admission limit against observed files and pending API reservations.
    /// </summary>
    [JsonPropertyName("attachments")]
    public IEnumerable<MaintenanceEstimateAttachmentResponseBody> Attachments { get; set; } =
        new List<MaintenanceEstimateAttachmentResponseBody>();

    /// <summary>
    /// Server creation time.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Whether this estimate is a recommendation or a vendor quote. Omitted create values default to vendorQuote. Unknown represents an unrecognized type.  Valid values: `unknown`, `expectedCost`, `vendorQuote`
    /// </summary>
    [JsonPropertyName("estimateType")]
    public required MaintenanceEstimateObjectResponseBodyEstimateType EstimateType { get; set; }

    /// <summary>
    /// Estimate external identifiers. Responses include these only when includeExternalIds=true; default omitted.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("externalRequest")]
    public MaintenanceEstimateExternalRequestResponseBody? ExternalRequest { get; set; }

    /// <summary>
    /// Stable estimate ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether this exact vendor quote has been awarded for the WO. Defaults to false; recommendation selection and approval do not award.
    /// </summary>
    [JsonPropertyName("isAwarded")]
    public required bool IsAwarded { get; set; }

    /// <summary>
    /// Up to 200 priced lines; incomplete dashboard quotes may have no lines.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public IEnumerable<MaintenanceEstimateLineItemResponseBody> LineItems { get; set; } =
        new List<MaintenanceEstimateLineItemResponseBody>();

    /// <summary>
    /// Additional notes, at most 4000 Unicode characters.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Actual instant the vendor issued the quote; omit when only a date is known.
    /// </summary>
    [JsonPropertyName("quotedAtTime")]
    public DateTime? QuotedAtTime { get; set; }

    [JsonPropertyName("subtotal")]
    public MaintenanceEstimateMoneyResponseBody? Subtotal { get; set; }

    /// <summary>
    /// Successor estimate; a superseded quote is historical.
    /// </summary>
    [JsonPropertyName("supersededByEstimateId")]
    public string? SupersededByEstimateId { get; set; }

    /// <summary>
    /// Previous denied estimate replaced by this new quote.
    /// </summary>
    [JsonPropertyName("supersedesEstimateId")]
    public string? SupersedesEstimateId { get; set; }

    [JsonPropertyName("tax")]
    public MaintenanceEstimateMoneyResponseBody? Tax { get; set; }

    [JsonPropertyName("total")]
    public MaintenanceEstimateMoneyResponseBody? Total { get; set; }

    /// <summary>
    /// Latest public content or lifecycle change.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

    /// <summary>
    /// Vendor location ID.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    /// <summary>
    /// Monotonic change counter including lifecycle and attachment updates.
    /// </summary>
    [JsonPropertyName("version")]
    public required long Version { get; set; }

    /// <summary>
    /// Owning numeric work order ID.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public required string WorkOrderId { get; set; }

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
