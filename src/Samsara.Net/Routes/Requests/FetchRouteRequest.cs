using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

[Serializable]
public record FetchRouteRequest
{
    /// <summary>
    /// ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// A comma-separated list of additional fields to include in the response. Valid values: `stops.actualDistanceMeters`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Include { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
