using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaJurisdictionReportDataObjectResponseBody
{
    /// <summary>
    /// List of summarized jurisdiction reports.
    /// </summary>
    [JsonPropertyName("jurisdictionReports")]
    public IEnumerable<IftaJurisdictionSummaryObjectResponseBody> JurisdictionReports { get; set; } =
        new List<IftaJurisdictionSummaryObjectResponseBody>();

    /// <summary>
    /// The specified month duration for this IFTA report.
    /// </summary>
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// The specified quarter duration for this IFTA report.
    /// </summary>
    [JsonPropertyName("quarter")]
    public string? Quarter { get; set; }

    [JsonPropertyName("troubleshooting")]
    public IftaReportTroubleshootingObjectResponseBody? Troubleshooting { get; set; }

    /// <summary>
    /// The specified year for this IFTA report.
    /// </summary>
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
