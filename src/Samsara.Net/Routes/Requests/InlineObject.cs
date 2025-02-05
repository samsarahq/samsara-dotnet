using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

public record InlineObject
{
    /// <summary>
    /// This is only for a recurring route.  If set to true, delete all following runs of the route.  If set to false, only delete the current route.
    /// </summary>
    [JsonPropertyName("apply_to_future_routes")]
    public bool? ApplyToFutureRoutes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
