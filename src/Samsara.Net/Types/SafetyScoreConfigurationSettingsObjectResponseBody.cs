using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configurable safety infraction weights.
/// </summary>
public record SafetyScoreConfigurationSettingsObjectResponseBody
{
    /// <summary>
    /// Score weight for AI-detected inattentive driving behavior.
    /// </summary>
    [JsonPropertyName("aiInattentiveDrivingDetectionWeight")]
    public long? AiInattentiveDrivingDetectionWeight { get; set; }

    /// <summary>
    /// Score weight for crash behavior.
    /// </summary>
    [JsonPropertyName("crashWeight")]
    public long? CrashWeight { get; set; }

    /// <summary>
    /// Score weight for defensive driving behavior. This behavior has a positive impact on the safety score.
    /// </summary>
    [JsonPropertyName("defensiveDrivingWeight")]
    public long? DefensiveDrivingWeight { get; set; }

    /// <summary>
    /// Score weight for driver not yielding.
    /// </summary>
    [JsonPropertyName("didNotYieldWeight")]
    public long? DidNotYieldWeight { get; set; }

    /// <summary>
    /// Score weight for drowsy behavior.
    /// </summary>
    [JsonPropertyName("drowsyWeight")]
    public long? DrowsyWeight { get; set; }

    /// <summary>
    /// Score weight for eating/drinking behavior.
    /// </summary>
    [JsonPropertyName("eatingDrinkingWeight")]
    public long? EatingDrinkingWeight { get; set; }

    /// <summary>
    /// Score weight for moderate (2-4s) following distance behavior.
    /// </summary>
    [JsonPropertyName("followingDistanceModerateWeight")]
    public long? FollowingDistanceModerateWeight { get; set; }

    /// <summary>
    /// Score weight for severe (0-2s) following distance behavior.
    /// </summary>
    [JsonPropertyName("followingDistanceSevereWeight")]
    public long? FollowingDistanceSevereWeight { get; set; }

    /// <summary>
    /// Score weight for following distance behavior.
    /// </summary>
    [JsonPropertyName("followingDistanceWeight")]
    public long? FollowingDistanceWeight { get; set; }

    /// <summary>
    /// Score weight for forward collision warning behavior.
    /// </summary>
    [JsonPropertyName("forwardCollisionWarningWeight")]
    public long? ForwardCollisionWarningWeight { get; set; }

    /// <summary>
    /// Score weight for harsh acceleration behavior.
    /// </summary>
    [JsonPropertyName("harshAccelWeight")]
    public long? HarshAccelWeight { get; set; }

    /// <summary>
    /// Score weight for harsh braking behavior.
    /// </summary>
    [JsonPropertyName("harshBrakeWeight")]
    public long? HarshBrakeWeight { get; set; }

    /// <summary>
    /// Score weight for harsh turn behavior.
    /// </summary>
    [JsonPropertyName("harshTurnWeight")]
    public long? HarshTurnWeight { get; set; }

    /// <summary>
    /// Score weight for heavy speeding (20-30% over limit).
    /// </summary>
    [JsonPropertyName("heavySpeedingWeight")]
    public long? HeavySpeedingWeight { get; set; }

    /// <summary>
    /// Score weight for inattentive driving behavior.
    /// </summary>
    [JsonPropertyName("inattentiveDrivingWeight")]
    public long? InattentiveDrivingWeight { get; set; }

    /// <summary>
    /// Score weight for lane departure behavior.
    /// </summary>
    [JsonPropertyName("laneDepartureWeight")]
    public long? LaneDepartureWeight { get; set; }

    /// <summary>
    /// Score weight for late response behavior.
    /// </summary>
    [JsonPropertyName("lateResponseWeight")]
    public long? LateResponseWeight { get; set; }

    /// <summary>
    /// Score weight for light speeding (0-10% over limit).
    /// </summary>
    [JsonPropertyName("lightSpeedingWeight")]
    public long? LightSpeedingWeight { get; set; }

    /// <summary>
    /// Score weight for max speed events.
    /// </summary>
    [JsonPropertyName("maxSpeedWeight")]
    public long? MaxSpeedWeight { get; set; }

    /// <summary>
    /// Score weight for mobile usage behavior.
    /// </summary>
    [JsonPropertyName("mobileUsageWeight")]
    public long? MobileUsageWeight { get; set; }

    /// <summary>
    /// Score weight for moderate speeding (10-20% over limit).
    /// </summary>
    [JsonPropertyName("moderateSpeedingWeight")]
    public long? ModerateSpeedingWeight { get; set; }

    /// <summary>
    /// Score weight for near collision behavior.
    /// </summary>
    [JsonPropertyName("nearCollisionWeight")]
    public long? NearCollisionWeight { get; set; }

    /// <summary>
    /// Score weight for no seatbelt behavior.
    /// </summary>
    [JsonPropertyName("noSeatbeltWeight")]
    public long? NoSeatbeltWeight { get; set; }

    /// <summary>
    /// Score weight for obstructed camera behavior.
    /// </summary>
    [JsonPropertyName("obstructedCameraWeight")]
    public long? ObstructedCameraWeight { get; set; }

    /// <summary>
    /// Score weight for driver running red light.
    /// </summary>
    [JsonPropertyName("ranRedLightWeight")]
    public long? RanRedLightWeight { get; set; }

    /// <summary>
    /// Score weight for rolling stop behavior.
    /// </summary>
    [JsonPropertyName("rollingStopWeight")]
    public long? RollingStopWeight { get; set; }

    /// <summary>
    /// Score weight for severe speeding (over 30% over limit).
    /// </summary>
    [JsonPropertyName("severeSpeedingWeight")]
    public long? SevereSpeedingWeight { get; set; }

    /// <summary>
    /// Score weight for smoking behavior.
    /// </summary>
    [JsonPropertyName("smokingWeight")]
    public long? SmokingWeight { get; set; }

    /// <summary>
    /// Score weight for manual speeding event.
    /// </summary>
    [JsonPropertyName("speedingWeight")]
    public long? SpeedingWeight { get; set; }

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
