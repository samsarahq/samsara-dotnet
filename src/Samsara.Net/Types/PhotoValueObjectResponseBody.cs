using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PhotoValueObjectResponseBody
{
    /// <summary>
    /// Id of the photo.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Url of the photo.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
