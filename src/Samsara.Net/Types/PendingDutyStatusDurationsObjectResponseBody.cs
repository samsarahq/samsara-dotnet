using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// What the duty status durations on the driver’s log would be if all pending carrier edits are accepted by the driver.
/// </summary>
[Serializable]
public record PendingDutyStatusDurationsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Duration the driver was active for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("activeDurationMs")]
    public long? ActiveDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was driving for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("driveDurationMs")]
    public long? DriveDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was off duty for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("offDutyDurationMs")]
    public long? OffDutyDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was on duty for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("onDutyDurationMs")]
    public long? OnDutyDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was driving for personal conveyance for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("personalConveyanceDurationMs")]
    public long? PersonalConveyanceDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was in their sleeper berth for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("sleeperBerthDurationMs")]
    public long? SleeperBerthDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was waiting for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("waitingTimeDurationMs")]
    public long? WaitingTimeDurationMs { get; set; }

    /// <summary>
    /// Duration the driver was driving for yard moves for in the log period in milliseconds.
    /// </summary>
    [JsonPropertyName("yardMoveDurationMs")]
    public long? YardMoveDurationMs { get; set; }

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
