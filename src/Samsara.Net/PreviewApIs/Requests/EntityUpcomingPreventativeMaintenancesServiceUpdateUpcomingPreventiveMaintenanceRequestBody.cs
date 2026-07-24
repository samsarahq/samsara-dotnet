using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record EntityUpcomingPreventativeMaintenancesServiceUpdateUpcomingPreventiveMaintenanceRequestBody
{
    /// <summary>
    /// Samsara ID for the asset.
    /// </summary>
    [JsonIgnore]
    public string? AssetId { get; set; }

    /// <summary>
    /// ID of the preventive maintenance schedule that the vehicle is scheduled to be serviced for.
    /// </summary>
    [JsonIgnore]
    public string? ScheduleId { get; set; }

    /// <summary>
    /// Date and time when the prior instance was resolved.
    /// </summary>
    [JsonPropertyName("lastResolvedAt")]
    public string? LastResolvedAt { get; set; }

    /// <summary>
    /// Engine hours at the time the prior instance was resolved.
    /// </summary>
    [JsonPropertyName("lastResolvedAtEngineHours")]
    public long? LastResolvedAtEngineHours { get; set; }

    /// <summary>
    /// Odometer reading at the time the prior instance was resolved. Measured in meters.
    /// </summary>
    [JsonPropertyName("lastResolvedAtOdometer")]
    public long? LastResolvedAtOdometer { get; set; }

    /// <summary>
    /// The next engine hour value that the vehicle is scheduled to be serviced.
    /// </summary>
    [JsonPropertyName("nextEngineHours")]
    public long? NextEngineHours { get; set; }

    /// <summary>
    /// The next odometer value that the vehicle is scheduled to be serviced. Measured in meters.
    /// </summary>
    [JsonPropertyName("nextOdometer")]
    public long? NextOdometer { get; set; }

    /// <summary>
    /// The next time that the vehicle is scheduled to be serviced for a date based PM.
    /// </summary>
    [JsonPropertyName("nextTime")]
    public string? NextTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
