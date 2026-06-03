using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single utterance in a voice session transcript.
/// </summary>
[Serializable]
public record AgentStudioVoiceSessionTranscriptEntryResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Offset from the start of the session at which this utterance ended, in milliseconds. Approximated from the start of the next utterance (or the end of the session for the final utterance).
    /// </summary>
    [JsonPropertyName("endMilliseconds")]
    public required long EndMilliseconds { get; set; }

    /// <summary>
    /// Who produced this utterance. Defaults to `unknown` when the speaker cannot be confidently classified.  Valid values: `agent`, `driver`, `admin`, `unknown`
    /// </summary>
    [JsonPropertyName("speakerType")]
    public required AgentStudioVoiceSessionTranscriptEntryResponseBodySpeakerType SpeakerType { get; set; }

    /// <summary>
    /// Offset from the start of the session at which this utterance began, in milliseconds.
    /// </summary>
    [JsonPropertyName("startMilliseconds")]
    public required long StartMilliseconds { get; set; }

    /// <summary>
    /// Transcribed text of the utterance.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

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
