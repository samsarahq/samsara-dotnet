using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentPdfQueryResponse
{
    [JsonPropertyName("data")]
    public DocumentPdfQueryResponseData? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
