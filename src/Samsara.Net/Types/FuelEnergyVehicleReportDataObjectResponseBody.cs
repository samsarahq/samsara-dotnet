using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelEnergyVehicleReportDataObjectResponseBody
{
    /// <summary>
    /// List of summarized vehicle reports.
    /// </summary>
    [JsonPropertyName("vehicleReports")]
    public IEnumerable<FuelEnergyVehicleReportObjectResponseBody> VehicleReports { get; set; } =
        new List<FuelEnergyVehicleReportObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
