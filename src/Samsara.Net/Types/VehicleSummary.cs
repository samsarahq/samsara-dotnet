using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleSummary
{
    [JsonPropertyName("anticipationBrakeEventCount")]
    public double? AnticipationBrakeEventCount { get; set; }

    [JsonPropertyName("coastingDurationMs")]
    public double? CoastingDurationMs { get; set; }

    [JsonPropertyName("cruiseControlDurationMs")]
    public double? CruiseControlDurationMs { get; set; }

    [JsonPropertyName("distanceDrivenMeters")]
    public double? DistanceDrivenMeters { get; set; }

    [JsonPropertyName("driveTimeDurationMs")]
    public double? DriveTimeDurationMs { get; set; }

    [JsonPropertyName("fuelConsumedMl")]
    public double? FuelConsumedMl { get; set; }

    [JsonPropertyName("greenBandDrivingDurationMs")]
    public double? GreenBandDrivingDurationMs { get; set; }

    [JsonPropertyName("highTorqueMs")]
    public double? HighTorqueMs { get; set; }

    [JsonPropertyName("idleTimeDurationMs")]
    public double? IdleTimeDurationMs { get; set; }

    [JsonPropertyName("overSpeedMs")]
    public double? OverSpeedMs { get; set; }

    [JsonPropertyName("powerTakeOffDurationMs")]
    public double? PowerTakeOffDurationMs { get; set; }

    [JsonPropertyName("totalBrakeEventCount")]
    public double? TotalBrakeEventCount { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleTinyResponse? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
