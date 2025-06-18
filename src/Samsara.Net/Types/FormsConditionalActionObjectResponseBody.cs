using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Conditional action object.
/// </summary>
public record FormsConditionalActionObjectResponseBody
{
    /// <summary>
    /// List of actions to take if the condition is met.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<FormsActionObjectResponseBody> Actions { get; set; } =
        new List<FormsActionObjectResponseBody>();

    [JsonPropertyName("condition")]
    public required FormsConditionObjectResponseBody Condition { get; set; }

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
