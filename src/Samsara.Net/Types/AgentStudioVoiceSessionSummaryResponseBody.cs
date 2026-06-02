using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Summary of a voice agent session.
/// </summary>
[Serializable]
public record AgentStudioVoiceSessionSummaryResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Identifier of the Agent Studio agent that handled the session.
    /// </summary>
    [JsonPropertyName("agentId")]
    public required string AgentId { get; set; }

    /// <summary>
    /// Display name of the agent that handled the session.
    /// </summary>
    [JsonPropertyName("agentName")]
    public required string AgentName { get; set; }

    /// <summary>
    /// Duration of the session, in milliseconds.
    /// </summary>
    [JsonPropertyName("durationMilliseconds")]
    public required long DurationMilliseconds { get; set; }

    /// <summary>
    /// Time at which the session started, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required DateTime HappenedAtTime { get; set; }

    /// <summary>
    /// Unique identifier for the voice session.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Human-readable name of the call recipient (driver name, dashboard user name, or phone number). Empty string when the recipient could not be resolved.
    /// </summary>
    [JsonPropertyName("recipient")]
    public required string Recipient { get; set; }

    /// <summary>
    /// Lifecycle status of the session.  Valid values: `completed`, `running`, `failed`, `unknown`
    /// </summary>
    [JsonPropertyName("sessionStatus")]
    public required AgentStudioVoiceSessionSummaryResponseBodySessionStatus SessionStatus { get; set; }

    /// <summary>
    /// Human-readable name of the trigger that initiated the session, as configured in Automations. Empty string when no trigger is associated with the session.
    /// </summary>
    [JsonPropertyName("triggerType")]
    public required string TriggerType { get; set; }

    /// <summary>
    /// Time at which the session was last updated, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required DateTime UpdatedAtTime { get; set; }

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
