using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Live Sharing Link response object.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
