using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetyEventBehaviorLabelsResponseBody
{
    /// <summary>
    /// Name of the behavior label.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of the BehaviorLabel.  Valid values: `Acceleration`, `Braking`, `Crash`, `DefensiveDriving`, `DidNotYield`, `Drinking`, `Drowsy`, `Eating`, `EatingDrinking`, `EdgeDistractedDriving`, `EdgeRailroadCrossingViolation`, `FollowingDistance`, `FollowingDistanceModerate`, `FollowingDistanceSevere`, `ForwardCollisionWarning`, `GenericDistraction`, `GenericTailgating`, `HarshTurn`, `Invalid`, `LaneDeparture`, `LateResponse`, `MobileUsage`, `NearCollison`, `NoSeatbelt`, `ObstructedCamera`, `PolicyViolationMask`, `RanRedLight`, `RollingStop`, `RolloverProtection`, `Smoking`, `Speeding`, `YawControl`
    /// </summary>
    [JsonPropertyName("type")]
    public SafetyEventBehaviorLabelsResponseBodyType? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
