using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms condition object.
/// </summary>
[Serializable]
public record FormsConditionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of option IDs that will satisfy the condition if selected. For check boxes fields, the condition will be met if any of these option IDs are selected. Only returned for multiple choice or check boxes fields when the condition type is `multipleChoiceValueCondition` or `checkBoxesValueCondition`.
    /// </summary>
    [JsonPropertyName("selectedOptionIds")]
    public IEnumerable<string>? SelectedOptionIds { get; set; }

    /// <summary>
    /// Type of condition that must be met for actions to be taken.  Valid values: `multipleChoiceValueCondition`, `checkBoxesValueCondition`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsConditionObjectResponseBodyType Type { get; set; }

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
