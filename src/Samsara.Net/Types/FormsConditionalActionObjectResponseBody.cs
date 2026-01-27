using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Conditional action object.
/// </summary>
[Serializable]
public record FormsConditionalActionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of actions to take if the condition is met.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<FormsActionObjectResponseBody> Actions { get; set; } =
        new List<FormsActionObjectResponseBody>();

    [JsonPropertyName("condition")]
    public required FormsConditionObjectResponseBody Condition { get; set; }

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
