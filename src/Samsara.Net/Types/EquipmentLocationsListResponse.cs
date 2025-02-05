using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentLocationsListResponse
{
    /// <summary>
    /// Time-series of locations for the specified units of equipment.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentLocationsListResponseData> Data { get; set; } =
        new List<EquipmentLocationsListResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
