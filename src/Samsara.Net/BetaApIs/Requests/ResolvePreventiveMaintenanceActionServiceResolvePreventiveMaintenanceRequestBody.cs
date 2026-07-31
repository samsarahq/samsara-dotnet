using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ResolvePreventiveMaintenanceActionServiceResolvePreventiveMaintenanceRequestBody
{
    /// <summary>
    /// Samsara ID of the asset the instance is being resolved for.
    /// </summary>
    [JsonIgnore]
    public string? AssetId { get; set; }

    /// <summary>
    /// ID of the preventive maintenance schedule to resolve.
    /// </summary>
    [JsonIgnore]
    public string? ScheduleId { get; set; }

    /// <summary>
    /// RFC3339 time when the maintenance was resolved. Defaults to the current time if not provided.
    /// </summary>
    [JsonPropertyName("resolvedAt")]
    public string? ResolvedAt { get; set; }

    /// <summary>
    /// Engine hours reading at the time of resolution.
    /// </summary>
    [JsonPropertyName("resolvedAtEngineHours")]
    public long? ResolvedAtEngineHours { get; set; }

    /// <summary>
    /// Odometer reading at the time of resolution. Measured in meters.
    /// </summary>
    [JsonPropertyName("resolvedAtOdometer")]
    public long? ResolvedAtOdometer { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
