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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
