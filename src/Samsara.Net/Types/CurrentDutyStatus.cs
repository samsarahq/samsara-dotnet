using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The current HOS status type and time the driver started being in this status.
/// </summary>
public record CurrentDutyStatus
{
    /// <summary>
    /// The Hours of Service status type.  If the driver app is disconnected, an empty string will be returned. To reconnect the app and return updated values, drivers should have the app open with good cell service. Valid values: `offDuty`, `sleeperBed`, `driving`, `onDuty`, `yardMove`, `personalConveyance`.
    /// </summary>
    [JsonPropertyName("hosStatusType")]
    public CurrentDutyStatusHosStatusType? HosStatusType { get; set; }

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
