using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// WarrantyClaim object
/// </summary>
[Serializable]
public record EntityListWarrantyClaimsTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public EntityListWarrantyClaimsAssetRefTypeResponseBody? Asset { get; set; }

    /// <summary>
    /// The cause of the 3 Cs - the root cause found.
    /// </summary>
    [JsonPropertyName("cause")]
    public string? Cause { get; set; }

    /// <summary>
    /// Engine hours at the time of repair.
    /// </summary>
    [JsonPropertyName("claimEngineHours")]
    public long? ClaimEngineHours { get; set; }

    /// <summary>
    /// Asset odometer reading at the time of repair. Measured in meters.
    /// </summary>
    [JsonPropertyName("claimOdometerMeters")]
    public long? ClaimOdometerMeters { get; set; }

    /// <summary>
    /// Current status of the claim.
    /// </summary>
    [JsonPropertyName("claimStatus")]
    public string? ClaimStatus { get; set; }

    /// <summary>
    /// IDs of asset component instances covered by this claim.
    /// </summary>
    [JsonPropertyName("componentInstanceIds")]
    public IEnumerable<string>? ComponentInstanceIds { get; set; }

    /// <summary>
    /// The concern of the 3 Cs - what was reported.
    /// </summary>
    [JsonPropertyName("concern")]
    public string? Concern { get; set; }

    /// <summary>
    /// The correction of the 3 Cs - the work performed.
    /// </summary>
    [JsonPropertyName("correction")]
    public string? Correction { get; set; }

    /// <summary>
    /// When the claim was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Customer-supplied external identifiers for the warranty claim, interchangeable with id in filters. Only included in the response when includeExternalIds is set.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public IEnumerable<ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimExternalIdTypeResponseBody>? ExternalIds { get; set; }

    /// <summary>
    /// Samsara ID for the warranty claim.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Labor being claimed.
    /// </summary>
    [JsonPropertyName("labor")]
    public IEnumerable<ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimLaborTypeResponseBody>? Labor { get; set; }

    [JsonPropertyName("linkedWarranty")]
    public EntityListWarrantyClaimsWarrantyRefTypeResponseBody? LinkedWarranty { get; set; }

    /// <summary>
    /// IDs of the work orders associated with this claim.
    /// </summary>
    [JsonPropertyName("linkedWorkOrderIds")]
    public IEnumerable<string>? LinkedWorkOrderIds { get; set; }

    /// <summary>
    /// IDs of media items attached to the claim.
    /// </summary>
    [JsonPropertyName("mediaItemIds")]
    public IEnumerable<string>? MediaItemIds { get; set; }

    [JsonPropertyName("otherCost")]
    public ListWarrantyClaimsEntityWarrantyClaimMoneyTypeResponseBody? OtherCost { get; set; }

    /// <summary>
    /// Parts being claimed.
    /// </summary>
    [JsonPropertyName("parts")]
    public IEnumerable<ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimPartTypeResponseBody>? Parts { get; set; }

    /// <summary>
    /// When reimbursement was received.
    /// </summary>
    [JsonPropertyName("reimbursedAtTime")]
    public string? ReimbursedAtTime { get; set; }

    /// <summary>
    /// Reimbursement amounts, optionally linked to a work order.
    /// </summary>
    [JsonPropertyName("reimbursements")]
    public IEnumerable<ListWarrantyClaimsEntityWarrantyClaimClaimReimbursementTypeResponseBody>? Reimbursements { get; set; }

    /// <summary>
    /// When the repair was completed.
    /// </summary>
    [JsonPropertyName("repairCompletedAtTime")]
    public string? RepairCompletedAtTime { get; set; }

    /// <summary>
    /// When the claim was resolved.
    /// </summary>
    [JsonPropertyName("resolutionAtTime")]
    public string? ResolutionAtTime { get; set; }

    /// <summary>
    /// Audit trail of status changes. Server-managed and read-only.
    /// </summary>
    [JsonPropertyName("statusHistory")]
    public IEnumerable<ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBody>? StatusHistory { get; set; }

    /// <summary>
    /// When the claim was submitted to the vendor.
    /// </summary>
    [JsonPropertyName("submittedAtTime")]
    public string? SubmittedAtTime { get; set; }

    /// <summary>
    /// When the claim was last updated.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    [JsonPropertyName("warrantyVendor")]
    public EntityListWarrantyClaimsVendorRefTypeResponseBody? WarrantyVendor { get; set; }

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
