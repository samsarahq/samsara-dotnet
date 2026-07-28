using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Preventive Maintenance Schedule Due.
/// </summary>
[Serializable]
public record PreventiveMaintenanceScheduleDueDataResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    /// <summary>
    /// The dimension(s) (date, odometer, engine hours) that caused this schedule instance to become due.
    /// </summary>
    [JsonPropertyName("dueReasons")]
    public IEnumerable<PreventiveMaintenanceScheduleDueDataResponseBodyDueReasonsItem>? DueReasons { get; set; }

    /// <summary>
    /// Description of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("scheduleDescription")]
    public string? ScheduleDescription { get; set; }

    /// <summary>
    /// Unique ID of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("scheduleId")]
    public string? ScheduleId { get; set; }

    /// <summary>
    /// Title of the preventive maintenance schedule.
    /// </summary>
    [JsonPropertyName("scheduleTitle")]
    public string? ScheduleTitle { get; set; }

    [JsonPropertyName("trailer")]
    public AlertObjectTrailerResponseBody? Trailer { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

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
