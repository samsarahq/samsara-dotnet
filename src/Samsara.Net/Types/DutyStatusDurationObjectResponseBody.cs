using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The currently applied duty status durations on the driver's log.
/// </summary>
public record DutyStatusDurationObjectResponseBody
{
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
