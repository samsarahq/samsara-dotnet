using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverTrailerAssignments;

public record TrailerAssignmentsCreateDriverTrailerAssignmentRequestBody
{
    /// <summary>
    /// ID of the driver. This can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// The start time in RFC 3339 format. The time needs to be current or within the past 7 days. Defaults to now if not provided
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// ID of the trailer. This can be either a unique Samsara ID or an [external ID](https://developers.samsara.com/docs/external-ids) for the trailer.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public required string TrailerId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
