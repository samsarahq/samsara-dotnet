using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetSharingAgreementsUpdateSharedAssetsBatchRequestBody
{
    /// <summary>
    /// List of shared assets to update.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<UpdateSharedAssetRequestObjectRequestBody> Data { get; set; } =
        new List<UpdateSharedAssetRequestObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
