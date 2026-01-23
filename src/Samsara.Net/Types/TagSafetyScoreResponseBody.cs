using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for tag.
/// </summary>
[Serializable]
public record TagSafetyScoreResponseBody : IJsonOnDeserialized
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
    /// Total sum of distance driven by drivers / vehicles in the tag.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public required long DriveDistanceMeters { get; set; }

    /// <summary>
    /// Total time spent driving by drivers / vehicles in the tag.
    /// </summary>
    [JsonPropertyName("driveTimeMilliseconds")]
    public required long DriveTimeMilliseconds { get; set; }

    /// <summary>
    /// Aggregated list of speeding events, one row for each unique type of speeding.
    /// </summary>
    [JsonPropertyName("speeding")]
    public IEnumerable<SafetyScoreSpeedingObjectResponseBody> Speeding { get; set; } =
        new List<SafetyScoreSpeedingObjectResponseBody>();

    /// <summary>
    /// ID of the tag.
    /// </summary>
    [JsonPropertyName("tagId")]
    public required string TagId { get; set; }

    /// <summary>
    /// Safety score for the tag. The score is a rounded number between 0-100.
    /// </summary>
    [JsonPropertyName("tagScore")]
    public required int TagScore { get; set; }

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
