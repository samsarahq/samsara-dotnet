using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record AgentStudioVoiceSessionsGetVoiceSessionsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Voice session details for the requested IDs. IDs that were not found are omitted.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<AgentStudioVoiceSessionDetailResponseBody> Data { get; set; } =
        new List<AgentStudioVoiceSessionDetailResponseBody>();

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
