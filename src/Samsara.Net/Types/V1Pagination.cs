using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Pagination
{
    /// <summary>
    /// Cursor identifier representing the last element in the response. This value should be used in conjunction with a subsequent request's 'startingAfter' query parameter.
    /// </summary>
    [JsonPropertyName("endCursor")]
    public required string EndCursor { get; set; }

    /// <summary>
    /// True if there are more pages of results after this response.
    /// </summary>
    [JsonPropertyName("hasNextPage")]
    public required bool HasNextPage { get; set; }

    /// <summary>
    /// True if there are more pages of results before this response.
    /// </summary>
    [JsonPropertyName("hasPrevPage")]
    public required bool HasPrevPage { get; set; }

    /// <summary>
    /// Cursor identifier representing the first element in the response. This value should be used in conjunction with a subsequent request's 'ending_before' query parameter.
    /// </summary>
    [JsonPropertyName("startCursor")]
    public required string StartCursor { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
