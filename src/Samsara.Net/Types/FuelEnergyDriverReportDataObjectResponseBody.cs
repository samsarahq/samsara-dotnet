using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelEnergyDriverReportDataObjectResponseBody
{
    /// <summary>
    /// List of summarized driver reports.
    /// </summary>
    [JsonPropertyName("driverReports")]
    public IEnumerable<FuelEnergyDriverReportObjectResponseBody> DriverReports { get; set; } =
        new List<FuelEnergyDriverReportObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
