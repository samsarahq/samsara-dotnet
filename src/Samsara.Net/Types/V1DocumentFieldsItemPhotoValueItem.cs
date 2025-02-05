using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldsItemPhotoValueItem
{
    /// <summary>
    /// Url of the photo.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Uuid of the photo.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
