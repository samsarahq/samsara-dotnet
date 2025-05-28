using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets.LocationAndSpeed;

public record LocationAndSpeedStreamRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Defaults to now if not provided. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to never if not provided; if not provided then pagination will not cease, and a valid pagination cursor will always be returned. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Comma-separated list of asset IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean indicating whether or not to return the 'speed' object
    /// </summary>
    [JsonIgnore]
    public bool? IncludeSpeed { get; set; }

    /// <summary>
    /// Optional boolean indicating whether or not to return the 'address' object
    /// </summary>
    [JsonIgnore]
    public bool? IncludeReverseGeo { get; set; }

    /// <summary>
    /// Optional boolean indicating whether or not to return the 'geofence' object
    /// </summary>
    [JsonIgnore]
    public bool? IncludeGeofenceLookup { get; set; }

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
