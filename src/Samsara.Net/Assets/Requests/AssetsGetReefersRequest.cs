using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

public record AssetsGetReefersRequest
{
    /// <summary>
    /// Timestamp in milliseconds representing the start of the period to fetch, inclusive. Used in combination with endMs.
    /// </summary>
    [JsonIgnore]
    public required long StartMs { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the end of the period to fetch, inclusive. Used in combination with startMs.
    /// </summary>
    [JsonIgnore]
    public required long EndMs { get; set; }

    /// <summary>
    /// Pagination parameter indicating the cursor position to continue returning results after. Used in conjunction with the 'limit' parameter. Mutually exclusive with 'endingBefore' parameter.
    /// </summary>
    [JsonIgnore]
    public string? StartingAfter { get; set; }

    /// <summary>
    /// Pagination parameter indicating the cursor position to return results before. Used in conjunction with the 'limit' parameter. Mutually exclusive with 'startingAfter' parameter.
    /// </summary>
    [JsonIgnore]
    public string? EndingBefore { get; set; }

    /// <summary>
    /// Pagination parameter indicating the number of results to return in this request. Used in conjunction with either 'startingAfter' or 'endingBefore'.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
