using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetReadingsSnapshotRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A collection of comma separated reading IDs. Include up to 3 readings IDs. Use /readings/definitions endpoint to get a list of valid reading IDs. (Examples: engineRpm,fuelLevel)
    /// </summary>
    [JsonIgnore]
    public required string ReadingIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of entity IDs or external IDs. If not set, all entities are returned.
    /// </summary>
    [JsonIgnore]
    public string? EntityIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of external IDs. (Examples: samsara.serial:ZPXKLMN7VJ, samsara.serial:ABXKIMN4NM)
    /// </summary>
    [JsonIgnore]
    public string? ExternalIds { get; set; }

    /// <summary>
    /// A filter on the data that returns the last known data points with timestamps less than or equal to this value. Defaults to now if not provided. Must be a string in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2020-01-27T07:06:25Z)
    /// </summary>
    [JsonIgnore]
    public string? AsOfTime { get; set; }

    /// <summary>
    /// A entity type of the entityIds or externalIds to fetch readings for. Use /readings/definitions endpoint to get a list of valid entity types. (Examples: asset, sensor)
    /// </summary>
    [JsonIgnore]
    public required string EntityType { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
