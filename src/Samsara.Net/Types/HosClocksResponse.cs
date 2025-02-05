using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosClocksResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<HosClocksForDriver> Data { get; set; } = new List<HosClocksForDriver>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
