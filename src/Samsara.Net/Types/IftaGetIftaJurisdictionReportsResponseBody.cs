using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaGetIftaJurisdictionReportsResponseBody
{
    [JsonPropertyName("data")]
    public required IftaJurisdictionReportDataObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
