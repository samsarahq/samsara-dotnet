using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Action object.
/// </summary>
[Serializable]
public record FormsActionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Identifier of the followup question that will be shown if the condition is met. Only returned when the action type is `askFollowupQuestion`.
    /// </summary>
    [JsonPropertyName("fieldId")]
    public string? FieldId { get; set; }

    /// <summary>
    /// Identifier of the conditional section that will be shown if the condition is met. Only returned when the action type is `showSection`.
    /// </summary>
    [JsonPropertyName("sectionId")]
    public string? SectionId { get; set; }

    /// <summary>
    /// Type of action to take if corresponding condition is met.  Valid values: `askFollowupQuestion`, `showSection`, `requirePhoto`, `requireNote`, `createIssue`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsActionObjectResponseBodyType Type { get; set; }

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
