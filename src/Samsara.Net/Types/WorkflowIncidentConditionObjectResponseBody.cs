using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object representing the granular details of the condition. These details will vary depending on the condition.
/// </summary>
[Serializable]
public record WorkflowIncidentConditionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Descriptive name of the condition.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("details")]
    public required WorkflowIncidentDetailsObjectResponseBody Details { get; set; }

    /// <summary>
    /// Unique identifier describing the type of condition being represented.
    /// </summary>
    [JsonPropertyName("triggerId")]
    public required long TriggerId { get; set; }

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
