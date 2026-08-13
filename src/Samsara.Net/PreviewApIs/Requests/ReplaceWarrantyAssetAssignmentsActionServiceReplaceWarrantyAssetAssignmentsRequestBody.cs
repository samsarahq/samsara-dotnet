using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record ReplaceWarrantyAssetAssignmentsActionServiceReplaceWarrantyAssetAssignmentsRequestBody
{
    /// <summary>
    /// ID of the warranty whose asset set to replace.
    /// </summary>
    [JsonIgnore]
    public string? WarrantyId { get; set; }

    /// <summary>
    /// The full desired asset set for the warranty.
    /// </summary>
    [JsonPropertyName("assets")]
    public IEnumerable<EntityReplaceWarrantyAssetAssignmentsWarrantyAssetAssignmentInputTypeRequestBody>? Assets { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
