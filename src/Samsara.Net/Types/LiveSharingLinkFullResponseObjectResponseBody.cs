using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Live Sharing Link object
/// </summary>
public record LiveSharingLinkFullResponseObjectResponseBody
{
    [JsonPropertyName("assetsLocationLinkConfig")]
    public AssetsLocationLinkConfigObjectResponseBody? AssetsLocationLinkConfig { get; set; }

    [JsonPropertyName("assetsNearLocationLinkConfig")]
    public AssetsNearLocationLinkConfigObjectResponseBody? AssetsNearLocationLinkConfig { get; set; }

    [JsonPropertyName("assetsOnRouteLinkConfig")]
    public AssetsOnRouteLinkConfigObjectResponseBody? AssetsOnRouteLinkConfig { get; set; }

    /// <summary>
    /// Description for the Live Sharing Link (not applicable for 'assetsOnRoute' type).
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Date that this link expires, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expiresAtTime")]
    public string? ExpiresAtTime { get; set; }

    /// <summary>
    /// Unique identifier for the Live Sharing Link.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
    /// Type of the Live Sharing Link.  Valid values: `assetsLocation`, `assetsNearLocation`, `assetsOnRoute`
    /// </summary>
    [JsonPropertyName("type")]
    public required LiveSharingLinkFullResponseObjectResponseBodyType Type { get; set; }

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
