using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Action object.
/// </summary>
public record FormsActionObjectResponseBody
{
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
