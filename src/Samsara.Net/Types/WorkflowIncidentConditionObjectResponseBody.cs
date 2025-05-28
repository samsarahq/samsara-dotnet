using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Object representing the granular details of the condition. These details will vary depending on the condition.
/// </summary>
public record WorkflowIncidentConditionObjectResponseBody
{
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
