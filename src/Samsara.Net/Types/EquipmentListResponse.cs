using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentListResponse
{
    /// <summary>
    /// List of equipment objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentObject> Data { get; set; } = new List<EquipmentObject>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
