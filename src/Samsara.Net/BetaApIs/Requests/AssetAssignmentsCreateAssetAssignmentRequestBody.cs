using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetAssignmentsCreateAssetAssignmentRequestBody
{
    /// <summary>
    /// Samsara ID of the asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <summary>
    /// Samsara ID of the assignee.
    /// </summary>
    [JsonPropertyName("assigneeId")]
    public required string AssigneeId { get; set; }

    /// <summary>
    /// Type of the assignee. This required field has no default.  Valid values: `driver`, `asset`, `geofence`
    /// </summary>
    [JsonPropertyName("assigneeType")]
    public required AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType AssigneeType { get; set; }

    /// <summary>
    /// Optional. The expected end time of the assignment in RFC 3339 format. Must be strictly after the current time.
    /// </summary>
    [JsonPropertyName("expectedEndTime")]
    public DateTime? ExpectedEndTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
