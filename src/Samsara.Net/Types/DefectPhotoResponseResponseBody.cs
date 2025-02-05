using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DefectPhotoResponseResponseBody
{
    /// <summary>
    /// Time when defect's photo was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// The URL to the defect's photo. Note: the link is available only for 24 hours after it's sent
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
