using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody
{
    /// <summary>
    /// List of driver assignment objects and their respective vehcile and driver info.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DriverVehicleAssignmentV2ObjectResponseBody> Data { get; set; } =
        new List<DriverVehicleAssignmentV2ObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
