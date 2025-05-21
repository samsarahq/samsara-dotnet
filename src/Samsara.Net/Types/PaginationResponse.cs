using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Pagination parameters.
/// </summary>
public record PaginationResponse
{
    /// <summary>
    /// Cursor identifier representing the last element in the response. This value should be used in conjunction with a subsequent request's 'after' query parameter. This may be an empty string if there are no more pages left to view.
    /// </summary>
    [JsonPropertyName("endCursor")]
    public required string EndCursor { get; set; }

    /// <summary>
    /// True if there are more pages of results immediately available after this endCursor.
    /// </summary>
    [JsonPropertyName("hasNextPage")]
    public required bool HasNextPage { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
