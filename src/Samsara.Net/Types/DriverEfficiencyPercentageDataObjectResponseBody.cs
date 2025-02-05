using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverEfficiencyPercentageDataObjectResponseBody
{
    /// <summary>
    /// Percentage of time a driver is in quickly breaking events vs total breaking events.
    /// </summary>
    [JsonPropertyName("anticipationPercentage")]
    public double? AnticipationPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is in coasting.
    /// </summary>
    [JsonPropertyName("coastingPercentage")]
    public double? CoastingPercentage { get; set; }

    /// <summary>
    /// Percentage of time a vehicle is in cruise control.
    /// </summary>
    [JsonPropertyName("cruiseControlPercentage")]
    public double? CruiseControlPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is driving within the green band.
    /// </summary>
    [JsonPropertyName("greenBandPercentage")]
    public double? GreenBandPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is driving on high-grade road.
    /// </summary>
    [JsonPropertyName("highGradeRoadDrivingPercentage")]
    public double? HighGradeRoadDrivingPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is driving in high torque.
    /// </summary>
    [JsonPropertyName("highTorquePercentage")]
    public double? HighTorquePercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is idling.
    /// </summary>
    [JsonPropertyName("idlingPercentage")]
    public required double IdlingPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is in over-speeding.
    /// </summary>
    [JsonPropertyName("overSpeedPercentage")]
    public double? OverSpeedPercentage { get; set; }

    /// <summary>
    /// Percentage of time a driver is in wear-free breaking.
    /// </summary>
    [JsonPropertyName("wearFreeBrakePercentage")]
    public double? WearFreeBrakePercentage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
