using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.LiveShares;

public record LiveSharingLinksCreateLiveSharingLinkRequestBody
{
    [JsonPropertyName("assetsLocationLinkConfig")]
    public AssetsLocationLinkConfigObject? AssetsLocationLinkConfig { get; set; }

    [JsonPropertyName("assetsNearLocationLinkConfig")]
    public AssetsNearLocationLinkConfigObject? AssetsNearLocationLinkConfig { get; set; }

    [JsonPropertyName("assetsOnRouteLinkConfig")]
    public AssetsOnRouteLinkConfigObject? AssetsOnRouteLinkConfig { get; set; }

    /// <summary>
    /// Description for the Live Sharing Link (not applicable for 'assetsOnRoute' type).
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Date that this link expires in RFC 3339 format. Can't be set in the past. If not provided then link will never expire.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public string? ExpiresAtTime { get; set; }

    /// <summary>
    /// Name of the Live Sharing Link.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Type of the Live Sharing Link. This field specifies which one of '&lt;type&gt;LinkConfig' objects will be used to configure the sharing link.  Valid values: `assetsLocation`, `assetsNearLocation`, `assetsOnRoute`
    /// </summary>
    [JsonPropertyName("type")]
    public required LiveSharingLinksCreateLiveSharingLinkRequestBodyType Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
