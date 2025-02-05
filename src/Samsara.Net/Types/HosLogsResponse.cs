using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosLogsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<HosLogsForDriver> Data { get; set; } = new List<HosLogsForDriver>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
