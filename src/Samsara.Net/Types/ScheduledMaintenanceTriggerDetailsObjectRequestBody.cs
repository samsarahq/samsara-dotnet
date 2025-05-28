using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Scheduled Maintenance by Date
/// </summary>
public record ScheduledMaintenanceTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// Alert when maintenance is due in the specified number of days.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public required long DueInDays { get; set; }

    /// <summary>
    /// The id of the maintenance schedule.
    /// </summary>
    [JsonPropertyName("scheduleId")]
    public required string ScheduleId { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
