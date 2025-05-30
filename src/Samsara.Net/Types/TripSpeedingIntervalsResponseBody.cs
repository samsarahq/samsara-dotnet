using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// TripSpeedingIntervals
/// </summary>
public record TripSpeedingIntervalsResponseBody
{
    [JsonPropertyName("asset")]
    public required TripAssetResponseBody Asset { get; set; }

    /// <summary>
    /// UTC time the trip was created in Samsara in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// The driver ID assigned to the trip. Only returned if includeDriverId is set to true. 'null' if no driver id.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// List of speeding intervals that belong to the trip. The full list of intervals associated with the trip is always returned, empty if no intervals exist.
    /// </summary>
    [JsonPropertyName("intervals")]
    public IEnumerable<SpeedingIntervalResponseBody> Intervals { get; set; } =
        new List<SpeedingIntervalResponseBody>();

    /// <summary>
    /// UTC time the trip started in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public required string TripStartTime { get; set; }

    /// <summary>
    /// UTC time the trip was last updated in Samsara in RFC 3339 format. Valid updates are when trip's endTime populates or interval.isDismissed changes value.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public required string UpdatedAtTime { get; set; }

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
