using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Route Stop Estimated Arrival
/// </summary>
[Serializable]
public record RouteStopEstimatedArrivalDetailsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
