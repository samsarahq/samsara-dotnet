using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

public record AlertsPostConfigurationsRequestBody
{
    /// <summary>
    /// An array of actions.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<ActionObjectRequestBody> Actions { get; set; } =
        new List<ActionObjectRequestBody>();

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Whether the alert is enabled or not.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>
    /// The custom name of the configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("operationalSettings")]
    public OperationalSettingsObjectRequestBody? OperationalSettings { get; set; }

    [JsonPropertyName("scope")]
    public required ScopeObjectRequestBody Scope { get; set; }

    /// <summary>
    /// An array of triggers.
    /// </summary>
    [JsonPropertyName("triggers")]
    public IEnumerable<WorkflowTriggerObjectRequestBody> Triggers { get; set; } =
        new List<WorkflowTriggerObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
