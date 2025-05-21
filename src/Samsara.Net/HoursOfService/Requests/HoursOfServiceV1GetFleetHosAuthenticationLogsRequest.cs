using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

public record HoursOfServiceV1GetFleetHosAuthenticationLogsRequest
{
    /// <summary>
    /// Driver ID to query.
    /// </summary>
    [JsonIgnore]
    public required long DriverId { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time.
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
