using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody
{
    /// <summary>
    /// List of driver efficiency data associated with vehicles.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<SingleDriverEfficiencyByVehicleDataObjectResponseBody> Data { get; set; } =
        new List<SingleDriverEfficiencyByVehicleDataObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
