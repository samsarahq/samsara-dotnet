using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// TimeEntry object
/// </summary>
[Serializable]
public record EntityListTimeEntriesTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Non-repair activity associated with the time entry. Omitted for work-order time.  Valid values: `unknown`, `break`, `shopCleaning`, `partsHandling`, `operationalTest`, `equipmentSetup`, `inspection`, `roadCall`, `training`, `administrative`, `shopMiscellaneous`
    /// </summary>
    [JsonPropertyName("activityType")]
    public EntityListTimeEntriesTypeResponseBodyActivityType? ActivityType { get; set; }

    /// <summary>
    /// Time when the technician clocked in.
    /// </summary>
    [JsonPropertyName("clockInAtTime")]
    public string? ClockInAtTime { get; set; }

    [JsonPropertyName("clockInLocation")]
    public ListTimeEntriesEntityTimeEntryTimeEntryLocationTypeResponseBody? ClockInLocation { get; set; }

    /// <summary>
    /// Surface that recorded the clock-in.  Valid values: `unknown`, `cloud`, `mobile`
    /// </summary>
    [JsonPropertyName("clockInSource")]
    public EntityListTimeEntriesTypeResponseBodyClockInSource? ClockInSource { get; set; }

    /// <summary>
    /// Time when the technician clocked out. Omitted while the entry is in progress.
    /// </summary>
    [JsonPropertyName("clockOutAtTime")]
    public string? ClockOutAtTime { get; set; }

    [JsonPropertyName("clockOutLocation")]
    public ListTimeEntriesEntityTimeEntryTimeEntryLocationTypeResponseBody? ClockOutLocation { get; set; }

    /// <summary>
    /// Method that ended the time entry.  Valid values: `unknown`, `manual`, `overwrite`, `clockIn`, `autoClockOut`
    /// </summary>
    [JsonPropertyName("clockOutMethodType")]
    public EntityListTimeEntriesTypeResponseBodyClockOutMethodType? ClockOutMethodType { get; set; }

    /// <summary>
    /// Surface that recorded the clock-out.  Valid values: `unknown`, `cloud`, `mobile`
    /// </summary>
    [JsonPropertyName("clockOutSource")]
    public EntityListTimeEntriesTypeResponseBodyClockOutSource? ClockOutSource { get; set; }

    /// <summary>
    /// Time when the time entry was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// Time when the time entry was deleted. Deleted records contain only the ID, this field, and deletedByUserId when available.
    /// </summary>
    [JsonPropertyName("deletedAtTime")]
    public string? DeletedAtTime { get; set; }

    /// <summary>
    /// Dashboard user ID that deleted the time entry, when available.
    /// </summary>
    [JsonPropertyName("deletedByUserId")]
    public string? DeletedByUserId { get; set; }

    [JsonPropertyName("hourlyRate")]
    public ListTimeEntriesEntityTimeEntryMoneyTypeResponseBody? HourlyRate { get; set; }

    /// <summary>
    /// Stable unique identifier for the time entry.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Samsara Place currently linked to the work order's maintenance site captured at clock-in.
    /// </summary>
    [JsonPropertyName("placeId")]
    public string? PlaceId { get; set; }

    /// <summary>
    /// Work-order service-task instance associated with the time entry, when present.
    /// </summary>
    [JsonPropertyName("serviceTaskId")]
    public string? ServiceTaskId { get; set; }

    /// <summary>
    /// Whether the time entry is in progress or completed.  Valid values: `unknown`, `inProgress`, `completed`
    /// </summary>
    [JsonPropertyName("timeEntryStatus")]
    public EntityListTimeEntriesTypeResponseBodyTimeEntryStatus? TimeEntryStatus { get; set; }

    /// <summary>
    /// Time when the time entry was last updated. The feed window and ordering operate on this field.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    /// <summary>
    /// Dashboard user ID of the technician. Omitted when the technician is not linked to a dashboard user.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// Work order associated with the time entry. Omitted for non-repair activities.
    /// </summary>
    [JsonPropertyName("workOrderId")]
    public string? WorkOrderId { get; set; }

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
