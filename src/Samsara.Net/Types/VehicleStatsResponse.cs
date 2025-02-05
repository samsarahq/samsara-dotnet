using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsResponse
{
    /// <summary>
    /// List of vehicles and a snapshot of the request stats.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleStatsResponseData> Data { get; set; } =
        new List<VehicleStatsResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
