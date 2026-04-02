using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details of a specific Function run.
/// </summary>
[Serializable]
public record GetFunctionRunDetailResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// RFC 3339 timestamp when the Function run completed. Absent while the run is in progress.
    /// </summary>
    [JsonPropertyName("completedAtTime")]
    public DateTime? CompletedAtTime { get; set; }

    [JsonPropertyName("context")]
    public required FunctionRunContextResponseBody Context { get; set; }

    /// <summary>
    /// Unique identifier for this Function run.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public required string CorrelationId { get; set; }

    /// <summary>
    /// Name of the Function.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// RFC 3339 timestamp when the Function run started.
    /// </summary>
    [JsonPropertyName("startedAtTime")]
    public required DateTime StartedAtTime { get; set; }

    /// <summary>
    /// Execution status of the Function run.  Valid values: `started`, `timeout`, `error`, `success`, `dropped`
    /// </summary>
    [JsonPropertyName("status")]
    public required GetFunctionRunDetailResponseBodyStatus Status { get; set; }

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
