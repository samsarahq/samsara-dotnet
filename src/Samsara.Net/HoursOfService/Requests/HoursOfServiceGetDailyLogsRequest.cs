using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

public record HoursOfServiceGetDailyLogsRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of driver IDs and externalIds. Example: `driverIds=1234,5678,payroll:4841`
    /// </summary>
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// A start date in YYYY-MM-DD. This is a date only without an associated time. Example: `2019-06-13`. This is a required field
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// An end date in YYYY-MM-DD. This is a date only without an associated time. Must be greater than or equal to the start date. Example: `2019-07-21`. This is a required field
    /// </summary>
    public string? EndDate { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    public string? TagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    public string? ParentTagIds { get; set; }

    /// <summary>
    /// If value is `deactivated`, only drivers that are deactivated will appear in the response. This parameter will default to `active` if not provided (fetching only active drivers).  Valid values: `active`, `deactivated`
    /// </summary>
    public HoursOfServiceGetDailyLogsRequestDriverActivationStatus? DriverActivationStatus { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// Expands the specified value(s) in the response object. Expansion populates additional fields in an object, if supported. Unsupported fields are ignored. To expand multiple fields, input a comma-separated list.
    ///
    /// Valid value: `vehicle`  Valid values: `vehicle`
    /// </summary>
    public string? Expand { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
