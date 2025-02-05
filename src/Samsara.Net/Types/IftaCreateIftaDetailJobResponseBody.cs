using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaCreateIftaDetailJobResponseBody
{
    [JsonPropertyName("data")]
    public required IftaDetailJobResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
