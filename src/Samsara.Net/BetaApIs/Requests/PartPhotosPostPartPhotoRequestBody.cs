using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record PartPhotosPostPartPhotoRequestBody
{
    [JsonPropertyName("file")]
    public required PartPhotoFileRequestBody File { get; set; }

    /// <summary>
    /// Whether the photo is the part's profile photo. A part has at most one profile photo; delete the existing one before adding another. Defaults to false.
    /// </summary>
    [JsonPropertyName("isProfilePhoto")]
    public bool? IsProfilePhoto { get; set; }

    /// <summary>
    /// ID of the part to add the photo to.
    /// </summary>
    [JsonPropertyName("partId")]
    public required string PartId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
