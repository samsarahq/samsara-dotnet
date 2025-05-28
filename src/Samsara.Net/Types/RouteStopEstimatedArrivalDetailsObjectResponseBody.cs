using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Route Stop Estimated Arrival
/// </summary>
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
