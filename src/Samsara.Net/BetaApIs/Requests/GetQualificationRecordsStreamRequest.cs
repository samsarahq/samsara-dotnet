using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetQualificationRecordsStreamRequest
{
    /// <summary>
    /// String of entity type.  Valid values: `worker`, `asset`
    /// </summary>
    [JsonIgnore]
    public required GetQualificationRecordsStreamRequestEntityType EntityType { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. Examples: '2019-06-13T19:08:25Z' (basic UTC), '2019-06-13T19:08:25.455Z' (with milliseconds), '2015-09-15T14:00:12-04:00' (with timezone).
    /// </summary>
    [JsonIgnore]
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Optional and defaults to now if not provided. Millisecond precision and timezones are supported. Examples: '2019-06-13T19:08:25Z' (basic UTC), '2019-06-13T19:08:25.455Z' (with milliseconds), '2015-09-15T14:00:12-04:00' (with timezone).
    /// </summary>
    [JsonIgnore]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Optional comma-separated list containing up to 100 qualification type IDs to filter on.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> QualificationTypeIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional comma-separated list of unique Samsara IDs of workers (if "entityType" is "worker") or assets (if "entityType" is "asset") to filter on. Max value for this field is 100 objects.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> OwnerIds { get; set; } = new List<string>();

    /// <summary>
    /// If true, deleted qualification records are returned.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDeleted { get; set; }

    /// <summary>
    /// If true, externalIds for qualification record and for the owner entity are returned.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
