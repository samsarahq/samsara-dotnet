using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficiency
{
    [JsonPropertyName("anticipationBrakeEventCount")]
    public double? AnticipationBrakeEventCount { get; set; }

    [JsonPropertyName("coastingDurationMs")]
    public double? CoastingDurationMs { get; set; }

    [JsonPropertyName("cruiseControlDurationMs")]
    public double? CruiseControlDurationMs { get; set; }

    [JsonPropertyName("driver")]
    public ExtendedDriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("greenBandDrivingDurationMs")]
    public double? GreenBandDrivingDurationMs { get; set; }

    [JsonPropertyName("highTorqueMs")]
    public double? HighTorqueMs { get; set; }

    [JsonPropertyName("overSpeedMs")]
    public double? OverSpeedMs { get; set; }

    [JsonPropertyName("totalBrakeEventCount")]
    public double? TotalBrakeEventCount { get; set; }

    [JsonPropertyName("totalDistanceDrivenMeters")]
    public double? TotalDistanceDrivenMeters { get; set; }

    [JsonPropertyName("totalDriveTimeDurationMs")]
    public double? TotalDriveTimeDurationMs { get; set; }

    [JsonPropertyName("totalFuelConsumedMl")]
    public double? TotalFuelConsumedMl { get; set; }

    [JsonPropertyName("totalIdleTimeDurationMs")]
    public double? TotalIdleTimeDurationMs { get; set; }

    [JsonPropertyName("totalPowerTakeOffDurationMs")]
    public double? TotalPowerTakeOffDurationMs { get; set; }

    /// <summary>
    /// Summaries of vehicle efficiency for each vehicle the driver was driving during the given time period.
    /// </summary>
    [JsonPropertyName("vehicleSummaries")]
    public IEnumerable<VehicleSummary>? VehicleSummaries { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
