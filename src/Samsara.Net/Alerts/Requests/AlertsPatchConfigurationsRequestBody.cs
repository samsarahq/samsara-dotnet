using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

[Serializable]
public record AlertsPatchConfigurationsRequestBody
{
    /// <summary>
    /// An array of actions.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<ActionObjectRequestBody>? Actions { get; set; }

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
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// The custom name of the configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operationalSettings")]
    public OperationalSettingsObjectRequestBody? OperationalSettings { get; set; }

    [JsonPropertyName("scope")]
    public ScopeObjectRequestBody? Scope { get; set; }

    /// <summary>
    /// An array of triggers.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IEnumerable<WorkflowTriggerObjectRequestBody>? Triggers { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
