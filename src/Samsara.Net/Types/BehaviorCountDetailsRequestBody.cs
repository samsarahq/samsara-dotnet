using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trigger when behavior count meets the specified condition.
/// </summary>
[Serializable]
public record BehaviorCountDetailsRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The comparison to use when comparing the value to the threshold.  Valid values: `EQUAL_TO`, `GREATER_THAN`, `GREATER_THAN_OR_EQUAL_TO`, `LESS_THAN`, `LESS_THAN_OR_EQUAL_TO`
    /// </summary>
    [JsonPropertyName("comparison")]
    public required BehaviorCountDetailsRequestBodyComparison Comparison { get; set; }

    /// <summary>
    /// The number of behaviors to compare to.
    /// </summary>
    [JsonPropertyName("numBehaviors")]
    public required long NumBehaviors { get; set; }

    /// <summary>
    /// The number of days to compare to.
    /// </summary>
    [JsonPropertyName("numDays")]
    public required long NumDays { get; set; }

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
