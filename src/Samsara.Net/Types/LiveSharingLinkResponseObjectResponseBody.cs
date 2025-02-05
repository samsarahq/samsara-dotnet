using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LiveSharingLinkResponseObjectResponseBody
{
    /// <summary>
    /// Date that this link expires, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public string? ExpiresAtTime { get; set; }

    /// <summary>
    /// The shareable URL of the vehicle's location.
    /// </summary>
    [JsonPropertyName("liveSharingUrl")]
    public required string LiveSharingUrl { get; set; }

    /// <summary>
    /// Name of the Live Sharing Link.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
