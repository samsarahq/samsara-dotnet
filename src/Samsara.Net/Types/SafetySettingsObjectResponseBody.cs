using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety settings for a single organization.
/// </summary>
public record SafetySettingsObjectResponseBody
{
    /// <summary>
    /// Default vehicle type (for newly added or activated vehicles).  Valid values: `off`, `automatic`, `passengerCar`, `lightTruck`, `heavyDuty`
    /// </summary>
    [JsonPropertyName("defaultVehicleType")]
    public required SafetySettingsObjectResponseBodyDefaultVehicleType DefaultVehicleType { get; set; }

    [JsonPropertyName("distractedDrivingDetectionAlerts")]
    public required DistractedDrivingDetectionAlertSettingsObjectResponseBody DistractedDrivingDetectionAlerts { get; set; }

    [JsonPropertyName("followingDistanceDetectionAlerts")]
    public required FollowingDistanceDetectionAlertSettingsObjectResponseBody FollowingDistanceDetectionAlerts { get; set; }

    [JsonPropertyName("forwardCollisionDetectionAlerts")]
    public required ForwardCollisionDetectionAlertSettingsObjectResponseBody ForwardCollisionDetectionAlerts { get; set; }

    [JsonPropertyName("harshEventSensitivity")]
    public required HarshEventSensitivitySettingsObjectResponseBody HarshEventSensitivity { get; set; }

    [JsonPropertyName("harshEventSensitivityV2")]
    public required HarshEventSensitivityV2SettingsObjectResponseBody HarshEventSensitivityV2 { get; set; }

    [JsonPropertyName("policyViolationsDetectionAlerts")]
    public required PolicyViolationsDetectionAlertSettingsObjectResponseBody PolicyViolationsDetectionAlerts { get; set; }

    [JsonPropertyName("rollingStopDetectionAlerts")]
    public required RollingStopDetectionAlertSettingsObjectResponseBody RollingStopDetectionAlerts { get; set; }

    [JsonPropertyName("safetyScoreConfiguration")]
    public required SafetyScoreConfigurationSettingsObjectResponseBody SafetyScoreConfiguration { get; set; }

    /// <summary>
    /// The fleet-wide target safety score that is shown on safety score graphs. A safety score goal of 0 means that score benchmarking is disabled.
    /// </summary>
    [JsonPropertyName("safetyScoreTarget")]
    public required long SafetyScoreTarget { get; set; }

    [JsonPropertyName("speedingSettings")]
    public required SpeedingSettingsObjectResponseBody SpeedingSettings { get; set; }

    [JsonPropertyName("voiceCoaching")]
    public required VoiceCoachingSettingsObjectResponseBody VoiceCoaching { get; set; }

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
