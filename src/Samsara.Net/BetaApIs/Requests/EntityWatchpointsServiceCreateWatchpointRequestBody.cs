using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityWatchpointsServiceCreateWatchpointRequestBody
{
    [JsonPropertyName("bearingRange")]
    public WatchpointBearingRangeTypeRequestBody? BearingRange { get; set; }

    /// <summary>
    /// Conditions to detect in new observations. Defaults to none. Requires custom detections to be enabled for your organization. Types must be distinct.
    /// </summary>
    [JsonPropertyName("customDetections")]
    public IEnumerable<WatchpointCustomDetectionRequestTypeRequestBody>? CustomDetections { get; set; }

    [JsonPropertyName("location")]
    public required WatchpointLatLngTypeRequestBody Location { get; set; }

    /// <summary>
    /// Recurrence frequency for observations.  Valid values: `justOnce`, `daily`, `weekly`, `monthly`, `every15Minutes`, `hourly`
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

    /// <summary>
    /// Sends the authenticated user a dashboard notification for each new observation. Defaults to false. Ignored when the API token is not associated with a user.
    /// </summary>
    [JsonPropertyName("sendDashboardNotification")]
    public bool? SendDashboardNotification { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
