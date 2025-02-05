using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentListResponse
{
    /// <summary>
    /// List of equipment objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<Equipment> Data { get; set; } = new List<Equipment>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
