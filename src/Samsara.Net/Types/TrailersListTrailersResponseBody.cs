using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailersListTrailersResponseBody
{
    /// <summary>
    /// List of trailer objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrailerResponseObjectResponseBody> Data { get; set; } =
        new List<TrailerResponseObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
