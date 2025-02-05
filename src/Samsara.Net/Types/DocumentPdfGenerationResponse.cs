using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DocumentPdfGenerationResponse
{
    [JsonPropertyName("data")]
    public DocumentPdfGenerationResponseData? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
