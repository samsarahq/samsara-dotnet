using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IdlingReportsGetVehicleIdlingReportsResponseBody
{
    /// <summary>
    /// Multiple idling events.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IdlingReportEventResponseBody> Data { get; set; } =
        new List<IdlingReportEventResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    /// <summary>
    /// The requested end time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestEndTime")]
    public required string RequestEndTime { get; set; }

    /// <summary>
    /// The requested start time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestStartTime")]
    public required string RequestStartTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
