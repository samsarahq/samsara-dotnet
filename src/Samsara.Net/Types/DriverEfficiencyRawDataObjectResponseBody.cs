using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Driver Efficiency raw data. This object is returned when the “raw” format is specified in “dataFormats”.
/// </summary>
[Serializable]
public record DriverEfficiencyRawDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Total number of quick braking events (less than one second after accelerating).
    /// </summary>
    [JsonPropertyName("anticipationBrakeEventCount")]
    public long? AnticipationBrakeEventCount { get; set; }

    /// <summary>
    /// Average vehicle weight in kilograms.
    /// </summary>
    [JsonPropertyName("averageVehicleWeightKg")]
    public long? AverageVehicleWeightKg { get; set; }

    /// <summary>
    /// Time spent without engaging the accelerator or brake in milliseconds.
    /// </summary>
    [JsonPropertyName("coastingDurationMs")]
    public long? CoastingDurationMs { get; set; }

    /// <summary>
    /// Time spent in cruise control in milliseconds.
    /// </summary>
    [JsonPropertyName("cruiseControlDurationMs")]
    public long? CruiseControlDurationMs { get; set; }

    /// <summary>
    /// Total driving time in milliseconds.
    /// </summary>
    [JsonPropertyName("driveTimeDurationMs")]
    public required long DriveTimeDurationMs { get; set; }

    /// <summary>
    /// Total engine-on time in milliseconds.
    /// </summary>
    [JsonPropertyName("engineOnDurationMs")]
    public required long EngineOnDurationMs { get; set; }

    /// <summary>
    /// Time spent driving within the configurable green band in milliseconds.
    /// </summary>
    [JsonPropertyName("greenBandDurationMs")]
    public long? GreenBandDurationMs { get; set; }

    /// <summary>
    /// Time spent driving on high-grade roads in milliseconds.
    /// </summary>
    [JsonPropertyName("highGradeRoadDrivingDurationMs")]
    public long? HighGradeRoadDrivingDurationMs { get; set; }

    /// <summary>
    /// Time the vehicle engine torque is greater than 90% in milliseconds.
    /// </summary>
    [JsonPropertyName("highTorqueDurationMs")]
    public long? HighTorqueDurationMs { get; set; }

    /// <summary>
    /// Time spent idling in milliseconds.
    /// </summary>
    [JsonPropertyName("idlingDurationMs")]
    public required long IdlingDurationMs { get; set; }

    /// <summary>
    /// Time spent over-speeding in milliseconds.
    /// </summary>
    [JsonPropertyName("overSpeedDurationMs")]
    public long? OverSpeedDurationMs { get; set; }

    /// <summary>
    /// Total breaking time in milliseconds.
    /// </summary>
    [JsonPropertyName("totalBrakeDurationMs")]
    public required long TotalBrakeDurationMs { get; set; }

    /// <summary>
    /// Total number of brake events.
    /// </summary>
    [JsonPropertyName("totalBrakeEventCount")]
    public long? TotalBrakeEventCount { get; set; }

    /// <summary>
    /// Time spent ware-free breaking in milliseconds.
    /// </summary>
    [JsonPropertyName("wearFreeBrakeDurationMs")]
    public long? WearFreeBrakeDurationMs { get; set; }

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
