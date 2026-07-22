using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetSharingAgreementsCreateSharedAssetsBatchRequestBody
{
    /// <summary>
    /// The unique identifier of the Data Sharing Agreement.
    /// </summary>
    [JsonIgnore]
    public required string DsaId { get; set; }

    /// <summary>
    /// List of assets to share.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CreateSharedAssetRequestObjectRequestBody> Data { get; set; } =
        new List<CreateSharedAssetRequestObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
