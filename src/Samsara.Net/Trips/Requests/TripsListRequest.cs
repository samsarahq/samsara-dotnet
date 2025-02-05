using Samsara.Net.Core;

namespace Samsara.Net.Trips;

public record TripsListRequest
{
    /// <summary>
    /// Vehicle ID to query.
    /// </summary>
    public required long VehicleId { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time. Limited to a 90 day window with respect to startMs and endMs
    /// </summary>
    public required long StartMs { get; set; }

    /// <summary>
    /// End of the time range, specified in milliseconds UNIX time.
    /// </summary>
    public required long EndMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
