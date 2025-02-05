using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ListDriversResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Driver>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
