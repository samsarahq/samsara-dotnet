using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The safety event that was updated.
/// </summary>
[Serializable]
public record SafetyEventObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Behavior labels for a safety event.
    /// </summary>
    [JsonPropertyName("behaviorLabels")]
    public IEnumerable<SafetyEventBehaviorLabelsResponseBody>? BehaviorLabels { get; set; }

    [JsonPropertyName("driver")]
    public SafetyEventDriverObjectResponseBody? Driver { get; set; }

    /// <summary>
    /// The unique Samsara ID of the safety event.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The time the safety event occurred in RFC 3339 milliseconds format.
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    [JsonPropertyName("vehicle")]
    public SafetyEventVehicleObjectResponseBody? Vehicle { get; set; }

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
