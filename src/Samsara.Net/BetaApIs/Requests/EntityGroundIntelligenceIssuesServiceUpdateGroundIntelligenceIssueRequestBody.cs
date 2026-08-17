using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBody
{
    /// <summary>
    /// Unique identifier for the Ground Intelligence issue.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Optional note about the dismissal. Set to null to clear.
    /// </summary>
    [JsonPropertyName("dismissalNote")]
    public string? DismissalNote { get; set; }

    /// <summary>
    /// Reason for dismissing the issue. Required when status is dismissed.  Valid values: `notMyJurisdiction`, `knownIssue`, `duplicate`, `inaccurateDetection`, `other`
    /// </summary>
    [JsonPropertyName("dismissalReason")]
    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyDismissalReason? DismissalReason { get; set; }

    /// <summary>
    /// Customer-facing review status for the issue.  Valid values: `needsReview`, `reviewed`, `resolved`, `dismissed`
    /// </summary>
    [JsonPropertyName("status")]
    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyStatus? Status { get; set; }

    /// <summary>
    /// Customer-facing road-condition type for the issue.  Valid values: `pothole`, `roadCracking`, `patchedPothole`
    /// </summary>
    [JsonPropertyName("type")]
    public EntityGroundIntelligenceIssuesServiceUpdateGroundIntelligenceIssueRequestBodyType? Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
