using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A technician time entry (work session) clocked in against a service task. Each entry records when a technician started and (if completed) finished working on the task. driverId and userId identify the Samsara driver and/or dashboard user linked to the technician who performed the work. Either, both, or neither may be present: a technician may be linked to a driver, a dashboard user, or both simultaneously, and both fields are omitted if the technician record could not be resolved (e.g. the technician was deleted).
/// </summary>
[Serializable]
public record WorkOrderTimeEntryObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time the technician clocked in to this service task in RFC 3339 (UTC) format.
    /// </summary>
    [JsonPropertyName("clockInAtTime")]
    public required DateTime ClockInAtTime { get; set; }

    /// <summary>
    /// Time the technician clocked out of this service task in RFC 3339 (UTC) format. Null if the technician is still clocked in.
    /// </summary>
    [JsonPropertyName("clockOutAtTime")]
    public DateTime? ClockOutAtTime { get; set; }

    /// <summary>
    /// Samsara driver ID linked to the technician who performed the work. Set when the technician has a linked driver. Joinable against the public drivers API.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// Samsara dashboard user ID linked to the technician who performed the work. Set when the technician has a linked dashboard user. Joinable against the public users API.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

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
