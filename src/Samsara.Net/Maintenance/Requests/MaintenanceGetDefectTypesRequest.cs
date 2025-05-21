using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

public record MaintenanceGetDefectTypesRequest
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
    /// A filter on the data based on this comma-separated list of defect type IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
