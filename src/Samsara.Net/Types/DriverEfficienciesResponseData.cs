using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficienciesResponseData
{
    /// <summary>
    /// A list of driver and associated vehicle efficiency data.
    /// </summary>
    [JsonPropertyName("driverSummaries")]
    public IEnumerable<DriverEfficiency>? DriverSummaries { get; set; }

    /// <summary>
    /// End time of the window for which this efficiency report was computed. Will be a UTC timestamp in RFC 3339 format. For example: `2020-03-16T16:00:00Z`
    /// </summary>
    [JsonPropertyName("summaryEndTime")]
    public DateTime? SummaryEndTime { get; set; }

    /// <summary>
    /// Start time of the window for which this efficiency report was computed. Will be a UTC timestamp in RFC 3339 format. For example: `2020-03-15T16:00:00Z`
    /// </summary>
    [JsonPropertyName("summaryStartTime")]
    public DateTime? SummaryStartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
