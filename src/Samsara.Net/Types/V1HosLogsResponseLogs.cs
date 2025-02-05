using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1HosLogsResponseLogs
{
    [JsonPropertyName("codriverIds")]
    public IEnumerable<double>? CodriverIds { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    [JsonPropertyName("groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// The Hours of Service status type. One of `OFF_DUTY`, `SLEEPER_BED`, `DRIVING`, `ON_DUTY`, `YARD_MOVE`, `PERSONAL_CONVEYANCE`.
    /// </summary>
    [JsonPropertyName("hosStatusType")]
    public string? HosStatusType { get; set; }

    /// <summary>
    /// City in which the log was recorded.
    /// </summary>
    [JsonPropertyName("locCity")]
    public string? LocCity { get; set; }

    /// <summary>
    /// Latitude at which the log was recorded.
    /// </summary>
    [JsonPropertyName("locLat")]
    public float? LocLat { get; set; }

    /// <summary>
    /// Longitude at which the log was recorded.
    /// </summary>
    [JsonPropertyName("locLng")]
    public float? LocLng { get; set; }

    /// <summary>
    /// Name of location at which the log was recorded.
    /// </summary>
    [JsonPropertyName("locName")]
    public string? LocName { get; set; }

    /// <summary>
    /// State in which the log was recorded.
    /// </summary>
    [JsonPropertyName("locState")]
    public string? LocState { get; set; }

    /// <summary>
    /// The time at which the log/HOS status started in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("logStartMs")]
    public long? LogStartMs { get; set; }

    /// <summary>
    /// Remark associated with the log entry.
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public long? VehicleId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
