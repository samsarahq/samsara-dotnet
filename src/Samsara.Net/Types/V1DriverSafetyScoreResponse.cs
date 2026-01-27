using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for a driver
/// </summary>
[Serializable]
public record V1DriverSafetyScoreResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Crash event count
    /// </summary>
    [JsonPropertyName("crashCount")]
    public long? CrashCount { get; set; }

    /// <summary>
    /// Driver ID
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// Harsh acceleration event count
    /// </summary>
    [JsonPropertyName("harshAccelCount")]
    public long? HarshAccelCount { get; set; }

    /// <summary>
    /// Harsh braking event count
    /// </summary>
    [JsonPropertyName("harshBrakingCount")]
    public long? HarshBrakingCount { get; set; }

    [JsonPropertyName("harshEvents")]
    public IEnumerable<V1SafetyReportHarshEvent>? HarshEvents { get; set; }

    /// <summary>
    /// Harsh turning event count
    /// </summary>
    [JsonPropertyName("harshTurningCount")]
    public long? HarshTurningCount { get; set; }

    /// <summary>
    /// The driver’s Safety Score for the requested period. Note that if the driver has zero drive time in this period, the Safety Score will be returned as 100.
    /// </summary>
    [JsonPropertyName("safetyScore")]
    public long? SafetyScore { get; set; }

    /// <summary>
    /// Safety Score Rank
    /// </summary>
    [JsonPropertyName("safetyScoreRank")]
    public string? SafetyScoreRank { get; set; }

    /// <summary>
    /// Amount of time driven over the speed limit in milliseconds
    /// </summary>
    [JsonPropertyName("timeOverSpeedLimitMs")]
    public long? TimeOverSpeedLimitMs { get; set; }

    /// <summary>
    /// Total distance driven in meters
    /// </summary>
    [JsonPropertyName("totalDistanceDrivenMeters")]
    public long? TotalDistanceDrivenMeters { get; set; }

    /// <summary>
    /// Total harsh event count
    /// </summary>
    [JsonPropertyName("totalHarshEventCount")]
    public long? TotalHarshEventCount { get; set; }

    /// <summary>
    /// Amount of time driven in milliseconds
    /// </summary>
    [JsonPropertyName("totalTimeDrivenMs")]
    public long? TotalTimeDrivenMs { get; set; }

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
