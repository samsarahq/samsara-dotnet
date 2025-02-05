using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

public record InlineObject1
{
    /// <summary>
    /// Duty status to set the driver to. The only supported values are 'ON_DUTY' and 'OFF_DUTY'.
    /// </summary>
    [JsonPropertyName("duty_status")]
    public required string DutyStatus { get; set; }

    /// <summary>
    /// Location to associate the duty status change with.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Remark to associate the duty status change with.
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// Timestamp that the duty status will begin at specified in milliseconds UNIX time. Defaults to the current time if left blank. This can only be set to up to 8 hours in the past.
    /// </summary>
    [JsonPropertyName("status_change_at_ms")]
    public long? StatusChangeAtMs { get; set; }

    /// <summary>
    /// Vehicle ID to associate the duty status change with.
    /// </summary>
    [JsonPropertyName("vehicle_id")]
    public long? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
