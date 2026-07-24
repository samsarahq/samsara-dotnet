using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// PreventativeMaintenanceSchedule object
/// </summary>
[Serializable]
public record EntityListPreventiveMaintenanceSchedulesTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date interval for the preventive maintenance schedule if applicable. Measured in milliseconds.
    /// </summary>
    [JsonPropertyName("dateIntervalMs")]
    public long? DateIntervalMs { get; set; }

    /// <summary>
    /// Description of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Distance interval for the preventive maintenance schedule if applicable. Measured in meters.
    /// </summary>
    [JsonPropertyName("distanceInterval")]
    public long? DistanceInterval { get; set; }

    /// <summary>
    /// Engine hour interval for the preventive maintenance schedule if applicable.
    /// </summary>
    [JsonPropertyName("engineHourInterval")]
    public long? EngineHourInterval { get; set; }

    /// <summary>
    /// Samsara ID for the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IDs of other preventive maintenance schedules linked to this schedule.
    /// </summary>
    [JsonPropertyName("linkedSchedules")]
    public IEnumerable<EntityListPreventiveMaintenanceSchedulesPreventativeMaintenanceScheduleRefTypeResponseBody>? LinkedSchedules { get; set; }

    /// <summary>
    /// Title of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// ID of the work order template associated with this schedule.
    /// </summary>
    [JsonPropertyName("workOrderTemplateId")]
    public string? WorkOrderTemplateId { get; set; }

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
