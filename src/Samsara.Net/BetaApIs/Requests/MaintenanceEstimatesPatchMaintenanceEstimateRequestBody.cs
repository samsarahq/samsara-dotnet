using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record MaintenanceEstimatesPatchMaintenanceEstimateRequestBody
{
    /// <summary>
    /// Include estimate external identifiers. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Estimate UUID or external ID.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Approve or deny the current quote through Samsara approval and UTS. Cancel an unapproved or pending estimate and close any open approval ticket. For an active externally selected recommendation or unapproved quote, this existing cancellation path also releases that selection, clears its vendor assignment and returns an open work order to vendor selection. Unselected recommendations leave other selections unchanged, and native quote cancellation preserves vendor assignment. A current finished vendorQuote that is approved, denied or awarded can instead be withdrawn while retaining its approval decision and award history and retiring only its exact completed active award. This decided-quote withdrawal does not change the work order, vendor assignment, selection attempt, service tasks, actual costs or invoices. It is not restricted by whether repair work has started. Cancellation requires approval authority and, for a known or current award, separate award authority. Processing or superseded quotes and incomplete awards cannot be withdrawn; retry an award in progress after reconciliation. Repeating a cancellation is safe. Omit to preserve the current status. Send approval or cancellation separately from content changes, estimateType and isAwarded.  Valid values: `approved`, `denied`, `cancelled`
    /// </summary>
    [JsonPropertyName("approvalStatus")]
    public MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus? ApprovalStatus { get; set; }

    /// <summary>
    /// Omit to preserve the type. Repeating the current type is allowed. Only the active selected expectedCost recommendation can become a vendorQuote, preserving its estimate ID. The reverse transition is not allowed. Type conversion can include pricing changes, but must be separate from approval, cancellation and award.  Valid values: `expectedCost`, `vendorQuote`
    /// </summary>
    [JsonPropertyName("estimateType")]
    public MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyEstimateType? EstimateType { get; set; }

    /// <summary>
    /// Estimate external identifiers. Responses include these only when includeExternalIds=true; default omitted.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("externalRequest")]
    public MaintenanceEstimateExternalRequestInputRequestBody? ExternalRequest { get; set; }

    /// <summary>
    /// Only true is writable: award an eligible approved quote, assign its vendor to the work order and preserve its financial baseline. Applying quote lines to work-order service tasks is a separate dashboard action. A different quote cannot replace an active award through this API; withdraw an eligible awarded quote before awarding its replacement. Send award separately from content and external ID changes. Defaults to unchanged when omitted; requires separate award authority.
    /// </summary>
    [JsonPropertyName("isAwarded")]
    public bool? IsAwarded { get; set; }

    /// <summary>
    /// Complete set of 1 to 200 priced lines when supplied.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public IEnumerable<MaintenanceEstimateLineInputRequestBody>? LineItems { get; set; }

    /// <summary>
    /// Notes, at most 4000 Unicode characters. PATCH null clears.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Actual quote timestamp. Omit if the source only has a date; do not invent a time or offset. PATCH null clears.
    /// </summary>
    [JsonPropertyName("quotedAtTime")]
    public DateTime? QuotedAtTime { get; set; }

    [JsonPropertyName("tax")]
    public MaintenanceEstimateMoneyRequestBody? Tax { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
