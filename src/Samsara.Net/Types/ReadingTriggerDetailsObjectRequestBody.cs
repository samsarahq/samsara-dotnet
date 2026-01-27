using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to reading based Trigger, readings can be discovered through the Readings API.
/// </summary>
[Serializable]
public record ReadingTriggerDetailsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("continuousThreshold")]
    public ReadingTriggerContinuousValueObjectRequestBody? ContinuousThreshold { get; set; }

    /// <summary>
    /// The type of the entity associated with the reading.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required string EntityType { get; set; }

    [JsonPropertyName("enumThreshold")]
    public ReadingTriggerEnumValueObjectRequestBody? EnumThreshold { get; set; }

    /// <summary>
    /// The ID of the reading.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

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
