using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CustomReportConfigObjectResponseBody
{
    /// <summary>
    /// List of custom report column objects
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<CustomReportColumnsObjectResponseBody> Columns { get; set; } =
        new List<CustomReportColumnsObjectResponseBody>();

    /// <summary>
    /// ID of the custom report config.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the custom report config.
    /// </summary>
    [JsonPropertyName("reportName")]
    public required string ReportName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
