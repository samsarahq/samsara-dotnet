using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Watchpoint object
/// </summary>
[Serializable]
public record EntityCreateWatchpointTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time when the watchpoint resource was created.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// Unique identifier for the watchpoint.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Time when the most recent observation was collected, or null when unavailable.
    /// </summary>
    [JsonPropertyName("lastObservationTime")]
    public string? LastObservationTime { get; set; }

    [JsonPropertyName("location")]
    public required WatchpointLatLngTypeResponseBody Location { get; set; }

    /// <summary>
    /// Recurrence frequency for observations.  Valid values: `unknown`, `justOnce`, `daily`, `weekly`, `monthly`
    /// </summary>
    [JsonPropertyName("mode")]
    public required EntityCreateWatchpointTypeResponseBodyMode Mode { get; set; }

    /// <summary>
    /// Server-derived end of the current monitoring window.
    /// </summary>
    [JsonPropertyName("monitoringEndTime")]
    public required string MonitoringEndTime { get; set; }

    /// <summary>
    /// Start of the current monitoring run.
    /// </summary>
    [JsonPropertyName("monitoringStartTime")]
    public required string MonitoringStartTime { get; set; }

    /// <summary>
    /// Customer-provided name for the watchpoint, or null when unavailable.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customer-provided note about the watchpoint, or null when unavailable.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Number of observations collected for the watchpoint.
    /// </summary>
    [JsonPropertyName("observationCount")]
    public required long ObservationCount { get; set; }

    /// <summary>
    /// Type of condition to observe at this watchpoint.  Valid values: `unknown`, `roadDefect`, `utilityCut`, `guardrail`, `streetlight`, `signage`, `stormDrain`, `graffiti`, `vegetation`, `blight`, `illegalDumping`, `littering`, `highVegetationWeeds`, `fire`, `other`
    /// </summary>
    [JsonPropertyName("observationType")]
    public required EntityCreateWatchpointTypeResponseBodyObservationType ObservationType { get; set; }

    /// <summary>
    /// Organization-scoped URL that opens this Watchpoint in the Samsara dashboard.
    /// </summary>
    [JsonPropertyName("samsaraDashboardUrl")]
    public required string SamsaraDashboardUrl { get; set; }

    /// <summary>
    /// Current lifecycle status of the watchpoint.  Valid values: `unknown`, `active`, `completed`
    /// </summary>
    [JsonPropertyName("status")]
    public required EntityCreateWatchpointTypeResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Time when the public watchpoint projection was most recently updated.
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
