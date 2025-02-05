using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosDailyLogsUpdateShippingDocsResponseBody
{
    [JsonPropertyName("data")]
    public required PatchShippingDocsResponseBodyResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
