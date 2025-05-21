using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record PreviewGetDriverEfficiencyByVehiclesRequest
{
    /// <summary>
    /// A start time in RFC 3339 format. Must be in multiple of hours and at least 1 day before endTime. Timezones are supported. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. (Examples: 2019-06-11T19:00:00Z, 2015-09-12T14:00:00-04:00).
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Must be in multiple of hours and no later than 3 hours before the current time. Timezones are supported. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. (Examples: 2019-06-13T19:00:00Z, 2015-09-15T14:00:00-04:00).
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle IDs and externalIds. Example: `vehicleIds=1234,5678,samsara.vin:1HGBH41JXMN109186`
    /// </summary>
    [JsonIgnore]
    public string? VehicleIds { get; set; }

    /// <summary>
    /// A comma-separated list of data formats you want to fetch. Valid values: `score`, `raw` and `percentage`. The default data format is `score`. Example: `dataFormats=raw,score`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DataFormats { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public string? TagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    [JsonIgnore]
    public string? ParentTagIds { get; set; }

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
