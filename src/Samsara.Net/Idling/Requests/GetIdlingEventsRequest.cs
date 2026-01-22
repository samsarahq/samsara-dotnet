using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Idling;

[Serializable]
public record GetIdlingEventsRequest
{
    /// <summary>
    /// The start of the time range for filtering idling events in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-11T19:00:00Z, 2015-09-12T14:00:00-04:00). Returns events that begin at or after this timestamp.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// The end of the time range for filtering idling events in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:00:00Z, 2015-09-15T14:00:00-04:00). Returns events that begin before this timestamp.
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of asset IDs. Asset IDs only include vehicle IDs at this time.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of operator IDs. Operator IDs only include driver IDs at this time.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> OperatorIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data on this PTO (Power Take-Off) state. If no specific state is provided, data including any state will be included.  Valid values: `active`, `inactive`
    /// </summary>
    [JsonIgnore]
    public GetIdlingEventsRequestPtoState? PtoState { get; set; }

    /// <summary>
    /// A filter on the data based on the minimum value of air temperature in millicelsius. The acceptable range for this value is between -20,000 and 50,000 millicelsius.
    /// </summary>
    [JsonIgnore]
    public long? MinAirTemperatureMillicelsius { get; set; }

    /// <summary>
    /// A filter on the data based on the maximum value of air temperature in millicelsius. The acceptable range for this value is between -20,000 and 50,000 millicelsius.
    /// </summary>
    [JsonIgnore]
    public long? MaxAirTemperatureMillicelsius { get; set; }

    /// <summary>
    /// A filter on the data based on unknown air temperature value.
    /// </summary>
    [JsonIgnore]
    public bool? ExcludeEventsWithUnknownAirTemperature { get; set; }

    /// <summary>
    /// A filter on the data based on the minimum value of Idling duration in milliseconds. The acceptable range for this value is between 2 minutes and 24 hours.
    /// </summary>
    [JsonIgnore]
    public long? MinDurationMilliseconds { get; set; }

    /// <summary>
    /// A filter on the data based on the maximum value of Idling duration in milliseconds. The acceptable range for this value is between 2 minutes and 24 hours.
    /// </summary>
    [JsonIgnore]
    public long? MaxDurationMilliseconds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Tag IDs only include vehicle IDs at this time.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs. Parent tag IDs only include vehicle IDs at this time.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ParentTagIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 200 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
