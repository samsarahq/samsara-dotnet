using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatsGetTrailerStatsSnapshotResponseBody
{
    /// <summary>
    /// List of trailers and their stats
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TrailerStatsSnapshotObjectResponseBody> Data { get; set; } =
        new List<TrailerStatsSnapshotObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
