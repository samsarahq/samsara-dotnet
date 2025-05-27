using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Dictionary containing summarized jurisdiction report data.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
