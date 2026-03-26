using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.CarbCtc;

[Serializable]
public record ListCarbCtcVehiclesRequest
{
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
    /// Optional filter based on the test status. This parameter can be passed multiple times to filter by multiple statuses.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<ListCarbCtcVehiclesRequestTestStatusItem> TestStatus { get; set; } =
        new List<ListCarbCtcVehiclesRequestTestStatusItem>();

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
