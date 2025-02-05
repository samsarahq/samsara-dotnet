using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehiclesListVehiclesResponseBody
{
    /// <summary>
    /// Multiple vehicles.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleResponseObjectResponseBody> Data { get; set; } =
        new List<VehicleResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
