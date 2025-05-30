using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Dvirs;

public record DvirsStreamRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Required RFC 3339 timestamp to begin the feed or history by `updatedAtTime` at `startTime`.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// Optional RFC 3339 timestamp. If not provided then the endpoint behaves as an unending feed of changes.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Optional list of safety statuses. Valid values: [safe, unsafe, resolved]
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SafetyStatus { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
