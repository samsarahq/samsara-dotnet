using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchRouteHistory
{
    /// <summary>
    /// History of the route's state changes.
    /// </summary>
    [JsonPropertyName("history")]
    public IEnumerable<V1DispatchRouteHistoricalEntry>? History { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
