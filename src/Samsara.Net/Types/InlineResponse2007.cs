using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2007
{
    [JsonPropertyName("pagination")]
    public V1Pagination? Pagination { get; set; }

    [JsonPropertyName("trailers")]
    public IEnumerable<V1TrailerAssignmentsResponse>? Trailers { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
