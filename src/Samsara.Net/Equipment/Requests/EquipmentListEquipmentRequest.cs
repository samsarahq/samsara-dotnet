using Samsara.Net.Core;

namespace Samsara.Net.Equipment;

public record EquipmentListEquipmentRequest
{
    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    public long? Limit { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    public IEnumerable<string> ParentTagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
