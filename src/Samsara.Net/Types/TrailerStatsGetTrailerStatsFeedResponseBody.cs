using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatsGetTrailerStatsFeedResponseBody
{
    /// <summary>
    /// List of trailers and their stats
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrailerStatsObjectResponseBody> Data { get; set; } =
        new List<TrailerStatsObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
