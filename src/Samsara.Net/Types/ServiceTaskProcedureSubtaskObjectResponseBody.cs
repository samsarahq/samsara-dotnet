using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A procedure subtask.
/// </summary>
[Serializable]
public record ServiceTaskProcedureSubtaskObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the procedure is complete.
    /// </summary>
    [JsonPropertyName("isCompleted")]
    public required bool IsCompleted { get; set; }

    /// <summary>
    /// The name of the procedure.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
