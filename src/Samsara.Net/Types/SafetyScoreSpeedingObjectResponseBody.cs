using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score speeding object.
/// </summary>
[Serializable]
public record SafetyScoreSpeedingObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Total time spent speeding for the speeding type.
    /// </summary>
    [JsonPropertyName("durationMilliseconds")]
    public required long DurationMilliseconds { get; set; }

    /// <summary>
    /// Total points increased or deducted from the score due to the total time spent speeding of this type. Weights for this calculation are defined in organisation settings. Negative numbers indicate points deducted.
    /// </summary>
    [JsonPropertyName("scoreImpact")]
    public required double ScoreImpact { get; set; }

    /// <summary>
    /// Type of speeding.  Valid values: `light`, `moderate`, `heavy`, `severe`, `maxSpeed`, `unknown`
    /// </summary>
    [JsonPropertyName("speedingType")]
    public required SafetyScoreSpeedingObjectResponseBodySpeedingType SpeedingType { get; set; }

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
