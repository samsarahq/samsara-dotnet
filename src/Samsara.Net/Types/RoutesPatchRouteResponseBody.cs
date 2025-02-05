using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RoutesPatchRouteResponseBody
{
    [JsonPropertyName("data")]
    public BaseRouteResponseObjectResponseBody? Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
