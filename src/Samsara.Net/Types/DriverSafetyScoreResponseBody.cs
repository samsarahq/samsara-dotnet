using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Safety score details for driver.
/// </summary>
[Serializable]
public record DriverSafetyScoreResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Aggregated list of behaviors for the driver, one row for each unique type of behavior.
    /// </summary>
    [JsonPropertyName("behaviors")]
    public IEnumerable<SafetyScoreBehaviorObjectResponseBody> Behaviors { get; set; } =
        new List<SafetyScoreBehaviorObjectResponseBody>();

    /// <summary>
    /// Total sum of distance driven by the driver.
    /// </summary>
    [JsonPropertyName("driveDistanceMeters")]
    public required long DriveDistanceMeters { get; set; }

    /// <summary>
    /// Total time spent driving by the driver.
    /// </summary>
    [JsonPropertyName("driveTimeMilliseconds")]
    public required long DriveTimeMilliseconds { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// Safety score for the driver. The score is a rounded number between 0-100.
    /// </summary>
    [JsonPropertyName("driverScore")]
    public required int DriverScore { get; set; }

    /// <summary>
    /// Aggregated list of speeding events for the driver, one row for each unique type of speeding.
    /// </summary>
    [JsonPropertyName("speeding")]
    public IEnumerable<SafetyScoreSpeedingObjectResponseBody> Speeding { get; set; } =
        new List<SafetyScoreSpeedingObjectResponseBody>();

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
