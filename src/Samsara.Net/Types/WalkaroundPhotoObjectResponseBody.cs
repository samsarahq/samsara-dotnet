using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WalkaroundPhotoObjectResponseBody
{
    /// <summary>
    /// Time when walkaround's photo was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// The name of the walkaround's photo
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The URL to the walkaround's photo. Note: the link is available only for 24 hours after it's sent
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
