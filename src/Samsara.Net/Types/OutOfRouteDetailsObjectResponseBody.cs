using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record OutOfRouteDetailsObjectResponseBody
{
    /// <summary>
    /// The minimum distance in meters a vehicle has to be from its active route path to be considered out of its route.
    /// </summary>
    [JsonPropertyName("maxOffRouteMeters")]
    public required long MaxOffRouteMeters { get; set; }

    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
