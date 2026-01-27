using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for tag group.
/// </summary>
[Serializable]
public record TagGroupSafetyScoreResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Aggregated list of behaviors, one row for each unique type of behavior.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyScoreBehaviorObjectResponseBody> Behaviors { get; set; } =
        new List<SafetyScoreBehaviorObjectResponseBody>();

    /// <summary>
    /// Safety score for the tag group. The score is a rounded number between 0-100.
    /// </summary>
    [JsonPropertyName("combinedScore")]
    public required int CombinedScore { get; set; }

    /// <summary>
    /// Total sum of distance driven in all trips across the group.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public required long DriveDistanceMeters { get; set; }

    /// <summary>
    /// Total time spent driving in all trips across the group.
    /// </summary>
    [JsonPropertyName("driveTimeMilliseconds")]
    public required long DriveTimeMilliseconds { get; set; }

    /// <summary>
    /// Aggregated list of speeding events, one row for each unique type of speeding.
    /// </summary>
    [JsonPropertyName("speeding")]
    public IEnumerable<SafetyScoreSpeedingObjectResponseBody> Speeding { get; set; } =
        new List<SafetyScoreSpeedingObjectResponseBody>();

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
