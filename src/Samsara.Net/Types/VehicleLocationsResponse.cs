using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleLocationsResponse
{
    /// <summary>
    /// List of the most recent locations for the specified vehicles.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleLocationsResponseData> Data { get; set; } =
        new List<VehicleLocationsResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
