using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The configuration of a alert.
/// </summary>
public record PatchResponseWorkflowConfigurationObjectResponseBody
{
    /// <summary>
    /// An array of actions.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<ActionObjectResponseBody> Actions { get; set; } =
        new List<ActionObjectResponseBody>();

    /// <summary>
    /// The time the configuration was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The unqiue Samsara id of the alert configuration.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether the alert is enabled or not.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// The time the configuration was last modified in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastModifiedAtTime")]
    public required string LastModifiedAtTime { get; set; }

    /// <summary>
    /// The custom name of the configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("operationalSettings")]
    public OperationalSettingsObjectResponseBody? OperationalSettings { get; set; }

    [JsonPropertyName("scope")]
    public required ScopeObjectResponseBody Scope { get; set; }

    /// <summary>
    /// An array of triggers.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IEnumerable<WorkflowTriggerObjectResponseBody> Triggers { get; set; } =
        new List<WorkflowTriggerObjectResponseBody>();

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
