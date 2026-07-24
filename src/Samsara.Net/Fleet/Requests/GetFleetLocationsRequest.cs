using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Fleet;

[Serializable]
public record GetFleetLocationsRequest
{
    /// <summary>
    /// Pagination parameter indicating the cursor position to continue returning results after. Used in conjunction with the 'limit' parameter.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Pagination parameter indicating the number of results to return in this request. Used in conjunction with 'after'.
    /// </summary>
    [JsonIgnore]
    public long? Limit { get; set; }

    /// <summary>
    /// A comma-separated list of vehicle IDs. Example: `vehicleIds=1000,1001`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VehicleIds { get; set; } = new List<string>();

    /// <summary>
    /// A comma-separated list of tag IDs. Example: `tagIds=1000,1001`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
