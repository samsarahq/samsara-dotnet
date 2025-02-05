using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GetAttributesByEntityTypeResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Attribute>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
