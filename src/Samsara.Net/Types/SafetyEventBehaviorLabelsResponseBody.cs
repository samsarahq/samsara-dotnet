using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Behavior label for a safety event.
/// </summary>
[Serializable]
public record SafetyEventBehaviorLabelsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Name of the behavior label.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type of the BehaviorLabel.  Valid values: `Acceleration`, `Braking`, `Crash`, `DefensiveDriving`, `DidNotYield`, `Drinking`, `Drowsy`, `Eating`, `EatingDrinking`, `EdgeDistractedDriving`, `EdgeRailroadCrossingViolation`, `FollowingDistance`, `FollowingDistanceModerate`, `FollowingDistanceSevere`, `ForwardCollisionWarning`, `GenericDistraction`, `GenericTailgating`, `HarshTurn`, `HighSpeedSuddenDisconnect`, `Invalid`, `LaneDeparture`, `LateResponse`, `MobileUsage`, `NearCollison`, `NoSeatbelt`, `ObstructedCamera`, `OperationalEvent`, `Passenger`, `PolicyViolationMask`, `ProtectiveEquipment`, `RanRedLight`, `RearCollisionWarning`, `RollingStop`, `RolloverProtection`, `Smoking`, `Speeding`, `VehicleInBlindSpotWarning`, `VulnerableRoadUserCollisionWarning`, `YawControl`
    /// </summary>
    [JsonPropertyName("type")]
    public SafetyEventBehaviorLabelsResponseBodyType? Type { get; set; }

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
