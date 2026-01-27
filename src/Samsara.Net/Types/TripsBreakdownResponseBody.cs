using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trip impacts on safety score.
/// </summary>
[Serializable]
public record TripsBreakdownResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Aggregated list of behaviors that occurred during the trip, one row for each unique type of behavior.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyScoreBehaviorObjectResponseBody> Behaviors { get; set; } =
        new List<SafetyScoreBehaviorObjectResponseBody>();

    /// <summary>
    /// Distance driven during the trip.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public required long DriveDistanceMeters { get; set; }

    /// <summary>
    /// ID of the driver associated with the trip.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// Aggregated list of speeding events that occurred during the trip, one row for each unique type of speeding.
    /// </summary>
    [JsonPropertyName("speeding")]
    public IEnumerable<SafetyScoreSpeedingObjectResponseBody> Speeding { get; set; } =
        new List<SafetyScoreSpeedingObjectResponseBody>();

    /// <summary>
    /// [RFC 3339] Time the trip ended in UTC.
    /// </summary>
    [JsonPropertyName("tripEndTime")]
    public required string TripEndTime { get; set; }

    /// <summary>
    /// Impact of the trip to the overall score. This is the effective sum of all risk factors in the trip.
    /// </summary>
    [JsonPropertyName("tripScoreImpact")]
    public required double TripScoreImpact { get; set; }

    /// <summary>
    /// [RFC 3339] Time the trip started in UTC.
    /// </summary>
    [JsonPropertyName("tripStartTime")]
    public required string TripStartTime { get; set; }

    /// <summary>
    /// ID of the vehicle associated with the trip.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

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
