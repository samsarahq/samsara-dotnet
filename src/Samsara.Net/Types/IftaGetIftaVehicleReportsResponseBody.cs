using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaGetIftaVehicleReportsResponseBody
{
    [JsonPropertyName("data")]
    public required IftaVehicleReportDataObjectResponseBody Data { get; set; }

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
