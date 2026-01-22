using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trigger when safety score meets the specified condition.
/// </summary>
[Serializable]
public record SafetyScoreDetailsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The comparison to use when comparing the value to the threshold.  Valid values: `EQUAL_TO`, `GREATER_THAN`, `GREATER_THAN_OR_EQUAL_TO`, `LESS_THAN`, `LESS_THAN_OR_EQUAL_TO`
    /// </summary>
    [JsonPropertyName("comparison")]
    public required SafetyScoreDetailsResponseBodyComparison Comparison { get; set; }

    /// <summary>
    /// The score to compare to.
    /// </summary>
    [JsonPropertyName("score")]
    public required long Score { get; set; }

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
