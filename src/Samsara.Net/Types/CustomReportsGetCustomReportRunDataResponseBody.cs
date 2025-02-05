using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CustomReportsGetCustomReportRunDataResponseBody
{
    [JsonPropertyName("data")]
    public required GetCustomReportRunDataObjectResponseBody Data { get; set; }

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
