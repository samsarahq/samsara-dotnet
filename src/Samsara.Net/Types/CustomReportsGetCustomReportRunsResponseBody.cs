using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CustomReportsGetCustomReportRunsResponseBody
{
    /// <summary>
    /// List of custom report runs.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<GetCustomReportRunObjectResponseBody> Data { get; set; } =
        new List<GetCustomReportRunObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
