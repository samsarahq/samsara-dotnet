using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details on the associated safety event generated
/// </summary>
[Serializable]
public record DetectionLogSafetyEventObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique Samsara ID (uuid) of the safety event. Only returned when safetyEvent.inboxEvent is true.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether a corresponding safety event was published to the Safety Inbox. Always returned.
    /// </summary>
    [JsonPropertyName("inboxEvent")]
    public required bool InboxEvent { get; set; }

    /// <summary>
    /// The reason the detection was filtered out of the inbox. Only returned when safetyEvent.inboxEvent is false  Valid values: `overDailyLimit`, `overHourlyLimit`, `overTripLimit`, `belowConfidenceThreshold`, `belowSeverityThreshold`, `overEventRateLimit`, `geofenceFilter`, `belowNudgeThreshold`, `belowSpeedThreshold`, `nighttimeFilter`, `speedingFilter`, `inCabAlertOnly`, `unknown`
    /// </summary>
    [JsonPropertyName("inboxFilterReason")]
    public DetectionLogSafetyEventObjectResponseBodyInboxFilterReason? InboxFilterReason { get; set; }

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
