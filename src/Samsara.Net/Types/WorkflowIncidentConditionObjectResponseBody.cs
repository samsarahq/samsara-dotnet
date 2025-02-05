using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
