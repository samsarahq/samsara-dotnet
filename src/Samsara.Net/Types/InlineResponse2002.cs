using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record InlineResponse2002
{
    [JsonPropertyName("assets")]
    public IEnumerable<V1AssetCurrentLocationsResponse>? Assets { get; set; }

    [JsonPropertyName("pagination")]
    public V1Pagination? Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
