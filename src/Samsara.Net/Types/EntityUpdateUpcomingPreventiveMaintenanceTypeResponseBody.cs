using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpcomingPreventativeMaintenance object
/// </summary>
[Serializable]
public record EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public EntityUpdateUpcomingPreventiveMaintenanceAssetRefTypeResponseBody? Asset { get; set; }

    /// <summary>
    /// Current engine hours for the asset at the time of query.
    /// </summary>
    [JsonPropertyName("currentEngineHours")]
    public long? CurrentEngineHours { get; set; }

    /// <summary>
    /// Current odometer reading for the asset at the time of query. Measured in meters.
    /// </summary>
    [JsonPropertyName("currentOdometer")]
    public long? CurrentOdometer { get; set; }

    /// <summary>
    /// Current odometer reading for the asset at the time of query. Measured in miles.
    /// </summary>
    [JsonPropertyName("currentOdometerMiles")]
    public long? CurrentOdometerMiles { get; set; }

    /// <summary>
    /// The number of days until the next scheduled service for a date based PM.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public long? DueInDays { get; set; }

    /// <summary>
    /// The number of engine hours until the next scheduled service.
    /// </summary>
    [JsonPropertyName("dueInEngineHours")]
    public long? DueInEngineHours { get; set; }

    /// <summary>
    /// The odometer distance until the next scheduled service. Measured in meters.
    /// </summary>
    [JsonPropertyName("dueInOdometer")]
    public long? DueInOdometer { get; set; }

    /// <summary>
    /// The odometer distance until the next scheduled service. Measured in miles.
    /// </summary>
    [JsonPropertyName("dueInOdometerMiles")]
    public long? DueInOdometerMiles { get; set; }

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
    /// The next odometer value that the vehicle is scheduled to be serviced. Measured in miles.
    /// </summary>
    [JsonPropertyName("nextOdometerMiles")]
    public long? NextOdometerMiles { get; set; }

    /// <summary>
    /// The next time that the vehicle is scheduled to be serviced for a date based PM.
    /// </summary>
    [JsonPropertyName("nextTime")]
    public string? NextTime { get; set; }

    /// <summary>
    /// Estimated number of days until the next scheduled service, calculated by converting mileage and engine hour schedules to approximate daily rates. We take the minimum value for schedules with multiple interval types.
    /// </summary>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("schedule")]
    public EntityUpdateUpcomingPreventiveMaintenancePreventativeMaintenanceScheduleRefTypeResponseBody? Schedule { get; set; }

    /// <summary>
    /// Status of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("workOrder")]
    public EntityUpdateUpcomingPreventiveMaintenanceWorkOrderRefTypeResponseBody? WorkOrder { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
