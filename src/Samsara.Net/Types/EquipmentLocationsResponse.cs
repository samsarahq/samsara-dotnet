using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentLocationsResponse
{
    /// <summary>
    /// List of the most recent locations for the specified units of equipment.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentLocationsResponseData> Data { get; set; } =
        new List<EquipmentLocationsResponseData>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
