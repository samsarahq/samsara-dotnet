using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record AssetSharingAgreementsCancelSharedAssetsBatchRequestBody
{
    /// <summary>
    /// List of asset sharings to cancel.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IdReferenceObjectRequestBody> Data { get; set; } =
        new List<IdReferenceObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
