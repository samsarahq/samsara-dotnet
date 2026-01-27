using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for vehicle.
/// </summary>
[Serializable]
public record VehicleSafetyScoreResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Aggregated list of behaviors for the vehicle, one row for each unique type of behavior.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyScoreBehaviorObjectResponseBody> Behaviors { get; set; } =
        new List<SafetyScoreBehaviorObjectResponseBody>();

    /// <summary>
    /// Total sum of distance driven with the vehicle.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public required long DriveDistanceMeters { get; set; }

    /// <summary>
    /// Total time spent driving with the vehicle.
    /// </summary>
    [JsonPropertyName("driveTimeMilliseconds")]
    public required long DriveTimeMilliseconds { get; set; }

    /// <summary>
    /// Aggregated list of speeding events for the vehicle, one row for each unique type of speeding.
    /// </summary>
    [JsonPropertyName("speeding")]
    public IEnumerable<SafetyScoreSpeedingObjectResponseBody> Speeding { get; set; } =
        new List<SafetyScoreSpeedingObjectResponseBody>();

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

    /// <summary>
    /// Safety score for the vehicle. The score is a rounded number between 0-100.
    /// </summary>
    [JsonPropertyName("vehicleScore")]
    public required int VehicleScore { get; set; }

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
