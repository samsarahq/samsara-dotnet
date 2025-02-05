using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriversVehicleAssignmentsGetDriversVehicleAssignmentsResponseBody
{
    /// <summary>
    /// List of driver and their vehicle assignments.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DriversVehicleAssignmentsObjectResponseBody> Data { get; set; } =
        new List<DriversVehicleAssignmentsObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
