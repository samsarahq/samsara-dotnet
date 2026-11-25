using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Procedure completion for one stored procedure on a service task.
/// </summary>
[Serializable]
public record ServiceTaskProcedureInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the procedure is complete. Send false to mark the procedure incomplete.
    /// </summary>
    [JsonPropertyName("isCompleted")]
    public required bool IsCompleted { get; set; }

    /// <summary>
    /// The procedure name. Must match the stored procedure at the same position after sorting by rank.
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
