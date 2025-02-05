using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListUploadedMediaObjectResponseBody
{
    /// <summary>
    /// List of media retrieval objects.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<UploadedMediaObjectResponseBody> Media { get; set; } =
        new List<UploadedMediaObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
