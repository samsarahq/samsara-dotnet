using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A tool invocation made by the agent during a voice session.
/// </summary>
[Serializable]
public record AgentStudioVoiceSessionToolCallResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Arguments passed to the tool, as a JSON-encoded string.
    /// </summary>
    [JsonPropertyName("arguments")]
    public required string Arguments { get; set; }

    /// <summary>
    /// Wall-clock duration of the tool call, in milliseconds. Zero when the duration is unknown.
    /// </summary>
    [JsonPropertyName("durationMilliseconds")]
    public required long DurationMilliseconds { get; set; }

    /// <summary>
    /// Name of the tool that was invoked.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Output returned by the tool, as a string. Empty when the tool produced no output.
    /// </summary>
    [JsonPropertyName("output")]
    public required string Output { get; set; }

    /// <summary>
    /// Offset from the start of the session at which the tool call started, in milliseconds.
    /// </summary>
    [JsonPropertyName("startMilliseconds")]
    public required long StartMilliseconds { get; set; }

    /// <summary>
    /// Outcome of the tool call. Defaults to `unknown` when the outcome could not be determined.  Valid values: `success`, `error`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required AgentStudioVoiceSessionToolCallResponseBodyStatus Status { get; set; }

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
