using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialGetDataInputDataSnapshotRequest
{
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
    /// A comma-separated list of data input IDs. Example: `dataInputIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DataInputIds { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list of industrial asset UUIDs. Example: `assetIds=076efac2-83b5-47aa-ba36-18428436dcac,6707b3f0-23b9-4fe3-b7be-11be34aea544`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
