using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single log entry from a Function execution.
/// </summary>
[Serializable]
public record FunctionLogEntryResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The log message text.
    /// </summary>
    [JsonPropertyName("log")]
    public required string Log { get; set; }

    /// <summary>
    /// RFC 3339 timestamp of when the log entry was produced.
    /// </summary>
    [JsonPropertyName("loggedAtTime")]
    public required DateTime LoggedAtTime { get; set; }

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
