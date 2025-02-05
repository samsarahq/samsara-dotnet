using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentStatsResponse
{
    /// <summary>
    /// List of the most recent stats for the specified units of equipment and stat types.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentStatsResponseData> Data { get; set; } =
        new List<EquipmentStatsResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
