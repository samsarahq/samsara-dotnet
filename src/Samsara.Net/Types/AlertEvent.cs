using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertEvent
{
    /// <summary>
    /// Link to the alert in the Samsara dashboard
    /// </summary>
    [JsonPropertyName("alertEventUrl")]
    public required string AlertEventUrl { get; set; }

    /// <summary>
    /// Human-readable description of the alert condition
    /// </summary>
    [JsonPropertyName("alertConditionDescription")]
    public required string AlertConditionDescription { get; set; }

    /// <summary>
    /// Identifier for the type of alert
    /// </summary>
    [JsonPropertyName("alertConditionId")]
    public required AlertEventAlertConditionId AlertConditionId { get; set; }

    /// <summary>
    /// Human-readable string with dynamic details about the alert
    /// </summary>
    [JsonPropertyName("details")]
    public required string Details { get; set; }

    /// <summary>
    /// Organization ID
    /// </summary>
    [JsonPropertyName("orgId")]
    public required int OrgId { get; set; }

    /// <summary>
    /// Whether the alert has been resolved
    /// </summary>
    [JsonPropertyName("resolved")]
    public required bool Resolved { get; set; }

    /// <summary>
    /// Unix epoch timestamp when the event was triggered
    /// </summary>
    [JsonPropertyName("startMs")]
    public required long StartMs { get; set; }

    /// <summary>
    /// Brief summary of the event
    /// </summary>
    [JsonPropertyName("summary")]
    public required string Summary { get; set; }

    [JsonPropertyName("device")]
    public AlertEventDevice? Device { get; set; }

    [JsonPropertyName("driver")]
    public AlertEventDriver? Driver { get; set; }

    /// <summary>
    /// DVIR-specific fields
    /// </summary>
    [JsonPropertyName("dvir")]
    public AlertEventDvir? Dvir { get; set; }

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
