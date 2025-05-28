using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Behavior label for a safety event.
/// </summary>
public record SafetyEventBehaviorLabelsResponseBody
{
    /// <summary>
    /// Name of the behavior label.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of the BehaviorLabel.  Valid values: `Acceleration`, `Braking`, `Crash`, `DefensiveDriving`, `DidNotYield`, `Drinking`, `Drowsy`, `Eating`, `EatingDrinking`, `EdgeDistractedDriving`, `EdgeRailroadCrossingViolation`, `FollowingDistance`, `FollowingDistanceModerate`, `FollowingDistanceSevere`, `ForwardCollisionWarning`, `GenericDistraction`, `GenericTailgating`, `HarshTurn`, `Invalid`, `LaneDeparture`, `LateResponse`, `MobileUsage`, `NearCollison`, `NoSeatbelt`, `ObstructedCamera`, `Passenger`, `PolicyViolationMask`, `RanRedLight`, `RollingStop`, `RolloverProtection`, `Smoking`, `Speeding`, `VulnerableRoadUserCollisionWarning`, `YawControl`
    /// </summary>
    [JsonPropertyName("type")]
    public SafetyEventBehaviorLabelsResponseBodyType? Type { get; set; }

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
