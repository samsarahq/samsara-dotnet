using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CustomReportsGetCustomReportConfigsResponseBody
{
    /// <summary>
    /// List of custom report config objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CustomReportConfigObjectResponseBody> Data { get; set; } =
        new List<CustomReportConfigObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
