using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

[Serializable]
public record GetSafetyEventsV2StreamRequest
{
    /// <summary>
    /// RFC 3339 timestamp that indicates when to begin receiving data. Value is compared against `updatedAtTime` or `createdAtTime` depending on the `queryByTimeField` parameter.
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// RFC 3339 timestamp. If not provided and filtering by `updatedAtTime` then the endpoint behaves as an unending feed of changes. If endTime is set the same as startTime, the most recent data point before that time will be returned per asset. Value is compared against `updatedAtTime` or `createdAtTime` depending on the `queryByTimeField` parameter.
    /// </summary>
    [JsonIgnore]
    public string? EndTime { get; set; }

    /// <summary>
    /// Optional string that decides which field to compare against the provided time range.  Valid values: `updatedAtTime`, `createdAtTime`
    /// </summary>
    [JsonIgnore]
    public GetSafetyEventsV2StreamRequestQueryByTimeField? QueryByTimeField { get; set; }

    /// <summary>
    /// Optional string of comma separated asset IDs. If asset ID is present, events for the specified asset(s) will be returned. Limit of 2000 asset IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssetIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated driver IDs. If driver ID is present, events for the specified driver(s) will be returned. Limit of 2000 driver IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated tag IDs. If tag ID is present, events for the specified tag(s) will be returned. Limit of 2000 tag IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated coach IDs to filter events assigned to a particular coach. Limit of 2000 coach IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> AssignedCoaches { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated values to filter behavior labels. Valid values: `Acceleration`, `AggressiveDriving`, `BluetoothHeadset`, `Braking`, `ContextConstructionOrWorkZone`, `ContextSnowyOrIcy`, `ContextVulnerableRoadUser`, `ContextWet`, `Crash`, `DefensiveDriving`, `DidNotYield`, `Drinking`, `Drowsy`, `Eating`, `EatingDrinking`, `EdgeDistractedDriving`, `EdgeRailroadCrossingViolation`, `FollowingDistance`, `FollowingDistanceModerate`, `FollowingDistanceSevere`, `ForwardCollisionWarning`, `GenericDistraction`, `GenericTailgating`, `HarshTurn`, `HeavySpeeding`, `HosViolation`, `Idling`, `Invalid`, `LaneDeparture`, `LateResponse`, `LeftTurn`, `LightSpeeding`, `MaxSpeed`, `MobileUsage`, `ModerateSpeeding`, `NearCollison`, `NearPedestrianCollision`, `NoSeatbelt`, `ObstructedCamera`, `OtherViolation`, `Passenger`, `PolicyViolationMask`, `ProtectiveEquipment`, `RanRedLight`, `Reversing`, `RollingStop`, `RolloverProtection`, `SevereSpeeding`, `Smoking`, `Speeding`, `UTurn`, `UnsafeManeuver`, `UnsafeParking`, `VulnerableRoadUserCollisionWarning`, `YawControl`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> BehaviorLabels { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated values to filter event states. Valid values: `needsReview`, `reviewed`, `needsCoaching`, `coached`, `dismissed`, `needsRecognition`, `recognized`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> EventStates { get; set; } = new List<string>();

    /// <summary>
    /// Indicates whether or not to return expanded “asset” data
    /// </summary>
    [JsonIgnore]
    public bool? IncludeAsset { get; set; }

    /// <summary>
    /// Indicates whether or not to return expanded “driver” data
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDriver { get; set; }

    /// <summary>
    /// Indicates whether or not to return events that are captured by devices with only a Vehicle Gateway (VG) installed.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeVgOnlyEvents { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
