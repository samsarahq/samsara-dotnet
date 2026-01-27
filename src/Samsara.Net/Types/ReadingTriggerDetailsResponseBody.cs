using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Reading Triggers.
/// </summary>
[Serializable]
public record ReadingTriggerDetailsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asset")]
    public AlertObjectAssetResponseBody? Asset { get; set; }

    [JsonPropertyName("continuousThreshold")]
    public ContinuousReadingAlertThresholdResponseBody? ContinuousThreshold { get; set; }

    [JsonPropertyName("enumThreshold")]
    public EnumReadingAlertThresholdResponseBody? EnumThreshold { get; set; }

    /// <summary>
    /// The ID of the reading.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
