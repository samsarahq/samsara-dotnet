using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Detection log entry
/// </summary>
[Serializable]
public record DetectionLogDetectionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public required DetectionLogAssetObjectResponseBody Asset { get; set; }

    /// <summary>
    /// Time the detection was detected or in-cab alert played in UTC. RFC 3339 format. Always returned.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    [JsonPropertyName("driver")]
    public DetectionLogDriverObjectResponseBody? Driver { get; set; }

    /// <summary>
    /// Unique Samsara ID (uuid) of the detection.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether an in cab alert played aloud in the cab. Always returned.
    /// </summary>
    [JsonPropertyName("inCabAlertPlayed")]
    public required bool InCabAlertPlayed { get; set; }

    /// <summary>
    /// Details on the associated safety event generated. Always returned.
    /// </summary>
    [JsonPropertyName("safetyEvent")]
    public IEnumerable<DetectionLogSafetyEventObjectResponseBody> SafetyEvent { get; set; } =
        new List<DetectionLogSafetyEventObjectResponseBody>();

    /// <summary>
    /// The label associated with the detection. Always returned.  Valid values: `acceleration`, `braking`, `crash`, `drowsy`, `eatingDrinking`, `edgeRailroadCrossingViolation`, `followingDistance`, `forwardCollisionWarning`, `genericDistraction`, `harshTurn`, `heavySpeeding`, `laneDeparture`, `lightSpeeding`, `maxSpeed`, `mobileUsage`, `moderateSpeeding`, `noSeatbelt`, `obstructedCamera`, `passenger`, `policyViolationMask`, `ranRedLight`, `rearCollisionWarning`, `rollingStop`, `rolloverProtection`, `severeSpeeding`, `smoking`, `speeding`, `unsafeParking`, `vehicleInBlindSpotWarning`, `vulnerableRoadUserCollisionWarning`, `yawControl`
    /// </summary>
    [JsonPropertyName("triggerDetectionLabel")]
    public required DetectionLogDetectionObjectResponseBodyTriggerDetectionLabel TriggerDetectionLabel { get; set; }

    /// <summary>
    /// Time the detection was updated in Samsara in UTC. RFC 3339 format. Always returned.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
