using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverDocumentSubmittedResponseBody
{
    [JsonPropertyName("document")]
    public DocumentResponseObjectResponseBody? Document { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
