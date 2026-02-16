using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetReadingsHistoryRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The reading ID to retrieve data for. Use /readings/definitions endpoint to get a list of valid reading IDs. (Examples: engineRpm,fuelLevel)
    /// </summary>
    [JsonIgnore]
    public required string ReadingId { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of entity IDs or external IDs. If not set, all entities are returned.
    /// </summary>
    [JsonIgnore]
    public string? EntityIds { get; set; }

    /// <summary>
    /// A entity type of the entityIds or externalIds to fetch readings for. Use /readings/definitions endpoint to get a list of valid entity types. (Examples: asset, sensor)
    /// </summary>
    [JsonIgnore]
    public required string EntityType { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of external IDs. (Examples: samsara.serial:ZPXKLMN7VJ, samsara.serial:ABXKIMN4NM)
    /// </summary>
    [JsonIgnore]
    public string? ExternalIds { get; set; }

    /// <summary>
    /// A filter on the data that returns the last known data points with timestamps greater than or equal to this value. Must be a string in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2020-01-27T07:06:25Z)
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// A filter on the data that returns the last known data points with timestamps less than or equal to this value. If not set, the time of the request is considered the endTime. Must be a string in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2020-01-27T07:06:25Z)
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Set to true to enable feed mode for continuous reading updates. When enabled, the API always includes an endCursor in the response. If hasNextPage is false, it indicates that no new data is currently available — wait at least 5 seconds before making the next request to avoid unnecessary polling.
    /// </summary>
    [JsonIgnore]
    public bool? Feed { get; set; }

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
