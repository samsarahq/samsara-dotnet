using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Reports.Drivers.FuelEnergy;

public record FuelEnergyGetRequest
{
    /// <summary>
    /// A start date in RFC 3339 format. This parameter ignores everything (i.e. hour, minutes, seconds, nanoseconds, etc.) besides the date and timezone. If no time zone is passed in, then the UTC time zone will be used. This parameter is inclusive, so data on the date specified will be considered. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. For example, 2022-07-13T14:20:50.52-07:00 is a time in Pacific Daylight Time.
    /// </summary>
    [JsonIgnore]
    public required string StartDate { get; set; }

    /// <summary>
    /// An end date in RFC 3339 format. This parameter ignores everything (i.e. hour, minutes, seconds, nanoseconds, etc.) besides the date and timezone. If no time zone is passed in, then the UTC time zone will be used. This parameter is inclusive, so data on the date specified will be considered. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. For example, 2022-07-13T14:20:50.52-07:00 is a time in Pacific Daylight Time.
    /// </summary>
    [JsonIgnore]
    public required string EndDate { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of driver IDs and externalIds. Example: `driverIds=1234,5678,payroll:4841`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

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
