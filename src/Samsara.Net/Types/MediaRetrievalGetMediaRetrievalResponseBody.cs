using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MediaRetrievalGetMediaRetrievalResponseBody
{
    [JsonPropertyName("data")]
    public required GetMediaRetrievalObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
