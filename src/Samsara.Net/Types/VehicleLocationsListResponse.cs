using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleLocationsListResponse
{
    /// <summary>
    /// A list of vehicles and an array of location events for each vehicle.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleLocationsListResponseData> Data { get; set; } =
        new List<VehicleLocationsListResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
