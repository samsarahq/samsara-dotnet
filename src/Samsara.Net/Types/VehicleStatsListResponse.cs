using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsListResponse
{
    /// <summary>
    /// A list of vehicles and an array of stat events for each vehicle.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleStatsListResponseData> Data { get; set; } =
        new List<VehicleStatsListResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
