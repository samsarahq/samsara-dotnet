using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for a driver
/// </summary>
public record V1DriverSafetyScoreResponse
{
    /// <summary>
    /// Crash event count
    /// </summary>
    [JsonPropertyName("crashCount")]
    public int? CrashCount { get; set; }

    /// <summary>
    /// Driver ID
    /// </summary>
    [JsonPropertyName("driverId")]
    public int? DriverId { get; set; }

    /// <summary>
    /// Harsh acceleration event count
    /// </summary>
    [JsonPropertyName("harshAccelCount")]
    public int? HarshAccelCount { get; set; }

    /// <summary>
    /// Harsh braking event count
    /// </summary>
    [JsonPropertyName("harshBrakingCount")]
    public int? HarshBrakingCount { get; set; }

    [JsonPropertyName("harshEvents")]
    public IEnumerable<V1SafetyReportHarshEvent>? HarshEvents { get; set; }

    /// <summary>
    /// Harsh turning event count
    /// </summary>
    [JsonPropertyName("harshTurningCount")]
    public int? HarshTurningCount { get; set; }

    /// <summary>
    /// The driver’s Safety Score for the requested period. Note that if the driver has zero drive time in this period, the Safety Score will be returned as 100.
    /// </summary>
    [JsonPropertyName("safetyScore")]
    public int? SafetyScore { get; set; }

    /// <summary>
    /// Safety Score Rank
    /// </summary>
    [JsonPropertyName("safetyScoreRank")]
    public string? SafetyScoreRank { get; set; }

    /// <summary>
    /// Amount of time driven over the speed limit in milliseconds
    /// </summary>
    [JsonPropertyName("timeOverSpeedLimitMs")]
    public int? TimeOverSpeedLimitMs { get; set; }

    /// <summary>
    /// Total distance driven in meters
    /// </summary>
    [JsonPropertyName("totalDistanceDrivenMeters")]
    public int? TotalDistanceDrivenMeters { get; set; }

    /// <summary>
    /// Total harsh event count
    /// </summary>
    [JsonPropertyName("totalHarshEventCount")]
    public int? TotalHarshEventCount { get; set; }

    /// <summary>
    /// Amount of time driven in milliseconds
    /// </summary>
    [JsonPropertyName("totalTimeDrivenMs")]
    public int? TotalTimeDrivenMs { get; set; }

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
