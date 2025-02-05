using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehiclesDriverAssignmentsGetVehiclesDriverAssignmentsResponseBody
{
    /// <summary>
    /// List of vehicles and their driver assignments.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehiclesDriverAssignmentsObjectResponseBody> Data { get; set; } =
        new List<VehiclesDriverAssignmentsObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
