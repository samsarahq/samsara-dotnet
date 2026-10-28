using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record MaintenanceEstimatesCreateMaintenanceEstimateRequestBody
{
    /// <summary>
    /// Include estimate external identifiers. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Defaults to unapproved on create. Approved or denied records a decision through Samsara approval and UTS and requires a stable externalIds identifier for retries; approval never awards the estimate.  Valid values: `unapproved`, `approved`, `denied`
    /// </summary>
    [JsonPropertyName("approvalStatus")]
    public MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus? ApprovalStatus { get; set; }

    /// <summary>
    /// Recommendation or vendor quote. Defaults to vendorQuote when omitted. expectedCost requires an externally managed work order and must be created unapproved; lineItems and tax remain required.  Valid values: `expectedCost`, `vendorQuote`
    /// </summary>
    [JsonPropertyName("estimateType")]
    public MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType? EstimateType { get; set; }

    /// <summary>
    /// Estimate external identifiers. Responses include these only when includeExternalIds=true; default omitted.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("externalRequest")]
    public MaintenanceEstimateExternalRequestInputRequestBody? ExternalRequest { get; set; }

    /// <summary>
    /// Complete set of 1 to 200 priced lines when supplied.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public IEnumerable<MaintenanceEstimateLineInputRequestBody> LineItems { get; set; } =
        new List<MaintenanceEstimateLineInputRequestBody>();

    /// <summary>
    /// Notes, at most 4000 Unicode characters.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Actual quote timestamp. Omit if the source only has a date; do not invent a time or offset.
    /// </summary>
    [JsonPropertyName("quotedAtTime")]
    public DateTime? QuotedAtTime { get; set; }

    /// <summary>
    /// Same-WO/vendor denied estimate superseded by this quote.
    /// </summary>
    [JsonPropertyName("supersedesEstimateId")]
    public string? SupersedesEstimateId { get; set; }

    [JsonPropertyName("tax")]
    public required MaintenanceEstimateMoneyRequestBody Tax { get; set; }

    /// <summary>
    /// Same-org vendor location UUID or external ID.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public required string VendorId { get; set; }

    /// <summary>
    /// Same-org numeric work order ID.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public required string WorkOrderId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
