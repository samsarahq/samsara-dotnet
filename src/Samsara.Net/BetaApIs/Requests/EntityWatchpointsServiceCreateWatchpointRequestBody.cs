using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityWatchpointsServiceCreateWatchpointRequestBody
{
    [JsonPropertyName("location")]
    public required WatchpointLatLngTypeRequestBody Location { get; set; }

    /// <summary>
    /// Recurrence frequency for observations.  Valid values: `justOnce`, `daily`, `weekly`, `monthly`
    /// </summary>
    [JsonPropertyName("mode")]
    public required EntityWatchpointsServiceCreateWatchpointRequestBodyMode Mode { get; set; }

    /// <summary>
    /// Customer-provided name for the watchpoint.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customer-provided note about the watchpoint.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Type of condition to observe at this watchpoint.  Valid values: `roadDefect`, `utilityCut`, `guardrail`, `streetlight`, `signage`, `stormDrain`, `graffiti`, `vegetation`, `blight`, `illegalDumping`, `littering`, `highVegetationWeeds`, `fire`, `other`
    /// </summary>
    [JsonPropertyName("observationType")]
    public required EntityWatchpointsServiceCreateWatchpointRequestBodyObservationType ObservationType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
