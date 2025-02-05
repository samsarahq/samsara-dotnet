using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MediaRetrievalListUploadedMediaResponseBody
{
    [JsonPropertyName("data")]
    public required ListUploadedMediaObjectResponseBody Data { get; set; }

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
