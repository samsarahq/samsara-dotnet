using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetAssignmentsUnassignAssetAssignmentRequestBody
{
    /// <summary>
    /// Samsara ID of the asset.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
