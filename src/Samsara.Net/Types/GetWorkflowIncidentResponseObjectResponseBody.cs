using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GetWorkflowIncidentResponseObjectResponseBody
{
    /// <summary>
    /// An array of conditions associated with the incident.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<WorkflowIncidentConditionObjectResponseBody> Conditions { get; set; } =
        new List<WorkflowIncidentConditionObjectResponseBody>();

    /// <summary>
    /// Unique ID of the alert configuration.
    /// </summary>
    [JsonPropertyName("configurationId")]
    public required string ConfigurationId { get; set; }

    /// <summary>
    /// Time and date that the alert incident occurred in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required string HappenedAtTime { get; set; }

    /// <summary>
    /// Url of alert incident in the cloud dashboard.
    /// </summary>
    [JsonPropertyName("incidentUrl")]
    public required string IncidentUrl { get; set; }

    /// <summary>
    /// Indicates whether the incident is resolved or not.
    /// </summary>
    [JsonPropertyName("isResolved")]
    public required bool IsResolved { get; set; }

    /// <summary>
    /// Time and date that the alert incident was resolved in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("resolvedAtTime")]
    public string? ResolvedAtTime { get; set; }

    /// <summary>
    /// Time and date that the alert incident updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
