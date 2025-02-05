using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsSignatureValueObjectResponseBody
{
    [JsonPropertyName("media")]
    public required FormsMediaRecordObjectResponseBody Media { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
