using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

[Serializable]
public record InlineObject
{
    /// <summary>
    /// ID of the route. This can either be the Samsara-specified ID, or an external ID. External IDs are customer specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `payrollId:ABFS18600`
    /// </summary>
    [JsonIgnore]
    public required string RouteIdOrExternalId { get; set; }

    /// <summary>
    /// This is only for a recurring route.  If set to true, delete all following runs of the route.  If set to false, only delete the current route.
    /// </summary>
    [JsonPropertyName("apply_to_future_routes")]
    public bool? ApplyToFutureRoutes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
