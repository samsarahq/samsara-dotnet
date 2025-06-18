using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

public record DriversListRequest
{
    /// <summary>
    /// If value is `deactivated`, only drivers that are deactivated will appear in the response. This parameter will default to `active` if not provided (fetching only active drivers).
    /// </summary>
    [JsonIgnore]
    public DriversListRequestDriverActivationStatus? DriverActivationStatus { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 512 objects.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ParentTagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of attribute value IDs. Only entities associated with ALL of the referenced values will be returned (i.e. the intersection of the sets of entities with each value). Example: `attributeValueIds=076efac2-83b5-47aa-ba36-18428436dcac,6707b3f0-23b9-4fe3-b7be-11be34aea544`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AttributeValueIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data to return entities having given attributes using name-value pair, separated by semicolon. Only entities associated with ALL of the referenced values will be returned (i.e. the intersection of the sets of entities with each value). Example: `attributes=ExampleAttributeName:some_value&attributes=SomeOtherAttr:123`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Attributes { get; set; } = new List<string>();

    /// <summary>
    /// A filter on data to have an updated at time after or equal to this specified time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? UpdatedAfterTime { get; set; }

    /// <summary>
    /// A filter on data to have a created at time after or equal to this specified time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public string? CreatedAfterTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
