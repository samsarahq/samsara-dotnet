using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A service task subtask. Exactly one of procedure or form is populated.
/// </summary>
[Serializable]
public record ServiceTaskSubtaskObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("form")]
    public ServiceTaskFormSubtaskObjectResponseBody? Form { get; set; }

    [JsonPropertyName("procedure")]
    public ServiceTaskProcedureSubtaskObjectResponseBody? Procedure { get; set; }

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
