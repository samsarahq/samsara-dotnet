using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetsLocationLinkConfigObject
{
    /// <summary>
    /// Unique assets ID that Live Sharing Link will show.
    /// </summary>
    [JsonPropertyName("assetId")]
    public required string AssetId { get; set; }

    [JsonPropertyName("location")]
    public AssetsLocationLinkConfigAddressDetailsObject? Location { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
