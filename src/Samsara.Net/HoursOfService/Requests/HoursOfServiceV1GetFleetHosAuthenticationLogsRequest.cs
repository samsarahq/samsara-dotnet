using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

public record HoursOfServiceV1GetFleetHosAuthenticationLogsRequest
{
    /// <summary>
    /// Driver ID to query.
    /// </summary>
    public required long DriverId { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time.
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
