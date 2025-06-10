using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Multiple choice or checkbox value option object.
/// </summary>
public record FormsSelectOptionObjectResponseBody
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
