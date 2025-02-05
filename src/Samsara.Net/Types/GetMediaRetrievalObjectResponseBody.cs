using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GetMediaRetrievalObjectResponseBody
{
    /// <summary>
    /// List of media retrieval objects.
    /// </summary>
    [JsonPropertyName("media")]
    public IEnumerable<MediaObjectResponseBody> Media { get; set; } =
        new List<MediaObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
