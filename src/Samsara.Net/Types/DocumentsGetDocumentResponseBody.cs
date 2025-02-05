using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentsGetDocumentResponseBody
{
    [JsonPropertyName("data")]
    public DocumentResponseObjectResponseBody? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
