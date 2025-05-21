using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

public record LiveSharingLinksUpdateLiveSharingLinkRequestBody
{
    /// <summary>
    /// Unique identifier for the Live Sharing Link.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
