using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetVehicleSafetyScoresRequest
{
    /// <summary>
    /// End time in RFC 3339 format. Millisecond precision and timezones are supported. Includes trips that end before this timestamp.
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// Start time in RFC 3339 format. Millisecond precision and timezones are supported. Includes trips that end after this timestamp. Can be up to 1 year before endTime.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// Comma separated list of vehicle IDs to filter by. Include up to 100 IDs. Defaults to all vehicles.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VehicleIds { get; set; } = new List<string>();

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
