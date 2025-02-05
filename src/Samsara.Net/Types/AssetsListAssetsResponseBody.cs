using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsListAssetsResponseBody
{
    /// <summary>
    /// List of assets
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<AssetResponseBody> Data { get; set; } = new List<AssetResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
