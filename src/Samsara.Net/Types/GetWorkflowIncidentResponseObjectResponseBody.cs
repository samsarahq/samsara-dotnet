using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record GetWorkflowIncidentResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
