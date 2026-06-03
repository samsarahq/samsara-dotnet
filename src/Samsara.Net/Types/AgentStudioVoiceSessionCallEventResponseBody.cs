using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A lifecycle event that occurred during a voice session.
/// </summary>
[Serializable]
public record AgentStudioVoiceSessionCallEventResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time at which the event occurred, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required DateTime HappenedAtTime { get; set; }

    /// <summary>
    /// Human-readable description of the lifecycle event.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

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
