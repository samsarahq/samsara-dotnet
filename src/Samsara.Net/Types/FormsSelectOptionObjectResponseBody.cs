using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Multiple choice or checkbox value option object.
/// </summary>
[Serializable]
public record FormsSelectOptionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Identifier of the option.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the question should be ignored from the total score if this option is selected. Returns true if a score weight was not given to this option. Only present when the select form field has scoring.
    /// </summary>
    [JsonPropertyName("ignoreQuestionFromScoreIfSelected")]
    public bool? IgnoreQuestionFromScoreIfSelected { get; set; }

    /// <summary>
    /// Label of the option.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Score weight of the option, indicates number of score points received if this option is selected. Only present if the select form field has scoring.
    /// </summary>
    [JsonPropertyName("optionScoreWeight")]
    public long? OptionScoreWeight { get; set; }

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
