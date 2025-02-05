using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SpeedingIntervalsGetSpeedingIntervalsResponseBody
{
    /// <summary>
    /// List of speeding intervals associated with trips.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<TripSpeedingIntervalsResponseBody> Data { get; set; } =
        new List<TripSpeedingIntervalsResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
