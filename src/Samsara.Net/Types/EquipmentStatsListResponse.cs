using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentStatsListResponse
{
    /// <summary>
    /// Time-series of stats for the specified units of equipment and stat types.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentStatsListResponseData> Data { get; set; } =
        new List<EquipmentStatsListResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
