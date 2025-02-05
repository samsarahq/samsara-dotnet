using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchRouteAllOf
{
    /// <summary>
    /// The dispatch jobs associated with this route.
    /// </summary>
    [JsonPropertyName("dispatch_jobs")]
    public IEnumerable<V1DispatchJob>? DispatchJobs { get; set; }

    /// <summary>
    /// ID of the Samsara dispatch route.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
