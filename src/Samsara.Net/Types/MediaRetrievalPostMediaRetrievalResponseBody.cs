using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MediaRetrievalPostMediaRetrievalResponseBody
{
    [JsonPropertyName("data")]
    public required PostMediaRetrievalObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
