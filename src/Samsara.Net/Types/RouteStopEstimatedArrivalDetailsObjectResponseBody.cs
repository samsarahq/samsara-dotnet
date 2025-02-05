using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record RouteStopEstimatedArrivalDetailsObjectResponseBody
{
    /// <summary>
    /// Time threshold for when to send an alert. Sends an alert when the ETA is less than the threshold.
    /// </summary>
    [JsonPropertyName("alertBeforeArrivalMilliseconds")]
    public required long AlertBeforeArrivalMilliseconds { get; set; }

    /// <summary>
    /// If true, will include a live sharing link in the alert. Defaults to false.
    /// </summary>
    [JsonPropertyName("hasLiveShareLink")]
    public bool? HasLiveShareLink { get; set; }

    /// <summary>
    /// If true, will only alert if the vehicle is en-route to the stop. Defaults to false.
    /// </summary>
    [JsonPropertyName("isAlertOnRouteStopOnly")]
    public bool? IsAlertOnRouteStopOnly { get; set; }

    [JsonPropertyName("location")]
    public required LocationObjectResponseBody Location { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
