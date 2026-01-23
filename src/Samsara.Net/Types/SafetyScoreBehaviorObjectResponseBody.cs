using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score behavior object.
/// </summary>
[Serializable]
public record SafetyScoreBehaviorObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Type of the behavior.  Valid values: `acceleration`, `braking`, `crash`, `defensiveDriving`, `didNotYield`, `distractedDrivingAutomatic`, `distractedDrivingManual`, `drowsy`, `eatingDrinking`, `followingDistance`, `followingDistanceModerate`, `followingDistanceSevere`, `forwardCollisionWarning`, `harshTurn`, `laneDeparture`, `lateResponse`, `mobileUsage`, `nearCollision`, `noSeatbelt`, `obstructedCamera`, `ranRedLight`, `rollingStop`, `smoking`, `speedingManual`, `unknown`
    /// </summary>
    [JsonPropertyName("behaviorType")]
    public required SafetyScoreBehaviorObjectResponseBodyBehaviorType BehaviorType { get; set; }

    /// <summary>
    /// Count of occurrences of the behavior.
    /// </summary>
    [JsonPropertyName("count")]
    public required long Count { get; set; }

    /// <summary>
    /// Total points increased or deducted from the score due to the total count of behaviors of this type. Weights for this calculation are defined in organisation settings. Negative numbers indicate points deducted and positive indicates points increased (e.g. defensive driving).
    /// </summary>
    [JsonPropertyName("scoreImpact")]
    public required double ScoreImpact { get; set; }

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
