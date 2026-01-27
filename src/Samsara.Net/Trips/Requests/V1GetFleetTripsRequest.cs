using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trips;

[Serializable]
public record V1GetFleetTripsRequest
{
    /// <summary>
    /// Vehicle ID to query.
    /// </summary>
    [JsonIgnore]
    public required long VehicleId { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time. Limited to a 90 day window with respect to startMs and endMs
    /// </summary>
    [JsonIgnore]
    public required long StartMs { get; set; }

    /// <summary>
    /// End of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonIgnore]
    public required long EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
